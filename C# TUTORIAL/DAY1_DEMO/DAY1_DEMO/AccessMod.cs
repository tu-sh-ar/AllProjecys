namespace DAY1_DEMO
{
    
    public class AccessMod
    {
        private static int x = int.MaxValue;
        static internal int y = int.MaxValue;
        protected int z = int.MaxValue;
        public int d = int.MinValue;
        static void fn()
        {
            Console.WriteLine("hello");
            Console.WriteLine();
        }
    }
}
