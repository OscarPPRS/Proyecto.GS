//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FCT.Negocio
{
    using System;
    using System.Collections.Generic;
    
    public partial class UBICACIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UBICACIONES()
        {
            this.MOVIMIENTOS_PICKING_LOG = new HashSet<MOVIMIENTOS_PICKING_LOG>();
            this.PALETS = new HashSet<PALETS>();
        }
    
        public string COD_UBICACION { get; set; }
        public string DESC_UBICACION { get; set; }
        public string CALLE { get; set; }
        public string POSICION { get; set; }
        public Nullable<bool> LLENA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOVIMIENTOS_PICKING_LOG> MOVIMIENTOS_PICKING_LOG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PALETS> PALETS { get; set; }
    }
}
