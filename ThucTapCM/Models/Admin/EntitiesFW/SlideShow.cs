namespace ThucTapCM.Models.Admin.EntitiesFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SlideShow")]
    public partial class SlideShow
    {
        public int Id { get; set; }

        [Column(TypeName = "text")]
        public string Image { get; set; }

        [Column(TypeName = "text")]
        public string Text { get; set; }

        public bool? Status { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        public DateTime? CreatedDay { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [Column(TypeName = "ntext")]
        public string metaTiltle { get; set; }
    }
}
