using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Furniture
    {
        public string Name { get; set; }
        public Furniture()
        {
            Name = "Шкаф";
        }
        public Furniture(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
