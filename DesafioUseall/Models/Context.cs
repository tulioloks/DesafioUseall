using Microsoft.EntityFrameworkCore;

namespace DesafioUseall.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
           
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
