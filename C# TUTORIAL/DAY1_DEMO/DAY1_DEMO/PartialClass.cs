using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class PartialClass
    {
        static void Fn()
        {
            Class1 class1 = new Class1();
            class1.FunctionHello();
            class1.FunctionUniverse();
        }
    }

    public partial class Class1
    {
        public void FunctionHello() => Console.WriteLine("Hello world");
    }
    public partial class Class1
    {
        public void FunctionUniverse() => Console.WriteLine("Hello Universe");
    }
}
