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
            int sum1 = sum(1, 5);

            Console.WriteLine(sum1);
        }

        public static int sum(int number1, int number2) 
        {
         
            return number1 + number2;
        }
    }
}
