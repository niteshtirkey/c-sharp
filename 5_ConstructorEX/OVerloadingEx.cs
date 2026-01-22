using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConstructorEX {
    internal class OVerloadingEx {
        void Add(int a, int b) {
            Console.WriteLine("a+b:"+a+b);
        }
        void Add(int a, int b, int c) {
            Console.WriteLine("a+b+c:" + a + b +c);
        }

        void Add(float a, float b) {
            Console.WriteLine( a + b);
        }
        //public static void Main(string[] args) {
        //    OVerloadingEx overEX = new OVerloadingEx();
        //    overEX.Add(1, 2);
        //    overEX.Add(1, 2, 3);
        //    overEX.Add(1.32F, 2.43F);

        //}

    }
}
