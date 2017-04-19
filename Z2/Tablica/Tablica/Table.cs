using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica
{
    class Table
    {
        int[] tab;
        int index;
        int size;
        int last;

        void Add(int x)
        {
            if(last + 1 > size)
            {
                tab = new int[size * 2];
                size *= 2;
            }
            tab[last + 1] = x;
            last++;
        }

        public int this[int index]
        {
            get
            {
                if(index > size)
                {
                    throw new Exception("Index out of bounds");
                }else
                {
                    return tab[index];
                }
            }
            set
            {
                if(index > size)
                {
                    size = index;
                    tab = new int[size];
                }
                tab[index] = value;
                last = index;
            }
        }
    }
}
