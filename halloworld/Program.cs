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
            FileInfo f = new FileInfo("/home/abc.txt");

            Console.WriteLine("file size is : " + f.Length);
        }        
    }        
}
