using System.Runtime.InteropServices;

namespace WiW
{
    public class Dragable : Form
    {
        protected FileMgr fileMgr;

        public Dragable()
        {
            this.fileMgr = FileMgr.Instance();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void Drag(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
