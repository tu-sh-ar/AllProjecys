class UnCheckedStatement
{
    static void fn()
    {

        int result = int.MaxValue;
        Console.WriteLine(result);
        try
        {
            unchecked
            {
                result += 1;
                Console.WriteLine(result);
            }


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //Console.WriteLine(result);
    }
}
