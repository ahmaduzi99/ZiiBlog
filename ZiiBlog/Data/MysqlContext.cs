using Microsoft.EntityFrameworkCore;
using ZiiBlog.Models;

namespace ZiiBlog.Data
{
    public class MysqlContext :DbContext
    {
        public MysqlContext(DbContextOptions options)
            : base(options) 
        {
            
        }

        public DbSet<post> Posts { get; set; }
    }
}
