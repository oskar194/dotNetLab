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

namespace ClientApp {
	public partial class Client : Form {
		string ip;
		int port;
		string path;
		MyTcpClient client = new MyTcpClient();
		Thread t;
		public Client() {
			InitializeComponent();
			textBox1.Text = "127.0.0.1";
			textBox2.Text = "8080";
			textBox3.Text = "C:\\Users\\Admin\\Downloads\\18918017_1918410061735001_4473894770262933504_n.mp4";
		}

		private void folderBrowseButton_Click(object sender, EventArgs e) {
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.ShowDialog();
			textBox3.ResetText();
			textBox3.Text = fileDialog.FileName;
		}

		private void sendButton_Click(object sender, EventArgs e) {
			if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals("")) {
				try {
					IPAddress.Parse(textBox1.Text);
					ip = textBox1.Text;
				} catch (FormatException fe) {
					MessageBox.Show("CLIENT: Not a valid IP");
					return;
				}
				try {
					port = int.Parse(textBox2.Text);
				} catch (FormatException fex) {
					MessageBox.Show("CLIENT: Invalid port");
					return;
				}
				if (!File.Exists(textBox3.Text)) {
					MessageBox.Show("CLIENT: File don't exist");
					return;
				}
				path = textBox3.Text;
				t = new Thread(() => { client.Connect(ip, port, path); });
				t.Start();
			} else {
				MessageBox.Show("CLIENT: Fill all fields");
				return;
			}
		}
	}
}
