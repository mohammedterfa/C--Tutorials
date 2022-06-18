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
            Console.WriteLine(sumTriple(2, 2));
            Console.WriteLine(sumTriple(12, 10));
            Console.WriteLine(sumTriple(-5, 2));
        }

        public static int sumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
        
    }        
}
