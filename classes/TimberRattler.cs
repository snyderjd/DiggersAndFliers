using System;

namespace DiggersAndFliers
{
    public class TimberRattler : IGroundable
    {
        public int NumLegs { get; set; }

        public void MoveOnGround()
        {
            Console.WriteLine("The snake slithers along the ground.");
        }
    }
}