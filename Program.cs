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
            int nN;
           
            Console.WriteLine("Nhap N: ");
            nN = int.Parse(Console.ReadLine());
            for(int i=2;i<=nN;i++)
            {
                int count = 0;
                for (int j=1;j<=Math.Sqrt(nN);j++)
                {
                    if(i%j==0)
                    {
                        count++;
                    }
                }
                if(count==1)
                {
                    Console.Write(" {0}", i);
                }
                
            }
            Console.ReadKey();
        }
    }
}

