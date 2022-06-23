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

            Console.WriteLine("input first intrger : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input second integer : ");
            int y = Convert.ToInt32(Console.ReadLine());    

            Console.WriteLine("input second integer : ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lagest integer : " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("minalues integer : " + Math.Min(x, Math.Min(y, z)));


        }


    }
}
