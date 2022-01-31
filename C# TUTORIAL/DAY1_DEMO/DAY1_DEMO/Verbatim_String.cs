using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class Verbatim_String
    {
        static void Fn()
        {
            string s = @"hello 'there this is \Code@store'"" ";
            Console.WriteLine(s);
        }
    }
}
