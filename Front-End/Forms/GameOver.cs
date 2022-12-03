using WiW.src.IViews;

namespace WiW
{
    public partial class GameOver : Dragable, GameOverView
    {
        public event EventHandler BtnClose;
        public event EventHandler BtnNewGame;

        public GameOver()
        {
            InitializeComponent();
            InitEvents();
        }

        public void PcGuess(Image predictedFace, double probability)
        {
            string s = "Definitivamente elijiste a ";
            if (probability != 100)
                s = "Me arriesgo a decir que eligiste a ";
            InitForm(predictedFace, s, Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200))))));
        }

        public void PlayerHit(Image predictedFace)
        {
            InitForm(predictedFace, "Correcto!!", Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(80))))));
        }

        public void PlayerMiss(Image predictedFace)
        {
            InitForm(predictedFace, "Incorrecto!!", Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(0))))));
        }

        private void InitEvents()
        {
            EventHandler e = delegate { BtnClose?.Invoke(this, EventArgs.Empty); };
            btnClose.Click += e;
            btnExit.Click += e;
            btnNewGame.Click += delegate { BtnNewGame?.Invoke(this, EventArgs.Empty); };
        }

        private void InitForm(Image predictedFace, string txt, Color backColor)
        {
            title.Text = txt;
            pictureBox1.Image = predictedFace;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            title.ForeColor = backColor;
            caras.BackColor = backColor;
            barra.BackColor = backColor;
            Show();
            Activate();
        }

        public Form GetForm()
        {
            return this;
        }
    }
}
