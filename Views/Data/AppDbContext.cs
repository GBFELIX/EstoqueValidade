using Microsoft.EntityFrameworkCore;

namespace InventarioValidade.Views.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Produto> Produtos { get; set; }

        }
}
