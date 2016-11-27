using System;
using System.Collections.Generic;
using MinDI;

namespace Custom.Demo.Implementations
{
    public class World : ContextObject, IWorld
    {
        [Injection] public IList<int> list { get; set; }

        public void Run()
        {
            Console.WriteLine("Hello from World! This world has list: "+list);
        }
    }
}