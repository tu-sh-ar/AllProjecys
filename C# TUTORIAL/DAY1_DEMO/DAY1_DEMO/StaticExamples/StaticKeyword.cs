namespace DAY1_DEMO
{
    internal class StaticKeyword
    {
        static void MainFn()
        {
            var obj1 = new Demo1();
            var obj2 = new Demo1();
            var obj3 = new Demo1();

            obj1.OutCount();

        }
    }
    public class Demo1
    {
        public static int ObjCount = 0;
        internal Demo1() { ObjCount++; }   //Counts Objects

        public void OutCount()
        {
            Console.WriteLine(ObjCount);
        }

    }

}
