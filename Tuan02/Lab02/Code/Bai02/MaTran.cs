using System;

namespace Bai02
{
    public class MaTran
    {
        private int[,] a;
        private int n;
        private int m;

        // Constructor mặc nhiên
        public MaTran()
        {
            n = 0;
            m = 0;
            a = new int[0, 0];
        }

        // Constructor có tham số
        public MaTran(int n, int m)
        {
            if (n < 0 || m < 0)
            {
                throw new ArgumentException(
                    "So dong va so cot phai >= 0."
                );
            }

            this.n = n;
            this.m = m;
            a = new int[n, m];
        }

        // Copy Constructor
        public MaTran(MaTran other)
        {
            n = other.n;
            m = other.m;

            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = other.a[i, j];
                }
            }
        }

        // Indexer 2 chiều
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= n || j < 0 || j >= m)
                {
                    throw new IndexOutOfRangeException(
                        "Chi so nam ngoai pham vi."
                    );
                }

                return a[i, j];
            }

            set
            {
                if (i < 0 || i >= n || j < 0 || j >= m)
                {
                    throw new IndexOutOfRangeException(
                        "Chi so nam ngoai pham vi."
                    );
                }

                a[i, j] = value;
            }
        }

        // Nhập
        public void Input()
        {
            Console.Write("Nhap so dong n: ");
            n = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so cot m: ");
            m = int.Parse(Console.ReadLine() ?? "0");

            while (n < 0 || m < 0)
            {
                Console.WriteLine(
                    "n va m phai >= 0. Nhap lai."
                );

                Console.Write("Nhap so dong n: ");
                n = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Nhap so cot m: ");
                m = int.Parse(Console.ReadLine() ?? "0");
            }

            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(
                        Console.ReadLine() ?? "0"
                    );
                }
            }
        }

        // Xuất
        public void Output()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],6}");
                }

                Console.WriteLine();
            }
        }

        // Kiểm tra số nguyên tố
        private bool LaSoNguyenTo(int x)
        {
            if (x < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Tìm số nguyên tố
        public void TimSoNguyenTo()
        {
            Console.Write("Cac so nguyen to: ");

            bool found = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (LaSoNguyenTo(a[i, j]))
                    {
                        Console.Write(a[i, j] + " ");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.Write("Khong co");
            }

            Console.WriteLine();
        }
    }
}