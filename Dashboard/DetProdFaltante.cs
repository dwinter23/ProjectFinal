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
    
    public partial class DetProdFaltante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetProdFaltante()
        {
            this.ProdFaltantes = new HashSet<ProdFaltante>();
        }
    
        public string iddetprodfaltantes { get; set; }
        public int cantidad { get; set; }
        public string detalle { get; set; }
        public string idproducto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdFaltante> ProdFaltantes { get; set; }
        public virtual Producto Producto { get; set; }
    }
}