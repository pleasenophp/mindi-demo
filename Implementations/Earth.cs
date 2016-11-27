using System;
using MinDI;

namespace Custom.Demo.Implementations
{
    public class Earth : ContextObject, IWorld
    {
        [Injection] public ISky sky { get; set; }
        [Injection] public ILog log { get; set; }

        public void Run()
        {
            log.LogMessage("Hello from the Earth!");
            log.LogMessage("Earth has sky. Trying to touch it...");
            sky.Touch();
        }
    }
}