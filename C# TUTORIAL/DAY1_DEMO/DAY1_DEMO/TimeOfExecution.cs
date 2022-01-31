class TimeOfExecution
{
    public static void GetMultipleRandomValue(out int x, out int y, out int z, out int d, out int e)
    {
        var random = new Random();
        x = random.Next(100);
        y = random.Next(500);
        z = random.Next(500);
        d = random.Next(500);
        e = random.Next(500);

    }

    public static void fn()
    {

        var timer = new System.Diagnostics.Stopwatch();

        timer.Start(); //watch start

        int random1, random2, random3, random4, random5;
        GetMultipleRandomValue(out random1, out random2, out random3, out random4,out random5);
        //int s = 10;
        
        Console.WriteLine($"{random1}, {random2}");

        for(int i = 0; i < 1000; i++)
        {
            Console.Write("  {0}", i);
            //Console.WriteLine(i);
        }
        
        timer.Stop(); //watch ends

        Console.WriteLine($"Execution Time: {timer.ElapsedMilliseconds} ms");
    }
}