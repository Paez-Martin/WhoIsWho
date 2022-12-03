using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiW.src.IDato
{
    public class Choice : Query, IData
    {
        private string Reply { get; set; }

        public Choice(string feature, string txt) : base(feature, txt)
        {
            Reply = feature;
        }
        public bool answer(string txt)
        {
            if (Reply == "no")
                return txt.Equals("si");
            return txt.Equals(Reply);
        }
    }
}
