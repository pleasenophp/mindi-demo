using System.ComponentModel.Design.Serialization;
using Custom.Demo.Implementations;
using LogSystem;
using MinDI;

namespace Custom.Demo.Context {
	public class MyApplicationContext : IApplicationContextInitializer {
		public void Initialize(IDIContext context)
		{
		    context.s().Rebind<ILog>(null, BindingName.For(LogType.Decorated));

			context.s().Bind<IWorld>(() => new Earth());
			context.s().Bind<ISky>(() => new Sky());
			context.m().Bind<IHumanFactory>(() => new HumanFactory());
			context.m().Bind<IHuman>(() => new Human());
		}
	}
}