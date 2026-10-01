using System;
using System.Collections.Generic;

namespace Bai02
{
    public class DayPhanSo
    {
        private List<PhanSo> ds;

        public DayPhanSo()
        {
            ds = new List<PhanSo>();
        }

        public void Input()
        {
            Console.Write("Nhap so luong phan so n: ");
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
                Console.WriteLine($"Nhap phan so thu {i + 1}:");

                PhanSo ps = new PhanSo();
                ps.Input();

                ds.Add(ps);
            }
        }

        public void Output()
        {
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(
                    $"Phan so thu {i + 1}: {ds[i]}"
                );
            }
        }

        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo();

            for (int i = 0; i < ds.Count; i++)
            {
                tong = tong + ds[i];
            }

            tong.RutGon();

            return tong;
        }
    }
}