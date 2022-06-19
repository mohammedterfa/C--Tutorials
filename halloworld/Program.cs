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
            Console.WriteLine("Input an integer : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (num != 0) {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine(sum);
        }

    }        
}
