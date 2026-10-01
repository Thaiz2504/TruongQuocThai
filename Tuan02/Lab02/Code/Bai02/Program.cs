using System;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.Clear();

                Console.WriteLine("============================================");
                Console.WriteLine("             LAB02 - PHAN 2");
                Console.WriteLine("        THIET KE LOP NANG CAO");
                Console.WriteLine("============================================");
                Console.WriteLine("1. Bai 2.1 - ArrayPoint");
                Console.WriteLine("2. Bai 2.2 - PersonList");
                Console.WriteLine("3. Bai 2.3a - Day so");
                Console.WriteLine("4. Bai 2.4a - Mang 2 chieu");
                Console.WriteLine("5. Bai 2.3b - Da thuc");
                Console.WriteLine("6. Bai 2.4b - Day phan so");
                Console.WriteLine("7. Bai 2.5 - Tinh luong nhan vien");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("============================================");
                Console.Write("Nhap lua chon: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        TestArrayPoint();
                        break;

                    case 2:
                        TestPersonList();
                        break;

                    case 3:
                        TestDaySo();
                        break;

                    case 4:
                        TestMaTran();
                        break;

                    case 5:
                        TestDaThuc();
                        break;

                    case 6:
                        TestDayPhanSo();
                        break;

                    case 7:
                        TestPhongBan();
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

        // ==================================================
        // BAI 2.1 - ARRAYPOINT
        // ==================================================
        static void TestArrayPoint()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("       BAI 2.1 - ARRAYPOINT");
            Console.WriteLine("=================================");

            ArrayPoint arr = new ArrayPoint();

            Console.Write("Nhap so luong Point: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            if (n < 0)
            {
                Console.WriteLine("So luong khong hop le.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Nhap Point thu {i + 1}:");

                Point p = new Point();
                p.Input();

                arr.Add(p);
            }

            Console.WriteLine();
            Console.WriteLine("--- DANH SACH POINT ---");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine($"Point[{i}] = {arr[i]}");
            }

            if (arr.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("--- TEST INDEXER ---");

                Console.Write("Nhap vi tri Point muon xem: ");
                int index = int.Parse(Console.ReadLine() ?? "0");

                try
                {
                    Console.WriteLine($"arr[{index}] = {arr[index]}");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        // ==================================================
        // BAI 2.2 - PERSONLIST
        // ==================================================
        static void TestPersonList()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("       BAI 2.2 - PERSONLIST");
            Console.WriteLine("=================================");

            PersonList list = new PersonList();

            Console.WriteLine();
            Console.WriteLine("--- NHAP DANH SACH PERSON ---");
            list.Input();

            Console.WriteLine();
            Console.WriteLine("--- DANH SACH PERSON ---");
            list.Output();

            Console.WriteLine();
            Console.WriteLine("--- NGUOI CON SONG ---");

            PersonList living = list.LivingPeople();
            living.Output();

            Console.WriteLine();
            Console.WriteLine("--- COPY CONSTRUCTOR ---");

            PersonList copy = new PersonList(list);
            copy.Output();
        }

        // ==================================================
        // BAI 2.3 - DAY SO
        // ==================================================
        static void TestDaySo()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("          BAI 2.3 - DAY SO");
            Console.WriteLine("=================================");

            DaySo d = new DaySo();

            Console.WriteLine();
            Console.WriteLine("--- NHAP DAY SO ---");
            d.Input();

            Console.WriteLine();
            Console.WriteLine("--- DAY SO ---");
            d.Output();

            Console.WriteLine();
            Console.WriteLine("--- CAC SO CHAN ---");
            d.TimSoChan();

            Console.WriteLine();
            Console.WriteLine("--- TEST INDEXER ---");

            Console.Write("Nhap vi tri phan tu muon xem: ");
            int index = int.Parse(Console.ReadLine() ?? "0");

            try
            {
                Console.WriteLine($"d[{index}] = {d[index]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("--- COPY CONSTRUCTOR ---");

            DaySo copy = new DaySo(d);
            copy.Output();
        }

        // ==================================================
        // BAI 2.4 - MANG 2 CHIEU
        // ==================================================
        static void TestMaTran()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("      BAI 2.4 - MANG 2 CHIEU");
            Console.WriteLine("=================================");

            MaTran mt = new MaTran();

            Console.WriteLine();
            Console.WriteLine("--- NHAP MA TRAN ---");
            mt.Input();

            Console.WriteLine();
            Console.WriteLine("--- MA TRAN ---");
            mt.Output();

            Console.WriteLine();
            Console.WriteLine("--- CAC SO NGUYEN TO ---");
            mt.TimSoNguyenTo();

            Console.WriteLine();
            Console.WriteLine("--- TEST INDEXER ---");

            Console.Write("Nhap dong i: ");
            int i = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap cot j: ");
            int j = int.Parse(Console.ReadLine() ?? "0");

            try
            {
                Console.WriteLine($"mt[{i},{j}] = {mt[i, j]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("--- COPY CONSTRUCTOR ---");

            MaTran copy = new MaTran(mt);
            copy.Output();
        }

        // ==================================================
        // BAI DA THUC
        // ==================================================
        static void TestDaThuc()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("           BAI DA THUC");
            Console.WriteLine("=================================");

            DaThuc p = new DaThuc();

            Console.WriteLine();
            Console.WriteLine("--- NHAP DA THUC ---");
            p.Input();

            Console.WriteLine();
            Console.WriteLine("--- XUAT DA THUC ---");
            p.Output();

            Console.WriteLine();
            Console.WriteLine("--- TINH GIA TRI P(x) ---");

            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine() ?? "0");

            double result = p.TinhGiaTri(x);

            Console.WriteLine($"P({x}) = {result}");

            Console.WriteLine();
            Console.WriteLine("--- TEST INDEXER ---");

            Console.Write("Nhap vi tri don thuc i: ");
            int index = int.Parse(Console.ReadLine() ?? "0");

            try
            {
                Console.WriteLine($"Don thuc thu {index}: {p[index]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("--- COPY CONSTRUCTOR ---");

            DaThuc copy = new DaThuc(p);
            copy.Output();
        }

        // ==================================================
        // BAI DAY PHAN SO
        // ==================================================
        static void TestDayPhanSo()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("         BAI DAY PHAN SO");
            Console.WriteLine("=================================");

            DayPhanSo day = new DayPhanSo();

            Console.WriteLine();
            Console.WriteLine("--- NHAP DAY PHAN SO ---");
            day.Input();

            Console.WriteLine();
            Console.WriteLine("--- DAY PHAN SO ---");
            day.Output();

            Console.WriteLine();
            Console.WriteLine("--- TINH TONG ---");

            PhanSo tong = day.TinhTong();

            Console.WriteLine($"Tong = {tong}");
        }

        // ==================================================
        // BAI TINH LUONG NHAN VIEN
        // ==================================================
        static void TestPhongBan()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("      BAI TINH LUONG NHAN VIEN");
            Console.WriteLine("=================================");

            PhongBan phongBan = new PhongBan();

            Console.WriteLine();
            Console.WriteLine("--- NHAP PHONG BAN ---");
            phongBan.Input();

            Console.WriteLine();
            Console.WriteLine("--- DANH SACH NHAN VIEN ---");
            phongBan.Output();

            Console.WriteLine();
            Console.WriteLine("--- TONG LUONG PHONG BAN ---");

            double tongLuong = phongBan.TinhTongLuong();

            Console.WriteLine($"Tong luong = {tongLuong:N0} VNĐ");
        }
    }
}