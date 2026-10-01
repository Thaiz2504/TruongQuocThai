namespace Bai03;

public class CuocThi
{
    private List<ThiSinh> danhSach;

    public CuocThi()
    {
        danhSach = new List<ThiSinh>();
    }

    public void Input()
    {
        Console.Write("Nhap so luong thi sinh: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n===== THI SINH {i + 1} =====");
            Console.WriteLine("1. Thi sinh Chuyen");
            Console.WriteLine("2. Thi sinh Sieu cup");
            Console.Write("Chon loai thi sinh: ");

            string choice = Console.ReadLine() ?? "";

            ThiSinh ts;

            if (choice == "1")
            {
                ts = new ThiSinhChuyen();
            }
            else if (choice == "2")
            {
                ts = new ThiSinhSieuCup();
            }
            else
            {
                Console.WriteLine("Loai thi sinh khong hop le!");
                i--;
                continue;
            }

            ts.Input();
            danhSach.Add(ts);
        }
    }

    public void Output()
    {
        Console.WriteLine("\n======================================");
        Console.WriteLine("          KET QUA CUOC THI");
        Console.WriteLine("======================================");

        foreach (ThiSinh ts in danhSach)
        {
            ts.Output();
            Console.WriteLine("--------------------------------------");
        }
    }
}