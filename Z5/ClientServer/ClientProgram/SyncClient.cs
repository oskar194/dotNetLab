using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProgram {
	class SyncClient {
		public static void StartClient(IPAddress ip, int port, FileStream file, string name) {
			byte[] dataFile = new Byte[file.Length];
			byte[] dataFileName = new Byte[name.Length];
			byte[] eof = new Byte["<EOF>".Length];
			dataFileName = ASCIIEncoding.ASCII.GetBytes(name);
			eof = ASCIIEncoding.ASCII.GetBytes("<EOF>");
			file.Read(dataFile, 0, (int)file.Length);
			file.Close();
			try {
				IPEndPoint remoteEP = new IPEndPoint(ip, port);
				Socket sender = new Socket(AddressFamily.InterNetwork,
					SocketType.Stream, ProtocolType.Tcp);
				sender.Connect(remoteEP);
				int bytesSent = sender.Send(dataFile);
				bytesSent = sender.Send(eof);
				bytesSent = sender.Send(dataFileName);
				sender.Shutdown(SocketShutdown.Send);
				byte[] receivedData = new byte[1024];
				int bytesRec = sender.Receive(receivedData);
				string s = Encoding.ASCII.GetString(receivedData, 0, bytesRec);
				if (s.Equals("SUCCESS")) {
					sender.Shutdown(SocketShutdown.Both);
					sender.Close();
					MessageBox.Show("Server received file successfully");
				}
			} catch (SocketException se) {
				throw new ConnectionException("Can't connect to a server", se);
			}
		}
	}
}
