namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTableArea : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tables", "Area", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tables", "Area");
        }
    }
}
