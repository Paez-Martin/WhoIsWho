using tpf;
using WiW;
using WiW.src.Clasificador;
using WiW.src.IDato;
using static System.Net.Mime.MediaTypeNames;

namespace WiW.src.Game
{
    public class Machine
    {
        private DTree Node { get; set; }
        private DTree Root { get; set; }
        public RawData Data { get; set; }
        private List<string>? Replys { get; set; }
        private string? character;

        public Machine()
        {
            Data = new RawData();
            Node = Root = new(SFactory.New(Data));
        }

        public bool Ends()
        {
            return character == null || Node.ChildLess();
        }

        public string Query()
        {
            return Node.Data.ToString();
        }

        public (string, double)? Answer(bool valor)
        {
            if (Ends())
                throw new Exception("El juego ya terminó.");
            Node = valor ? Node.Left! : Node.Right!;
            if (!Ends())
                return null;
            return ((Result)Node.Data).Rand();
        }

        public bool Ask(int queryNum)
        {
            if (Replys == null)
                throw new Exception("El juego todavia no empezo.");
            return Replys[queryNum].Equals("si");
        }

        public bool Guess(string Face)
        {
            if (Face == null)
                throw new Exception("El juego no empezo.");
            return Face.Equals(character);
        }

        public string Name()
        {
            return character;
        }

        public string Leafs()
        {
            return Node.Leafs();
        }

        public string Paths()
        {
            return Node.Paths();
        }

        public string Levels()
        {
            return Node.Levels();
        }

        public List<Query> startGame()
        {
            Replys = new();
            RawData d = Data;
            int sel = new Random().Next(0, d.Ylen);
            HashSet<Query> hs = new();
            List<Query> querys = new();
            Query q;
            string rta;
            character = d.Name(sel);
            for (int j = 0; j < d.Xlen - 1; j++)
                for (int i = 0; i < d.Ylen; i++)
                    if (hs.Add( q = new Query(d.Val(i, j), d.Query![j]) ))
                    {
                        if ( (rta=d.Val(sel, j)) != "si" && rta != "no")
                            rta = d.Val(i, j) == rta ? "si" : "no";
                        Replys.Add(rta);
                        querys.Add(q);
                    }
            Node = Root;
            return querys;
        }

    }
}