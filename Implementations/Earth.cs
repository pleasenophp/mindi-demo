using System;
using MinDI;

namespace Custom.Demo.Implementations
{
    public class Earth : ContextObject, IWorld
    {
        [Injection] public ISky sky { get; set; }
        [Injection] public ILog log { get; set; }

        [Injection] public IHumanFactory humanFactory { get; set; }

        public void Run()
        {
            log.LogLine("Hello from the Earth!");
            log.LogLine("Earth has sky. Trying to touch it...");
            sky.Touch();

            IHuman human = humanFactory.CreateHuman("Adam");
            log.LogLine("I have created a human Adam, and he will say something now.");
            human.Say();

            log.LogLine("Now let the human act");
            human.Act();

            IHuman eva = humanFactory.CreateHuman("Eva");
            log.LogLine("I have created another human");
            eva.Say();
        }
    }
}