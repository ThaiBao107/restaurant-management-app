namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateStaffShift : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staffs", "Shift", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "Shift");
        }
    }
}
