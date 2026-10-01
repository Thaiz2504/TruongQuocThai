using System;
using System.Collections.Generic;

namespace Bai02
{
    public class PhongBan
    {
        private List<NhanVien> ds;

        public PhongBan()
        {
            ds = new List<NhanVien>();
        }

        public void Input()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            while (n < 0)
            {
                Console.Write("n phai >= 0. Nhap lai: ");
                n = int.Parse(Console.ReadLine() ?? "0");
            }

            ds.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Nhap nhan vien thu {i + 1}:");

                NhanVien nv = new NhanVien();
                nv.Input();

                ds.Add(nv);
            }
        }

        public void Output()
        {
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Nhan vien thu {i + 1}:");
                ds[i].Output();
            }
        }

        public double TinhTongLuong()
        {
            double tong = 0;

            foreach (NhanVien nv in ds)
            {
                tong += nv.TinhLuong();
            }

            return tong;
        }
    }
}