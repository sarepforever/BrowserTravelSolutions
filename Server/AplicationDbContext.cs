using BrowserTravel.Server.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BrowserTravel.Server
{
    public class AplicationDbContext:IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Autor>().HasKey(prop => prop.id);

            modelBuilder.Entity<Editorial>().HasKey(prop => prop.id);

            modelBuilder.Entity<Libro>().HasKey(prop => prop.id);

            modelBuilder.Entity<Autor_has_libro>().HasKey(prop =>
            new { prop.autorId, prop.libroId });

            modelBuilder.Entity<Libro>().Property(prop => prop.titulo)
                .HasMaxLength(2000);
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor_has_libro> Autores_Has_Libros { get; set; }
    }
}
