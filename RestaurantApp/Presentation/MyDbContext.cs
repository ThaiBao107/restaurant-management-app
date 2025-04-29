using Presentation.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("CnStr")
        {
        }

        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<BanAn> BanAns { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Nguoi>()
        //    modelBuilder.Entity<Nguoi>()
        //                .HasOne
        //                .WithOne(t => t.Nguoi)
        //                .HasForeignKey<TaiKhoan>(t => t.NguoiId);
        //}
    }
}
