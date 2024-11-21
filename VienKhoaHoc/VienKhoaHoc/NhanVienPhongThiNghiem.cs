using System;

public class NhanVienPhongThiNghiem : NhanVien
{
    public decimal LuongThang { get; set; }

    public NhanVienPhongThiNghiem(string hoTen, int namSinh, string bangCap, decimal luongThang)
        : base(hoTen, namSinh, bangCap)
    {
        LuongThang = luongThang;
    }

    public override decimal TinhLuong()
    {
        return LuongThang;
    }
}