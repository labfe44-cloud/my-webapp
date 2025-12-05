using Microsoft.EntityFrameworkCore;

namespace XuanPhu.Web.Data
{
    public class XuanPhuDbContext : DbContext
    {
        public XuanPhuDbContext(DbContextOptions<XuanPhuDbContext> options) : base(options)
        {
        }

        // Sau này khai báo các bảng ở đây, ví dụ:
        // public DbSet<Tour> Tours { get; set; }
    }
}