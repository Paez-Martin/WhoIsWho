using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace WiW.src.IViews
{
    internal interface GameOverView : FormView
    {
        public event EventHandler BtnClose;
        public event EventHandler BtnNewGame;

        public void PcGuess(Image predictedFace, double probability);
        public void PlayerHit(Image predictedFace);
        public void PlayerMiss(Image predictedFace);
    }
}
