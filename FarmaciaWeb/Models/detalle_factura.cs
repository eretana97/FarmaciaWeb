//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmaciaWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_factura
    {
        public int id_detalle_factura { get; set; }
        public Nullable<int> fk_inventario { get; set; }
        public Nullable<int> fk_factura { get; set; }
        public Nullable<int> cantidad { get; set; }
    
        public virtual factura factura { get; set; }
        public virtual inventario inventario { get; set; }
    }
}