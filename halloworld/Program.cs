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
            Console.Write("input integer : ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("input integer : ");
            int second = Convert.ToInt32(Console.ReadLine());

            bool result;
            if ((first >= -10 && first <= 10) || (second >= -10 && second <= 10))
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
