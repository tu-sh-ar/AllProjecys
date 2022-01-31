using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    public class BoxingUnboxing
    {
        static void fn(string[] args)
        {
            //Boxing
            int i = 10;
            object o = i;
            o = 20;
            Console.WriteLine(o);
            Console.WriteLine(i);

            //UnBoxing
            int j = (int)o;
            Console.WriteLine(j);   
        }


    }
}

//Boxing and unboxing degrade the performance. So, avoid using it. Use generics to avoid boxing and unboxing. For example, use List instead of ArrayList.