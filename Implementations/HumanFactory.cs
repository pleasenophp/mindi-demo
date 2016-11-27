using Custom.Demo.Context;
using MinDI;

namespace Custom.Demo.Implementations
{
    public class HumanFactory : ReproduceContextFactory<IHuman, HumanContext>, IHumanFactory
    {
        public IHuman CreateHuman(string humanName)
        {
            return this.Create(() => Construction.For("name", humanName));
        }
    }
}