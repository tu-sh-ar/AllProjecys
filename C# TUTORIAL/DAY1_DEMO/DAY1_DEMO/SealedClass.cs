using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class SealedClassExample
    {
        static void MainFn(string[] args)
        {
            var sealedclass = new SealedClass();
            sealedclass.Foo();
        }
    }
    public sealed class SealedClass
    {
        public void Foo()
        {
            Console.WriteLine("......Hello I Am Sealed Class......\n.........No One Can Inherit Me");
        }
    }
    //class Demo : SealedClass              Can not inherit Sealed
    //{

    //}
}
