using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConstructorEX {
    internal class Program {
        static void Main() {
            Constractor_ex obj = new Constractor_ex(2,3);

            //get set 

            PropertyEx example = new PropertyEx();
            example.Width = 100; // setter 
            Console.WriteLine(example.Width); // getter

            B obj1 = new B();
            obj1.Fun();

            Trangle obj2 = new Trangle();
            obj2.Accept(2);
            obj2.Accept1(3);
            obj2.TrangleArea();
            obj2.Display();
        }
    }
}
