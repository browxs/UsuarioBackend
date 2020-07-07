using APIUsuario.Models;
using Microsoft.EntityFrameworkCore;

namespace APIUsuario.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
