using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.LINQ
{
    internal class Lambda
    {
        static void MainFn(string[] args)
        {
            Func<int, int, long> multiply = (num1, num2) => num1 * num2; // Lambda Expression
            Console.WriteLine(multiply(5, 10).ToString());
            Console.ReadLine();
        }
    }
}
