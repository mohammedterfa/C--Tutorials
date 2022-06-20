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
            string hexval = "4B0";
            Console.WriteLine("hexadecima number : " + hexval);

            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("convert to ");
            Console.WriteLine("decimal number : " + decValue);
        }        
    }        
}
