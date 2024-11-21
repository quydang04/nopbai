using System;

public class NhaQuanLy : NhanVien
{
    public string ChucVu { get; set; }
    public int SoNgayCong { get; set; }
    public decimal BacLuong { get; set; }

    public NhaQuanLy(string hoTen, int namSinh, string bangCap, string chucVu, int soNgayCong, decimal bacLuong)
        : base(hoTen, namSinh, bangCap)
    {
        ChucVu = chucVu;
        SoNgayCong = soNgayCong;
        BacLuong = bacLuong;
    }

    public override decimal TinhLuong()
    {
        return SoNgayCong * BacLuong;
    }
}