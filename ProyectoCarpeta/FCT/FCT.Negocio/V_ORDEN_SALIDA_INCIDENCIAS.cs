//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FCT.Negocio
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_ORDEN_SALIDA_INCIDENCIAS
    {
        public int ID_INCIDENCIA { get; set; }
        public Nullable<int> COD_PETICION { get; set; }
        public Nullable<int> ID_EMPRESA { get; set; }
        public string DIRECCION_ENTREGA { get; set; }
        public string COD_POSTAL { get; set; }
        public string POBLACION { get; set; }
        public string DES_INCIDENCIA { get; set; }
        public Nullable<int> ESTADO { get; set; }
    }
}
