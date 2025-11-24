using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Date_Time {
    internal class SumDateDigit {
        static void Main() {
            string date1 = "12052016";
            int d1 = Convert.ToInt32(date1);
            int sum = 0;

                while(d1 != 0) {
                    int first = d1 % 10;
                    d1 = (int)(d1 / 10);
                    sum += first;
                }
                Console.WriteLine(sum);

            //OPERATOR 

            int a = 10;
            int b = a++ + a++ + a++;
            Console.WriteLine("a={0} and b={1}", a, b);
         }
    }
}
