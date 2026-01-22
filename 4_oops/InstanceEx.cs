using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_oops {
    internal class InstanceEx {
        internal int x = 23; // Global instance

        internal void fun1() {
            int y = 29; // Local Instance variable
            Console.WriteLine(y);
            
        }

    }
}
