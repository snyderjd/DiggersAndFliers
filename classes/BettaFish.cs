using System;

namespace DiggersAndFliers
{
    public class BettaFish : ISwimable
    {
        public int MaximumDepth { get; set; }

        public BettaFish()
        {
            MaximumDepth = 10;
        }

        public void Swim()
        {
            Console.WriteLine("The betta fish swims in the water.");
        }


    }
}