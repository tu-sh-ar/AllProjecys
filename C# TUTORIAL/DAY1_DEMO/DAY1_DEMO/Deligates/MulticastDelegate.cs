public delegate void MyDelegate(string msg); //declaring a delegate

class ProgramTest
{
    static void MainFn2(string[] args)
    {
        MyDelegate del1 = ClassA.MethodA;
        MyDelegate del2 = ClassB.MethodB;

        MyDelegate del = del1 + del2; // combines del1 + del2
        del("Hello World");
        Console.WriteLine("Calling del1 and del2");

        MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del += del3; // combines del1 + del2 + del3
        del("Hello World");
        Console.WriteLine("Calling del1 and del2 and del3");

        del = del - del2; // removes del2
        del("Hello World");
        Console.WriteLine("Calling del1 and del3 del2 removed");

        del -= del1; // removes del1
        del("Hello World");
        Console.WriteLine("Calling del2 removed del1");
    }
}

public class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}

public class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}