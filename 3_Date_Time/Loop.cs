using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Date_Time {
    internal class Loop {
        static void Main() {
            Console.WriteLine("For loop step incremnet");
            for(int step = 1; step <= 10; step++) {
                Console.WriteLine("Step is " + step);
            }

            Console.WriteLine("For loop step decrement");
            for(int step = 10; step >= 1; step--) {
                Console.WriteLine("Step is " + step);
            }

            Console.WriteLine("factorial:");
            int num = 7;
            int r = 1;
            for(int a = num; a > 1; a--) {
                r = r * a;
            }
            Console.WriteLine("fectorial is " + r);

            //while loop 

            int num1 = 123456789;
            String str = "";
            //while(num1 != 0) {
            //    str = str + num1 % 10;
            //    num1 = num1 / 10;
            //}
            do {
                str = str + num1 % 10;
                num1 = num1 / 10;
            }
            while(num1 != 0);
            Console.WriteLine("Reverse is:" + str);

            //nested for loop 

            for(int i = 1; i <= 5; i++) {
                char ch = 'A';
                for(int j = 1; j <= 6 - i; j++) {
                    //    if(i % 2 != 0)
                    //        Console.Write(j);
                    //    else
                    //        Console.Write(6-j);
                    //}
                    //Console.WriteLine();

                    if(j % 2 != 0)
                        Console.Write(ch + " ");
                    else {
                        Console.Write((char)(ch + 32) + " ");
                        ch++;
                    }
                }
                Console.WriteLine();
            }
            //Ex:2
            int rows = 5;

            for(int i = 0; i < rows; i++) {

                for(int s = 0; s < i * 2; s++) {
                    Console.Write(" ");
                }


                for(int j = 0; j < rows - i; j++) {
                    // Print alternating 1 and 0
                    Console.Write((j % 2 == 0 ? 1 : 0) + " ");
                }
                Console.WriteLine();
            }

            //Ex:3
            
            for(int i = 0; i < rows; i++) {
                // Print leading spaces (each level 2 spaces)
                for(int s = 0; s < i * 2; s++) {
                    Console.Write(" ");
                }

                // Print numbers based on the row
                for(int j = 0; j < rows - i; j++) {
                    // Pattern rule:
                    // First half = 1s, second half = 2s
                    if(j < (rows - i) / 2)
                        Console.Write("1 ");
                    else
                        Console.Write("2 ");
                }

                Console.WriteLine();
            }

            //EX: 4
            int[] primes = { 2, 3, 5, 7, 11 };
            int n = primes.Length;

            for(int i = 0; i < n; i++) {
                // Print leading spaces
                for(int s = 0; s < i * 2; s++) {
                    Console.Write(" ");
                }

                // Print decreasing prime sequence
                for(int j = i; j < n; j++) {
                    Console.Write(primes[j] + " ");
                }

                Console.WriteLine();
            }

            int num2 = 1001;
            int b, e = 0, s1 = 0;

            while(num2 !=0) { // 100!=0
                b = num2 % 10; // 0
                s1 = s1 + b * (int)(Math.Pow(2, e));
                num2 = (int)(num2 / 10); // 100
                e++;
            }

            Console.WriteLine(s1);
        }
    }
}

    
