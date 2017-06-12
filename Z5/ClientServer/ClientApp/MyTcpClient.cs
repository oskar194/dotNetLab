using MyCommunicationInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp {
	class MyTcpClient {
		private TcpClient client = null;
		NetworkStream stream = null;
		FileStream file = null;
		public void Connect(string ip, int port, string path) {
			try {
				string[] splitted = path.Split('\\');
				string filename = splitted.Last();
				file = new FileStream(path, FileMode.Open);
				byte[] fileData = new byte[file.Length];
				file.Read(fileData, 0, (int)file.Length);
				BinaryFormatter formatter = new BinaryFormatter();
				ExchangeClass dataObject = new ExchangeClass(filename, fileData);
				client = new TcpClient(ip,port);
				stream = client.GetStream();
				formatter.Serialize(stream, dataObject);
				stream.Close();
				file.Close();
				client.Close();
			} catch(SocketException se) {
				MessageBox.Show("CLIENT: Problem with connection!");
			}finally {
				if (stream != null)
					stream.Close();
				if (file != null)
					file.Close();
				if (client != null)
					client.Close();
			}


		}
	}
}
