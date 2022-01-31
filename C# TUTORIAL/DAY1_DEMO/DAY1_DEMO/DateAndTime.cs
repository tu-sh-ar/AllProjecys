//namespace CSharpTutorials
//{
class Program4
{
    static void fn(string[] args)

    {

        DateTime dt = new DateTime();
        dt = DateTime.UtcNow;

        //setting datetime
        DateTime dt1 = new DateTime(2018, 11, 21);


        Console.WriteLine(dt);
        Console.WriteLine(dt1);
        Console.WriteLine(DateTime.Now);
        //Console.ReadLine();

        //TimeSpan
        DateTime dt2 = new DateTime();
        TimeSpan ts = new TimeSpan(24, 10, 20);
        DateTime dt3 = dt2.Add(ts);
        DateTime dt4 = dt3.Subtract(ts);
        Console.WriteLine(dt3);
        Console.WriteLine(dt4);

        //Convert String to DateTime
        var str = "5/12/2020";
        DateTime dt5;

        var isValid = DateTime.TryParse(str, out dt5);
        if (isValid)
        {
            Console.WriteLine(dt5);
        }
        else
        {
            Console.WriteLine($"{str} is not a valid format");

        }

    }
}
//}

