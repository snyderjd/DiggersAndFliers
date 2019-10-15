using System;

namespace DiggersAndFliers
{
    public class Copperhead : IGroundable
    {
        public int NumLegs { get; set; }

        public void MoveOnGround()
        {
            Console.WriteLine("The copperhead slithers along the ground.");
        }
    }
}