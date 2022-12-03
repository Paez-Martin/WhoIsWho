using System.Runtime.InteropServices;
using tpf;
using WiW.src.Clasificador;
using WiW.src.IDato;
using WiW.src.Views;

namespace WiW
{
    public partial class Board : Dragable, BoardView
    {
        public int SelectedQuery { get { return userQuerys.SelectedIndex; } }

        public event EventHandler BtnYes;
        public event EventHandler BtnNo;
        public event EventHandler BtnPaths;
        public event EventHandler BtnLevels;
        public event EventHandler BtnLeafs;
        public event EventHandler BtnGuess;
        public event EventHandler BtnAsk;
        public event EventHandler BtnClose;
        public event EventHandler BtnNewGame;

        public Board(List<Query> querys, string pcQuery, List<PictureBox> faces
            , Image playerFace) : base()
        {
            InitializeComponent();
            InitEvents();
            InitForm(querys, faces, pcQuery, playerFace);
		}

        private void InitEvents()
        {
            btnYes.Click += delegate { BtnYes?.Invoke(this, EventArgs.Empty); };
            btnNo.Click += delegate { BtnNo?.Invoke(this, EventArgs.Empty); };
            btnPaths.Click += delegate { BtnPaths?.Invoke(this, EventArgs.Empty); };
            btnLevels.Click += delegate { BtnLevels?.Invoke(this, EventArgs.Empty); };
            btnLeafs.Click += delegate { BtnLeafs?.Invoke(this, EventArgs.Empty); };
            btnGuess.Click += delegate { BtnGuess?.Invoke(this, EventArgs.Empty); };
            btnAsk.Click += delegate { BtnAsk?.Invoke(this, EventArgs.Empty); };
            btnClose.Click += delegate { BtnClose?.Invoke(this, EventArgs.Empty); };
            btnNewGame.Click += delegate { BtnNewGame?.Invoke(this, EventArgs.Empty); };
        }

        public BoardView InitForm(List<Query> querys, List<PictureBox> faces
            , string pcQuery, Image playerFace)
        {
            userQuerys.DataSource = querys;
            txtPregunta.Text = pcQuery;
            userFace.Image = playerFace;
            int x = 0, y = 0, i = 0, w = 125, h = 192;
            foreach (PictureBox f in faces)
            {
                PictureBox face = new PictureBox();
                face.Cursor = f.Cursor;
                face.BackColor = f.BackColor;
                face.Image = f.Image;
                face.SizeMode = f.SizeMode;
                face.Name = f.Name;
                face.Size = new Size(w, h);
                face.Location = this.pictureBox2.Location = new System.Drawing.Point(x * w + 5, y * h + 5);
                face.Click += new EventHandler(MarkFace);
                y = ++i / 6;
                x = i % 6;
                caras.Controls.Add(face);
            }
            userQuerys.SelectedIndex = 0;
            btnGuess.Enabled = true;
            PcTurn();
            return this;
        }

        public void UserTurn(string pcQuery)
        {
            txtPregunta.Text = pcQuery;
            userQuerys.Enabled = true;
            btnAsk.Enabled = true;
            pictureBox2.Visible = true;
            pictureBoxSi.Visible = false;
            pictureBoxNo.Visible = false;
            btnNo.Enabled = false;
            btnYes.Enabled = false;
            txtPregunta.Enabled = false;
        }

        public void PcTurn()
        {
            userQuerys.Enabled = false;
            btnAsk.Enabled = false;
            btnNo.Enabled = true;
            btnYes.Enabled = true;
            txtPregunta.Enabled = true;
        }

        public void PcReply(bool reply)
        {
            pictureBoxSi.Visible = reply;
            pictureBoxNo.Visible = !pictureBoxSi.Visible;
            pictureBox2.Visible = false;
        }

        public Form GetForm()
        {
            return this;
        }
        void MarkFace(object? sender, EventArgs e)
        {
            if (sender == null)
                throw new ArgumentNullException();
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox.Name.StartsWith("No_"))
                pictureBox.Name = pictureBox.Name.Substring(3);
            else
                pictureBox.Name = "No_" + pictureBox.Name;
            pictureBox.Image = fileMgr.Img(pictureBox.Name);
        }

    }
}