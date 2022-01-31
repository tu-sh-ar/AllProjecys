using MainPtr;

namespace ConsoleApplication2
{
    public class DeligateClass
    {
        //Declaration
        //Creating Delegates with no parameters and no return type.
        public delegate void DeligateFunction1();

        public void fun1()
        {
            Console.WriteLine("I am Function 1");
        }
        public void fun2()
        {
            Console.WriteLine("I am Function 2");
        }
        public void fun3()
        {
            Console.WriteLine("I am Function 3");
        }

        public delegate void DeligateFunction2();

        public string f1() { return "hello from fn1"; }
        public string f2() { return "hello from fn1"; }
    }

    class Program
    {
        static void MainFn(string[] args)
        {
            MainPointer.UpdatePtr("DeligateTest");
            DeligateClass deligateObject = new DeligateClass();
            //Instantiation
            DeligateClass.DeligateFunction1 fd1 = new DeligateClass.DeligateFunction1(deligateObject.fun1);
            DeligateClass.DeligateFunction1 fd2 = new DeligateClass.DeligateFunction1(deligateObject.fun2);
            DeligateClass.DeligateFunction1 fd3 = new DeligateClass.DeligateFunction1(deligateObject.fun3);

            //Invocation 
            fd1();
            fd2();
            fd3();

            Console.ReadKey();




        }
    }
}