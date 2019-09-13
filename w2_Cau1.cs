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
            float a, b, x;
            Console.WriteLine("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine(a + "x + " + b + " = 0");
            Console.WriteLine("x = {0}", (-b) / a);
            Console.ReadKey();
        }
    }
}
