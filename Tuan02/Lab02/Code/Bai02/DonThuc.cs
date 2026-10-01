using System;

namespace Bai02
{
    public class DonThuc
    {
        private double a;
        private int n;

        // Constructor mặc nhiên
        public DonThuc()
        {
            a = 0;
            n = 0;
        }

        // Constructor có tham số
        public DonThuc(double a, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException(
                    "So mu n phai la so nguyen khong am."
                );
            }

            this.a = a;
            this.n = n;
        }

        // Copy Constructor
        public DonThuc(DonThuc other)
        {
            a = other.a;
            n = other.n;
        }

        // Tính giá trị đơn thức
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        public override string ToString()
        {
            if (n == 0)
            {
                return $"{a}";
            }

            if (n == 1)
            {
                return $"{a}x";
            }

            return $"{a}x^{n}";
        }
    }
}