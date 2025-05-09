namespace DataLayer.Migrations
{
    using RestaurantManagement.DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantManagement.DAL.RestaurantDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RestaurantManagement.DAL.RestaurantDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // Seed Staff nếu chưa tồn tại
            context.Staffs.AddOrUpdate(s => s.Email,
                 new Staff
                 {
                     FirstName = "admin",
                     LastName = "admin",
                     Role = StaffRole.Manager,
                     Sex = Sex.Male,
                     Shift = Shift.Morning,
                     Phone = "0113114115",
                     Email = "admin@gmail.com",
                     HireDate = new DateTime(2025, 4, 30),
                     Salary = 60000000
                 });

            context.SaveChanges(); // Cần save để StaffID được tạo

            // Lấy lại staff vừa thêm (trong trường hợp AddOrUpdate không trả lại object)
            var tung = context.Staffs.FirstOrDefault(s => s.Email == "admin@gmail.com");

            if (tung != null && !context.StaffAccounts.Any(a => a.Username == "admin"))
            {
                context.StaffAccounts.Add(new StaffAccount
                {
                    StaffID = tung.StaffID,
                    Username = "admin",
                    Password = "Admin@123" // ⚠ Trong thực tế cần mã hóa mật khẩu
                });

                context.SaveChanges();
            }

        }
    }
}
