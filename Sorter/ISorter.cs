using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiW.src.IDato;

namespace WiW.src.Clasificador
{
    public interface ISorter
    {
        public IData Data();
        public ISorter? Left();
        public ISorter? Right();
        public bool isParent();
    }
}
