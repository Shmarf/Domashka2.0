using System;
using System.Collections.Generic;
using System.Text;

namespace Domashka_2._0
{
    class Gym
    {
        public List<Animal> animals = new List<Animal>();

        public void AddAmimal(Animal dog, Animal butterfly, Animal bird, Animal fish)
        {
            animals.Add(dog);
            animals.Add(butterfly);
            animals.Add(bird);
            animals.Add(fish);

        }

        public void LetsMove()
        {
            if (animals is IWalking)
            {
                IWalking iDog = animals as IWalking;
                iDog.Walk();
            }
            if (animals is ISwimming)
            {
                ISwimming iFish = animals as ISwimming;
                iFish.Swimm();
            }
            if (animals is IFlying)
            {
                IFlying iButt = animals as IFlying;
                iButt.Fly();
            }
            if (animals is IFlying)
            {
                IFlying iBird = animals as IFlying;
                iBird.Fly();
            }

        }

    }
}
    

