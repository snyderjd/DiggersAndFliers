using System;

namespace DiggersAndFliers
{
    public class Earthworm : IDigable
    {
        public void Dig()
        {
            Console.WriteLine("The earthworm is digging!");
        }
    }
}