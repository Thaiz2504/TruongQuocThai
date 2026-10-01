namespace Bai03;

public abstract class NhanVien
{
    protected string maNV;
    protected string hoTen;

    public NhanVien()
    {
        maNV = "";
        hoTen = "";
    }

    public NhanVien(string maNV, string hoTen)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
    }

    public virtual void Input()
    {
        Console.Write("Nhap ma nhan vien: ");
        maNV = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";
    }

    public virtual void Output()
    {
        Console.WriteLine($"Ma NV: {maNV} | Ho ten: {hoTen}");
    }

    // Mỗi loại nhân viên tự tính lương
    public abstract double TinhLuong();
}