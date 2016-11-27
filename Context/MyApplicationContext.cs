using System.ComponentModel.Design.Serialization;
using Custom.Demo.Implementations;
using MinDI;

namespace Custom.Demo.Context
{
    public class MyApplicationContext : IApplicationContextInitializer
    {
        public void Initialize(IDIContext context)
        {
            // context.s().Bind<ILog>(() => new SimpleLog());
            context.s().Bind<ILog>(() => new DecoratedLog(new SimpleLog()));

            context.s().Bind<IWorld>(() => new Earth());
            context.s().Bind<ISky>(() => new Sky());

            context.m().Bind<IHumanFactory>(() => new HumanFactory());
            context.m().Bind<IHuman>(() => new Human());
        }
    }
}