using System;
using MinDI;

namespace Custom.Demo.Implementations
{
    public class Earth : ContextObject, IWorld
    {
        [Injection] public ISky sky { get; set; }
        [Injection] public ILog log { get; set; }

        [Injection] public IDIFactory<IHuman> humanFactory { get; set; }

        public void Run()
        {
            log.LogLine("Hello from the Earth!");
            log.LogLine("Earth has sky. Trying to touch it...");
            sky.Touch();

            IHuman human = humanFactory.Create();
            log.LogLine("I have created a human and he will say something now.");
            human.Say();

            log.LogLine("Now let the human act");
            human.Act();
        }
    }
}