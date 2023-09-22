using System;
using System.Collections.Generic;
class Sach
{
    public string MaSach { get; set; }
    public string TenSach { get; set; }
    public string TacGia { get; set; }
    public Sach(string maSach, string tenSach, string tacGia)
    {
        MaSach = maSach;
        TenSach = tenSach;
        TacGia = tacGia;
    }
}
class ThuVien
{
    private List<Sach> danhSachSach;
    public ThuVien()
    {
        danhSachSach = new List<Sach>();
    }
    public void ThemSach(string maSach, string tenSach, string tacGia)
    {
        Sach sach = new Sach(maSach, tenSach, tacGia);
        danhSachSach.Add(sach);
    }
    public void XoaSach(string maSach)
    {
        Sach sach = danhSachSach.Find(s => s.MaSach == maSach);
        if (sach != null)
        {
            danhSachSach.Remove(sach);
        }
    }
    public void HienThiDanhSachSach()
    {
        Console.WriteLine("Danh sach sach trong thu vien:");
        foreach (Sach sach in danhSachSach)
        {
            Console.WriteLine($"Ma sach: {sach.MaSach}");
            Console.WriteLine($"Ten sach: {sach.TenSach}");
            Console.WriteLine($"Tac gia: {sach.TacGia}");
            Console.WriteLine("-----------------------------");
        }
    }
}
class Program
{
    static void Main()
    {
        ThuVien thuVien = new ThuVien();
        while (true)
        {
            Console.WriteLine("Chon tuy chon:");
            Console.WriteLine("1. Them sach");
            Console.WriteLine("2. Xoa sach");
            Console.WriteLine("3. Hien thi danh sach sach");
            Console.WriteLine("4. Thoat");
            Console.Write("Nhap lua chon: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Nhap ma sach: ");
                    string maSach = Console.ReadLine();
                    Console.Write("Nhap ten sach: ");
                    string tenSach = Console.ReadLine();
                    Console.Write("Nhap tac gia: ");
                    string tacGia = Console.ReadLine();
                    thuVien.ThemSach(maSach, tenSach, tacGia);
                    Console.WriteLine("Sach da duoc them vao thu vien.");
                    break;
                case "2":
                    Console.Write("Nhap ma sach can xoa: ");
                    string maSachXoa = Console.ReadLine();
                    thuVien.XoaSach(maSachXoa);
                    Console.WriteLine("Sach da duoc xoa khoi thu vien.");
                    break;
                case "3":
                    thuVien.HienThiDanhSachSach();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }
}
