using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class DynamicAndVar
    {
        static void MainFn()
        {
            dynamic data; // dynamic variables need no initialization
            var data2 = 0; // var needs initialization

            var obj1 = 1;
            //var obj1 = "string"; Not Possible
            
            
            dynamic obj2 = 2;
            obj2 = "Hello";//Possible    object will be reassigned with system.String
            DynamicParam(obj2);
            DynamicAndVar.DynamicParam(obj1);
            //DynamicAndVar.Main();
        }

        public static void DynamicParam(dynamic data)
        {
            Console.WriteLine(data.GetTypeCode());
        }
    }
}
