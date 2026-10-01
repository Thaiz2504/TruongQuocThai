using System;

namespace Bai02
{
    public class NhanVien
    {
        private string hoTen = "";
        private double luong;
        private int soNgayVang;

        public NhanVien()
        {
            hoTen = "";
            luong = 0;
            soNgayVang = 0;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap muc luong: ");
            luong = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so ngay vang: ");
            soNgayVang = int.Parse(Console.ReadLine() ?? "0");
        }

        public void Output()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Muc luong: " + luong);
            Console.WriteLine("So ngay vang: " + soNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }

        public double TinhLuong()
        {
            return luong - soNgayVang * 100000;
        }
    }
}