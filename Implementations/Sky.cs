using System;
using MinDI;

namespace Custom.Demo.Implementations
{
    public class Sky : ContextObject, ISky
    {
        [Injection] public ILog log { get; set; }

        public void Touch()
        {
            log.LogLine("You cannot touch the sky");
        }
    }
}