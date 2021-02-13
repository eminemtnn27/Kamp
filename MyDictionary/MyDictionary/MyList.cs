using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList <E>
    {
        E [] units;
        public MyList()
        {
            units = new E[0];
        }
        public void Add(E unit)
        {
            E[] tempArray = units;
            units = new E[units.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                units[i] = tempArray[i];
            }
            units[units.Length - 1] = unit;
        }
        public E[] Units
        {
            get { return units; }
        }
    }
}
