using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWeek6
{
    internal class PhongBan
    { 
        public string MaSo {  get; set; }

        public string TenPhongBan {  get; set; }

        public string MoTa {  get; set; }
        // Danh sách nhân viên thuộc phòng ban
        public List<NhanVien> DanhSachNhanVien { get; set; }

        // Phương thức in bảng lương của phòng ban
        public void InBangLuong()
        {
            Console.WriteLine("Bang luong cua phong ban {0}", TenPhongBan);
            Console.WriteLine("Ma nhan vien\tHo ten nhan vien\tLương");
            foreach (var nv in DanhSachNhanVien)
            {
                Console.WriteLine("{0}\t{1}\t{2}", nv.MaSo, nv.HoTen, nv.TinhLuong());
            }
        }

        // Phương thức in danh sách nhân viên đã nghỉ hưu
        public void InDanhSachNghiHuu()
        {
            Console.WriteLine("Danh sach nghi huu cua phong ban {0}", TenPhongBan);
            Console.WriteLine("Ma nhan vien\tHo ten nhan vien\tNgay sinh\tGioi tinh");
            foreach (var nv in DanhSachNhanVien)
            {
                if (nv.LaNghiHuu())
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", nv.MaSo, nv.HoTen, nv.NgaySinh, nv.GioiTinh);
                }
            }
        }

    }
}
