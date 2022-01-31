using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.Deligates
{
    internal delegate void DeligateFunction();
    internal class Deligate1
    {
        public static void Fn1() => Console.WriteLine("hello from Fn1");
        static public void Fn2() => Console.WriteLine("hello from Fn2");
        

        
        internal static void MainFn()
        {
            DeligateFunction deligateFunction1 = new DeligateFunction(Fn1);
            //or
            var deligateFunction2 = Fn2;
            deligateFunction2();
            Console.WriteLine(  deligateFunction2.GetType());

            deligateFunction1 = Fn1;
            Console.WriteLine(deligateFunction1.GetType());
            deligateFunction1();
            var ptr = () => { Console.WriteLine("annonimus fn"); };
            Console.WriteLine(ptr.GetType());
            ptr();
        }

    }
}
