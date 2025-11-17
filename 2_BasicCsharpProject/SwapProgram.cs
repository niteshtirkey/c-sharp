using System;

namespace _2_BasicCsharpProject {
    internal class SwapProgram {

        static int a = 5, b = 10;

        internal static  void Swap() { 
        int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Value of a = {0} and b = {1}", a, b);
        }
    }
}
