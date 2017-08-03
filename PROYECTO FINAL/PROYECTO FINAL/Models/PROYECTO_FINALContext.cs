using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PROYECTO_FINAL.Models
{
    public class PROYECTO_FINALContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PROYECTO_FINALContext() : base("name=PROYECTO_FINALContext")
        {
        }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.categoria> categorias { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.articulo> articuloes { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.venta> ventas { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.persona> personas { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.ingreso> ingresoes { get; set; }

        public System.Data.Entity.DbSet<PROYECTO_FINAL.Models.domicilio> domicilios { get; set; }

        
    }
}
