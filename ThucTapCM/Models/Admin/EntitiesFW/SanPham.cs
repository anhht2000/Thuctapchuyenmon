namespace ThucTapCM.Models.Admin.EntitiesFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietPNs = new HashSet<ChiTietPN>();
        }

        [Key]
        public int MaSP { get; set; }

        [Column(TypeName = "ntext")]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string DonGiaCu { get; set; }

        [Column(TypeName = "ntext")]
        public string HinhAnh { get; set; }

        [StringLength(50)]
        public string DonGia { get; set; }

        public int? LuotXem { get; set; }

        public bool? TrangThai { get; set; }

        public int? MaCTSP { get; set; }

        public int? MaNCC { get; set; }

        public int? MaNSX { get; set; }

        [StringLength(50)]
        public string MetaTiltle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPN> ChiTietPNs { get; set; }

        public virtual ChiTietSP ChiTietSP { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhaSanXuat NhaSanXuat { get; set; }
    }
}
