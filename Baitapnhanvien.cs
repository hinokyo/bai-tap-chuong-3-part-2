using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhan_Vien
{
    internal class Program
    {
        private string hoten, diachi;
        private int namsinh;
        private double luongcb, heso, phucap;
        public nhanvien()
        {
            hoten = "";
            diachi = "";
            namsinh = 0;
            luongcb = 0;
            heso = 0;
            phucap = 0;
        }
        public void nhap ()
        {
            Console.WriteLine("Nhap ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            diachi = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh cua nhan vien: ");
            namsinh = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong co ban cua nhan vien: ");
            luongcb = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong: ");
            heso = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap: ");
            phucap = double.Parse(Console.ReadLine());
        }
        public static double tongtien(double luongcb, double heso, double phucap)
        {
            double tongtien;
            tongtien = luongcb * heso + phucap;
            return tongtien;
        }
        public void xuat()
        {
            Console.WriteLine("Ho va ten cua nhan vien la: {0}:", hoten);
            Console.WriteLine("Dia chi cua {0} la: {1}", hoten, diachi);
            Console.WriteLine("Nam sinh cua {0} la: {1}", hoten, namsinh);
            Console.WriteLine("Luong co ban cua {0} la: {1}");
            Console.WriteLine("He so luong cua {0} la: {1}", hoten, heso);
            Console.WriteLine("Phu cap cua {0} la: {1}", hoten, phucap);
            Console.WriteLine("Tien luong duoc nhan la: {0}", tongtien(luongcb, heso, phucap));
        }
        
    }
}
