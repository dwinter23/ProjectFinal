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
    
    public partial class Inventario
    {
        public string idcabinventario { get; set; }
        public System.DateTime fecha { get; set; }
        public string motivo { get; set; }
        public decimal entrada_total { get; set; }
        public decimal salida_total { get; set; }
        public decimal total { get; set; }
        public string iddetinventario { get; set; }
    
        public virtual DetInventario DetInventario { get; set; }
    }
}
