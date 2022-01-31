using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.Deligates
{
    public class ActionDelegate
    {
        public static void Foo(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void MainFn(string[] args)
        {
            Action<int,int> FooPtr = ActionDelegate.Foo;
           FooPtr(2, 7);
        }

        
    }
}
