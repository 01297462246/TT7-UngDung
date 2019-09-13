using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            float nA, nB, nC, f_Max;
            Console.WriteLine("Nhap a:");
            nA = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            nB = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            nC = float.Parse(Console.ReadLine());
            f_Max = nA;
            if(f_Max<nB)
            {
                f_Max = nB;
            }
            if(f_Max<nC)
            {
                f_Max = nC;
            }
            Console.WriteLine("MAX = {0}", f_Max);
            Console.ReadKey();
        }
    }
}
