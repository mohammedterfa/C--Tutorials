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
            Console.WriteLine(checkSum(20,4));
            Console.WriteLine(checkSum(10,10));
            Console.WriteLine(checkSum(9,4));
        }

        public static int checkSum(int num1, int num2)
        {
            int sum = num1 + num2;
            bool check;

            if (sum == 20 || num1 == 20 || num2 == 20)
            {
                check = true;
                Console.WriteLine(check);
                return sum;

            }

            else {
                check = false;
                Console.WriteLine(check);

                return sum;
            
            }

        }
        
        
    }        
}
