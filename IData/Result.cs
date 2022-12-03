using System.Xml.Linq;
using WiW.src.IDato;

namespace tpf
{
	public class Result : IData
	{
		private HashSet<string> Faces { get; }
		public double Potluck { get; }
		private string toString = "";
		public Result(HashSet<string> results)
		{
			if (results.Count == 0)
				return;
			Faces = results;
			Potluck = 100 / Faces.Count;
            foreach (string name in Faces)
                toString += " " + name + " , ";
            toString = toString.Substring(0, toString.Length - 2);
            if (Faces.Count > 1)
                toString = "(" + toString + ") : " + Potluck.ToString() + "%";
        }
        public (string, double) Rand()
		{
            int i = new Random().Next(Faces.Count);
            return (Faces.ElementAt(i), Potluck);
        }
		public override string ToString()
		{
			return toString;
		}

	}
}
