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
    
    public partial class ESTADOS_RECEPCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADOS_RECEPCION()
        {
            this.RECEPCIONES_CAB = new HashSet<RECEPCIONES_CAB>();
        }
    
        public int COD_ESTADO { get; set; }
        public string DES_ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEPCIONES_CAB> RECEPCIONES_CAB { get; set; }
    }
}