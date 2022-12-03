using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WiW.src.IViews;

namespace WiW
{
    public partial class Output : Dragable, OutputView
    {
        public string Print
        {
            get { return txt.Text; }
            set { txt.Text = value;  }
        }

        public event EventHandler? BtnClose;

        public Output()
        {
            InitializeComponent();
            EventHandler d = delegate { BtnClose?.Invoke(this, EventArgs.Empty); };
            btnclose.Click += d;
            btnBack.Click += d;
        }

        public Form GetForm()
        {
            return this;
        }
    }
}

