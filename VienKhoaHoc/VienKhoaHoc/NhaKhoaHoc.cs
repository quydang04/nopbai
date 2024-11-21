using System;

public class NhaKhoaHoc : NhanVien
{
    public string ChucVu { get; set; }
    public int SoBaiBao { get; set; }
    public int SoNgayCong { get; set; }
    public decimal BacLuong { get; set; }

    public NhaKhoaHoc(string hoTen, int namSinh, string bangCap, string chucVu, int soBaiBao, int soNgayCong, decimal bacLuong)
        : base(hoTen, namSinh, bangCap)
    {
        ChucVu = chucVu;
        SoBaiBao = soBaiBao;
        SoNgayCong = soNgayCong;
        BacLuong = bacLuong;
    }

    public override decimal TinhLuong()
    {
        return SoNgayCong * BacLuong;
    }
}