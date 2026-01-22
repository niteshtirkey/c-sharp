using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Date_Time {
    internal class SwitchStatement {
        static void Main() {
            int num = 4;
            switch(num % 2) {
                case 0:
                    Console.WriteLine("Event");
                    break;
                default:
                    Console.WriteLine("Odd");
                    break;
            }
        }
    }
}
