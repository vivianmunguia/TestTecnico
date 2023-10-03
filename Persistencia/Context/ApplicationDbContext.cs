using Microsoft.EntityFrameworkCore;
using TestTecnico.Dominio.Models;

namespace TestTecnico.Persistencia.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioProducto> UsuarioProducto { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
