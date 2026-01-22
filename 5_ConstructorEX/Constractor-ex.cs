using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConstructorEX {
    internal class Constractor_ex {

        static int x, y;
        int a, b;
        static Constractor_ex() {
            x = 1;
            y = 2;
            Console.WriteLine("Static Default Constuctor"+(x+y));
        }
        internal Constractor_ex() {
            Console.WriteLine("Default Constructor");
        }
        internal Constractor_ex(int a, int b) {
            this.a = a; this.b = b;
            Console.WriteLine("Parameter Constuctor"+(a+b));
        }
    }
}
