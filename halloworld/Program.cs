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
            Console.WriteLine("print odd number just");

            for (int n = 1; n < 100; n++) {
                if (n % 2 != 0) {
                    Console.WriteLine(n);
                }
            }
        }

    }        
}
