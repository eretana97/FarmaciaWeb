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
    
    public partial class detalle_pedido
    {
        public int id_detalle_pedido { get; set; }
        public int fk_medicamento { get; set; }
        public int fk_pedido { get; set; }
    
        public virtual medicamento medicamento { get; set; }
        public virtual pedido pedido { get; set; }
    }
}