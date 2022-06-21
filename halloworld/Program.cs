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
            Console.Write("input a string : ");
            string sen = Console.ReadLine();

            int i = 0;

            if (sen.Length > 4) { 
                Console.WriteLine(sen.Length < 4 ? sen + sen + sen : sen.Substring(sen.Length - 4) + sen.Substring(sen.Length - 4) + sen.Substring(sen.Length - 4) + sen.Substring(sen.Length - 4));
            }
            
        }        
    }        
}
