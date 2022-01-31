using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.Deligates
{
    public delegate void MyDelegate();
    internal class DeligateReturns
    {
        static void MainFn()
        {
            var ptr1 = Foo;
            ptr1 += Foo2;
            //Will return Then last called Delegate
            Console.WriteLine(ptr1(21));
            Foo3(out int a,out int b);
            Console.WriteLine(a + b);
            //Multiple deligate will return last updated value
            //Console.WriteLine();
        }

        static int Foo(int val) { 
            return val;
        }
        static int Foo2(int val) { 
            return val;
        }

        static void Foo3(out int a, out int b)
        {
            a = 10;
            b= 20;
        }
    }
}
