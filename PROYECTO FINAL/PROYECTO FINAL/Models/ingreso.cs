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

    [Table("ingreso")]
    public partial class ingreso
    {
        [Key]
        public int idingreso { get; set; }
        public int idproveedor { get; set; }
        public string tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }
        public string num_comprobante { get; set; }
        public System.DateTime fecha_hora { get; set; }
        public decimal impuesto { get; set; }
        public string estado { get; set; }
        public string detalle_Ingreso { get; set; }
        public decimal valor_ingreso { get; set; }
    
        public virtual persona persona { get; set; }
    }
}
