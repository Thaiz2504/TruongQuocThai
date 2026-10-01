using System;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("        LAB02 - PHAN 1: CO BAN");
                Console.WriteLine("======================================");
                Console.WriteLine("1 - Tinh tuoi sinh vien");
                Console.WriteLine("2 - Lop Point");
                Console.WriteLine("3 - Lop Person");
                Console.WriteLine("4 - Lop Phan So");
                Console.WriteLine("5 - Lop Don Thuc");
                Console.WriteLine("0.  - Thoat");
                Console.WriteLine("======================================");

                Console.Write("Nhap lua chon: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        TestBai11();
                        break;

                    case 2:
                        TestBai12();
                        break;

                    case 3:
                        TestBai13();
                        break;

                    case 4:
                        TestBai14();
                        break;

                    case 5:
                        TestBai15();
                        break;

                    case 0:
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nhan Enter de quay lai menu...");
                    Console.ReadLine();
                }

            } while (choice != 0);
        }

        // =========================
        // BAI 1.1
        // =========================
        static void TestBai11()
        {
            Console.WriteLine("=== BAI 1.1 - SINH VIEN ===");
            Console.WriteLine();

            SinhVien sv = new SinhVien();

            sv.Nhap();

            Console.WriteLine();
            sv.Xuat();
        }

        // =========================
        // BAI 1.2
        // =========================
        static void TestBai12()
        {
            Console.WriteLine("=== BAI 1.2 - POINT ===");
            Console.WriteLine();

            Point A = new Point();
            Point B = new Point();

            Console.WriteLine("Nhap diem A:");
            A.Input();

            Console.WriteLine();
            Console.WriteLine("Nhap diem B:");
            B.Input();

            Console.WriteLine();
            Console.WriteLine("--- THONG TIN DIEM ---");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

            Console.WriteLine();
            Console.WriteLine("--- TOAN TU ---");
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("-A = " + (-A));

            Console.WriteLine();
            Console.WriteLine("--- KHOANG CACH ---");

            double d1 = A.Distance(B);
            double d2 = Point.Distance(A, B);

            Console.WriteLine(
                "Thanh vien = " + d1
            );

            Console.WriteLine(
                "Tinh = " + d2
            );

            Console.WriteLine();
            Console.WriteLine("--- TRUNG DIEM ---");

            Point I1 = A.MidPoint(B);
            Point I2 = Point.MidPoint(A, B);

            Console.WriteLine(
                "Thanh vien = " + I1
            );

            Console.WriteLine(
                "Tinh = " + I2
            );
        }

        // =========================
        // BAI 1.3
        // =========================
        static void TestBai13()
        {
            Console.WriteLine("=== BAI 1.3 - PERSON ===");
            Console.WriteLine();

            Person p1 = new Person();

            Console.WriteLine("Nhap thong tin Person:");
            p1.Input();

            Console.WriteLine();
            Console.WriteLine("--- PERSON GOC ---");
            p1.Output();

            Console.WriteLine();
            Console.WriteLine("--- KIEM TRA TRANG THAI ---");

            if (p1.IsLiving())
            {
                Console.WriteLine("Person dang con song.");
            }
            else
            {
                Console.WriteLine("Person da mat.");
            }

            Console.WriteLine();
            Console.WriteLine("--- COPY CONSTRUCTOR ---");

            Person p2 = new Person(p1);

            p2.Output();
        }

        // =========================
        // BAI 1.4
        // =========================
        static void TestBai14()
{
    Console.WriteLine("=== BAI 1.4 - PHAN SO ===");
    Console.WriteLine();

    // Nhập phân số a
    Console.WriteLine("Nhap phan so a:");
    PhanSo a = new PhanSo();
    a.Input();

    Console.WriteLine();

    // Nhập phân số b
    Console.WriteLine("Nhap phan so b:");
    PhanSo b = new PhanSo();
    b.Input();

    Console.WriteLine();

    // Xuất hai phân số
    Console.WriteLine("--- HAI PHAN SO ---");
    Console.WriteLine("a = " + a);
    Console.WriteLine("b = " + b);

    // Rút gọn
    a.RutGon();
    b.RutGon();

    Console.WriteLine();
    Console.WriteLine("--- SAU KHI RUT GON ---");
    Console.WriteLine("a = " + a);
    Console.WriteLine("b = " + b);

    // Các phép toán
    Console.WriteLine();
    Console.WriteLine("--- PHEP TOAN ---");

    Console.WriteLine("a + b = " + (a + b));
    Console.WriteLine("a - b = " + (a - b));
    Console.WriteLine("a * b = " + (a * b));

    try
    {
        Console.WriteLine("a / b = " + (a / b));
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("a / b: " + ex.Message);
    }

    // Toán tử một ngôi
    Console.WriteLine();
    Console.WriteLine("--- TOAN TU MOT NGOI ---");

    Console.WriteLine("+a = " + (+a));
    Console.WriteLine("-a = " + (-a));

    // So sánh
    Console.WriteLine();
    Console.WriteLine("--- SO SANH ---");

    Console.WriteLine("a > b  = " + (a > b));
    Console.WriteLine("a < b  = " + (a < b));
    Console.WriteLine("a >= b = " + (a >= b));
    Console.WriteLine("a <= b = " + (a <= b));
    Console.WriteLine("a == b = " + (a == b));
    Console.WriteLine("a != b = " + (a != b));

    // Copy Constructor
    Console.WriteLine();
    Console.WriteLine("--- COPY CONSTRUCTOR ---");

    PhanSo copy = new PhanSo(a);

    Console.WriteLine("Ban sao cua a = " + copy);
}
        // =========================
        // BAI 1.5
        // =========================
        static void TestBai15()
        {
            Console.WriteLine("=== BAI 1.5 - DON THUC ===");
            Console.WriteLine();

            DonThuc p = new DonThuc();

            p.Input();

            Console.WriteLine();
            Console.WriteLine("Don thuc: " + p);

            Console.WriteLine();
            Console.Write("Nhap x: ");

            double x = double.Parse(
                Console.ReadLine() ?? "0"
            );

            double value = p.TinhGiaTri(x);

            Console.WriteLine();
            Console.WriteLine($"P({x}) = {value}");

            DonThuc derivative = p.DaoHam();

            Console.WriteLine(
                "Dao ham: " + derivative
            );
        }
    }
}