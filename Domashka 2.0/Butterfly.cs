using System;
using System.Collections.Generic;
using System.Text;

namespace Domashka_2._0
{
    class Butterfly : Animal, IFlying
    {
        public string Name { get; set; }
        public Butterfly(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public override string ToString() => Name;
    }
}
