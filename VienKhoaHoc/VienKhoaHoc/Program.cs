using System;

class Program
{
    static void Main(string[] args)
    {
        VienKhoaHoc vien = new VienKhoaHoc();

        Console.WriteLine("Nhap so luong nhan vien:");
        int soLuongNhanVien = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuongNhanVien; i++)
        {
            Console.WriteLine("Chon loai nhan vien (1: Nha khoa hoc, 2: Nha quan ly, 3: Nhan vien phong thi nghiem):");
            int loaiNhanVien = int.Parse(Console.ReadLine());

            switch (loaiNhanVien)
            {
                case 1:
                    NhapNhaKhoaHoc(vien);
                    break;
                case 2:
                    NhapNhaQuanLy(vien);
                    break;
                case 3:
                    NhapNhanVienPhongThiNghiem(vien);
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }

        Console.WriteLine("Danh sach nhan vien:");
        vien.XuatDanhSachNhanVien();

        Console.WriteLine($"Tong luong: {vien.TinhTongLuong()}");
    }

    static void NhapNhaKhoaHoc(VienKhoaHoc vien)
    {
        Console.WriteLine("Nhap ho ten:");
        string hoTen = Console.ReadLine();
        Console.WriteLine("Nhap nam sinh:");
        int namSinh = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap bang cap:");
        string bangCap = Console.ReadLine();
        Console.WriteLine("Nhap chuc vu:");
        string chucVu = Console.ReadLine();
        Console.WriteLine("Nhap so bai bao:");
        int soBaiBao = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so ngay cong:");
        int soNgayCong = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap bac luong:");
        decimal bacLuong = decimal.Parse(Console.ReadLine());

        NhaKhoaHoc nhaKhoaHoc = new NhaKhoaHoc(hoTen, namSinh, bangCap, chucVu, soBaiBao, soNgayCong, bacLuong);
        vien.NhapNhanVien(nhaKhoaHoc);
    }

    static void NhapNhaQuanLy(VienKhoaHoc vien)
    {
        Console.WriteLine("Nhap ho ten:");
        string hoTen = Console.ReadLine();
        Console.WriteLine("Nhap nam sinh:");
        int namSinh = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap bang cap:");
        string bangCap = Console.ReadLine();
        Console.WriteLine("Nhap chuc vu:");
        string chucVu = Console.ReadLine();
        Console.WriteLine("Nhap so ngay cong:");
        int soNgayCong = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap bac luong:");
        decimal bacLuong = decimal.Parse(Console.ReadLine());

        NhaQuanLy nhaQuanLy = new NhaQuanLy(hoTen, namSinh, bangCap, chucVu, soNgayCong, bacLuong);
        vien.NhapNhanVien(nhaQuanLy);
    }

    static void NhapNhanVienPhongThiNghiem(VienKhoaHoc vien)
    {
        Console.WriteLine("Nhap ho ten:");
        string hoTen = Console.ReadLine();
        Console.WriteLine("Nhap nam sinh:");
        int namSinh = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap bang cap:");
        string bangCap = Console.ReadLine();
        Console.WriteLine("Nhap luong thang:");
        decimal luongThang = decimal.Parse(Console.ReadLine());

        NhanVienPhongThiNghiem nhanVien = new NhanVienPhongThiNghiem(hoTen, namSinh, bangCap, luongThang);
        vien.NhapNhanVien(nhanVien);
    }
}