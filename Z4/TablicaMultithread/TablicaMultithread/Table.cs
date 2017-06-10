using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TablicaMultithread {
	public class Table {
		private int[] tab;
		private int last;
		private object syncToken;
		private int length;
		public int Length {
			get{
				return length;
			}
		}
		public event EventHandler sizeChange;
		public event EventHandler elementAdded;

		public Table(int size) {
			this.tab = new int[size];
			this.last = 0;
			length = size;
			syncToken = new object();
		}

		protected virtual void OnAddition(EventArgs e) {
			elementAdded?.Invoke(this, e);
		}

		protected virtual void OnSizeChange(SizeArgs e) {
			sizeChange?.Invoke(this, e);
		}

		public void Add(int x) {
			if (last == tab.Length - 1) {
				int[] tab2 = new int[tab.Length];
				tab.CopyTo(tab2, 0);
				tab = new int[tab.Length * 2];
				OnSizeChange(new SizeArgs(tab.Length));
				tab2.CopyTo(tab, 0);
				// tab[last] = x;
				// last++;
			}
			tab[last] = x;
			length = tab.Length;
			OnAddition(EventArgs.Empty);
			last++;
		}

		public void AddBlocking(int x) {
			int timeBefore = DateTime.Now.Millisecond;
			lock (syncToken) {
				Add(x);
			}
			Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " waited: " + (DateTime.Now.Millisecond - timeBefore) + "ms");
		}

		public void AddNonblocking(int x) {
			var lockAquired = Monitor.TryEnter(syncToken);
			if (!lockAquired) {
				Console.Write(" Tab is locked. Exiting ");
				//Monitor.Exit(syncToken);
				return;
			} else {
				Add(x);
				Console.Write("Value added" + '\n');
				Monitor.Exit(syncToken);
			}
		}


		

		public int this[int index] {
			get {
				if (index >= tab.Length) {
					throw new Exception("Index out of bounds");
				} else {
					return tab[index];
				}
			}
			set {
				if (index >= tab.Length) {
					int[] tab2 = new int[tab.Length];
					tab.CopyTo(tab2, 0);
					tab = new int[index + 1];
					OnSizeChange(new SizeArgs(tab.Length));
					tab2.CopyTo(tab, 0);
				}
				tab[index] = value;
				length = tab.Length;
				OnAddition(EventArgs.Empty);
				last = index;
			}
		}
	}
}
