using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConstructorEX {
    internal class Program {
        static void Main() {

            Trangle obj2 = new Trangle();
            obj2.Accept(2);
            obj2.Accept1(3);
            obj2.TrangleArea();
            obj2.Display();
        }
    }
}
