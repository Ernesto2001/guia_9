using Microsoft.EntityFrameworkCore;
namespace guia_9.Models
{
    public class equiposDbContext: DbContext
    {
        public equiposDbContext(DbContextOptions<equiposDbContext> options) : base(options) { }

        public DbSet<equipos> equipos { get; set; }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
        public DbSet<estados_equipo> estados_equipo { get; set; }
    }
}
