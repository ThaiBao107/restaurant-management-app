namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_LSGD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LichSuGiaoDich",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KhachHangId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KhachHang", t => t.KhachHangId)
                .Index(t => t.KhachHangId);
            
            AddColumn("dbo.DonHang", "MaHD", c => c.Int(nullable: false));
            AddColumn("dbo.DonHang", "TrangThaiThanhToan", c => c.Int(nullable: false));
            AddColumn("dbo.HoaDons", "HoaDon_Id", c => c.Int());
            CreateIndex("dbo.DonHang", "MaHD");
            CreateIndex("dbo.HoaDons", "HoaDon_Id");
            AddForeignKey("dbo.HoaDons", "HoaDon_Id", "dbo.HoaDons", "Id");
            AddForeignKey("dbo.DonHang", "MaHD", "dbo.HoaDons", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LichSuGiaoDich", "KhachHangId", "dbo.KhachHang");
            DropForeignKey("dbo.DonHang", "MaHD", "dbo.HoaDons");
            DropForeignKey("dbo.HoaDons", "HoaDon_Id", "dbo.HoaDons");
            DropIndex("dbo.LichSuGiaoDich", new[] { "KhachHangId" });
            DropIndex("dbo.HoaDons", new[] { "HoaDon_Id" });
            DropIndex("dbo.DonHang", new[] { "MaHD" });
            DropColumn("dbo.HoaDons", "HoaDon_Id");
            DropColumn("dbo.DonHang", "TrangThaiThanhToan");
            DropColumn("dbo.DonHang", "MaHD");
            DropTable("dbo.LichSuGiaoDich");
        }
    }
}
