namespace ThucTapCM.Models.Admin.EntitiesFW
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AutoShop_DbContext : DbContext
    {
        public AutoShop_DbContext()
            : base("name=AutoShop_DbContext")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<ChiTietPN> ChiTietPNs { get; set; }
        public virtual DbSet<ChiTietSP> ChiTietSPs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SlideShow> SlideShows { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.FeedBack)
                .IsUnicode(false);

            modelBuilder.Entity<SlideShow>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<SlideShow>()
                .Property(e => e.Text)
                .IsUnicode(false);
        }
    }
}
