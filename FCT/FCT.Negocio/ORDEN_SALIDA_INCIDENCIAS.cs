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
    
    public partial class ORDEN_SALIDA_INCIDENCIAS
    {
        public int ID_INCIDENCIA { get; set; }
        public Nullable<int> COD_PETICION { get; set; }
        public string DES_INCIDENCIA { get; set; }
        public Nullable<bool> RESUELTA { get; set; }
    
        public virtual ORDEN_SALIDA_CAB ORDEN_SALIDA_CAB { get; set; }
    }
}