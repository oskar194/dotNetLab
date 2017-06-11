using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProgram {

	public partial class Form1 : Form {
		public Form1() {

			InitializeComponent();
			Thread t = new Thread(delegate () {
				for (;;) {
					this.Invoke((MethodInvoker)delegate () {
						if (progressBar1.Value == progressBar1.Maximum) {
							progressBar1.Value = 0;
						}
						progressBar1.Value++;
					});
				}
			});
			t.Start();

		}

		public void UpdateProgressBar() {

				if (this.InvokeRequired) {
					this.BeginInvoke(new Action(UpdateProgressBar));
					return;
				}
				if (progressBar1.Value == progressBar1.Maximum) {
					progressBar1.Value = 0;
				}
				progressBar1.PerformStep();
				Thread.Sleep(1000);
			

		}
	}
}
