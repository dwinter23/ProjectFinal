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
    
    public partial class DetGuiaSalida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetGuiaSalida()
        {
            this.GuiaSalidas = new HashSet<GuiaSalida>();
        }
    
        public string iddetguiasalida { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public string idproducto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuiaSalida> GuiaSalidas { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
