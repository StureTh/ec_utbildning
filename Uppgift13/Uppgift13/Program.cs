using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift13
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name;
            DateTime userSSN = new DateTime();
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Please enter when you where born:");
            
            string sSN = Console.ReadLine();
            sSN = sSN.Replace("-","");
            var year = int.Parse(sSN.Substring(0, 4));
            var month = int.Parse(sSN.Substring(4, 2));
            var day = int.Parse(sSN.Substring(6, 2));
            
            


            userSSN = new DateTime(year,month,day);
            TimeSpan age = DateTime.Now - userSSN;
            var currentAge = age.Days/365;

            DateTime daysToNextBDay = new DateTime(DateTime.Now.Year,month,day); 

            if (daysToNextBDay<DateTime.Now)
            {
                daysToNextBDay.AddYears(1);
            }
            var daysToBDay = (daysToNextBDay - DateTime.Now).Days;

            DateTime age100 = userSSN.AddYears(100);
            string dayOfWeek= age100.DayOfWeek.ToString();
            
            Console.WriteLine($"Hello {name}\nYou are {currentAge} years old\nYour next Bday is in {daysToBDay} days\n You will turn 100 on a {dayOfWeek} at the date {age100}");
            Console.ReadLine();
        }
    }
}
