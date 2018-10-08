
using Microsoft.EntityFrameworkCore;

namespace RentaCongelada.Models
{
    public class ConexionWebRentas : DbContext
    {
        public ConexionWebRentas(DbContextOptions<ConexionWebRentas> options) : base(options) { }
        public DbSet<Usuario> usuarios { get; set; }

    }
}