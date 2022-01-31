using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class OutKeyword
    {
        static void fn()
        {
            //int a = 20; // declare variable without initialization
            //int b = 10;

            OutParamExample(out int a,out int b);// calling method with out keyword

            Console.WriteLine(a);// accessing out parameter value
            Console.Write(b);// accessing out parameter value

            
        }
        public static void OutParamExample(out int y,out int z)
        {

            y = 200;
            z = 300;

        }
    }
}
