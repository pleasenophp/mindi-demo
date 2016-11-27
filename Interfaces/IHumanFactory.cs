using Custom.Demo.Implementations;
using MinDI;

namespace Custom.Demo
{
    public interface IHumanFactory : IDIFactory<IHuman>
    {
        IHuman CreateHuman(string name);
    }
}