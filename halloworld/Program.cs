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
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("input second number : ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            if (firstnumber == secondnumber)
            {
                Console.WriteLine("first number equlas second number \n input thired number");
                int thirdnumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The sum is : " + (firstnumber + secondnumber + thirdnumber));
            }
            else 
            {
                Console.WriteLine("the sum is : "+ (firstnumber+secondnumber));
            }
        }

        
        }        
    }
