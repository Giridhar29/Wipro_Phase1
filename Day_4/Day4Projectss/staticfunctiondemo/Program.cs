using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        int a = 1;
        public static void count()
        {
            abcd obj = new abcd();// here again non static variable is used in static function 
            obj.a = obj.a + 1;
            Console.WriteLine($"The value of a : {obj.a}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {


            abcd.count();// static to static outside the class use classname
            Console.ReadLine();

        }
    }
}