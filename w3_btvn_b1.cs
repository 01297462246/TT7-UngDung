/*
Name: Huynh Duy Quoc
MSSV: 18211TT5025
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_ungdung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cau1:
            double d_Tongam = 0, d_Tongduong = 0;
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            for (int i=0;i< array.Length; i++)
            {
                Console.Write("array[" + i + "]=");
                array[i] = double.Parse(Console.ReadLine());
                if(array[i]<0)
                {
                    d_Tongam += array[i];
                }
                else
                {
                    d_Tongduong += array[i];
                }
            }
            Console.WriteLine("Tong am trong mang la: {0}", d_Tongam);
            Console.WriteLine("Tong duong trong mang la: {0}", d_Tongduong);

            //Cau2:
            Console.Write("Nhap X: ");
            double x = double.Parse(Console.ReadLine());
            int nTemptL = 0;
            int nTemptN = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (x < array[i])
                {
                    nTemptL++;
                }
                if (x > array[i]) nTemptN++;
            }
            Console.WriteLine("So co gia tri lon hon " + x + " la: {0}", nTemptL);
            Console.WriteLine("So co gia tri nho hon " + x + " la: {0}", nTemptN);

            //Cau 3:
            double d_TongChan = 0, d_TongLe = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    d_TongChan += array[i];
                }
                else
                    d_TongLe += array[i];
            }
            Console.WriteLine("Tong Chan: {0}", d_TongChan);
            Console.WriteLine("Tong Le: {0}", d_TongLe);

            //Cau 4:
            double Min=0, Max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Min = array[i];
                    if (array[i] < Min)
                    {
                        Min = array[i];
                    }
                }
                else if(array[i] >= 0)
                {
                    Max = array[i];
                    if (array[i] > Max)
                    {
                        Max = array[i];
                    }
                }
                
            }
            if(Min==0)
            {
                Console.WriteLine("Mang ko co so am !!!");
            }
            else
            {
                Console.WriteLine("So Am Be Nhat: {0}", Min);
            }
            Console.WriteLine("So Duong Lon Nhat: {0}", Max);
            Console.ReadKey();
        }
    }
}
