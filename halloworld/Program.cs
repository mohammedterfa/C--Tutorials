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
            string line = "hallo world iam mohammed";
            Console.WriteLine("the original :  " + line);

            string result = "";

            List<string> list = new List<string>();

            string[] words = line.Split(" ");

            for (int i = words.Length - 1; i >= 0; i--)
            {

                result += words[i] + " ";
            }

            list.Add(result);

            foreach (string s in list) {
                Console.WriteLine("revers : " + s);
            }
        }        
    }        
}
