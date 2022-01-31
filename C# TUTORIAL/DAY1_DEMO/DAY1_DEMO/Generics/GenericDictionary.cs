using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO.Generics
{
    internal class GenericDictionary
    {
        static void MainFn(string[] args)
        {
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            cities.Add("China", "Beijing");
            Console.WriteLine(cities.ContainsKey("China"));
            Console.WriteLine(cities["China"]);
            //Console.WriteLine(cities.Values);

            string result;
            //use TryGetValue() to get a value of unknown key
            if (cities.TryGetValue("India", out result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
