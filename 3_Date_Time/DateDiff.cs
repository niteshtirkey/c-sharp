using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Date_Time {
    internal class DateDiff {
        static void Main() {
            String Date1 = "14111997";
            String Date2 = "18112025";


            int d1 = Convert.ToInt32(Date1);
            int d2 = Convert.ToInt32(Date2);
            int y1 = d1 % 10000;
            int y2 = d2 % 10000;
            Console.WriteLine("Difference of date in year = {0}", y2-y1);
        }
    }
}
