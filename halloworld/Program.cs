using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a string : ");

            string str = Console.ReadLine();

            var count = str.Count(s => s == 'w');

            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");

            Console.WriteLine(count>=1 && count <=3);
        }


    }
}
