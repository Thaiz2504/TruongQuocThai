using System;

namespace Bai01
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

        // Nhập
        public void Input()
        {
            Console.Write("Nhap he so a: ");
            a = double.Parse(Console.ReadLine() ?? "0");

            do
            {
                Console.Write("Nhap so mu n: ");
                n = int.Parse(Console.ReadLine() ?? "0");

                if (n < 0)
                {
                    Console.WriteLine(
                        "So mu n phai >= 0!"
                    );
                }

            } while (n < 0);
        }

        // Xuất
        public void Output()
        {
            Console.WriteLine(ToString());
        }

        // Tính giá trị P(x)
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        // Tính đạo hàm
        public DonThuc DaoHam()
        {
            if (n == 0)
            {
                return new DonThuc(0, 0);
            }

            return new DonThuc(a * n, n - 1);
        }

        // Biểu diễn đơn thức
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