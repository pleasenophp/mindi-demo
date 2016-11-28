using System;
using Custom.Demo;
using Custom.Demo.Implementations;
using MinDI;

namespace LogSystem
{
	public class LogSystemContextInitializer : IGlobalContextInitializer
	{
		public void Initialize(IDIContext context)
		{
			// context.s().Bind<ILog>(() => new SimpleLog());
			context.s().Bind<ILog>(() => new DecoratedLog(new SimpleLog()));
		}
	}
}
