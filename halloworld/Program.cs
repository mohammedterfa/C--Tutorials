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
            Book book1 = new Book();
            book1.title = "HAllow World";
            book1.author = "terfa";
            book1.pages = 300;

            Console.WriteLine(book1.title);
        }
    }
}
