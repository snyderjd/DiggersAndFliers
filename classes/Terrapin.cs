using System;

namespace DiggersAndFliers
{
    public class Terrapin : ISwimable
    {
        public int MaximumDepth { get; set; }

        public Terrapin()
        {
            MaximumDepth = 5;
        }
        public void Swim()
        {
            Console.WriteLine("The terrapin swims in the brackish water.");
        }
    }
}