using System;

namespace Bai01
{
    public class SinhVien
    {
        private string hoTen = "";
        private int namSinh;

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine() ?? "0");
        }

        public int TinhTuoi()
        {
            int namHienTai = DateTime.Now.Year;
            return namHienTai - namSinh;
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Nam sinh: " + namSinh);
            Console.WriteLine("Tuoi: " + TinhTuoi());
        }
    }
}