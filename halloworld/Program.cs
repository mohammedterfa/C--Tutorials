using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    struct w3struct {
        public int x;
        public int y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("declariate a simple structure ");
            Console.WriteLine("-------------------------------");

            w3struct w3 = new w3struct();

            w3.x = 15;
            w3.y = 25;

            int sum = w3.x + w3.y;

            Console.WriteLine("the sum of x and y is " + sum);
        }


    }
}
