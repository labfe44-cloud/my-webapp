using Microsoft.EntityFrameworkCore;

namespace XuanPhu.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Sau này khai báo các bảng ở đây, ví dụ:
        // public DbSet<Tour> Tours { get; set; }
    }
}