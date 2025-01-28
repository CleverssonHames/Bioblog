using Microsoft.EntityFrameworkCore;

namespace BioBlog.Web.Repositories.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }
    
    public DbSet<Models.Artigo> Artigos { get; set; }
    public DbSet<Models.Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder.HasDefaultSchema("bioblog"));
        
        modelBuilder.Entity<Models.Usuario>()
            .ToTable("usuarios");
        modelBuilder.Entity<Models.Artigo>()
            .ToTable("artigos");
    }
}