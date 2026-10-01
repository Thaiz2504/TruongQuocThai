namespace Bai03;

public class SinhVien : IComparable<SinhVien>, ISoSanh<SinhVien>
{
    private string maSo;
    private string hoTen;
    private double diem;

    public SinhVien()
    {
        maSo = "";
        hoTen = "";
        diem = 0;
    }

    public SinhVien(string maSo, string hoTen, double diem)
    {
        this.maSo = maSo;
        this.hoTen = hoTen;
        this.diem = diem;
    }

    // ==========================================
    // NHẬP SINH VIÊN
    // ==========================================
    public void Input()
    {
        Console.Write("Nhap ma so: ");
        maSo = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap diem: ");

        while (!double.TryParse(Console.ReadLine(), out diem))
        {
            Console.Write("Diem khong hop le, nhap lai: ");
        }
    }

    // ==========================================
    // XUẤT SINH VIÊN
    // ==========================================
    public void Output()
    {
        Console.WriteLine(
            $"Ma so: {maSo} | Ho ten: {hoTen} | Diem: {diem}"
        );
    }

    // ==========================================
    // BÀI 3.1
    // IComparable -> Array.Sort()
    // ==========================================
    public int CompareTo(SinhVien? other)
    {
        if (other == null)
            return 1;

        return diem.CompareTo(other.diem);
    }

    // ==========================================
    // BÀI 3.2
    // Interface tự định nghĩa
    // ==========================================
    public int SoSanh(SinhVien other)
    {
        return diem.CompareTo(other.diem);
    }

    // ==========================================
    // BÀI 3.3
    // Delegate
    // ==========================================
    public int SoSanhDiem(SinhVien other)
    {
        return diem.CompareTo(other.diem);
    }

    public int SoSanhMaSo(SinhVien other)
    {
        return string.Compare(
            maSo,
            other.maSo,
            StringComparison.OrdinalIgnoreCase
        );
    }

    // ==========================================
    // Có thể dùng thêm Nhap/Xuat nếu cần
    // ==========================================
    public void Nhap()
    {
        Input();
    }

    public void Xuat()
    {
        Output();
    }
}