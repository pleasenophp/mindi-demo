using System;
using Custom.Demo.Implementations;
using MinDI;

namespace Custom.Demo.Context {
	public class HumanContext : ICustomContextInitializer {
		public void Initialize(IDIContext context) {
			context.s().Bind<ISky>(() => new Sky());
			context.Resolve<ISky>().SetColor(ConsoleColor.Magenta);
		}
	}
}