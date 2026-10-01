namespace Bai03;

public class ThiSinhSieuCup : ThiSinh
{
    private double csdl;

    public ThiSinhSieuCup()
        : base()
    {
        csdl = 0;
    }

    public override void Input()
    {
        base.Input();

        csdl = NhapDiem("Nhap diem CSDL: ");
    }

    public override double TinhTongDiem()
    {
        return bai1
             + bai2
             + bai3
             + csdl;
    }

    public override void Output()
    {
        base.Output();

        Console.WriteLine($"CSDL: {csdl}");
        Console.WriteLine($"Tong diem: {TinhTongDiem()}");
    }
}