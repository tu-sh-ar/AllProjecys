class CheckedStatement
{
    static void fn()
    {
        
        int result = int.MaxValue;
        
        try
        {
            checked
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