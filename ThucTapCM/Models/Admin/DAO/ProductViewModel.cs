using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThucTapCM.Models.Admin.DAO
{
    public class ProductViewModel
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonGiaCu { get; set; }
        public string HinhAnh { get; set; }
        public string DonGia { get; set; }
        public int? LuotXem { get; set; }
        public bool? TrangThai { get; set; }
        public int? MaCTSP { get; set; }
        public string MetaTiltle { get; set; }
        //public int MaCTSP { get; set; }
        public string ChungLoai { get; set; }
        public string XuatXu { get; set; }
        public int? NamSanXuat { get; set; }
        public string KichThuoc { get; set; }
        public string ChieuDaiCoSo { get; set; }
        public string TuTrong { get; set; }
        public string TrongLuong { get; set; }
        public double? DungTichXiLanh { get; set; }
        public string KieuDongCo { get; set; }
        public string HopSo { get; set; }
        public string CongSuatLonNhat { get; set; }
        public string Momen { get; set; }
        public string TocDoToiDa { get; set; }
        public string NhienLieu { get; set; }
        public string KieuDanDong { get; set; }
        public int? SoChoNgoi { get; set; }
        public double? TieuThu { get; set; }
        public string CoLop { get; set; }
    }
}