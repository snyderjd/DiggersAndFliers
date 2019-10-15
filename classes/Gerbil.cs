using System;

namespace DiggersAndFliers
{
    public class Gerbil : IGroundable
    {
        public int NumLegs { get; set; }

        public void MoveOnGround()
        {
            Console.WriteLine("The gerbil runs along the ground.");
        }
    }
}