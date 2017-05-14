using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaMultithread {
	public class SizeArgs : EventArgs {
		int val;
		public SizeArgs(int val) {
			this.Val = val;
		}

		public int Val {
			get {
				return val;
			}

			set {
				val = value;
			}
		}
	}
}