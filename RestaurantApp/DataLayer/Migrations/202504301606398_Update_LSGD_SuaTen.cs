namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_LSGD_SuaTen : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.HoaDons", newName: "HoaDon");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.HoaDon", newName: "HoaDons");
        }
    }
}
