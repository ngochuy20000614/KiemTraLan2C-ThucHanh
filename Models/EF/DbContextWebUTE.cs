using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.EF
{
    public partial class DbContextWebUTE : DbContext
    {
        public DbContextWebUTE()
            : base("name=DbContextWebUTE")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ChiTietThanhVien> ChiTietThanhViens { get; set; }
        public virtual DbSet<LopSinhVien> LopSinhViens { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietThanhVien>()
                .Property(e => e.MaSinhVien)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThanhVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThanhVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<LopSinhVien>()
                .Property(e => e.TenLSH)
                .IsUnicode(false);

            modelBuilder.Entity<LopSinhVien>()
                .HasMany(e => e.ChiTietThanhViens)
                .WithRequired(e => e.LopSinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSinhVien)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasOptional(e => e.ChiTietThanhVien)
                .WithRequired(e => e.SinhVien);
        }
    }
}
