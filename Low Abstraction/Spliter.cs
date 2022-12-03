using System;
using System.Collections.Generic;
using WiW.src.IDato;

namespace WiW.src.Clasificador
{
    public class Spliter
    {
        private double Gini(RawData child)
        {   // Gini Impurity - https://en.wikipedia.org/wiki/Decision_tree_learning
            Dictionary<string, int> counts = child.NamesDic();
            double impurity = 1.0;
            foreach (var pair in counts)
            {
                double prob = pair.Value / (double)child.Ylen;
                impurity -= Math.Pow(prob, 2.0);
            }
            return impurity;
        }
            
        private double InfoGain(RawData [] child, double parentGini)
        {   //Information Gain.
            // Uncertainty of parent, minus the weighted impurity of children.
            double p = (double) child[0].Ylen/ (double) (child[0].Ylen + child[1].Ylen);
            return parentGini - p * Gini(child[0]) - (1.0 - p) * Gini(child[1]);
        }

        private RawData[] Split(RawData child, int col, Choice p)
        {
            RawData[] res = { new(null), new(null) };
            for (int i = 0; i < child.Ylen; i++)
                if ( p.answer(child.Val(i,col)) )
                    res[0].Add(child.Row(i));
                else
                    res[1].Add(child.Row(i));
            return res;
        }

        public (Choice, RawData[]) BestSplit(RawData rd)
        {   //Iteration by feature with gain calculation .
            (Choice, RawData[]) o = new(null!, new RawData[2]);
            double best = 0;
            double gini = Gini(rd);
            for (int j = 0; j < rd.Xlen - 1; j++)
            {
                HashSet<string> hs = new();
                for (int i = 0; i < rd.Ylen && hs.Add(rd.Val(i,j)) ; i++)
                {
                    Choice p = new(rd.Val(i, j), rd.Query![j]);
                    var res = Split(rd, j, p);
                    if (res[0].Ylen != 0 && res[1].Ylen != 0)
                    {
                        double gain = InfoGain(res, gini);
                        if (gain >= best)
                        {
                            best = gain;
                            o.Item1 = p;
                            o.Item2 = res;
                        }
                    }
                }
            }
            return best > 0 ? o : default ;
        }
    }
}
