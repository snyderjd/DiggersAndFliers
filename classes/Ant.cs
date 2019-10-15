using System;

namespace DiggersAndFliers
{
    public class Ant : IDigable
    {
        public void Dig()
        {
            Console.WriteLine("The ant is now digging!");
        }
    }
}