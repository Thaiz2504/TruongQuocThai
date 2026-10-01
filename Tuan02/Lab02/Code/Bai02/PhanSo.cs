using System;

namespace Bai02
{
    public class PhanSo
    {
        private int tu;
        private int mau;

        // Constructor mặc nhiên
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }

        // Constructor có tham số
        public PhanSo(int tu, int mau)
        {
            if (mau == 0)
            {
                throw new ArgumentException("Mau so khong duoc bang 0.");
            }

            this.tu = tu;
            this.mau = mau;
        }

        // Copy Constructor
        public PhanSo(PhanSo other)
        {
            tu = other.tu;
            mau = other.mau;
        }

        // Nhập phân số
        public void Input()
        {
            Console.Write("Nhap tu so: ");
            tu = int.Parse(Console.ReadLine() ?? "0");

            do
            {
                Console.Write("Nhap mau so: ");
                mau = int.Parse(Console.ReadLine() ?? "1");

                if (mau == 0)
                {
                    Console.WriteLine("Mau so phai khac 0!");
                }

            } while (mau == 0);
        }

        // Xuất phân số
        public void Output()
        {
            Console.WriteLine(ToString());
        }

        // Tìm UCLN
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }

        // Rút gọn phân số
        public void RutGon()
        {
            int gcd = UCLN(tu, mau);

            if (gcd != 0)
            {
                tu /= gcd;
                mau /= gcd;
            }

            // Đưa dấu âm lên tử số
            if (mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }
        }

        // Xuất dạng a/b
        public override string ToString()
        {
            return $"{tu}/{mau}";
        }

        // =========================
        // TOÁN TỬ MỘT NGÔI
        // =========================

        public static PhanSo operator +(PhanSo a)
        {
            return new PhanSo(a);
        }

        public static PhanSo operator -(PhanSo a)
        {
            return new PhanSo(-a.tu, a.mau);
        }

        // =========================
        // TOÁN TỬ HAI NGÔI
        // =========================

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo result = new PhanSo(
                a.tu * b.mau + b.tu * a.mau,
                a.mau * b.mau
            );

            result.RutGon();
            return result;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo result = new PhanSo(
                a.tu * b.mau - b.tu * a.mau,
                a.mau * b.mau
            );

            result.RutGon();
            return result;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo result = new PhanSo(
                a.tu * b.tu,
                a.mau * b.mau
            );

            result.RutGon();
            return result;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.tu == 0)
            {
                throw new DivideByZeroException(
                    "Khong the chia cho phan so 0."
                );
            }

            PhanSo result = new PhanSo(
                a.tu * b.mau,
                a.mau * b.tu
            );

            result.RutGon();
            return result;
        }

        // =========================
        // TOÁN TỬ SO SÁNH
        // =========================

        public static bool operator >(PhanSo a, PhanSo b)
        {
            return (long)a.tu * b.mau >
                   (long)b.tu * a.mau;
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            return (long)a.tu * b.mau <
                   (long)b.tu * a.mau;
        }

        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return (long)a.tu * b.mau >=
                   (long)b.tu * a.mau;
        }

        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return (long)a.tu * b.mau <=
                   (long)b.tu * a.mau;
        }

        public static bool operator ==(PhanSo a, PhanSo b)
        {
            return (long)a.tu * b.mau ==
                   (long)b.tu * a.mau;
        }

        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is not PhanSo other)
            {
                return false;
            }

            return this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(tu, mau);
        }
    }
}