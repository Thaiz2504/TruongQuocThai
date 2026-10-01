namespace Bai03;

public class NhanVienSanXuat : NhanVien
{
    private int soSanPham;

    public NhanVienSanXuat()
        : base()
    {
        soSanPham = 0;
    }

    public override void Input()
    {
        base.Input();

        Console.Write("Nhap so luong san pham: ");
        while (!int.TryParse(Console.ReadLine(), out soSanPham))
        {
            Console.Write("So san pham khong hop le, nhap lai: ");
        }
    }

    public override double TinhLuong()
    {
        double luong = soSanPham * 1000;

        if (soSanPham > 3000)
        {
            luong *= 1.05;
        }

        return luong;
    }

    public override void Output()
    {
        base.Output();

        Console.WriteLine($"So san pham: {soSanPham}");
        Console.WriteLine($"Luong: {TinhLuong()}");
    }
}