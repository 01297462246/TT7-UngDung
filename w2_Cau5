using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.UTF8;
            Console.WriteLine("Nhap nam duong lich ban muon doi: ");
            int nNam = int.Parse(Console.ReadLine());
            int nCan = nNam % 10;
            int nChi = nNam % 12;
            string[] Can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] Chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sữu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };


            string NamAm = Can[nCan] +" "+ Chi[nChi];  
            Console.WriteLine("Nam " + nNam + " la nam: {0}", NamAm);
            Console.ReadKey();

        }
    }
}
