using System;

public abstract class NhanVien
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string BangCap { get; set; }

    public NhanVien(string hoTen, int namSinh, string bangCap)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        BangCap = bangCap;
    }

    public abstract decimal TinhLuong();
}