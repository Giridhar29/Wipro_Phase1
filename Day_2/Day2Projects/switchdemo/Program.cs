using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, choice;
            Console.Clear();
            Console.WriteLine("enter values in a and b...");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.addition....");
            Console.WriteLine("2.substraction...");
            Console.WriteLine("3.Multiplication....");
            Console.WriteLine("4.Division...");
            Console.WriteLine("enter your choice....");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine($"The sum is {c}");
                    break;
                case 2:
                    c = (a > b) ? (a - b) : (b - a);
                    Console.WriteLine($"The subtraction is {c}");
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine($"The prodcut is {c}");
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine($"The division is {c}");
                    break;
                default:
                    Console.WriteLine("enter values in between 1 and 4 only");
                    break;


                    Console.ReadLine();
            }
        }
    }
}




            