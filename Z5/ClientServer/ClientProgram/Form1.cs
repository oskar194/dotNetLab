using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProgram {

	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			//Thread t = new Thread(delegate () {
			//	for (;;) {
			//		this.Invoke((MethodInvoker)delegate () {
			//			if (progressBar1.Value == progressBar1.Maximum) {
			//				progressBar1.Value = 0;
			//			}
			//			progressBar1.Value++;
			//		});
			//	}
			//});
			//t.Start();

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

		private void button1_Click(object sender, EventArgs e) {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.ShowDialog();
			textBox3.ResetText();
			textBox3.Text = dialog.FileName;
		}

		private void button2_Click(object sender, EventArgs e) {
			//SENDbutton
			IPAddress ip = null;
			int port = 0;
			FileStream file = null;
			string path = String.Empty;
			if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null) {
				try {
					ip = IPAddress.Parse(textBox1.Text);
				}catch(FormatException fe) {
					MessageBox.Show("Wrong IP");
					return;
				}
				try {
					port = int.Parse(textBox2.Text);
				}catch(FormatException fe2) {
					MessageBox.Show("Wrong port");
					return;
				}
				try {
					file = new FileStream(textBox3.Text, FileMode.Open);
				} catch (FileNotFoundException fnfe) {
					MessageBox.Show("Cannot find file");
					return;
				}
				try {
					string[] vals = textBox3.Text.Split('\\'); 
					Thread t = new Thread(() => { SyncClient.StartClient(ip, port, file,vals.Last()); });
					t.Start();
				}catch(ConnectionException ce) {
					MessageBox.Show("Cannot connect to server");
					return;
				}
				MessageBox.Show("File sent");
				

				
			}else {
				MessageBox.Show("Fill all fields");
			}
		}
	}
}
