using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.Deligates
{
    internal class Subscriber
    {
        static void MainFn(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.Ev_Odd += new Publisher.Dg_Odd(EventMessageOdd);      //step 4 Bind delegates with event
            publisher.Ev_Even += new Publisher.Dg_Odd(EventMessageEven);

            publisher.Add(3, 3);
        }

        static void EventMessageOdd()
        {
            Console.WriteLine("----Odd Number---- Event Raised");
        }static void EventMessageEven()
        {
            Console.WriteLine("----Even Number---- Event Raised");
        }
    }

    internal class Publisher
    {
        public delegate void Dg_Odd();                  // Step 1 declare delegate
        public event  Dg_Odd Ev_Odd;                    //Step 2 declare event
        public event  Dg_Odd Ev_Even;

        public void Add(int a, int b)
        {
            if((a+b)%2!=0 && (Ev_Odd!=null)) {
                Ev_Odd();
            }
            else
            {
                Ev_Even();                             //step 3 raise event
            }
        }
    }
}