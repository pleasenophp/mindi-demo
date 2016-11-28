using System;
using MinDI;

namespace Custom.Demo.Implementations {
	public class Sky : ContextObject, ISky {
		[Injection] public ILog log { get; set; }

		private ConsoleColor color = ConsoleColor.Blue;

		public void SetColor(ConsoleColor color) {
			this.color = color;
		}

		public void Touch() {
			log.LogLine(string.Format("You cannot touch the {0} sky", color));
		}
	}
}