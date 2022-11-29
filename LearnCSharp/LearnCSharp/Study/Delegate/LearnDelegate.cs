//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

namespace LearnCSharp.Study.Delegate__Func__Lambda
{ // What is delegate!
  //  A delegate is an object which refers to a method or you can say it is a reference type variable
  //  that can hold a reference to the methods. Delegates in C# are similar to the function pointer in C/C++.
  //  It provides a way which tells which method is to be called when an event is triggered.
    public class LearnDelegate
    {
        public static void main(string[] arg)
        {
            Calculate calculate = new Calculate();
            // calculate.ShowOddNumberUnderN(20);
            // calculate.ShowOddNumberUnderNInLine(20);
            // calculate.ShowOddNumberUnderNInLineSeparateByComma(20);
            // you see it is difficult. To solve this problem we can use delegate key.
            // calculate.ShowOddNumberUnderNDelegate(25, print);
            calculate.ShowOddNumberUnderNDelegate(50, i => Console.WriteLine(i));
        }

        private static void Print(int i)
        {
            Console.Write(i + ", ");
        }
    }

    public class Calculate
    {
        public void ShowOddNumberUnderN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // if my boss asks print inline all number at one line.
        public void ShowOddNumberUnderNInLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                }
            }
        }

        // if my boss asks print inline all number at one line and separate by ,comma
        public void ShowOddNumberUnderNInLineSeparateByComma(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");
                }
            }
        }

        public delegate void CallBack(int i);
        public void ShowOddNumberUnderNDelegate(int n, CallBack callBack)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    // callBack(i);
                    callBack.Invoke(i);
                }
            }
        }
    }
}
