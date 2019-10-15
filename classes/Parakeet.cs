using System;

namespace DiggersAndFliers
{
    public class Parakeet : IFlyable
    {
        public int MaxSpeed { get; set; }

        public Parakeet()
        {
            MaxSpeed = 20;
        }

        public void Fly()
        {
            Console.WriteLine("The parakeet flies through the air.");
        }
    }
}