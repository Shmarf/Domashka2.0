using System;

namespace Domashka_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Dog sobaka1 = new Dog("пудель", new DateTime(2001, 03, 30));
                Console.WriteLine(sobaka1 .Age);
                ((IWalking)sobaka1 ).Walk();

                Butterfly babochka1 = new Butterfly("махаон", new DateTime(2000, 05, 05));
                Console.WriteLine(babochka1 .Age);
                ((IFlying)babochka1 ).Fly();

                Bird ptica1 = new Bird("воробей", new DateTime(2020, 11, 16));
                Console.WriteLine(ptica1 .Age);
                ((IFlying)ptica1 ).Fly();

                Fish riba1 = new Fish("камбала", new DateTime(2010, 10, 25));
                Console.WriteLine(riba1 .Age);
                ((ISwimming)riba1 ).Swimm();
                Gym gym = new Gym();
                gym.AddAmimal(sobaka1, babochka1, ptica1, riba1);

                gym.LetsMove();


            }
        }
    }
}
