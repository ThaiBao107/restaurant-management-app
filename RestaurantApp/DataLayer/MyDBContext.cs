using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(): base("name=cnstr")
        {
            
        }
        public DbSet<BanAn> BanAns { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<DonHangBanAn> DonHangBanAns { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        public DbSet<LichSuGiaoDich> LichSuGiaoDichs { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<test> tests { get; set; }
    }
}
