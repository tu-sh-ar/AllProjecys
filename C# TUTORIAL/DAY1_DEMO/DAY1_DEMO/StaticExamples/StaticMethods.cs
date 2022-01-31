
namespace DAY1_DEMO
{
    internal class StaticMethods
    {
        static void MainFn(string[] args)
        {
            var obj = new Method1();
            obj.Fn1(21);
            //Can not accerss static method with non-static Method
            Method1.Fn1();
            Method2.Fn1();
        }
    }

    public class Method1
    {
        static int Count = 0;
        int a = 0;
        public static void Fn1()
        {
            //Static methods can contain local static variables.

            //Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.
            Console.WriteLine("Method1 static function Fn1()");
        }

        //static method overloaded
        public void Fn1(int a)
        {
            Console.WriteLine("Method1 nonstatic Fn1()");
        }
        public void Fn2()
        {
            Console.WriteLine("Static Method1 Fn2() ");
        }
    }

    //static methods can be overloaded but cannot be overrided
    //Static Methods Can not be overridden

    public static class Method2
    {
        //static constructor
        static Method2()
        {
            Console.WriteLine("Constructor Called");
        }
        public static void Fn1()
        {
            int b = 0;
            Console.WriteLine("Static Method2 Fn1()");
        }
        public static void Fn2()
        {
            Console.WriteLine("Static Method2 Fn2()");
        }
    }
}
