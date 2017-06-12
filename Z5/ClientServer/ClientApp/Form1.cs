using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp {
	public partial class Form1 : Form {
		IPAddress ip;
		int port;
		string path;
		public Form1() {
			InitializeComponent();
		}

		private void folderBrowseButton_Click(object sender, EventArgs e) {
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.ShowDialog();
			textBox3.ResetText();
			textBox3.Text = fileDialog.FileName;
		}
	}
}
