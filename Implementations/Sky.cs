using System;

namespace Custom.Demo.Implementations
{
    public class Sky : ISky
    {
        public void Touch()
        {
            Console.WriteLine("You cannot touch the sky");
        }
    }
}