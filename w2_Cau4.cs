using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gio: ");
            int nH = int.Parse(Console.ReadLine());
            if((nH>=0 && nH <4) || (nH>=20 && nH <=24))
            {
                Console.WriteLine("Good night!");
            }
            else if(nH >=4 && nH<=12)
            {
                Console.WriteLine("Good morning!");
            }
            else if(nH>12 && nH<=17)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if(nH>17 && nH<20)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Default!!!");
            }
            Console.ReadKey();
        }
    }
}
