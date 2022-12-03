using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace WiW.src.Parse
{
    public static class Parser
    {
        const char delimiter = ','; // es const por el switch

        public static List<List<string>> Parse(TextReader reader)
        {
            List<List<string>> list = new();
            List<string>  field = new();
            
            StringBuilder s = new();
            char c = '1';
            while (c != '\uffff')
                switch (c = (char)reader.Read())
                {
                    case delimiter: Record(s, field); break;
                    case '\r': break;
                    case '\n':
                    case '\uffff':
                        list.Add(Record(s, field));
                        field = new();
                        break;
                    case '"': while ((c = (char)reader.Read()) != '"' && c != '\uffff');
                              break;
                    default: s.Append(c); break;
                }
            return list;
        }

        private static List<string> Record(StringBuilder sb, List<string> record)
        {
            record.Add(sb.ToString().Trim());
            sb.Clear();
            return record;
        }
    }
}
