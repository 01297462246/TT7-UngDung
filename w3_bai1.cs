using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nN;
            Console.WriteLine("Nhap N: ");
            nN = int.Parse(Console.ReadLine());
            int i = -nN;
            do
            {
                Console.Write(" {0}", i);
                i++;
            } while (i <= nN);
            Console.ReadKey();
        }
    }
}
