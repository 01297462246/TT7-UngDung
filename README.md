# UngDung_w1
/*
 Name: Huynh Duy Quoc
 MSSV: 18211TT5025
 Bai 3:
 */



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
            //Khai Bao Bien

            string s_TenPhong;
            string s_TenNguoiThue;
            string s_Age;
            string s_QueQuanNT;
            double d_TienPhong;
            double d_TienDien;
            double d_TienNuoc;
            double d_TienWF;
            double d_Rac;

            //**Phan Nhap Thong Tin
            //Thong tin cua Day tro
            Console.WriteLine("Dia chi day tro: So 123/7 KVC,LT,TD,HCM");
            Console.WriteLine("Chu tro: Nguyen Van A ");

            //Thong Tin Nguoi Thue
            Console.WriteLine("Nhap Ten nguoi thue phong: ");
            s_TenNguoiThue = Console.ReadLine();
            Console.WriteLine("Nhap Ngay Thang Nam Sinh Nguoi Thue: ");
            s_Age = Console.ReadLine();
            Console.WriteLine("Nhap Dia Chi Cu Tru(Theo CMND): ");
            s_QueQuanNT = Console.ReadLine();

            //Thong Tin Phong
            Console.WriteLine("Nhap Ten Phong: ");
            s_TenPhong = Console.ReadLine();
            Console.WriteLine("Nhap gia phong: ");
            d_TienPhong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tien dien: ");
            d_TienDien = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tien nuoc: ");
            d_TienNuoc = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tien wifi: ");
            d_TienWF = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tien rac: ");
            d_Rac = double.Parse(Console.ReadLine());


            //**Phan xuat thong tin
            //Thong tin cua Day tro
            Console.WriteLine("****************** HOA DON *****************");
            Console.WriteLine("Dia chi day tro: So 123/7 KVC,LT,TD,HCM");
            Console.WriteLine("Chu tro: Nguyen Van A ");

            //Thong tin ng thue
            Console.WriteLine("Nguoi Thue: {0}", s_TenNguoiThue);
            Console.WriteLine("Ng/Th/NS: {0}", s_Age);
            Console.WriteLine("Dia Chi Cu Tru(Theo CMND): {0}", s_QueQuanNT);

            //Thong tin phong
            Console.WriteLine("Ten Phong: {0}", s_TenPhong);
            Console.WriteLine("Tien Phong: {0}", d_TienPhong);
            Console.WriteLine("Tien Dien: {0}", d_TienDien);
            Console.WriteLine("Tien Nuoc: {0}", d_TienNuoc);
            Console.WriteLine("Tien WiFi: {0}", d_TienWF);
            Console.WriteLine("Tien Rac: {0}", d_Rac);
            Console.WriteLine("Tong Tien: {0}", (d_TienPhong + d_TienDien + d_TienNuoc + d_TienWF + d_Rac));

            Console.ReadKey();

        }
    }
}
