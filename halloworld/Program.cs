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
            int[] firstArray = { 1, 4, -5, 4 };
            int[] secondArray = { 1, 8, -5, -8 };

            Console.WriteLine("Array 1 : [{0}]", string.Join(", ", firstArray));
            Console.WriteLine("Array 2 : [{0}]", string.Join(", ", secondArray));

            Console.WriteLine("multiply arrays : ");

            for (int i = 0; i < firstArray.Length; i++) {
                Console.Write(firstArray[i] * secondArray[i] + " ");
            }

            
        }        
    }        
}
