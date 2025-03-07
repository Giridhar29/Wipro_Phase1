using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifdemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, l;

            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            l = a;
            if (b > l)
            {
                l = b;

            }
            if (c > l)
            {
                l = c;
            }
            if (d > l)
            {
                l = d;
            }
            Console.WriteLine($"The laregst is {l}");
            Console.ReadLine();
        }
    }
}
