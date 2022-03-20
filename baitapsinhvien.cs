using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinh_Vien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            sinhvien sv1 = new sinhvien();
            sinhvien sv2 = new sinhvien();
            Console.WriteLine("Thong tin sinh vien thu nhat la: ");
            sv1.nhap();
            sv1.xuat();
            Console.WriteLine("Thong tin sinh vien thu hai la: ");
            sv2.nhap();
            sv2.xuat();
        }
    }
}
