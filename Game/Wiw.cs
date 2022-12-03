using WiW.src.IViews;
using WiW.src.Views;

namespace WiW.src.Game
{
    public class Wiw
    {
        public Machine Pc;
        private FileMgr fileMgr;
        private BoardView VBoard;
        private FacesView VFaces;
        private OutputView output;
        private GameOverView VGameOver;

        public Wiw()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            CreateObjects();
            InitEvents();
            Application.Run(VFaces!.GetForm());
        }

        // Turno de la PC

        private void BtnYes(object? sender, EventArgs e)
        {
            UserReply(true);
        }

        private void BtnNo(object? sender, EventArgs e)
        {
            UserReply(false);
        }

        private void UserReply(bool reply)
        {
            (string, double)? rta = Pc.Answer(reply);
            if (rta == null)
                VBoard.UserTurn(Pc.Query());
            else
            {
                Image face = fileMgr.Img(rta?.Item1!);
                VBoard.Close();
                VGameOver.PcGuess(face, (double)rta?.Item2!);
            }
        }

        // Consultas

        private void BtnLeafs(object? sender, EventArgs e)
        {
            PrintRequest(Pc.Leafs());
        }

        private void BtnPaths(object? sender, EventArgs e)
        {
            PrintRequest(Pc.Paths());
        }

        private void BtnLevels(object? sender, EventArgs e)
        {
            PrintRequest(Pc.Levels());
        }

        private void PrintRequest(string resultado)
        {
            output.Print = resultado;
            VBoard.Hide();
            output.Show();
        }

        // Turno del usuario

        private void BtnAsk(object? sender, EventArgs e)
        {
            VBoard.PcTurn();
            VBoard.PcReply(Pc.Ask(VBoard.SelectedQuery));
        }

        private void BtnGuess(object? sender, EventArgs e)
        {
            VFaces.Show();
            VFaces.NameSelected += Guess;
            VFaces.BtnClose -= ExitApp; 
            VFaces.BtnClose += VFacesHide;
            VBoard.Hide();
        }

        private void Guess(object? sender, NameArg e)
        {
            if (VFaces.AreYouShure("¿ Seguro queres elegir a " + e.Name + "?"))
            {
                VBoard.Hide();
                Image img = fileMgr.Img(Pc.Name());
                if (Pc.Guess(e.Name))
                    VGameOver.PlayerHit(img);
                else
                    VGameOver.PlayerMiss(img);
                VFaces.BtnClose -= VFacesHide;
                VFaces.NameSelected -= Guess;
            }
        }

        // Objetos participantes

        private void CreateObjects()
        {
            fileMgr = FileMgr.Instance();
            Pc = new Machine();
            VFaces = new FacesForm(Pc.Data);
            VGameOver = new GameOver();
            output = new Output();
        }

        // Secuencia de eventos

        private void InitEvents()
        {
            VFaces.ImgSelected += InitBoardView;
            VFaces.BtnClose += ExitApp;
            VGameOver.BtnNewGame += BtnNewGame;
            VGameOver.BtnClose += ExitApp;
            output.BtnClose += delegate { output.Hide(); VBoard.Show(); };
        }

        private void InitBoardView(object? sender, ImgArg e)
        {
            VBoard = new Board(Pc.startGame(), Pc.Query(), VFaces.Imgs, e.Face);
            VFaces.Hide();
            VFaces.BtnClose += VFacesHide;
            VFaces.BtnClose -= ExitApp;
            VFaces.ImgSelected -= InitBoardView;
            VBoard.BtnYes += BtnYes;
            VBoard.BtnNo += BtnNo;
            VBoard.BtnPaths += BtnPaths;
            VBoard.BtnLevels += BtnLevels;
            VBoard.BtnLeafs += BtnLeafs;
            VBoard.BtnGuess += BtnGuess;
            VBoard.BtnAsk += BtnAsk;
            VBoard.BtnClose += ExitApp;
            VBoard.BtnNewGame += (s, e) =>
            {
                if (VFaces.AreYouShure("Se terminara la partida, ¿ Desea continuar ?"))
                    BtnNewGame(s, e);
            };
            VBoard.Show();
        }

        private void BtnNewGame(object? sender, EventArgs e)
        {
            VBoard.Hide();
            VGameOver.Hide();
            VFaces.NameSelected -= Guess;
            VFaces.ImgSelected += InitBoardView;
            VFaces.BtnClose += ExitApp;
            VFaces.BtnClose -= VFacesHide;
            VFaces.Show();
        }

        public void ExitApp(object? sender, EventArgs e)
        {
            if (VFaces.AreYouShure("Se cerrara la aplicacion, ¿ Desea continuar ?"))
                Application.Exit();
        }

        public void VFacesHide(object? sender, EventArgs e)
        {
            VFaces.Hide();
            VBoard.Show();
            VFaces.BtnClose -= VFacesHide;
            VFaces.NameSelected -= Guess;
        }
    }
}
