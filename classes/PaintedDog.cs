using System;

namespace DiggersAndFliers
{
    public class PaintedDog : IWalking
    {
        public void Run()
        {
            Console.WriteLine("The Painted dog is now running.");
        }

        public void Walk()
        {
            Console.WriteLine("The painted dog is now walking.");
        }
    }
}