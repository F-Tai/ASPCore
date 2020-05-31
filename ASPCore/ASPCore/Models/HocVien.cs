using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    public class HocVien
    {
        [DisplayName("Mã Học Viên")]
        public int MaSo { get; set; }
        [DisplayName("Tên Học Viên")]
        public string TenHocVien { get; set; }
        [DisplayName("Số Điện Thoại")]
        public string SoDienThoai { get; set; }
        [DisplayName("Điểm Trung Bình")]
        public double DiemTrungBinh { get; set; }
        [DisplayName("Giới Tính")]
        public bool GioiTinh { get; set; }
    }
}
