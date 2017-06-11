using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientServer {
	public class DataObject {
		public Socket clientSocket = null;
		public const int bufferSize = 1024;
		public byte[] buffer = new Byte[bufferSize];
		public StringBuilder sb = new StringBuilder();
	}

	public class AsyncSocketListener {
		public static ManualResetEvent eventDone = new ManualResetEvent(false);

		public AsyncSocketListener() {

		}

		public static void StartListening(IPAddress ip, int port) {
			byte[] bytes = new Byte[1024];
			IPEndPoint endPoint = new IPEndPoint(ip, port);
			Socket listenerSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			try {
				listenerSocket.Bind(endPoint);
			} catch (SocketException e) {
				throw new InvalidBindException("Address or port was invalid",e);
			}
			try {
				listenerSocket.Listen(20);
				while (true) {
					eventDone.Reset();
					Console.WriteLine("Server is running");
					listenerSocket.BeginAccept(new AsyncCallback(AcceptCallback), listenerSocket);
					eventDone.WaitOne();
				}
			}catch(Exception e) {
				Console.WriteLine(e.ToString());
			}
			Console.WriteLine("\nPress ENTER to continue...");
			Console.Read();

		}

		public static void AcceptCallback(IAsyncResult asyncResult) {
			eventDone.Set();
			Socket listenerSocket = (Socket)asyncResult.AsyncState;
			Socket handler = listenerSocket.EndAccept(asyncResult);
			DataObject dataObject = new DataObject();
			dataObject.clientSocket = handler;
			handler.BeginReceive(dataObject.buffer, 0, DataObject.bufferSize, 0, new AsyncCallback(ReadCallback), dataObject);
		}
		public static void ReadCallback(IAsyncResult asyncResult) {
			String content = String.Empty;
			DataObject dataObject = new DataObject();
			Socket handler = dataObject.clientSocket;
			int bytesRead = handler.EndReceive(asyncResult);
			if(bytesRead > 0) {
				dataObject.sb.Append(ASCIIEncoding.ASCII.GetString(dataObject.buffer, 0, bytesRead));
				content = dataObject.sb.ToString();
				if(content.IndexOf("<EOF>") > -1) {
					Console.WriteLine("Read {0} bytes from client", content.Length);
					Console.WriteLine("Content: {0}", content);
					Send(handler, "SUCCESS");
				}else {
					handler.BeginReceive(dataObject.buffer, 0, DataObject.bufferSize, 0,new AsyncCallback(ReadCallback),dataObject);
				}
			}
		}

		private static void Send(Socket handler, String data) {
			byte[] byteData = ASCIIEncoding.ASCII.GetBytes(data);
			handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
		}

		private static void SendCallback(IAsyncResult asyncResult) {
			try {
				Socket handler = (Socket)asyncResult.AsyncState;
				int bytesSend = handler.EndSend(asyncResult);
				Console.WriteLine("Message send. Closing connection.");
				handler.Shutdown(SocketShutdown.Both);
				handler.Close();
			}catch(Exception e) {
				Console.WriteLine(e.ToString());
			}
		}

		static void Main(string[] args) {
			IPAddress ip;
			int port;
			Console.WriteLine("Please enter an IP address and port");
			string[] arguments = Console.ReadLine().Split(' ');
			if (arguments.Length < 1) {
				Console.WriteLine("Usage: <ip_address ex. 127.0.0.1> <port_number ex. 8080>");
				Console.ReadKey();
				return;
			} else {
				if (arguments[0].Equals("xd")) {
					ip = IPAddress.Parse("127.0.0.1");
					port = 8080;
				} else {
					try {
						ip = IPAddress.Parse(arguments[0]);
						port = int.Parse(arguments[1]);
					} catch (FormatException e) {
						Console.WriteLine(e.Message);
						Console.ReadKey();
						return;
					}
				}
			}
			try {
				StartListening(ip, port);
			} catch (InvalidBindException e) {
				Console.WriteLine(e.Message + " " + e.InnerException.Message);
				Console.ReadKey();
				return;
			}


		}
	}
}
