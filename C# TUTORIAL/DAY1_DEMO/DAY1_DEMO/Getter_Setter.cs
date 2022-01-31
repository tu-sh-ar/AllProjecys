using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class Getter_Setter
    {
        static void fn(String[] a)
        {

            //Getter_Setter gs = new Getter_Setter();
            test ts = new test();
            ts.Name = "BABA";
            Console.WriteLine(ts.Name);
        }
        
    }

    class test
    {
        private string name = String.Empty;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }


}
