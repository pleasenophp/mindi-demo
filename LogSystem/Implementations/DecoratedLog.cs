using System;
using MinDI;

namespace Custom.Demo.Implementations {
	public class DecoratedLog : ContextObject, ILog {
		private readonly ILog innerLog;

		public DecoratedLog(ILog innerLog) {
			this.innerLog = innerLog;
		}

		public void Log(string message) {
			innerLog.Log(message);
		}

		public void LogLine(string message) {
			innerLog.Log(string.Format("{0} > ", DateTime.Now.ToShortTimeString()));
			innerLog.LogLine(message);
		}
	}
}