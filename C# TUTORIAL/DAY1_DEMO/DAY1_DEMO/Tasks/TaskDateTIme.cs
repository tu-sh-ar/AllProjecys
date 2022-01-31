using System.Globalization;
using System.Text;

namespace DAY1_DEMO
{
    internal class TaskDateTIme
    {
        static DateTime dt = new DateTime();
        static void MainFn()
        {
            string UserInp = "";
            bool flag = true;
            bool checkedFlag = false;
            do
            {
                Console.WriteLine("------------Please Enter Your Date Of Birth in the format-----\n \t-DD//MM//YYYY \n \t-DD-MM-YYYY \n \t-YYYY\\MM\\DD \n \t-YYYY-MM-DD \n \t-DDMMYYYY");
                UserInp = Console.ReadLine().Trim();

                checkedFlag = CheckFormat(UserInp);
                if (checkedFlag)
                {
                    Console.WriteLine("**********Your Date Of Birth is {0}-{1}-{2}*************", dt.Day, CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt.Month), dt.Year);
                }
                else
                {
                    Console.WriteLine("Invalid Format");
                }
                Console.WriteLine("--------Want To Give Input Again?\n Press 'Y' to confirm and press any key to terminate------");
                UserInp = Console.ReadLine().Trim();
                if (UserInp == "Y")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            } while (flag);
        }

        static bool CheckFormat(string inp)
        {

            DateTime UserDOB;
            var isvalid = DateTime.TryParse(inp, out UserDOB);
            //Console.WriteLine(inp);
            //Console.WriteLine(isvalid);
            if (!isvalid)
            {
                var input = ConvertToDate(inp);
                var isvalidated = DateTime.TryParse(input, out UserDOB);
                if (!isvalidated) { return false; }

            }
            dt = UserDOB;
            return true;
        }

        static string ConvertToDate(string inp)
        {
            StringBuilder stringDate = new StringBuilder();
            string dd = "";
            string mm = "";
            string yy = "";
            if (inp.Length == 8)
            {


                try
                {
                    for (int count = 0; count < inp.Length; count++)
                    {
                        if (count == 1)
                        {
                            dd = inp.Substring(0, 2);
                            //inp.Substring(0,2);
                        }
                        else if (count == 3)
                        {
                            mm = inp.Substring(2, 2);
                        }
                        else if (count == 7)
                        {
                            yy = inp.Substring(4, 4);
                        }
                    }
                    stringDate.Append(dd + "-" + mm + "-" + yy);
                    //Console.WriteLine(stringDate.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sorry Not in Date Format");
                    //Console.WriteLine(ex.ToString());
                    return "";
                }
                return stringDate.ToString();
            }

            return "";
        }
    }
}
