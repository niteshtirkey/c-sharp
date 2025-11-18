using System;

namespace _2_BasicCsharpProject {
    internal class Program {

        static int y = 100;
        int a = 5;
        static void Main(string[] args) {
            int y = 10;
            y = 20;
            Console.WriteLine("y is satic varibals"+y);
            Console.WriteLine("y is satic varibles" + Program.y);

            Program obj = new Program();
            Console.WriteLine(obj.a);

            A obj2 = new A();
            obj2.fun1();
            A.fun();

            const String companyName = "Nitesh Kumar Tirkey";
            Console.WriteLine(companyName);

            SwapProgram.Swap();

            BoxingExample example = new BoxingExample();
            example.BoxingFun();
            example.UnBoxingFun2();

            DataType dataType = new DataType();
            dataType.PDataTypeFun();
            dataType.DDataTypeFun();
        }
    }
}
