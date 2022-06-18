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
            Console.WriteLine(absoluteValue(2, 9));
            Console.WriteLine(absoluteValue(10,9));
        }

        public static int absoluteValue(int a, int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }

            else {
                return b - a;
            }
        }
             
        
    }        
}
