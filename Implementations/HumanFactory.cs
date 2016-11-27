using MinDI;

namespace Custom.Demo.Implementations
{
    public class HumanFactory : ContextFactory<IHuman>, IHumanFactory
    {
        public IHuman CreateHuman(string humanName)
        {
            return this.Create(() => Construction.For("name", humanName));
        }
    }
}