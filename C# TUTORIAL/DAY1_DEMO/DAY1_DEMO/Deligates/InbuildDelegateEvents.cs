using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;

namespace DAY1_DEMO.Deligates
{
    internal class InbuildDelegateEvents
    {
        static void MainFn(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            //Event gets binded with delegates
            a.ev_OddNumber += EventMessage;
            a.Add();
            Console.Read();
        }
        static void EventMessage(object sender,EventArgs e)
        {
            Console.WriteLine("***Event Executed : This is Odd Number***");
        }
    }

    class AddTwoNumbers
    {
        public event EventHandler<EventArgs> ev_OddNumber;

        public void Add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber(this, EventArgs.Empty); //Raised Event
            }
            
        }
    }
}
