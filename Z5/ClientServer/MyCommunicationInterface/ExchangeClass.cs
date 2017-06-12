using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCommunicationInterface
{
	[Serializable]
    public class ExchangeClass
    {
		private string name;
		private byte[] fileContents;
		public ExchangeClass(string name, byte[] fileContents) {
			this.Name = name;
			this.FileContents = fileContents;
		}
		public string Name {
			get {
				return name;
			}

			set {
				name = value;
			}
		}

		public byte[] FileContents {
			get {
				return fileContents;
			}

			set {
				fileContents = value;
			}
		}
	}
}
