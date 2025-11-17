using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BasicCsharpProject {
    internal class A {
       internal static void fun() { 
            int a = 10; // static
            Console.WriteLine(a);
        }
        internal void fun1() {
            int b = 200; // intance
            Console.WriteLine(b);
        }
    }
}
