namespace Delegates
{
    public delegate void MyDelegate();
    class DelegatesAsPerimeter
    {
        static void MainFn()
        {
            MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del);
            del = ClassB.MethodB;
            InvokeDelegate(del);
        }

        public static void InvokeDelegate(MyDelegate del)
        {
            del();
        }
    }
    public class ClassA
    {
        public static void MethodA()
        {
            Console.WriteLine("Hello form Method A");
        }
    }

    public class ClassB
    {
        public static void MethodB()
        {
            Console.WriteLine("Hello form Method B");
        }
    }
}