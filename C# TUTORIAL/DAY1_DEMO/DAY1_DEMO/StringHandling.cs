using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class StringHandling
    {
        static void MainFn()
        {
            string s = "hello";
            s = "hello world";
            String str = new String("new stirng");
            Console.WriteLine(str.Replace("stirng","string"));
            Console.WriteLine(s.Replace("hello","Hello"));
            Console.WriteLine(s[0]);
            Console.WriteLine();
        }
    }
}
