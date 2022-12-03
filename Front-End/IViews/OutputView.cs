namespace WiW.src.IViews
{
    public interface OutputView : FormView
    {
        public string Print { get; set; }

        public event EventHandler? BtnClose;
    }
}
