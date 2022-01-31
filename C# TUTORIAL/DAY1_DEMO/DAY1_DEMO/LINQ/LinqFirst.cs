using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.LINQ
{
    internal class LinqFirst
    {
        static void MainFn(string[] args)
        {
            IList<string> list = new List<string>() { 
                "India",
                "Bangladesh",
                "Sri-lanka",
                "Pakistan",
                "China",
                "Nepal",
                "Bhutan"
            };
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var items = from i in list where list.Contains(i) select i;   //LINQ Convention
            var @except = from s in items where s.Contains("China")  select s; //LINQ Convention  
            foreach (var item in items)
            Console.WriteLine(item);
            foreach(var item in @except)
            Console.WriteLine(item);
        }
    }
}
