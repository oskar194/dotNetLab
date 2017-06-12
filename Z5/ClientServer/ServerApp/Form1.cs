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

namespace ServerApp {
	public partial class Form1 : Form {
		TcpListenerServer server = new TcpListenerServer();
		int port;
		string path;
		IPAddress ip;
		Thread t;
		public Form1() {
			InitializeComponent();
			statusLabel.Text = "Disconnected";
		}

		private void folderBrowseButton_Click(object sender, EventArgs e) {
			FolderBrowserDialog folderDialog = new FolderBrowserDialog();
			folderDialog.ShowDialog();
			textBox3.ResetText();
			textBox3.Text = folderDialog.SelectedPath;
		}

		private void startButton_Click(object sender, EventArgs e) {
			if (server.IsRunning) {
				server.stopServer();
				t.Join();
				statusLabel.Text = "Disconnected";
			}else {
				if(!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals("")) {
					try {
						ip = IPAddress.Parse(textBox1.Text);
					} catch(FormatException fe) {
						MessageBox.Show("SERVER: Not a valid IP");
						return;
					}
					try {
						port = int.Parse(textBox2.Text);
					}catch(FormatException fex) {
						MessageBox.Show("SERVER: Invalid port");
						return;
					}
					if (!Directory.Exists(textBox3.Text)) {
						MessageBox.Show("SERVER: Directory don't exist");
						return;
					}
					path = textBox3.Text;
					t = new Thread(() => { server.StartListening(ip, port, path); });
					t.Start();
					statusLabel.Text = "Connected";

				} else {
					MessageBox.Show("SERVER: Fill all fields");
					return;
				}

			}
		}
	}
}
