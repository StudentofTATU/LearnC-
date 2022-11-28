using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Study.Delegate__Func__Lambda
{
    public class LearnMulticastDelegate
    {
        public delegate void AddNumbers(int i, int b);
        public delegate void Calculate(int i, int b);
        public static void main(string[] args)
        {
            var add = new AddNumbers(Add);
            AddNumbers add2 = Add;
            add.Invoke(2, 5);
            add2(5, 3);
            Console.WriteLine("--------------------");
            var calculate = new Calculate(Add);
            calculate += Mult;
            calculate += Sub;
            calculate.Invoke(5, 3);
            // if your method's type is not void (int, string..), you will get last method's return value.
            
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Mult(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
