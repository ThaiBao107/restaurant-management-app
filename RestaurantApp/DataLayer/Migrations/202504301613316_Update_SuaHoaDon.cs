namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_SuaHoaDon : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HoaDon", "HoaDon_Id", "dbo.HoaDon");
            DropIndex("dbo.HoaDon", new[] { "HoaDon_Id" });
            DropColumn("dbo.HoaDon", "HoaDon_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HoaDon", "HoaDon_Id", c => c.Int());
            CreateIndex("dbo.HoaDon", "HoaDon_Id");
            AddForeignKey("dbo.HoaDon", "HoaDon_Id", "dbo.HoaDon", "Id");
        }
    }
}
