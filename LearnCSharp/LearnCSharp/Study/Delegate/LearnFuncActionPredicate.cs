//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

namespace LearnCSharp.Study.Delegate
{
    public class LearnFuncActionPredicate
    {
        public delegate double AreDelegate(int a, int b);
        public static void main(string args)
        {
            AreDelegate areDelegate = new AreDelegate(Area);
            areDelegate(3, 5);

            Func<int, int, double> area = Area;
            Console.WriteLine(area(3, 4));

            Action<int, int> areaPrint = PrintArea;
            areaPrint(5, 6);

            // Func<int,bool> IsAreaBig = IsAreaBiggerThan100;
            Predicate<int> isAreaBig = IsAreaBiggerThan100;
            bool isBig = isAreaBig(10);
            Console.WriteLine(isBig);

            Func<int, double, string> circleArea = (radius, pi) => $"Area of the Circle is {pi * radius * radius}";

            Console.WriteLine(circleArea(5,3.14));
        }

        public static double Area(int a, int b)
        {
            return a * b;
        }
        public static void PrintArea(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static bool IsAreaBiggerThan100(int area)
        {
            return area > 100;
        }


    }
}
