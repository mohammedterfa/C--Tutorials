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
            Console.Write("input first number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("input first number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("check if one is negative and one is positive : " +CheckNumber(firstNumber,secondNumber));




        }

        public static bool CheckNumber(int num1, int num2) {
            if (num1 > 0 && num2 > 0)
            {
                return false;
            }
            else if (num1 < 0 && num2 < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }        
    }
}
