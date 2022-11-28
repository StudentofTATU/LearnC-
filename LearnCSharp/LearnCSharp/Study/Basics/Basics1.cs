using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Study.Basics
{
    public class Basics1
    {
        public static void main(string[] args)
        {
            StringInterpolation();

        }
        private static void VaraiableByRef()
        {
            int number = 5;
            Add100(number);
            Console.WriteLine(number);
            Console.WriteLine("-------------");
            Add10ByRef(ref number);
            Console.WriteLine(number);
        }
        private static void Add100(int i)
        {
            i += 100;
        }

        private static void Add10ByRef(ref int i)
        {
            i += 100;
        }


        //string interpolation
        private static void StringInterpolation()
        {
            Console.WriteLine("{0}+{1}={2}", 3, 4, 7);
            int a = 10, b = 20;
            Console.WriteLine($"{a}+{b}={a + b}");
            string name = "Alisher";
            Console.WriteLine($"He is {name,15}. He is my friend.");//15 space for name varialble.

        }
    }
}
