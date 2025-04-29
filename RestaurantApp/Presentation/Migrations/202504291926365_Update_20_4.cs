namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_20_4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Nguois", newName: "KhachHang");
            DropForeignKey("dbo.DonHang", "MaKH", "dbo.Nguois");
            DropForeignKey("dbo.TaiKhoan", "maNguoi", "dbo.Nguois");
            DropForeignKey("dbo.NhanVien", "Id", "dbo.Nguois");
            DropPrimaryKey("dbo.KhachHang");
            CreateTable(
                "dbo.Nguois",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ho = c.String(nullable: false, maxLength: 50),
                        Ten = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.KhachHang", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.KhachHang", "Id");
            CreateIndex("dbo.KhachHang", "Id");
            AddForeignKey("dbo.KhachHang", "Id", "dbo.Nguois", "Id");
            AddForeignKey("dbo.DonHang", "MaKH", "dbo.KhachHang", "Id");
            DropColumn("dbo.KhachHang", "Ho");
            DropColumn("dbo.KhachHang", "Ten");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KhachHang", "Ten", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.KhachHang", "Ho", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.DonHang", "MaKH", "dbo.KhachHang");
            DropForeignKey("dbo.KhachHang", "Id", "dbo.Nguois");
            DropIndex("dbo.KhachHang", new[] { "Id" });
            DropPrimaryKey("dbo.KhachHang");
            AlterColumn("dbo.KhachHang", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Nguois");
            AddPrimaryKey("dbo.KhachHang", "Id");
            AddForeignKey("dbo.NhanVien", "Id", "dbo.Nguois", "Id");
            AddForeignKey("dbo.TaiKhoan", "maNguoi", "dbo.Nguois", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DonHang", "MaKH", "dbo.Nguois", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.KhachHang", newName: "Nguois");
        }
    }
}
