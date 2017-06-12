using MyCommunicationInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ServerApp {
	class TcpListenerServer {
		private TcpListener server = null;
		private bool isRunning = false;
		public bool IsRunning {
			get {
				return isRunning;
			}
		}
		List<Thread> threadList = new List<Thread>();
		public void StartListening(IPAddress ip, int port, String path) {
			try {
				server = new TcpListener(ip, port);
				server.Start();
				isRunning = true;
				while (isRunning) {
					TcpClient client = server.AcceptTcpClient();
					threadList.Add( new Thread(() => { processClient(client, path); }));
					threadList.Last().Start();
				}
			}catch(SocketException se) {
				if (se.SocketErrorCode == SocketError.Interrupted) {
				}
				else {
					MessageBox.Show("SERVER: Connection problem!");
				}
				return;
			}catch(Exception e) {
				MessageBox.Show("SERVER: Unknown problem!");
			}finally {
				stopServer();
			}
		}

		private void processClient(TcpClient client, string path) {
			if (!isRunning)
				return;
			int bytesRead = 0;
			int allRead = 0;
			string[] filesInDirectory;
			byte[] dataBuffer = new byte[1024];
			NetworkStream stream = client.GetStream();
			ExchangeClass dataFromClient;
			Stream message = new MemoryStream();
			while((bytesRead = stream.Read(dataBuffer, 0, dataBuffer.Length))!=0){
				message.Write(dataBuffer, 0, bytesRead);
				allRead += bytesRead;
			}
			message.Seek(0, SeekOrigin.Begin);
			BinaryFormatter formatter = new BinaryFormatter();
			dataFromClient = (ExchangeClass)formatter.Deserialize(message);
			filesInDirectory = Directory.GetFiles(path);
			string[] splittedName = dataFromClient.Name.Split('.');
			string name = splittedName[0];
			foreach (string filename in filesInDirectory) {
				if (Path.GetFileName(filename).Equals(dataFromClient.Name)) {
					dataFromClient.Name = name + "copy" + "." + splittedName[1];
					name += "copy";
				}
			}
			FileStream file = null;
			try {
				file = new FileStream(path + "\\" + name + "." + splittedName[1], FileMode.CreateNew);
			} catch (IOException ioe) {
				name += "copy";
				file = new FileStream(path + "\\" + name + "." + splittedName[1], FileMode.CreateNew);

			}
			file.Write(dataFromClient.FileContents, 0, dataFromClient.FileContents.Length);
			file.Close();
			message.Close();
			client.Close();
		}

		public void stopServer() {
			foreach(Thread t in threadList) {
				t.Join();
			}
			isRunning = false;
			server.Stop();
		}
	}
}
