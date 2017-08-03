using Microsoft.AspNet.Identity.EntityFramework;

namespace PROYECTO_FINAL.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.categoria> categorias { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.articulo> articuloes { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.ingreso> ingresoes { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.venta> ventas { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.persona> personas { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.domicilio> domicilios { get; set; }
    }
}