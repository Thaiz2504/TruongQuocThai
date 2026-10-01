namespace Bai03;

public abstract class ThiSinh
{
    protected string sbd;
    protected string hoTen;
    protected double bai1;
    protected double bai2;
    protected double bai3;

    public ThiSinh()
    {
        sbd = "";
        hoTen = "";
        bai1 = 0;
        bai2 = 0;
        bai3 = 0;
    }

    public virtual void Input()
    {
        Console.Write("Nhap so bao danh: ");
        sbd = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";

        bai1 = NhapDiem("Nhap diem bai 1: ");
        bai2 = NhapDiem("Nhap diem bai 2: ");
        bai3 = NhapDiem("Nhap diem bai 3: ");
    }

    protected double NhapDiem(string message)
    {
        double diem;

        while (true)
        {
            Console.Write(message);

            if (double.TryParse(Console.ReadLine(), out diem)
                && diem >= 0 && diem <= 10)
            {
                return diem;
            }

            Console.WriteLine("Diem phai tu 0 den 10. Nhap lai!");
        }
    }

    public virtual void Output()
    {
        Console.WriteLine($"SBD: {sbd}");
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine($"Bai 1: {bai1}");
        Console.WriteLine($"Bai 2: {bai2}");
        Console.WriteLine($"Bai 3: {bai3}");
    }

    public abstract double TinhTongDiem();
}