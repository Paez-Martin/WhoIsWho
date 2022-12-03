using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiW.src.IViews
{
    public interface FacesView : FormView
    {
        public List<PictureBox> Imgs { get; }

        public event EventHandler<ImgArg> ImgSelected;
        public event EventHandler<NameArg> NameSelected;
        public event EventHandler BtnClose;

        public bool AreYouShure(string text);
    }

    public class ImgArg : EventArgs
    {
        public Image Face { get; }
        public ImgArg(Image face)
        {
            Face = face;
        }
    }

    public class NameArg : EventArgs
    {
        public string Name { get; }
        public NameArg(string name)
        {
            Name = name;
        }
    }
}
