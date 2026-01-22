using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_oops {
    internal class Program {
        static void Main(string[] args) { 

         Employee obj = new Employee();
            obj.Accept(1, "Emp1", 22);
            obj.Display();

        Employee obj1 = new Employee();
            obj1.Accept(2, "Emp2", 23);
            obj1.Display();


            Console.WriteLine(StaticExample.x);
            StaticExample.fun();

            InstanceEx obj2 = new InstanceEx();
            Console.WriteLine(obj2.x);
            obj2.fun1();

            //Student 

            Student[] obj3 = new Student[5];
            for(int i = 0; i < obj3.Length; i++) {
                obj3[i] = new Student();
                Console.WriteLine("Enter rno:");
                int rno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter fees:");
                int fees = Convert.ToInt32(Console.ReadLine());
                obj3[i].Accept(rno,fees);
            }

            int max = 0;
            int stuindex = 0;
            for(int j = 0; j < obj3.Length; j++) {
                if(max < obj3[j].fees) { 
                    max = obj3[j].fees;
                    stuindex = j;
                }   
            }
            Console.WriteLine("Max Fees is {0}", max);
            obj3[stuindex].Display();
        }
    }
}
