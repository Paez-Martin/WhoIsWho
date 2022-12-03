using System;
using System.Collections.Generic;
using System.Data;
using WiW.src.Clasificador;
using WiW.src.IDato;

namespace tpf
{
    
	public abstract class SFactory
    {

        public static ISorter New(RawData data)
		{
			(Choice, RawData[]) i = data.BestQuery();
			if (i == default)
				return new SLFactoy().Create(data);
			return new SPFactory().Create(i.Item1, i.Item2);
		}

	}

    // Se decide que las Factory concretas no sean hijos
    // Podrian evitarse, pero mejor dejarlas listas.

    internal class SLFactoy
    {
        public ISorter Create(RawData data)
        {
            return new SLeaf(data.ToHashSet());
        }

    }
    internal class SPFactory
    {
        public ISorter Create(Choice c, RawData[] d)
        {
            return new SParent(c, d);
        }

    }
}
