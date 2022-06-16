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
            bool isMale = true;
            bool isTall = false;
            
            if (isMale && isTall)
            {
                Console.WriteLine("you are tall male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("you are tall not male");
            }

            else if (isMale && !isTall) {
                Console.WriteLine("you are short male");
            }
            else { 
                Console.WriteLine("you are not tall not male then you are a woman");
            }
        }
    }
}
