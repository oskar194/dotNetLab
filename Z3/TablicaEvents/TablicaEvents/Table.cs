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
        int last;
		public event EventHandler sizeChange;
		public event EventHandler elementAdded;

		public Table(int size)
        {
            this.tab = new int[size];
            this.last = 0;
        }

		protected virtual void OnAddition(EventArgs e) {
			elementAdded?.Invoke(this, e);
		}

		protected virtual void OnSizeChange(SizeArgs e) {
			sizeChange?.Invoke(this, e);
		}

		public void Add(int x)
        {
            if(last == tab.Length-1)
            {
                int[] tab2 = new int[tab.Length];
                tab.CopyTo(tab2, 0);
                tab = new int[tab.Length * 2];
				OnSizeChange(new SizeArgs(tab.Length));
                tab2.CopyTo(tab, 0);

               // tab[last] = x;
               // last++;
            }
                tab[last] = x;
				OnAddition(EventArgs.Empty);
                last++;
        }

        public int this[int index]
        {
            get
            {
                if(index >= tab.Length)
                {
                    throw new Exception("Index out of bounds");
                }else
                {
                    return tab[index];
                }
            }
            set
            {
                if(index >= tab.Length)
                { 
                    int[] tab2 = new int[tab.Length];
                    tab.CopyTo(tab2, 0);
                    tab = new int[index + 1];
					OnSizeChange(new SizeArgs(tab.Length));
                    tab2.CopyTo(tab, 0);
                }
                tab[index] = value;
				OnAddition(EventArgs.Empty);
                last = index;
            }
        }
    }
}
