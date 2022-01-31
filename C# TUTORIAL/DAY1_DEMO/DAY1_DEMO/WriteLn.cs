using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Program to implement Writeline method with delegates
namespace WriteLn
{   public delegate void DelFn(dynamic s);
    
    internal class WriteLn
    {
        
        static void MainFn(string[] args)
        {
            DelFn del = new DelFn(Console.WriteLine);
            del("hello{0}");
        }
    }
}
