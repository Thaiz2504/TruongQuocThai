namespace Bai03;

public class NhanVienKinhDoanh : NhanVien
{
    private double luongCoBan;
    private int soHopDong;

    public NhanVienKinhDoanh()
        : base()
    {
        luongCoBan = 0;
        soHopDong = 0;
    }

    public override void Input()
    {
        base.Input();

        Console.Write("Nhap luong co ban: ");
        while (!double.TryParse(Console.ReadLine(), out luongCoBan))
        {
            Console.Write("Luong khong hop le, nhap lai: ");
        }

        Console.Write("Nhap so hop dong: ");
        while (!int.TryParse(Console.ReadLine(), out soHopDong))
        {
            Console.Write("So hop dong khong hop le, nhap lai: ");
        }
    }

    public override double TinhLuong()
    {
        return luongCoBan + soHopDong * 500000;
    }

    public override void Output()
    {
        base.Output();

        Console.WriteLine($"Luong co ban: {luongCoBan}");
        Console.WriteLine($"So hop dong: {soHopDong}");
        Console.WriteLine($"Luong: {TinhLuong()}");
    }
}