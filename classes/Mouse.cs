using System;

namespace DiggersAndFliers
{
    public class Mouse : IGroundable
    {
        public int NumLegs { get; set; }

        public void MoveOnGround()
        {
            Console.WriteLine("The mouse runs to get the cheese.");
        }
    }
}