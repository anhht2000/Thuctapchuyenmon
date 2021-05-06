namespace ThucTapCM.Models.Admin.EntitiesFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPN")]
    public partial class ChiTietPN
    {
        [Key]
        public int MaCTPN { get; set; }

        public double? DonGiaNhap { get; set; }

        public int? SoLuongNhap { get; set; }

        public int? MaPN { get; set; }

        public int? MaSP { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
