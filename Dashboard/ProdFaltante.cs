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
    
    public partial class ProdFaltante
    {
        public string idprodfaltantes { get; set; }
        public System.DateTime fecha { get; set; }
        public int cantidad { get; set; }
        public string condiciones { get; set; }
        public string iddetprodfaltantes { get; set; }
        public string idproveedor { get; set; }
    
        public virtual DetProdFaltante DetProdFaltante { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
