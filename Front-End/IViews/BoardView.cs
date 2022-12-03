using WiW.src.IDato;
using WiW.src.IViews;

namespace WiW.src.Views
{
    public interface BoardView : FormView
    {
        public int SelectedQuery { get; }

        public event EventHandler BtnYes;
        public event EventHandler BtnNo;
        public event EventHandler BtnPaths;
        public event EventHandler BtnLevels;
        public event EventHandler BtnLeafs;
        public event EventHandler BtnGuess;
        public event EventHandler BtnAsk;
        public event EventHandler BtnClose;
        public event EventHandler BtnNewGame;

        public void UserTurn(string pcQuery);
        public void PcTurn();
        public void PcReply(bool reply);
    }
}
