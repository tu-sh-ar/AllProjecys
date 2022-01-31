using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class Properties
    {
        
        static void MainFn(string[] args)
        {
            var myclass = new MyClass();
            myclass.MyProperty = 34;
            Console.WriteLine(myclass.MyProperty);
           
        }
        
    }
    internal class MyClass
    {
        private int _myVar;

        public int MyProperty
        {
            get { return _myVar; }
            set { _myVar = value; }
        }

       
    }
}
