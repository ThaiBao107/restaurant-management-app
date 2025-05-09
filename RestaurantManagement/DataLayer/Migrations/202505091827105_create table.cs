namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        Image = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 10),
                        Email = c.String(maxLength: 100),
                        Address = c.String(maxLength: 255),
                        LoyaltyPoints = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        TableID = c.Int(nullable: false),
                        StaffID = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                        PromotionID = c.Int(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.PromotionID)
                .ForeignKey("dbo.Staffs", t => t.StaffID, cascadeDelete: true)
                .ForeignKey("dbo.Tables", t => t.TableID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.TableID)
                .Index(t => t.StaffID)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Int(nullable: false, identity: true),
                        PromotionName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        DiscountPercentage = c.Double(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PromotionID);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Role = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                        Shift = c.Int(nullable: false),
                        Phone = c.String(maxLength: 10),
                        Email = c.String(maxLength: 100),
                        HireDate = c.DateTime(nullable: false),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        TableID = c.Int(nullable: false, identity: true),
                        TableNumber = c.String(nullable: false, maxLength: 10),
                        Capacity = c.Int(nullable: false),
                        Area = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TableID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        TableID = c.Int(nullable: false),
                        ReservationTime = c.DateTime(nullable: false),
                        NumberOfGuests = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Tables", t => t.TableID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.TableID);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientID = c.Int(nullable: false, identity: true),
                        IngredientName = c.String(nullable: false, maxLength: 100),
                        Unit = c.String(nullable: false, maxLength: 50),
                        StockQuantity = c.Double(nullable: false),
                        SupplierID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IngredientID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID, cascadeDelete: true)
                .Index(t => t.SupplierID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(nullable: false, maxLength: 100),
                        Address = c.String(maxLength: 200),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.StaffAccounts",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        StaffID = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.AccountID)
                .ForeignKey("dbo.Staffs", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.StaffID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaffAccounts", "StaffID", "dbo.Staffs");
            DropForeignKey("dbo.Ingredients", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.Orders", "TableID", "dbo.Tables");
            DropForeignKey("dbo.Reservations", "TableID", "dbo.Tables");
            DropForeignKey("dbo.Reservations", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "StaffID", "dbo.Staffs");
            DropForeignKey("dbo.Orders", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.StaffAccounts", new[] { "StaffID" });
            DropIndex("dbo.Ingredients", new[] { "SupplierID" });
            DropIndex("dbo.Reservations", new[] { "TableID" });
            DropIndex("dbo.Reservations", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "PromotionID" });
            DropIndex("dbo.Orders", new[] { "StaffID" });
            DropIndex("dbo.Orders", new[] { "TableID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.StaffAccounts");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Reservations");
            DropTable("dbo.Tables");
            DropTable("dbo.Staffs");
            DropTable("dbo.Promotions");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
