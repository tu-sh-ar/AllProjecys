//namespace CSharpTutorials
//{
class Program3
{
    static void fn(string[] args)

    {

        string name, city;
        short age, pin;
        float x;

        Console.WriteLine("Enter our name:- ");
        name = Console.ReadLine();
        Console.WriteLine("Enter our city:- ");
        city = Console.ReadLine();
        Console.WriteLine("Enter our pin:- ");
        pin = short.Parse(Console.ReadLine());
        Console.WriteLine("Enter our Age:- ");
        age = short.Parse(Console.ReadLine());
        x = (float)age;


        Console.WriteLine("==============");
        Console.WriteLine("Your Complete Address:");
        Console.WriteLine("============\n");

        Console.WriteLine("Name = {0}", name);
        Console.WriteLine("City = {0}", city);
        Console.WriteLine("Age = {0}", age);
        Console.WriteLine("Pin = {0}", pin);
        Console.WriteLine("===============");
        Console.WriteLine(DateTime.Now);
        Console.ReadLine();

    }
}
//}

