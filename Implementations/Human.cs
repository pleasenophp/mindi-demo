using MinDI;

namespace Custom.Demo.Implementations
{
    public class Human : ContextObject, IHuman
    {
        [Injection] public ISky sky { get; set; }
        [Injection] public ILog log { get; set; }

        public void Act()
        {
            log.LogLine("I will act and will try to touch the sky right now");
            sky.Touch();
        }

        public void Say()
        {
            log.LogLine("Hi, I'm a human");
        }
    }
}