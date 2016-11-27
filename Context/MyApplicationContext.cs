using Custom.Demo.Implementations;
using MinDI;

namespace Custom.Demo.Context
{
    public class MyApplicationContext : IApplicationContextInitializer
    {
        public void Initialize(IDIContext context)
        {
            // context.s().Bind<IWorld>(() => new World());
            context.s().Bind<IWorld>(() => new Earth());
        }
    }
}