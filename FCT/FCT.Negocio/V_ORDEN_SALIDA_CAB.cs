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
    
    public partial class V_ORDEN_SALIDA_CAB
    {
        public int COD_PETICION { get; set; }
        public Nullable<int> ESTADO { get; set; }
        public string DES_ESTADO { get; set; }
        public Nullable<int> ID_EMPRESA { get; set; }
        public string DES_EMPRESA { get; set; }
        public string DIRECCION_ENTREGA { get; set; }
        public string COD_POSTAL { get; set; }
        public string POBLACION { get; set; }
        public string PROVINCIA { get; set; }
        public string TELEFONO { get; set; }
        public Nullable<System.DateTime> FECH_CREACION { get; set; }
        public Nullable<int> CANTIDAD_LINEAS { get; set; }
    }
}
