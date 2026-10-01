namespace Bai03;

public class ConsoleMenu
{
    // Event khi người dùng chọn chức năng
    public event Action<int>? Choose;

    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("           CONSOLE MENU");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Giai phuong trinh bac 2");
            Console.WriteLine("2. Say function x");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("======================================");
            Console.Write("Nhap lua chon: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Lua chon khong hop le!");
                TamDung();
                continue;
            }

            if (choice == 0)
            {
                break;
            }

            // Phat event
            Choose?.Invoke(choice);

            TamDung();
        }
    }

    protected virtual void TamDung()
    {
        Console.WriteLine("\nNhan Enter de tiep tuc...");
        Console.ReadLine();
    }
}