using System;
using System.Diagnostics;
using Custom.Demo;
using Custom.Demo.Implementations;
using MinDI;

namespace LogSystem {
	public class LogSystemContextInitializer : IGlobalContextInitializer {
		public void Initialize(IDIContext context) {
			context.m().Bind<ILog>(() => new SimpleLog(), BindingName.For(LogType.Simple));
			context.m().Bind<ILog>(() => new DecoratedLog(context.Resolve<ILog>(BindingName.For(LogType.Simple))), BindingName.For(LogType.Decorated));
			context.m().Bind<ILogOwner>(() => new CoreLogOwner());
		}
	}
}
