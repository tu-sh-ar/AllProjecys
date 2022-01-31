namespace DAY1_DEMO.StaticExamples
{
    internal class StaticConstructor
    {
        static void MainFn(string[] args)
        {

        }
    }

    public class MyClass
    {
        static int val = 0;
        //int val2 = 0;
       

        //A non-static class can contain one parameterless static constructor. Parameterized static constructors are not allowed.
        static MyClass()
        {
            Console.WriteLine("static Constructor");
            val = 1;
            Console.WriteLine(val);

        }

        public MyClass()
        {
            Console.WriteLine("Instance Constructor");
        }

    }
}
