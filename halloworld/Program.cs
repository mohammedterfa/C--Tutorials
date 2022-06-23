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
            Console.WriteLine("input integer : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input integer : ");
            int y = Convert.ToInt32(Console.ReadLine());

            int n = 20;
            int val1 = Math.Abs(x - n);
            int val2 = Math.Abs(y - n);

            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
        }


    }
}
