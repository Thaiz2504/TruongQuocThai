using Mylib;

namespace Buoi01Prj;

public class UAT
{
    public static void Run()
    {
        Console.WriteLine("=== GIAI PHUONG TRINH BAC 2 ===");

        Console.Write("Nhap a = ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap b = ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap c = ");
        double c = double.Parse(Console.ReadLine()!);

        double x1 = 0;
        double x2 = 0;

        int soNghiem = LibBaiTap.GiaiPTBac2(
            a, b, c,
            ref x1,
            ref x2
        );

        Console.WriteLine();

        switch (soNghiem)
        {
            case -1:
                Console.WriteLine("Phuong trinh co vo so nghiem.");
                break;

            case 0:
                Console.WriteLine("Phuong trinh vo nghiem.");
                break;

            case 1:
                Console.WriteLine($"Phuong trinh co 1 nghiem: x = {x1}");
                break;

            case 2:
                Console.WriteLine($"Phuong trinh co 2 nghiem:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
                break;
        }
    }
}