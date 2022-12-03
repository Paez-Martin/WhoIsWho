using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpf;
using WiW.src.IDato;

namespace WiW.src.Clasificador
{
    internal class SParent : ISorter
    {
        private Choice Query;
        private RawData[] Dataset;
        public SParent(Choice p, RawData[] data)
        {
            if (data.Length != 2)
                throw new Exception("Se esperaban dos ParsedData");
            Query = p;
            Dataset = data;
        }
        public IData Data()
        {
            return Query;
        }
        public ISorter Left()
        {
            return SFactory.New(Dataset[0]);
        }
        public ISorter Right()
        {
            return SFactory.New(Dataset[1]);
        }
        public bool isParent()
        {
            return true;
        }
    }
}
