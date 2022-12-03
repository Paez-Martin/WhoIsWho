using System;
using System.Collections.Generic;
using WiW.src.Clasificador;
using static System.Net.Mime.MediaTypeNames;

namespace WiW.src.IDato
{
    public class Query
    {
        protected string _Phrase;
        public string Phrase { get { return _Phrase; } }

        public Query(string feature, string txt)
        {
            if (txt.StartsWith("¿{0}"))
            {
                txt = txt.Substring(5);
                _Phrase = "¿" + char.ToUpper(txt[0]) + txt.Substring(1);
            }
            else
                _Phrase = string.Format(txt, feature);
        }

        public override int GetHashCode()
        {
            return Phrase.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is not Query)
                return false;
            Query q = (Query)obj;
            return Phrase == q.Phrase;
        }
        public override string ToString()
        {
            return Phrase;
        }
    }

}
