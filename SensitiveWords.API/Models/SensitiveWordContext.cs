using Microsoft.EntityFrameworkCore;

namespace SensitiveWords.API.Models
{
    public class SensitiveWordContext : DbContext
    {
        public SensitiveWordContext(DbContextOptions<SensitiveWordContext> options)
            : base(options)
        {
        }
        public DbSet<SensitiveWord> SensitiveWords { get; set; }
    }
}