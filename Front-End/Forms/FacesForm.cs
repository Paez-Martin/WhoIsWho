using tpf;
using WiW.src.Clasificador;
using WiW.src.IViews;

namespace WiW
{
    public partial class FacesForm : Dragable, FacesView
    {
        public List<PictureBox> Imgs { get; }

        public event EventHandler<ImgArg> ImgSelected;
        public event EventHandler<NameArg> NameSelected;
        public event EventHandler BtnClose;

        public FacesForm(RawData data)
        {
            InitializeComponent();
            Imgs = drawFaces(data);
            btnclose.Click += delegate { BtnClose?.Invoke(this, EventArgs.Empty); };
            Show();
            Activate(); // Lo trae al frente 
        }

        private List<PictureBox> drawFaces(RawData data)
        {
            List<PictureBox> faces = new();
            for (int j = 0, x = 0, y = 0; j < data.Ylen;)
            {
                faces.Add(CreateFace(data.Name(j), x, y));
                y = ++j / 6;
                x = j % 6;
            }
            return faces;
        }

        private PictureBox CreateFace(string name, int x, int y)
        {
            int w = 70, h = 105;
            PictureBox face = new();
            face.Size = new System.Drawing.Size(w, h);
            Image file = fileMgr.Img(name);
            face.Cursor = Cursors.Hand;
            face.BackColor = Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            face.Image = file;
            face.Location = new Point(x * w + 3, y * h + 3);
            face.SizeMode = PictureBoxSizeMode.StretchImage;
            face.Name = name;
            face.Click += new EventHandler(delegate { ImgSelected?.Invoke(this, new ImgArg(file)); });
            face.Click += new EventHandler(delegate { NameSelected?.Invoke(this, new NameArg(name)); });
            answerPanel.Controls.Add(face);
            return face;
        }

        public Form GetForm()
        {
            return this;
        }

        public bool AreYouShure(string text)
        {
            DialogResult dr = MessageBox.Show(text, "Pregunta", MessageBoxButtons.YesNo);
            if ( dr == DialogResult.Yes)
                return true;
            return false;
        }
    }
}
