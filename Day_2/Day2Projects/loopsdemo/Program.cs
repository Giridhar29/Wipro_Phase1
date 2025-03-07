
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // whileloop();
            dowhileloop();
            Console.ReadLine();


        }

        private static void dowhileloop()
        {
            int counter = 1;// here if i give 120 means condition then also one 
            // time do while will execute which will not happen in while loop
            do
            {
                Console.Write($"{counter}  ");
                counter++;

            } while (counter <= 100);
        }

        private static void whileloop()
        {
            int counter = 1;

            while (counter <= 100)
            {
                Console.Write($"{counter}  ");
                counter = counter + 1;// if u comment this code ininfite loop
            }
        }
    }
}
