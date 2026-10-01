using System;

namespace Bai02
{
    public class DaySo
    {
        private int[] a;
        private int n;

        // Constructor mặc nhiên
        public DaySo()
        {
            n = 0;
            a = new int[0];
        }

        // Constructor có kích thước
        public DaySo(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n phai >= 0.");
            }

            this.n = n;
            a = new int[n];
        }

        // Copy Constructor
        public DaySo(DaySo other)
        {
            n = other.n;
            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = other.a[i];
            }
        }

        // Indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= n)
                {
                    throw new IndexOutOfRangeException(
                        "Chi so nam ngoai pham vi."
                    );
                }

                return a[index];
            }

            set
            {
                if (index < 0 || index >= n)
                {
                    throw new IndexOutOfRangeException(
                        "Chi so nam ngoai pham vi."
                    );
                }

                a[index] = value;
            }
        }

        // Nhập
        public void Input()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine() ?? "0");

            while (n < 0)
            {
                Console.Write("n phai >= 0. Nhap lai n: ");
                n = int.Parse(Console.ReadLine() ?? "0");
            }

            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        // Xuất
        public void Output()
        {
            Console.Write("Day so: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);

                if (i < n - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

        // Tìm và xuất các số chẵn
        public void TimSoChan()
        {
            Console.Write("Cac so chan: ");

            bool found = false;

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                    found = true;
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