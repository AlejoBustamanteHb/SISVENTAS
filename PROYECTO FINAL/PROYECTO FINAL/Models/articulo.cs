//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROYECTO_FINAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("articulo")]
    public partial class articulo
    {
        [Key]
        public int idarticulo { get; set; }
        public int idcategoria { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public string estado { get; set; }
        public decimal price { get; set; }
    
        public virtual categoria categoria { get; set; }
    }
}
