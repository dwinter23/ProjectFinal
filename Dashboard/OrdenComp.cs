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
    
    public partial class OrdenComp
    {
        public string idordencomp { get; set; }
        public string idproveedor { get; set; }
        public System.DateTime fecha_requerida { get; set; }
        public string lugar_entrega { get; set; }
        public string iddetordencomp { get; set; }
    
        public virtual DetOrdenComp DetOrdenComp { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
