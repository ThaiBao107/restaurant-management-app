namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test456 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BanAn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SoBan = c.Int(nullable: false),
                        KhuVuc = c.Int(nullable: false),
                        TrangThai = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DonHangBanAn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BanAnId = c.Int(nullable: false),
                        DonHangId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BanAn", t => t.BanAnId, cascadeDelete: true)
                .ForeignKey("dbo.DonHang", t => t.DonHangId, cascadeDelete: true)
                .Index(t => t.BanAnId)
                .Index(t => t.DonHangId);
            
            CreateTable(
                "dbo.DonHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NgayDat = c.DateTime(nullable: false),
                        MaKH = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KhachHang", t => t.MaKH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.TaiKhoan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        maNguoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nguois", t => t.maNguoi, cascadeDelete: true)
                .Index(t => t.maNguoi);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        TongTien = c.Double(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DiemTichLuy = c.Double(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nguois", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Luong = c.Double(nullable: false),
                        CaLam = c.Int(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        NgayVaoLam = c.DateTime(nullable: false),
                        GioiTinh = c.Int(nullable: false),
                        Mail = c.String(maxLength: 100),
                        ChucVu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nguois", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.Nguois", "Ho", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Nguois", "Ten", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Nguois", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Nguois", "Name", c => c.Int(nullable: false));
            DropForeignKey("dbo.NhanVien", "Id", "dbo.Nguois");
            DropForeignKey("dbo.KhachHang", "Id", "dbo.Nguois");
            DropForeignKey("dbo.TaiKhoan", "maNguoi", "dbo.Nguois");
            DropForeignKey("dbo.DonHang", "MaKH", "dbo.KhachHang");
            DropForeignKey("dbo.DonHangBanAn", "DonHangId", "dbo.DonHang");
            DropForeignKey("dbo.DonHangBanAn", "BanAnId", "dbo.BanAn");
            DropIndex("dbo.NhanVien", new[] { "Id" });
            DropIndex("dbo.KhachHang", new[] { "Id" });
            DropIndex("dbo.TaiKhoan", new[] { "maNguoi" });
            DropIndex("dbo.DonHang", new[] { "MaKH" });
            DropIndex("dbo.DonHangBanAn", new[] { "DonHangId" });
            DropIndex("dbo.DonHangBanAn", new[] { "BanAnId" });
            DropColumn("dbo.Nguois", "Ten");
            DropColumn("dbo.Nguois", "Ho");
            DropTable("dbo.NhanVien");
            DropTable("dbo.KhachHang");
            DropTable("dbo.HoaDons");
            DropTable("dbo.TaiKhoan");
            DropTable("dbo.DonHang");
            DropTable("dbo.DonHangBanAn");
            DropTable("dbo.BanAn");
        }
    }
}
