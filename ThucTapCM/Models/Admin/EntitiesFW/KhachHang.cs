namespace ThucTapCM.Models.Admin.EntitiesFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        [Column(TypeName = "text")]
        public string FeedBack { get; set; }
    }
}
