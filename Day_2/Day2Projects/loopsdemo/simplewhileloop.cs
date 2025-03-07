using System;

namespace loopsdemo
{
    internal class simplewhileloop
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 100)
            {
                Console.Write($"{counter} ");
                counter = counter + 1;

            }
            Console.ReadLine();
        }
    }
}