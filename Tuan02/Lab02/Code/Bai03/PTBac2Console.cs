namespace Bai03;

public class PTBac2Console : ConsoleMenu
{
    public PTBac2Console()
    {
        // Đăng ký xử lý event
        Choose += XuLyLuaChon;
    }

    private void XuLyLuaChon(int choice)
    {
        switch (choice)
        {
            case 1:
                GiaiPhuongTrinhBac2();
                break;

            case 2:
                SayFunction();
                break;

            default:
                Console.WriteLine("Chuc nang khong ton tai!");
                break;
        }
    }

    private void GiaiPhuongTrinhBac2()
    {
        Console.WriteLine("\n===== GIAI PHUONG TRINH BAC 2 =====");

        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("\nPhuong trinh:");
        Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");

        if (a == 0)
        {
            // Phương trình bậc nhất
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                else
                    Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phuong trinh co nghiem x = {x}");
            }

            return;
        }

        double delta = b * b - 4 * a * c;

        Console.WriteLine($"Delta = {delta}");

        if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);

            Console.WriteLine(
                $"Phuong trinh co nghiem kep x1 = x2 = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
    }

    private void SayFunction()
    {
        Console.WriteLine("\nDay la chuc nang SayFunction().");
        Console.WriteLine("Hello from PTBac2Console!");
    }
}