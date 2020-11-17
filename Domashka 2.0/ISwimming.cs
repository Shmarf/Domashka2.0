using System;
using System.Collections.Generic;
using System.Text;

namespace Domashka_2._0
{
    interface ISwimming
    {
        void Swimm()
        {
            Console.WriteLine(this + "  плывет в новую точку");
        }
    }
}
