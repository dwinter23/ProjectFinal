//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dashboard
{
    using System;
    using System.Collections.Generic;
    
    public partial class PedidoComp
    {
        public string idpedidocomp { get; set; }
        public string idproveedor { get; set; }
        public System.DateTime fecha { get; set; }
        public string detalle_condiciones { get; set; }
        public string iddetpedidocomp { get; set; }
    
        public virtual DetPedidoComp DetPedidoComp { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
