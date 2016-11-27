using System;
using System.Collections.Generic;
using MinDI;

namespace Custom.Demo.Implementations
{
    public class World : ContextObject, IWorld
    {
        [Injection] public IList<int> list { get; set; }
        [Injection] public ILog log { get; set; }

        public void Run()
        {
            log.LogLine("Hello from World! This world has list: "+list);
        }
    }
}