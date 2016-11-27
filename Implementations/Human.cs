using MinDI;

namespace Custom.Demo.Implementations
{
    public class Human : ContextObject, IHuman
    {
        [Injection] public ISky sky { get; set; }
        [Injection] public ILog log { get; set; }
        [Requirement] public string name { get; set; }

        public void Act()
        {
            log.LogLine("I will act and will try to touch the sky right now");
            sky.Touch();
        }

        public void Say()
        {
            log.LogLine(string.Format("Hi, I'm {0}", name));
        }
    }
}