namespace ThucTapCM.Models.Admin.EntitiesFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string User { get; set; }

        [StringLength(255)]
        public string PassWord { get; set; }
    }
}
