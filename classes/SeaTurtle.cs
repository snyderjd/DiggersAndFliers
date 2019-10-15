using System;

namespace DiggersAndFliers
{
    public class SeaTurtle : IWalking, ISwimable
    {
        public int MaximumDepth { get; set; } = 100;

        public void Run()
        {
            Console.WriteLine("The sea turtle is now running.");
        }

        public void Walk()
        {
            Console.WriteLine("The sea turtle is now walking.");
        }
        public void Swim()
        {
            Console.WriteLine("The sea turtle is now swimming.");
        }
    }
}