class ThrowError
{
    static void fn()
    {
        int a, b;
        long result = long.MinValue;
        Console.WriteLine("Enter First no");
        a = Console.Read();
        b = Console.Read();

        //Console.WriteLine("Enter Second no");
        //b = Int32.Parse(Console.ReadLine());

        //try
        //{
        //    if (b == 0)
        //    {
        //        throw new Exception("Can't divide by zero");
        //    }
        //    result = a / b;
        //    Console.WriteLine("{0} / {1} = {2}", a, b, result);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.ToString());
        //}
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(result);
    }
}