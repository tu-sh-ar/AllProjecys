using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variable_Example
{
    class Program
    {
        static void Main2(string[] args)
        {
            //cretaing integer type variable
            //int num1, num2, result;
            ////Displaying message
            Console.WriteLine("Please enter first value");

            ////Accepting Value in num1
            //num1 = Int32.Parse(Console.ReadLine());
            ////Displaying message
            //Console.WriteLine("Enter second Value");
            ////Accepting Value
            //num2 = Int32.Parse(Console.ReadLine());

            //result = num1 + num2; //processing value
            double n = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second value");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("val {0} type='{1}'",n,n.GetTypeCode()); //Output
            Console.WriteLine("val {0} type='{1}'", a, a.GetTypeCode()); //Output

            //Console.ReadLine();
        }
    }
}