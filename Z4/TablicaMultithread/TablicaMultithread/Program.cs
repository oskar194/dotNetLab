using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TablicaMultithread {
	public class BlockingThread {
		public void Run(Table tab) {
			Console.WriteLine("BlockingThread adding " + Thread.CurrentThread.ManagedThreadId);
			//if (new Random().Next(100) > 20) {
			//	Console.WriteLine("Waiting! " + Thread.CurrentThread.ManagedThreadId);
			//	Thread.Sleep(10000);
			//}
			tab.AddBlocking(Thread.CurrentThread.ManagedThreadId);
		}
	}


	public class NonBlockingThread {
		public void Run(Table tab) {
			Console.WriteLine("NonBlokingThread try to add " + Thread.CurrentThread.ManagedThreadId);
			tab.AddNonblocking(Thread.CurrentThread.ManagedThreadId);
		}
	}

	class Program {
		static void Main(string[] args) {
			Table tab = new Table(5);
			List<Thread> tList = new List<Thread>();
			for (int i = 1; i <= 100; i++) {
				if (i > 1) {
					tList.Add(new Thread(() => new BlockingThread().Run(tab)));
				} else {
					//tList.Add(new Thread(() => new NonBlockingThread(new Random().Next(100)).Run(tab)));

				}
			}
			foreach(Thread t in tList) {
				t.Start();
			}
			foreach (Thread t in tList) {
				t.Join();
			}
			for (int i = 0; i < tab.Length; i++) {
				Console.WriteLine(tab[i]);
			}
			Console.WriteLine("Table length is : " + tab.Length);
			Console.ReadKey();
		}
	}
}
