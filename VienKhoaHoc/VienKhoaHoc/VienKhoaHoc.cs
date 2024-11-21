using System;
using System.Collections.Generic;

public class VienKhoaHoc
{
    private List<NhanVien> danhSachNhanVien = new List<NhanVien>();

    public void NhapNhanVien(NhanVien nhanVien)
    {
        danhSachNhanVien.Add(nhanVien);
    }

    public void XuatDanhSachNhanVien()
    {
        foreach (var nhanVien in danhSachNhanVien)
        {
            Console.WriteLine($"Ho ten: {nhanVien.HoTen}, Nam sinh: {nhanVien.NamSinh}, Bang cap: {nhanVien.BangCap}, Luong: {nhanVien.TinhLuong()}");
        }
    }

    public decimal TinhTongLuong()
    {
        decimal tongLuong = 0;
        foreach (var nhanVien in danhSachNhanVien)
        {
            tongLuong += nhanVien.TinhLuong();
        }
        return tongLuong;
    }
}