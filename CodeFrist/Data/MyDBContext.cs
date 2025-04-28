using Microsoft.EntityFrameworkCore;

namespace CodeFrist.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
