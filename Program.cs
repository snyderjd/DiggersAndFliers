using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate ground animals
            TimberRattler timberRattler1 = new TimberRattler();
            Mouse mouse1 = new Mouse();
            Copperhead copperhead1 = new Copperhead();
            Gerbil gerbil1 = new Gerbil();
            
            // Instantiate digger animals
            Earthworm earthworm1 = new Earthworm();
            Ant ant1 = new Ant();

            // Instantiate flyer animals
            Parakeet parakeet1 = new Parakeet();
            Finch finch1 = new Finch();

            // Instantiate swimming animals
            BettaFish bettaFish1 = new BettaFish();
            Terrapin terrapin1 = new Terrapin();

            GroundBox groundBox1 = new GroundBox();
            DiggerBox diggerBox1 = new DiggerBox();
            FlyerBox flyerBox1 = new FlyerBox();
            SwimmerBox swimmerBox1 = new SwimmerBox();

            // Add ground animals to the ground box
            groundBox1.GroundAnimals.Add(timberRattler1);
            groundBox1.GroundAnimals.Add(mouse1);
            groundBox1.GroundAnimals.Add(copperhead1);
            groundBox1.GroundAnimals.Add(gerbil1);

            // Add digger animals to the digger box
            diggerBox1.DiggingAnimals.Add(earthworm1);
            diggerBox1.DiggingAnimals.Add(ant1);

            // Add flyer animals to the flyer box
            flyerBox1.FlyingAnimals.Add(parakeet1);
            flyerBox1.FlyingAnimals.Add(finch1);

            // Add swimming animals to the swimmer box
            swimmerBox1.SwimmingAnimals.Add(bettaFish1);
            swimmerBox1.SwimmingAnimals.Add(terrapin1);

            // for each item in each box, execute the common method that belongs to each animal
            foreach(IGroundable groundAnimal in groundBox1.GroundAnimals)
            {
                groundAnimal.MoveOnGround();
            }

            foreach(IDigable diggerAnimal in diggerBox1.DiggingAnimals)
            {
                diggerAnimal.Dig();
            }

            foreach(IFlyable flyerAnimal in flyerBox1.FlyingAnimals)
            {
                flyerAnimal.Fly();
            }

            foreach(ISwimable swimmingAnimal in swimmerBox1.SwimmingAnimals)
            {
                swimmingAnimal.Swim();
            }

        }
    }
}
