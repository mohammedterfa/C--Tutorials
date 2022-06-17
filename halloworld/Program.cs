using halloworld;
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
            string str;

            Console.WriteLine("Input a string");
            str = Console.ReadLine();

            if (str.Length > 1)
            {
                var s = str.Substring(0,1);
                Console.WriteLine(s+str+s);
            }
    

        }     
    }
}
