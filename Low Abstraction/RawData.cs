
using System;
using System.IO;
using System.Collections.Generic;
using WiW;
using WiW.src.IDato;
using WiW.src.Parse;

namespace WiW.src.Clasificador
{
    public class RawData
    {
        private static List<string>? query { get; set; }
        public List<string>? Query { get { return query; } }
        private List<List<string>> Rows { get; set; }
        public int Ylen { get { return Rows.Count; } }
        public int Xlen { get { return Rows.Count == 0 ? 0 : Rows[0].Count; } }
        
        private static Spliter strategy = new Spliter();
        public RawData(List<List<string>>? rows = null)
        {
            Rows = rows != null ? rows : new List<List<string>>();
        }
        public RawData()
        {
            Rows = new List<List<string>>();
            using (var stream = FileMgr.Instance().QueryFile())
                using (var reader = new StreamReader(stream))
                    Rows = Parser.Parse(reader);
            query = Rows[0];
            Rows.RemoveAt(0);
        }

        public string Name(int Fila)
        {
            if (Rows.Count <= Fila || Rows[Fila].Count == 0)
                return "";
            return Rows[Fila][Rows[Fila].Count - 1];
        }
        public string Val(int i, int j)
        {
            return Rows[i][j];
        }
        public List<string> Row(int i)
        {
            return Rows[i];
        }
        public void Add(List<string> row)
        {
            Rows.Add(row);
        }
        public (Choice, RawData[]) BestQuery()
        {
            return strategy.BestSplit(this);
        }
        public HashSet<string> ToHashSet()
        {
            HashSet<string> h = new();
            for (int i = 0; i<Ylen; i++)
                h.Add(Name(i));
            return h;
        }
        public Dictionary<string, int> NamesDic()
        {
            Dictionary<string, int> dic = new();
            for (int i = 0; i < Ylen; i++)
            {
                string name = Name(i);
                if (!dic.ContainsKey(name))
                    dic.Add(name, 0);
                dic[name] = dic[name] + 1;
            }
            return dic;
        }
    }
}
