using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpf;
using WiW.src.IDato;

namespace WiW.src.Clasificador
{
    public class SLeaf : ISorter
    {
        private IData Faces;
        public SLeaf(HashSet<string> faces)
        {
            Faces = new Result(faces);
        }

        public IData Data()
        {
            return Faces;
        }
        public ISorter? Left()
        {
            return null;
        }
        public ISorter? Right()
        {
            return null;
        }
        public bool isParent()
        {
            return false;
        }
    }
}
