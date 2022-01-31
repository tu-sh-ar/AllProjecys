using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumeration
{
    // creating enumeration for storing day.
    public enum attandance
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    
    class Program
    {
        static void fn(string[] args)
        {
            attandance present = attandance.Monday;//Valid
            Console.WriteLine(present);

            //attandance absent = attandance.Sunday;//Invalid
            Console.ReadLine();
        }
    }
}