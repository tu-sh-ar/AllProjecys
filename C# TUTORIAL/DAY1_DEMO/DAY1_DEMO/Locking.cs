using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lock_Statement
{
    class Program
    {
        public void printname()
        {
            Console.WriteLine("My name is Steven Clark");
        }

        static void fn(string[] args)
        {
            Program p = new Program();
            // creating lock segment. all the resources that is used in lock segment, can't be used by another thread until it releases.
            lock (p)
            {
                p.printname();
            }
            Console.ReadLine();
        }
    }
}