namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_ThemMyDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Loai",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenLoai = c.String(nullable: false, maxLength: 100),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MonAn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenMonAn = c.String(nullable: false, maxLength: 50),
                        GiaBan = c.Double(nullable: false),
                        DonViTinh = c.Int(nullable: false),
                        GhiChu = c.String(nullable: false, maxLength: 100),
                        LoaiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Loai", t => t.LoaiId, cascadeDelete: true)
                .Index(t => t.LoaiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonAn", "LoaiId", "dbo.Loai");
            DropIndex("dbo.MonAn", new[] { "LoaiId" });
            DropTable("dbo.MonAn");
            DropTable("dbo.Loai");
        }
    }
}
