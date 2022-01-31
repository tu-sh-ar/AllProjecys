namespace DAY1_DEMO
{
    class Functions
    {
        int Calc(int a, int b)
        {
            return a + b;

        }


        int Calc2(ref int a, ref int b) { return a + b; }

        int Calc3(Functions fn) { return fn.Calc(2, 6); }
        static void fn()
        {
            int x = 8, y = 9;
            Functions functions = new Functions();
            Console.WriteLine("Passed Value {0}",functions.Calc(2, 4));
            Console.WriteLine("Passed reference "+Convert.ToString(functions.Calc2(ref x, ref y)));
            Console.WriteLine("Passed object "+Convert.ToString(functions.Calc3(functions)));
        }

    }
}
