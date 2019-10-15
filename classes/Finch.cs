using System;

namespace DiggersAndFliers
{
    public class Finch : IFlyable
    {
        public int MaxSpeed { get; set; }

        public Finch()
        {
            MaxSpeed = 14;
        }

        public void Fly()
        {
            Console.WriteLine("The finch flies through the air.");
        }
    }
}