namespace ThucTapCM.Models.Admin.EntitiesFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietSP")]
    public partial class ChiTietSP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietSP()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        public int MaCTSP { get; set; }

        [StringLength(255)]
        public string ChungLoai { get; set; }

        [StringLength(255)]
        public string XuatXu { get; set; }

        public int? NamSanXuat { get; set; }

        [StringLength(255)]
        public string KichThuoc { get; set; }

        [StringLength(255)]
        public string ChieuDaiCoSo { get; set; }

        [StringLength(255)]
        public string TuTrong { get; set; }

        [StringLength(255)]
        public string TrongLuong { get; set; }

        public double? DungTichXiLanh { get; set; }

        [StringLength(25)]
        public string KieuDongCo { get; set; }

        [StringLength(50)]
        public string HopSo { get; set; }

        [StringLength(55)]
        public string CongSuatLonNhat { get; set; }

        [StringLength(55)]
        public string Momen { get; set; }

        [StringLength(55)]
        public string TocDoToiDa { get; set; }

        [StringLength(55)]
        public string NhienLieu { get; set; }

        [StringLength(55)]
        public string KieuDanDong { get; set; }

        public int? SoChoNgoi { get; set; }

        public double? TieuThu { get; set; }

        [StringLength(255)]
        public string CoLop { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        [Column(TypeName = "ntext")]
        public string MetaTiltle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
