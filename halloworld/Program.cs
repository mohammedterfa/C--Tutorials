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
            Console.Write("input interger > 100 : ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("input integer < 200");
            int second = Convert.ToInt32(Console.ReadLine());

            bool result;
            if (first < 100 && second > 200)
            {
                result = true;
            }
            else { 
                result = false;
            }

            Console.WriteLine(result);
        }        
    }        
}
