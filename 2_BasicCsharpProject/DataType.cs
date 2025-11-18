using System;

namespace _2_BasicCsharpProject {
    internal class DataType {

        public void PDataTypeFun() { 
        int a = 11; // 4 Byte
        byte bt = 2; // 1 byte.
        float b = 22.33F; // 4 Byte
        double c = 22332.3; // 8 Byte
        bool d = false; // 1 Byte
        char ch = 'a'; // 2 Byte
            string s = "hello"; // 
        Console.WriteLine("a={0}, bt={1}, c={2}, d={3}, ch={4}, s={5}", a,bt, b,c, d,ch,s);
        }
        public void DDataTypeFun() {
            Int16 a = 11; // 4 Byte
            Byte bt = 2; // 1 byte.
            Double c = 22332.3; // 4 Byte
            Boolean d1 = false; // 1 Byte
            Char ch = 'a'; // 2 Byte
            String s = "hello"; // 
            Console.WriteLine("a={0}, bt={1}, c={2}, d1={3}, ch={4}, s={5}", a, bt, c, d1, ch,s`                );
        }

    }
}

