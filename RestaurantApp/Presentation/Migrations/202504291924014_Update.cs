namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
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
                "dbo.DonHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NgayDat = c.DateTime(nullable: false),
                        MaKH = c.Int(nullable: false),
                        BanAn_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nguois", t => t.MaKH, cascadeDelete: true)
                .ForeignKey("dbo.BanAn", t => t.BanAn_Id)
                .Index(t => t.MaKH)
                .Index(t => t.BanAn_Id);
            
            CreateTable(
                "dbo.Nguois",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ho = c.String(nullable: false, maxLength: 50),
                        Ten = c.String(nullable: false, maxLength: 50),
                        DiemTichLuy = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanVien", "Id", "dbo.Nguois");
            DropForeignKey("dbo.DonHang", "BanAn_Id", "dbo.BanAn");
            DropForeignKey("dbo.TaiKhoan", "maNguoi", "dbo.Nguois");
            DropForeignKey("dbo.DonHang", "MaKH", "dbo.Nguois");
            DropIndex("dbo.NhanVien", new[] { "Id" });
            DropIndex("dbo.TaiKhoan", new[] { "maNguoi" });
            DropIndex("dbo.DonHang", new[] { "BanAn_Id" });
            DropIndex("dbo.DonHang", new[] { "MaKH" });
            DropTable("dbo.NhanVien");
            DropTable("dbo.HoaDons");
            DropTable("dbo.TaiKhoan");
            DropTable("dbo.Nguois");
            DropTable("dbo.DonHang");
            DropTable("dbo.BanAn");
        }
    }
}
