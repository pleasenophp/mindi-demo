using System;
using MinDI;

namespace Custom.Demo.Implementations
{
    public class Earth : ContextObject, IWorld
    {
        [Injection] public ISky sky { get; set; }

        public void Run()
        {
            Console.WriteLine("Hello from the Earth!");
            Console.WriteLine("Earth has sky. Trying to touch it...");
            sky.Touch();
        }
    }
}