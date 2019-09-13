using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a:");
            float nA = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            float nB = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            float nC = float.Parse(Console.ReadLine());
            if(nA==0)
            {
                Console.WriteLine("*Day la phuong trinh bac I:");
                float xI = (-nC) / nB;
                Console.WriteLine("x = {0}", xI);

            }
            else
            {
                Console.WriteLine("*Day la phuong trinh bac II:");
                Console.WriteLine(nA + "(x^2)+" + nB + "x+" + nC + "=0");
                float delta;

                Console.WriteLine("Denta = {0}", delta = (nB * nB) - 4 * (nA * nC));
                double c_delta = Math.Sqrt(delta);
                if (delta == 0)
                {
                    Console.WriteLine("PT co 1 nghiem");
                    Console.WriteLine("x = {0}", -nB / 2 * nA);
                }
                else if (delta > 0)
                {
                    double x1 = (-nB - c_delta) / (2 * nA);
                    double x2 = (-nB + c_delta) / (2 * nA);
                    Console.WriteLine("Phuong trinh co 2 nghiem: ");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else
                {
                    Console.WriteLine("PT vo nghiem");
                }
            }
            Console.ReadKey();
        }
    }
}
