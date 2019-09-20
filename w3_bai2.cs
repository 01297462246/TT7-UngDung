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
            int nN;
            Console.WriteLine("Nhap N: ");
            nN = int.Parse(Console.ReadLine());
            int i = -nN;
            while (  i <= nN)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" {0}", i);
                    
                }
                i++;
            }
            Console.ReadKey();
        }
    }

}
