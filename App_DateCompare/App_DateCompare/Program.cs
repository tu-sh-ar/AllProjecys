using System;
using System.Collections.Generic;

namespace App_DateCompare;
class DateCompare
{
    
    
    static void Main(string[] args)
    {
        string LoopFlag = String.Empty;

        do
        {
            Console.WriteLine("--------Please Enter Date in  \"DDMMYYYY\" Format--------");
            Console.WriteLine("******Enter First Date*******");
            string dateInput1 = Console.ReadLine().Trim();
            string dateInput2=string.Empty;

            List<int> dateList1 = new List<int>();
            List<int> dateList2 = new List<int>();
            DateCompare dateCompare = new DateCompare();
            dateList1 = dateCompare.DateVerify(dateInput1);
            if(dateList1.Count > 0)
            {
                Console.WriteLine("******Enter Second Date*******");
                dateInput2 = Console.ReadLine().Trim();
            }
            dateList2 = dateCompare.DateVerify(dateInput2);
            if (dateList1.Count!=0 && dateList2.Count!=0 )
            {
                Console.WriteLine(dateCompare.DateDifference(dateList1, dateList2));
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Do you want to print Again? press y/n");
            LoopFlag = Console.ReadLine();
        }
        while (LoopFlag=="y");
    }

    internal List<int> DateVerify(string data)
    {
        List<int> list = new List<int>();
        var dateIndices = (0, 2);
        var monthIndices = (2, 2);
        var yearIndices = (4, 4);
        byte monthLimit = 12;
        byte feb = 2;
        try
        {
            int day = int.Parse(data.Substring(dateIndices.Item1,dateIndices.Item2).Trim());
            day = Math.Abs(day);
            
            int month = int.Parse(data.Substring(monthIndices.Item1, monthIndices.Item2).Trim());
            month = Math.Abs(month);

            int year = int.Parse(data.Substring(yearIndices.Item1,yearIndices.Item2).Trim());
            month = Math.Abs(month);
            if (day < DateTime.DaysInMonth(year,month) && month <= monthLimit && day!=0 && month!=0 && year!=0) 
            {
                if(month==feb && day > DateTime.DaysInMonth(year,month))
                {
                    throw new Exception();
                }
                list.Add(day);
                list.Add(month);
                list.Add(year);
            }
            else
            {
                throw new Exception();
            }
        }
        catch (Exception ex) {
            
            return list;
        }
        return list;
    }

    internal string DateDifference(List<int> dateList1,List<int> dateList2) {
        
            var day = "Diff In Day=" + Math.Abs(dateList1[0] - dateList2[0]);
            var month = " Month=" + Math.Abs(dateList1[1] - dateList2[1]);
            var year = " year=" + Math.Abs(dateList1[2] - dateList2[2]);
        string diff = day+month+year;

        return diff;
    
    }

   

    
  
    
}
