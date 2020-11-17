using System;
using System.Collections.Generic;
using System.Text;

namespace Domashka_2._0
{
    interface IWalking
    {
        void Walk()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}