using MainPtr;

namespace DAY1_DEMO.ThreadingExamples

{
    internal class ThreadingExample1
    {
        static void MainFn()
        {
            MainPointer.UpdatePtr("ThreadingExample1");
            Thread t = Thread.CurrentThread;
            t.Name = "MainThread";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.ThreadState);
            Console.WriteLine(t.CurrentCulture);
            Thread thread2 = new Thread(ThreadFunction);
            Thread thread3 = new Thread(() => { Console.WriteLine("LAMBDA1"); });
            Thread thread4 = new Thread(() => { Console.WriteLine("LAMBDA2"); });
            Thread thread5 = new Thread(() => { Console.WriteLine("LAMBDA3"); });
            Thread thread6 = new Thread(() => { Console.WriteLine("LAMBDA4"); });

            thread2.Priority = ThreadPriority.Highest;
            thread2.Start();
            thread3.Priority = ThreadPriority.Lowest;
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            Console.WriteLine(thread3.ToString());
        }
        static void ThreadFunction()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("Hello from Thread");
        }
    }
}
