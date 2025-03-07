using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDemo
{
    internal class Program
    {
        enum weekdays { sun = 100, mon, tue, wed = 34, thu, fri, sat };
        static void Main(string[] args)
        {
            Console.WriteLine($"{(int)weekdays.sun}");
            Console.WriteLine($"{(int)weekdays.mon}");
            Console.WriteLine($"{(int)weekdays.fri}");
            // Get the current day of the week
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;

            // Convert the current day to our Weekdays enum
            weekdays today = (weekdays)currentDay;

            Console.WriteLine($"Today is: {today}");

            // Check if today is a weekday or weekend
            if (today == weekdays.sat || today == weekdays.sun)
            {
                Console.WriteLine("It's the weekend! Enjoy your day off.");
            }
            else
            {
                Console.WriteLine("It's a weekday. Time to work!");
            }
            Console.ReadLine();
        }
    }
}

