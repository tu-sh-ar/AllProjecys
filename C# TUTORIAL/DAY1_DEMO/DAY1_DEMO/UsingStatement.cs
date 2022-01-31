using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Using_Statement
{
    class check_using : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Execute  Second");
        }
    }

    class Program
    {
        static void fn(string[] args)
        {
            using (check_using c = new check_using())
            {
                Console.WriteLine("Executes First");
            }
            Console.WriteLine("Execute Third");
            Console.ReadLine();
        }
    }
}