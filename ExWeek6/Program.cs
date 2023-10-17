using System;

namespace ExWeek6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thong tin phong ban:");
            Console.WriteLine("Ma So: ");
            string maSo = Console.ReadLine();
            Console.WriteLine("Ten Phong Ban: ");
            string tenPhongBan = Console.ReadLine();
            Console.WriteLine("Mo ta:");
            string moTa = Console.ReadLine();
            
            // Tạo đối tượng phòng ban
            PhongBan pb = new PhongBan();
            pb.MaSo = maSo;
            pb.TenPhongBan = tenPhongBan;
            pb.MoTa = moTa;

            // Nhập số lượng nhân viên
            Console.Write("Nhap so luong nhan vien (2 < n < 15): ");
            int n = int.Parse(Console.ReadLine());

            // Tạo danh sách nhân viên rỗng
            pb.DanhSachNhanVien = new List<NhanVien>();

            // Nhập thông tin từng nhân viên và thêm vào danh sách
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu {0}:", i + 1);
                Console.Write("Ma so: ");
                maSo = Console.ReadLine();
                Console.Write("Ho ten: ");
                string hoTen = Console.ReadLine();
                Console.Write("Ngay Sinh (dd/mm/yyyy): ");
                DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Gioi Tinh (Nam/Nu): ");
                string gioiTinh = Console.ReadLine();
                Console.Write("He so luong: ");
                double heSoLuong = double.Parse(Console.ReadLine());

                // Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien();
                nv.MaSo = maSo;
                nv.HoTen = hoTen;
                nv.NgaySinh = ngaySinh;
                nv.GioiTinh = gioiTinh;
                nv.HeSoLuong = heSoLuong;

                // Thêm nhân viên vào danh sách
                pb.DanhSachNhanVien.Add(nv);
            }

            // In bảng lương của phòng ban
            pb.InBangLuong();

            // In danh sách nhân viên đã nghỉ hưu
            pb.InDanhSachNghiHuu();

            Console.ReadKey();
        }

    }
}
