namespace goto_statements
{
    class Program4
    {
        static void fn(string[] args)
        {
            string name;

        label: //creating label with colon(:)

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Welcome {0}", name);
            Console.WriteLine("Press Ctrl + C for Exit\n");

            goto label; //jump to label statement           

        }
    }
}