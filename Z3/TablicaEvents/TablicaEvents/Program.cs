using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica
{
    class Program
    {
		public static void WhenElementAdded(object sender, EventArgs e) {
			Console.WriteLine("Dodano element!");
		}
		public static void WhenSizeChanged(object sender, EventArgs e) {
			Console.WriteLine("Zmieniono wielkosc do: " + ((SizeArgs)e).Val);
		}

        static void Main(string[] args)
        {
            Table t = new Table(5);
			t.elementAdded += WhenElementAdded;
			t.sizeChange += WhenSizeChanged;
            t.Add(0);
            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(4);

            t.Add(5);
            t.Add(6);
            t.Add(7);
            //t[5] = 6;
            t[12] = 8;
            t.Add(9);
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(t[i].ToString());

            }

            Console.ReadKey();

        }
	}
}
