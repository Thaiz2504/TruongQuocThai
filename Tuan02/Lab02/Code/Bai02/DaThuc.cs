using System;
using System.Collections.Generic;

namespace Bai02
{
    public class DaThuc
    {
        private List<DonThuc> ds;
        private int bac;

        // Constructor mặc nhiên
        public DaThuc()
        {
            bac = 0;
            ds = new List<DonThuc>();
            ds.Add(new DonThuc(0, 0));
        }

        // Constructor có bậc
        public DaThuc(int bac)
        {
            if (bac < 0)
            {
                throw new ArgumentException(
                    "Bac da thuc phai >= 0."
                );
            }

            this.bac = bac;
            ds = new List<DonThuc>();

            for (int i = 0; i <= bac; i++)
            {
                ds.Add(new DonThuc(0, i));
            }
        }

        // Copy Constructor
        public DaThuc(DaThuc other)
        {
            bac = other.bac;
            ds = new List<DonThuc>();

            for (int i = 0; i < other.ds.Count; i++)
            {
                ds.Add(new DonThuc(other[i]));
            }
        }

        // Indexer
        public DonThuc this[int index]
        {
            get
            {
                if (index < 0 || index >= ds.Count)
                {
                    throw new IndexOutOfRangeException(
                        "Chi so don thuc khong hop le."
                    );
                }

                return ds[index];
            }

            set
            {
                if (index < 0 || index >= ds.Count)
                {
                    throw new IndexOutOfRangeException(
                        "Chi so don thuc khong hop le."
                    );
                }

                ds[index] = value;
            }
        }

        // Nhập đa thức
        public void Input()
        {
            Console.Write("Nhap bac cua da thuc n: ");
            bac = int.Parse(Console.ReadLine() ?? "0");

            while (bac < 0)
            {
                Console.Write("Bac phai >= 0. Nhap lai: ");
                bac = int.Parse(Console.ReadLine() ?? "0");
            }

            ds = new List<DonThuc>();

            for (int i = 0; i <= bac; i++)
            {
                Console.Write($"Nhap he so a{i}: ");

                double a = double.Parse(
                    Console.ReadLine() ?? "0"
                );

                ds.Add(new DonThuc(a, i));
            }
        }

        // Xuất đa thức
        public void Output()
        {
            Console.Write("P(x) = ");

            for (int i = bac; i >= 0; i--)
            {
                Console.Write(ds[i]);

                if (i > 0)
                {
                    Console.Write(" + ");
                }
            }

            Console.WriteLine();
        }

        // Tính P(x)
        public double TinhGiaTri(double x)
        {
            double sum = 0;

            for (int i = 0; i <= bac; i++)
            {
                sum += ds[i].TinhGiaTri(x);
            }

            return sum;
        }
    }
}