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
    
    public partial class DetDocVenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetDocVenta()
        {
            this.DocVentas = new HashSet<DocVenta>();
        }
    
        public string iddetdocventa { get; set; }
        public string idproducto { get; set; }
        public int cantidad { get; set; }
        public decimal igb { get; set; }
        public decimal total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocVenta> DocVentas { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
