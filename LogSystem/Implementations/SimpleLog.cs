using System;
using MinDI;

namespace Custom.Demo.Implementations {
	public class SimpleLog : ContextObject, ILog {


		public void Log(string message) {
			Console.Write(message);
		}

		public void LogLine(string message) {
			Console.WriteLine(message);
		}
	}
}