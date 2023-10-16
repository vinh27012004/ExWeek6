using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWeek6
{
    internal class NhanVien
    {
        public string MaSo { get; set; }
        public string HoTen {  get; set; }
        
        public DateTime NgaySinh { get; set; }

        public string GioiTinh {  get; set; }

        public double HeSoLuong { get; set; }

        // Hằng số lương cơ bản
        public const double LuongCoBan = 1800;

        // Phương thức tính lương
        public double TinhLuong()
        {
            return HeSoLuong * LuongCoBan;
        }

        // Phương thức kiểm tra nghỉ hưu
        public bool LaNghiHuu()
        {
            // Lấy tuổi hiện tại
            int tuoi = DateTime.Now.Year - NgaySinh.Year;
            if (NgaySinh > DateTime.Now.AddYears(-tuoi)) tuoi--;

            // Kiểm tra theo giới tính
            if (GioiTinh == "Nam" && tuoi >= 60) return true;
            if (GioiTinh == "Nữ" && tuoi >= 55) return true;
            return false;
        }


    }
}
