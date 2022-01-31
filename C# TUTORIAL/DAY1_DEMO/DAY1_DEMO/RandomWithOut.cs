class RandomNumbers
{
    public static void GetMultipleRandomValue(out int x, out int y)
    {
        var random = new Random();
        x = random.Next(100);
        y = random.Next(500);

    }

    public static void fn()
    {
        int random1, random2;
        GetMultipleRandomValue(out random1, out random2);
        //int s = 10;
        Console.WriteLine($"{random1}, {random2}");

    }
}