namespace Bai03;

public class ThiSinhChuyen : ThiSinh
{
    private double tiengAnh;

    public ThiSinhChuyen()
        : base()
    {
        tiengAnh = 0;
    }

    public override void Input()
    {
        base.Input();

        tiengAnh = NhapDiem("Nhap diem tieng Anh: ");
    }

    private double TinhDiemThuongTiengAnh()
    {
        if (tiengAnh >= 7 && tiengAnh <= 8)
        {
            return 1;
        }

        if (tiengAnh >= 9 && tiengAnh <= 10)
        {
            return 2;
        }

        return 0;
    }

    public override double TinhTongDiem()
    {
        return bai1
             + bai2
             + bai3
             + TinhDiemThuongTiengAnh();
    }

    public override void Output()
    {
        base.Output();

        Console.WriteLine($"Tieng Anh: {tiengAnh}");
        Console.WriteLine(
            $"Diem thuong tieng Anh: {TinhDiemThuongTiengAnh()}");
        Console.WriteLine($"Tong diem: {TinhTongDiem()}");
    }
}