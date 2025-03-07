using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingandUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object objone;
            int numberone;
            numberone = 77;
            objone = numberone;

            Console.WriteLine($"objectone is {objone}");

            string originalString = "Hello, Boxing and Unboxing!";
            object boxedString = originalString;

            Console.WriteLine($"Boxed string:  {boxedString}");

            int unboxint = (int)objone;
            string unboxedString = (string)boxedString;
            Console.WriteLine($"{unboxint}-- {unboxedString}");
            Console.ReadLine();
        }
    }
}
