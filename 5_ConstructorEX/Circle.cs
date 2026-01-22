using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConstructorEX {
    internal class Circle {
        internal int param1;
        internal float area;

        internal void Accept(int param1) { 
            this.param1 = param1;
        }

        internal void Display() {
            Console.WriteLine("Area is {0}", area);
        }
    }
}
