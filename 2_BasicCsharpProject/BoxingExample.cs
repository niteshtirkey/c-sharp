using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BasicCsharpProject {
    internal class BoxingExample {
        internal void BoxingFun() {
            int a = 4;
            Object o;
            o = a;
            Console.WriteLine(o);
        }
        internal void UnBoxingFun2() {
            Object o = 10;
            int a = (int)o;
            Console.WriteLine(a);
        }
    }
}
