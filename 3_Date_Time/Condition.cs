using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Date_Time {
    internal class Condition {
        static void Main() { 
            int num  = 4;
            int result;
            if(num % 2 == 0) {
                result = num * num;
                Console.WriteLine(result);
            } else { 
                result = num*num*num;
                Console.WriteLine(result);
            }

            //nested 

            int a = 10, b = 40, c=30;
            if(a > b) {
                if(a > c) {
                    Console.WriteLine("a is greater");
                } else {
                    Console.WriteLine("c is greated");
                }
            } else {
                if(b > c) {
                    Console.WriteLine("b is greater");
                } else {
                    Console.WriteLine("c is greater");
                }
            }
        }
    }
}
