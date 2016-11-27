using Custom.Demo.Context;
using MinDI;

namespace Custom.Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IDIContext context = ContextHelper.CreateContext<IGlobalContextInitializer>().Reproduce<IApplicationContextInitializer>();
            var world = context.Resolve<IWorld>();
            world.Run();
        }
    }
}