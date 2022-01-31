using System;
using System.Windows; 
using ExtensionMethods;

namespace DAY1_DEMO
{
    internal class ExtensionImplement
    {
        static void MainFn(string[] args)
        {
            var j = 1;
            string str = "hello";
            Console.WriteLine(j.IsGreaterThan(10.4));
            Console.WriteLine(j.IsLessThan(10));
            Console.WriteLine(j.IsEqualsTo(0.1));
            Console.WriteLine(j.IsZero());

            Console.WriteLine(str.IsEquals("hellow"));
        }
    }
}
