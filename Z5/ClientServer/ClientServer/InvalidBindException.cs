using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServer {
	class InvalidBindException : Exception{
		public InvalidBindException() {
		}

		public InvalidBindException(string message) : base(message) {
		}

		public InvalidBindException(string message, Exception inner):base(message,inner){
		}
	}
}
