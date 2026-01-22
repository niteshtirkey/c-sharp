using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConstructorEX {
    internal class Reactangle : Circle {
        internal int param2;
        internal void Accept1(int param2) {
            this.param2 = param2;
        }

        internal void ReactArea() {
            {
                area = param1 * param2;
            }
        }
    }
}
