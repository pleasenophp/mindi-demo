using System;
using MinDI;

namespace Custom.Demo.Implementations {
	public class DecoratedLog : ContextObject, ILog {
		[Injection] public ILogOwner logOwner { get; set; }

		private readonly ILog innerLog;

		public DecoratedLog(ILog innerLog) {
			this.innerLog = innerLog;
		}

		public void Log(string message) {
			innerLog.Log(message);
		}

		public void LogLine(string message) {
			innerLog.Log(string.Format("{0} > [from {1}]: ", DateTime.Now.ToShortTimeString(), logOwner.Name));
			innerLog.LogLine(message);
		}
	}
}