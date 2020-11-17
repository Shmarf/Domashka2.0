using System;
using System.Collections.Generic;
using System.Text;

namespace Domashka_2._0
{
    interface IFlying
    {
        void Fly()
        {
            Console.WriteLine(this + " летит в новую точку");
        }
    }
}