using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.Deligates
{
    internal class FuncDelegate
    {
        static void MainFn(string[] args)
        {
            Func<int, int, int, int, int, int> FooPtr = Foo;
            Console.WriteLine(FooPtr(1,2,3,4,5));
        }
        static int Foo(int a, int b, int c, int d, int e)
        {
            return a*b*c*d*e;
        }
    }
}
