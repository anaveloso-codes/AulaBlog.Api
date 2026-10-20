using AulaBlog.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AulaBlog.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
