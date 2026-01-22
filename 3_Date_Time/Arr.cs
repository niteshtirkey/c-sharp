using System;

namespace _3_Date_Time {
    internal class Arr {
        static void Main(string[] args) {

            int[] arr ={1,3,4,7,2};
            for(int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }

            //for Each loop 

            //foreach(int i in arr) { 
            //Console.WriteLine(i);
            //}

            //Console.WriteLine("Dynamic Arr Size:");

            //int size;
            //Console.WriteLine("Enter size of arr");
            //size = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[size];

            //Console.WriteLine("Array by for loop:");

            //for(int i = 0; i < arr1.Length; i++) {
            //    Console.WriteLine("Enter Item:");
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach(int i in arr1) {
            //    Console.WriteLine(i);
            //}

            //EX-1

            int [] arr2 = { 10, 40, 20, 50, 30 };
            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach(int num in arr2) {
                if(num > max) {
                    secondMax = max;
                    max = num;
                } else if(num > secondMax && num != max) {
                    secondMax = max;
                }
            }
            Console.WriteLine("MaxElement:" + max);
            Console.WriteLine("MinElement:" + secondMax);

        }
    }
}
