namespace Bai03;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("        BAI TAP PHAN 3 - C#");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Bai 3.1 - Array.Sort()");
            Console.WriteLine("2. Bai 3.2 - Interface");
            Console.WriteLine("3. Bai 3.3 - Delegate");
            Console.WriteLine("4. Bai 3.4 - Event");
            Console.WriteLine("5. Bai 3.5 - Tinh luong nhan vien");
            Console.WriteLine("6. Bai 3.6 - Tinh diem thi sinh");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("======================================");
            Console.Write("Nhap lua chon: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    TestBai31();
                    break;

                case "2":
                    TestBai32();
                    break;

                case "3":
                    TestBai33();
                    break;

                case "4":
                    TestBai34();
                    break;
                case "5":
                      TestBai35();
                      break;
                case "6":
                      TestBai36();
                      break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    TamDung();
                    break;
            }
        }
    }

    // ==================================================
    // BAI 3.1 - Array.Sort()
    // ==================================================
    static void TestBai31()
    {
        Console.Clear();

        Console.WriteLine("======================================");
        Console.WriteLine("BAI 3.1 - SAP XEP BANG ARRAY.SORT()");
        Console.WriteLine("======================================");

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        SinhVien[] ds = new SinhVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Sinh vien {i + 1} ---");

            ds[i] = new SinhVien();
            ds[i].Input();
        }

        Console.WriteLine("\n===== DANH SACH BAN DAU =====");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }

        // Su dung Array.Sort()
        Array.Sort(ds);

        Console.WriteLine("\n===== SAU KHI SAP XEP =====");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }

        TamDung();
    }

    // ==================================================
    // BAI 3.2 - INTERFACE
    // ==================================================
    static void TestBai32()
    {
        Console.Clear();

        Console.WriteLine("======================================");
        Console.WriteLine("BAI 3.2 - SAP XEP BANG INTERFACE");
        Console.WriteLine("======================================");

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        SinhVien[] ds = new SinhVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Sinh vien {i + 1} ---");

            ds[i] = new SinhVien();
            ds[i].Input();
        }

        Console.WriteLine("\n===== DANH SACH BAN DAU =====");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }

        // Su dung ham Sort tu viet bang Interface
        SapXep.Sort(ds);

        Console.WriteLine("\n===== SAU KHI SAP XEP =====");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }

        TamDung();
    }

    // ==================================================
    // BAI 3.3 - DELEGATE
    // ==================================================
    static void TestBai33()
    {
        Console.Clear();

        Console.WriteLine("======================================");
        Console.WriteLine("BAI 3.3 - SAP XEP BANG DELEGATE");
        Console.WriteLine("======================================");

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        SinhVien[] ds = new SinhVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Sinh vien {i + 1} ---");

            ds[i] = new SinhVien();
            ds[i].Input();
        }

        Console.WriteLine("\n===== DANH SACH BAN DAU =====");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }

        // Delegate so sanh theo diem
        SoSanhDelegate<SinhVien> compareDiem =
            (a, b) => a.SoSanhDiem(b);

        SapXepDelegate.Sort(ds, compareDiem);

        Console.WriteLine("\n===== SAP XEP THEO DIEM =====");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }

        // Delegate so sanh theo ma so
        SoSanhDelegate<SinhVien> compareMaSo =
            (a, b) => a.SoSanhMaSo(b);

        SapXepDelegate.Sort(ds, compareMaSo);

        Console.WriteLine("\n===== SAP XEP THEO MA SO =====");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }

        TamDung();
    }

static void TestBai34()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("BAI 3.4 - EVENT + KE THUA");
    Console.WriteLine("======================================");

    PTBac2Console app = new PTBac2Console();

    app.ShowMenu();
}
    // ==================================================
    // Tam dung man hinh
    // ==================================================
    static void TamDung()
    {
        Console.WriteLine("\nNhan Enter de quay lai menu...");
        Console.ReadLine();
    }
static void TestBai35()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("BAI 3.5 - TINH LUONG NHAN VIEN");
    Console.WriteLine("======================================");

    Console.Write("Nhap so luong nhan vien: ");
    int n = int.Parse(Console.ReadLine() ?? "0");

    List<NhanVien> danhSach = new List<NhanVien>();

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"\n===== NHAN VIEN {i + 1} =====");
        Console.WriteLine("1. Nhan vien kinh doanh");
        Console.WriteLine("2. Nhan vien san xuat");
        Console.Write("Chon loai nhan vien: ");

        string choice = Console.ReadLine() ?? "";

        NhanVien nv;

        if (choice == "1")
        {
            nv = new NhanVienKinhDoanh();
        }
        else if (choice == "2")
        {
            nv = new NhanVienSanXuat();
        }
        else
        {
            Console.WriteLine("Loai nhan vien khong hop le!");
            i--;
            continue;
        }

        nv.Input();
        danhSach.Add(nv);
    }

    Console.WriteLine("\n======================================");
    Console.WriteLine("        DANH SACH NHAN VIEN");
    Console.WriteLine("======================================");

    foreach (NhanVien nv in danhSach)
    {
        nv.Output();
        Console.WriteLine("--------------------------------------");
    }

    TamDung();
}
static void TestBai36()
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("BAI 3.6 - TINH DIEM THI SINH");
    Console.WriteLine("======================================");

    CuocThi cuocThi = new CuocThi();

    cuocThi.Input();
    cuocThi.Output();

    TamDung();
}
}