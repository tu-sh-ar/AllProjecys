using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.Generics
{
    internal class GenericList
    {
        static void MainFn(string[] args)
        {
            dynamic list = new List<int>() {98,55,47,15,34};//initialization
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
