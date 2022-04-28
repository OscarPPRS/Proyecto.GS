﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BDEntities : DbContext
    {
        public BDEntities()
            : base("name=BDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EMPRESAS> EMPRESAS { get; set; }
        public virtual DbSet<ESTADOS_ORDEN_SALIDA> ESTADOS_ORDEN_SALIDA { get; set; }
        public virtual DbSet<ESTADOS_PALETS> ESTADOS_PALETS { get; set; }
        public virtual DbSet<ESTADOS_RECEPCION> ESTADOS_RECEPCION { get; set; }
        public virtual DbSet<INCIDENCIAS_PALETS> INCIDENCIAS_PALETS { get; set; }
        public virtual DbSet<ORDEN_SALIDA_CAB> ORDEN_SALIDA_CAB { get; set; }
        public virtual DbSet<ORDEN_SALIDA_LIN> ORDEN_SALIDA_LIN { get; set; }
        public virtual DbSet<PALETS> PALETS { get; set; }
        public virtual DbSet<RECEPCIONES_CAB> RECEPCIONES_CAB { get; set; }
        public virtual DbSet<RECEPCIONES_LIN> RECEPCIONES_LIN { get; set; }
        public virtual DbSet<REFERENCIAS> REFERENCIAS { get; set; }
        public virtual DbSet<UBICACIONES> UBICACIONES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<V_REFERENCIAS> V_REFERENCIAS { get; set; }
        public virtual DbSet<V_SQL> V_SQL { get; set; }
        public virtual DbSet<V_SQL_FICHEROS> V_SQL_FICHEROS { get; set; }
        public virtual DbSet<V_RECEPCIONES_CAB> V_RECEPCIONES_CAB { get; set; }
        public virtual DbSet<V_RECEPCIONES_LIN> V_RECEPCIONES_LIN { get; set; }
        public virtual DbSet<MOVIMIENTOS_PICKING> MOVIMIENTOS_PICKING { get; set; }
        public virtual DbSet<V_MOVIMIENTOS_PICKING> V_MOVIMIENTOS_PICKING { get; set; }
        public virtual DbSet<V_ORDEN_SALIDA_CAB> V_ORDEN_SALIDA_CAB { get; set; }
    
        [DbFunction("BDEntities", "FN_FECHA_GT")]
        public virtual IQueryable<FN_FECHA_GT_Result> FN_FECHA_GT(Nullable<System.DateTime> fECHA, string tIME_ZONE_DESTINO)
        {
            var fECHAParameter = fECHA.HasValue ?
                new ObjectParameter("FECHA", fECHA) :
                new ObjectParameter("FECHA", typeof(System.DateTime));
    
            var tIME_ZONE_DESTINOParameter = tIME_ZONE_DESTINO != null ?
                new ObjectParameter("TIME_ZONE_DESTINO", tIME_ZONE_DESTINO) :
                new ObjectParameter("TIME_ZONE_DESTINO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FN_FECHA_GT_Result>("[BDEntities].[FN_FECHA_GT](@FECHA, @TIME_ZONE_DESTINO)", fECHAParameter, tIME_ZONE_DESTINOParameter);
        }
    
        public virtual int PA_ENVIAR_DBMAIL(string dESTINATARIOS, string tEXTO_EMAIL, string aSUNTO_EMAIL, string pERFIL_EMAIL, string dESTINATARIOS_CC, string dESTINATARIOS_CCO, string fORMATO_EMAIL, string iMPORTANCIA_EMAIL, string cONFIDENCIALIDAD, string aRCHIVOS_ADJUNTOS, Nullable<bool> oCULTAR_TEXTO, string rEPLY_TO)
        {
            var dESTINATARIOSParameter = dESTINATARIOS != null ?
                new ObjectParameter("DESTINATARIOS", dESTINATARIOS) :
                new ObjectParameter("DESTINATARIOS", typeof(string));
    
            var tEXTO_EMAILParameter = tEXTO_EMAIL != null ?
                new ObjectParameter("TEXTO_EMAIL", tEXTO_EMAIL) :
                new ObjectParameter("TEXTO_EMAIL", typeof(string));
    
            var aSUNTO_EMAILParameter = aSUNTO_EMAIL != null ?
                new ObjectParameter("ASUNTO_EMAIL", aSUNTO_EMAIL) :
                new ObjectParameter("ASUNTO_EMAIL", typeof(string));
    
            var pERFIL_EMAILParameter = pERFIL_EMAIL != null ?
                new ObjectParameter("PERFIL_EMAIL", pERFIL_EMAIL) :
                new ObjectParameter("PERFIL_EMAIL", typeof(string));
    
            var dESTINATARIOS_CCParameter = dESTINATARIOS_CC != null ?
                new ObjectParameter("DESTINATARIOS_CC", dESTINATARIOS_CC) :
                new ObjectParameter("DESTINATARIOS_CC", typeof(string));
    
            var dESTINATARIOS_CCOParameter = dESTINATARIOS_CCO != null ?
                new ObjectParameter("DESTINATARIOS_CCO", dESTINATARIOS_CCO) :
                new ObjectParameter("DESTINATARIOS_CCO", typeof(string));
    
            var fORMATO_EMAILParameter = fORMATO_EMAIL != null ?
                new ObjectParameter("FORMATO_EMAIL", fORMATO_EMAIL) :
                new ObjectParameter("FORMATO_EMAIL", typeof(string));
    
            var iMPORTANCIA_EMAILParameter = iMPORTANCIA_EMAIL != null ?
                new ObjectParameter("IMPORTANCIA_EMAIL", iMPORTANCIA_EMAIL) :
                new ObjectParameter("IMPORTANCIA_EMAIL", typeof(string));
    
            var cONFIDENCIALIDADParameter = cONFIDENCIALIDAD != null ?
                new ObjectParameter("CONFIDENCIALIDAD", cONFIDENCIALIDAD) :
                new ObjectParameter("CONFIDENCIALIDAD", typeof(string));
    
            var aRCHIVOS_ADJUNTOSParameter = aRCHIVOS_ADJUNTOS != null ?
                new ObjectParameter("ARCHIVOS_ADJUNTOS", aRCHIVOS_ADJUNTOS) :
                new ObjectParameter("ARCHIVOS_ADJUNTOS", typeof(string));
    
            var oCULTAR_TEXTOParameter = oCULTAR_TEXTO.HasValue ?
                new ObjectParameter("OCULTAR_TEXTO", oCULTAR_TEXTO) :
                new ObjectParameter("OCULTAR_TEXTO", typeof(bool));
    
            var rEPLY_TOParameter = rEPLY_TO != null ?
                new ObjectParameter("REPLY_TO", rEPLY_TO) :
                new ObjectParameter("REPLY_TO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ENVIAR_DBMAIL", dESTINATARIOSParameter, tEXTO_EMAILParameter, aSUNTO_EMAILParameter, pERFIL_EMAILParameter, dESTINATARIOS_CCParameter, dESTINATARIOS_CCOParameter, fORMATO_EMAILParameter, iMPORTANCIA_EMAILParameter, cONFIDENCIALIDADParameter, aRCHIVOS_ADJUNTOSParameter, oCULTAR_TEXTOParameter, rEPLY_TOParameter);
        }
    
        public virtual ObjectResult<string> PA_INF_TABLA(string objname)
        {
            var objnameParameter = objname != null ?
                new ObjectParameter("objname", objname) :
                new ObjectParameter("objname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INF_TABLA", objnameParameter);
        }
    
        public virtual int PA_REFERENCIAS(string cOD_REFERENCIA, Nullable<int> iD_EMPRESA, string dES_REFERENCIA, Nullable<double> pRECIO, string iMAGEN, Nullable<bool> eSTADO, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cOD_REFERENCIAParameter = cOD_REFERENCIA != null ?
                new ObjectParameter("COD_REFERENCIA", cOD_REFERENCIA) :
                new ObjectParameter("COD_REFERENCIA", typeof(string));
    
            var iD_EMPRESAParameter = iD_EMPRESA.HasValue ?
                new ObjectParameter("ID_EMPRESA", iD_EMPRESA) :
                new ObjectParameter("ID_EMPRESA", typeof(int));
    
            var dES_REFERENCIAParameter = dES_REFERENCIA != null ?
                new ObjectParameter("DES_REFERENCIA", dES_REFERENCIA) :
                new ObjectParameter("DES_REFERENCIA", typeof(string));
    
            var pRECIOParameter = pRECIO.HasValue ?
                new ObjectParameter("PRECIO", pRECIO) :
                new ObjectParameter("PRECIO", typeof(double));
    
            var iMAGENParameter = iMAGEN != null ?
                new ObjectParameter("IMAGEN", iMAGEN) :
                new ObjectParameter("IMAGEN", typeof(string));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(bool));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_REFERENCIAS", cOD_REFERENCIAParameter, iD_EMPRESAParameter, dES_REFERENCIAParameter, pRECIOParameter, iMAGENParameter, eSTADOParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_SQLD(string nOMBRE_PA)
        {
            var nOMBRE_PAParameter = nOMBRE_PA != null ?
                new ObjectParameter("NOMBRE_PA", nOMBRE_PA) :
                new ObjectParameter("NOMBRE_PA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_SQLD", nOMBRE_PAParameter);
        }
    
        public virtual int PAB(string tEXTO_BUSCAR, string tEXTO_BUSCAR_2, string tEXTO_BUSCAR_3, string tEXTO_BUSCAR_4, string tEXTO_BUSCAR_5, Nullable<int> iNVOKER)
        {
            var tEXTO_BUSCARParameter = tEXTO_BUSCAR != null ?
                new ObjectParameter("TEXTO_BUSCAR", tEXTO_BUSCAR) :
                new ObjectParameter("TEXTO_BUSCAR", typeof(string));
    
            var tEXTO_BUSCAR_2Parameter = tEXTO_BUSCAR_2 != null ?
                new ObjectParameter("TEXTO_BUSCAR_2", tEXTO_BUSCAR_2) :
                new ObjectParameter("TEXTO_BUSCAR_2", typeof(string));
    
            var tEXTO_BUSCAR_3Parameter = tEXTO_BUSCAR_3 != null ?
                new ObjectParameter("TEXTO_BUSCAR_3", tEXTO_BUSCAR_3) :
                new ObjectParameter("TEXTO_BUSCAR_3", typeof(string));
    
            var tEXTO_BUSCAR_4Parameter = tEXTO_BUSCAR_4 != null ?
                new ObjectParameter("TEXTO_BUSCAR_4", tEXTO_BUSCAR_4) :
                new ObjectParameter("TEXTO_BUSCAR_4", typeof(string));
    
            var tEXTO_BUSCAR_5Parameter = tEXTO_BUSCAR_5 != null ?
                new ObjectParameter("TEXTO_BUSCAR_5", tEXTO_BUSCAR_5) :
                new ObjectParameter("TEXTO_BUSCAR_5", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PAB", tEXTO_BUSCARParameter, tEXTO_BUSCAR_2Parameter, tEXTO_BUSCAR_3Parameter, tEXTO_BUSCAR_4Parameter, tEXTO_BUSCAR_5Parameter, iNVOKERParameter);
        }
    
        public virtual int PACE(string bUSQUEDA, Nullable<int> iNVOKER)
        {
            var bUSQUEDAParameter = bUSQUEDA != null ?
                new ObjectParameter("BUSQUEDA", bUSQUEDA) :
                new ObjectParameter("BUSQUEDA", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PACE", bUSQUEDAParameter, iNVOKERParameter);
        }
    
        public virtual int PAF(string eNTRADA)
        {
            var eNTRADAParameter = eNTRADA != null ?
                new ObjectParameter("ENTRADA", eNTRADA) :
                new ObjectParameter("ENTRADA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PAF", eNTRADAParameter);
        }
    
        public virtual ObjectResult<string> PAH(string tEXTO)
        {
            var tEXTOParameter = tEXTO != null ?
                new ObjectParameter("TEXTO", tEXTO) :
                new ObjectParameter("TEXTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PAH", tEXTOParameter);
        }
    
        public virtual int PAP(string nOMBRE_PA)
        {
            var nOMBRE_PAParameter = nOMBRE_PA != null ?
                new ObjectParameter("NOMBRE_PA", nOMBRE_PA) :
                new ObjectParameter("NOMBRE_PA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PAP", nOMBRE_PAParameter);
        }
    
        public virtual int PASE(string tABLA)
        {
            var tABLAParameter = tABLA != null ?
                new ObjectParameter("TABLA", tABLA) :
                new ObjectParameter("TABLA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PASE", tABLAParameter);
        }
    
        public virtual ObjectResult<PAT_Result> PAT(string tABLA)
        {
            var tABLAParameter = tABLA != null ?
                new ObjectParameter("TABLA", tABLA) :
                new ObjectParameter("TABLA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PAT_Result>("PAT", tABLAParameter);
        }
    
        public virtual int PA_INSERTAR_RECEPCIONES_CAB(Nullable<int> aLBARAN, Nullable<int> eSTADO, string pROVEEDOR, Nullable<System.DateTime> fECH_CREACION, Nullable<System.DateTime> fECH_LLEGADA, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var aLBARANParameter = aLBARAN.HasValue ?
                new ObjectParameter("ALBARAN", aLBARAN) :
                new ObjectParameter("ALBARAN", typeof(int));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(int));
    
            var pROVEEDORParameter = pROVEEDOR != null ?
                new ObjectParameter("PROVEEDOR", pROVEEDOR) :
                new ObjectParameter("PROVEEDOR", typeof(string));
    
            var fECH_CREACIONParameter = fECH_CREACION.HasValue ?
                new ObjectParameter("FECH_CREACION", fECH_CREACION) :
                new ObjectParameter("FECH_CREACION", typeof(System.DateTime));
    
            var fECH_LLEGADAParameter = fECH_LLEGADA.HasValue ?
                new ObjectParameter("FECH_LLEGADA", fECH_LLEGADA) :
                new ObjectParameter("FECH_LLEGADA", typeof(System.DateTime));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERTAR_RECEPCIONES_CAB", aLBARANParameter, eSTADOParameter, pROVEEDORParameter, fECH_CREACIONParameter, fECH_LLEGADAParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_INSERTAR_RECEPCIONES_LIN(Nullable<int> aLBARAN, Nullable<int> cOD_LINEA, string cOD_REFERENCIA, Nullable<int> cANTIDAD, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var aLBARANParameter = aLBARAN.HasValue ?
                new ObjectParameter("ALBARAN", aLBARAN) :
                new ObjectParameter("ALBARAN", typeof(int));
    
            var cOD_LINEAParameter = cOD_LINEA.HasValue ?
                new ObjectParameter("COD_LINEA", cOD_LINEA) :
                new ObjectParameter("COD_LINEA", typeof(int));
    
            var cOD_REFERENCIAParameter = cOD_REFERENCIA != null ?
                new ObjectParameter("COD_REFERENCIA", cOD_REFERENCIA) :
                new ObjectParameter("COD_REFERENCIA", typeof(string));
    
            var cANTIDADParameter = cANTIDAD.HasValue ?
                new ObjectParameter("CANTIDAD", cANTIDAD) :
                new ObjectParameter("CANTIDAD", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERTAR_RECEPCIONES_LIN", aLBARANParameter, cOD_LINEAParameter, cOD_REFERENCIAParameter, cANTIDADParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_INSERTAR_PALETS(string cOD_REFERENCIA, Nullable<int> cOD_ESTADO, Nullable<int> cANTIDAD, Nullable<int> aLBARAN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cOD_REFERENCIAParameter = cOD_REFERENCIA != null ?
                new ObjectParameter("COD_REFERENCIA", cOD_REFERENCIA) :
                new ObjectParameter("COD_REFERENCIA", typeof(string));
    
            var cOD_ESTADOParameter = cOD_ESTADO.HasValue ?
                new ObjectParameter("COD_ESTADO", cOD_ESTADO) :
                new ObjectParameter("COD_ESTADO", typeof(int));
    
            var cANTIDADParameter = cANTIDAD.HasValue ?
                new ObjectParameter("CANTIDAD", cANTIDAD) :
                new ObjectParameter("CANTIDAD", typeof(int));
    
            var aLBARANParameter = aLBARAN.HasValue ?
                new ObjectParameter("ALBARAN", aLBARAN) :
                new ObjectParameter("ALBARAN", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERTAR_PALETS", cOD_REFERENCIAParameter, cOD_ESTADOParameter, cANTIDADParameter, aLBARANParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_GENERAR_ETIQUETA(string cOD_REFERENCIA, Nullable<int> cOD_PALET, Nullable<int> cANTIDAD, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cOD_REFERENCIAParameter = cOD_REFERENCIA != null ?
                new ObjectParameter("COD_REFERENCIA", cOD_REFERENCIA) :
                new ObjectParameter("COD_REFERENCIA", typeof(string));
    
            var cOD_PALETParameter = cOD_PALET.HasValue ?
                new ObjectParameter("COD_PALET", cOD_PALET) :
                new ObjectParameter("COD_PALET", typeof(int));
    
            var cANTIDADParameter = cANTIDAD.HasValue ?
                new ObjectParameter("CANTIDAD", cANTIDAD) :
                new ObjectParameter("CANTIDAD", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GENERAR_ETIQUETA", cOD_REFERENCIAParameter, cOD_PALETParameter, cANTIDADParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_RECEPCIONES_CAB(Nullable<int> aLBARAN, Nullable<int> eSTADO, string pROVEEDOR, Nullable<System.DateTime> fECH_CREACION, Nullable<System.DateTime> fECH_LLEGADA, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var aLBARANParameter = aLBARAN.HasValue ?
                new ObjectParameter("ALBARAN", aLBARAN) :
                new ObjectParameter("ALBARAN", typeof(int));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(int));
    
            var pROVEEDORParameter = pROVEEDOR != null ?
                new ObjectParameter("PROVEEDOR", pROVEEDOR) :
                new ObjectParameter("PROVEEDOR", typeof(string));
    
            var fECH_CREACIONParameter = fECH_CREACION.HasValue ?
                new ObjectParameter("FECH_CREACION", fECH_CREACION) :
                new ObjectParameter("FECH_CREACION", typeof(System.DateTime));
    
            var fECH_LLEGADAParameter = fECH_LLEGADA.HasValue ?
                new ObjectParameter("FECH_LLEGADA", fECH_LLEGADA) :
                new ObjectParameter("FECH_LLEGADA", typeof(System.DateTime));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_RECEPCIONES_CAB", aLBARANParameter, eSTADOParameter, pROVEEDORParameter, fECH_CREACIONParameter, fECH_LLEGADAParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_RECEPCIONES_LIN(Nullable<int> aLBARAN, Nullable<int> cOD_LINEA, string cOD_REFERENCIA, Nullable<int> cANTIDAD, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var aLBARANParameter = aLBARAN.HasValue ?
                new ObjectParameter("ALBARAN", aLBARAN) :
                new ObjectParameter("ALBARAN", typeof(int));
    
            var cOD_LINEAParameter = cOD_LINEA.HasValue ?
                new ObjectParameter("COD_LINEA", cOD_LINEA) :
                new ObjectParameter("COD_LINEA", typeof(int));
    
            var cOD_REFERENCIAParameter = cOD_REFERENCIA != null ?
                new ObjectParameter("COD_REFERENCIA", cOD_REFERENCIA) :
                new ObjectParameter("COD_REFERENCIA", typeof(string));
    
            var cANTIDADParameter = cANTIDAD.HasValue ?
                new ObjectParameter("CANTIDAD", cANTIDAD) :
                new ObjectParameter("CANTIDAD", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_RECEPCIONES_LIN", aLBARANParameter, cOD_LINEAParameter, cOD_REFERENCIAParameter, cANTIDADParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_PALETS(string cOD_REFERENCIA, Nullable<int> cOD_ESTADO, Nullable<int> cANTIDAD, Nullable<int> aLBARAN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cOD_REFERENCIAParameter = cOD_REFERENCIA != null ?
                new ObjectParameter("COD_REFERENCIA", cOD_REFERENCIA) :
                new ObjectParameter("COD_REFERENCIA", typeof(string));
    
            var cOD_ESTADOParameter = cOD_ESTADO.HasValue ?
                new ObjectParameter("COD_ESTADO", cOD_ESTADO) :
                new ObjectParameter("COD_ESTADO", typeof(int));
    
            var cANTIDADParameter = cANTIDAD.HasValue ?
                new ObjectParameter("CANTIDAD", cANTIDAD) :
                new ObjectParameter("CANTIDAD", typeof(int));
    
            var aLBARANParameter = aLBARAN.HasValue ?
                new ObjectParameter("ALBARAN", aLBARAN) :
                new ObjectParameter("ALBARAN", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_PALETS", cOD_REFERENCIAParameter, cOD_ESTADOParameter, cANTIDADParameter, aLBARANParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_EMAIL_RECEPCIONES(string dESTINATARIOS, string aSUNTO_EMAIL, Nullable<int> aLBARAN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var dESTINATARIOSParameter = dESTINATARIOS != null ?
                new ObjectParameter("DESTINATARIOS", dESTINATARIOS) :
                new ObjectParameter("DESTINATARIOS", typeof(string));
    
            var aSUNTO_EMAILParameter = aSUNTO_EMAIL != null ?
                new ObjectParameter("ASUNTO_EMAIL", aSUNTO_EMAIL) :
                new ObjectParameter("ASUNTO_EMAIL", typeof(string));
    
            var aLBARANParameter = aLBARAN.HasValue ?
                new ObjectParameter("ALBARAN", aLBARAN) :
                new ObjectParameter("ALBARAN", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_EMAIL_RECEPCIONES", dESTINATARIOSParameter, aSUNTO_EMAILParameter, aLBARANParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_ORDEN_SALIDA_CAB(Nullable<int> cOD_PETICION, Nullable<int> eSTADO, string nOMBRE_CLIENTE, string dIRECCION_ENTREGA, string cOD_POSTAL, string pOBLACION, string pROVINCIA, string tELEFONO, Nullable<System.DateTime> fECH_CREACION, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cOD_PETICIONParameter = cOD_PETICION.HasValue ?
                new ObjectParameter("COD_PETICION", cOD_PETICION) :
                new ObjectParameter("COD_PETICION", typeof(int));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(int));
    
            var nOMBRE_CLIENTEParameter = nOMBRE_CLIENTE != null ?
                new ObjectParameter("NOMBRE_CLIENTE", nOMBRE_CLIENTE) :
                new ObjectParameter("NOMBRE_CLIENTE", typeof(string));
    
            var dIRECCION_ENTREGAParameter = dIRECCION_ENTREGA != null ?
                new ObjectParameter("DIRECCION_ENTREGA", dIRECCION_ENTREGA) :
                new ObjectParameter("DIRECCION_ENTREGA", typeof(string));
    
            var cOD_POSTALParameter = cOD_POSTAL != null ?
                new ObjectParameter("COD_POSTAL", cOD_POSTAL) :
                new ObjectParameter("COD_POSTAL", typeof(string));
    
            var pOBLACIONParameter = pOBLACION != null ?
                new ObjectParameter("POBLACION", pOBLACION) :
                new ObjectParameter("POBLACION", typeof(string));
    
            var pROVINCIAParameter = pROVINCIA != null ?
                new ObjectParameter("PROVINCIA", pROVINCIA) :
                new ObjectParameter("PROVINCIA", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var fECH_CREACIONParameter = fECH_CREACION.HasValue ?
                new ObjectParameter("FECH_CREACION", fECH_CREACION) :
                new ObjectParameter("FECH_CREACION", typeof(System.DateTime));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ORDEN_SALIDA_CAB", cOD_PETICIONParameter, eSTADOParameter, nOMBRE_CLIENTEParameter, dIRECCION_ENTREGAParameter, cOD_POSTALParameter, pOBLACIONParameter, pROVINCIAParameter, tELEFONOParameter, fECH_CREACIONParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_ORDEN_SALIDA_LIN(Nullable<int> cOD_PETICION, Nullable<int> cOD_LINEA, string cOD_REFERENCIA, Nullable<int> cANTIDAD, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cOD_PETICIONParameter = cOD_PETICION.HasValue ?
                new ObjectParameter("COD_PETICION", cOD_PETICION) :
                new ObjectParameter("COD_PETICION", typeof(int));
    
            var cOD_LINEAParameter = cOD_LINEA.HasValue ?
                new ObjectParameter("COD_LINEA", cOD_LINEA) :
                new ObjectParameter("COD_LINEA", typeof(int));
    
            var cOD_REFERENCIAParameter = cOD_REFERENCIA != null ?
                new ObjectParameter("COD_REFERENCIA", cOD_REFERENCIA) :
                new ObjectParameter("COD_REFERENCIA", typeof(string));
    
            var cANTIDADParameter = cANTIDAD.HasValue ?
                new ObjectParameter("CANTIDAD", cANTIDAD) :
                new ObjectParameter("CANTIDAD", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_ORDEN_SALIDA_LIN", cOD_PETICIONParameter, cOD_LINEAParameter, cOD_REFERENCIAParameter, cANTIDADParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_MOVIMIENTOS_PICKING(Nullable<int> cOD_PETICION, Nullable<int> cOD_PALET, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var cOD_PETICIONParameter = cOD_PETICION.HasValue ?
                new ObjectParameter("COD_PETICION", cOD_PETICION) :
                new ObjectParameter("COD_PETICION", typeof(int));
    
            var cOD_PALETParameter = cOD_PALET.HasValue ?
                new ObjectParameter("COD_PALET", cOD_PALET) :
                new ObjectParameter("COD_PALET", typeof(int));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_MOVIMIENTOS_PICKING", cOD_PETICIONParameter, cOD_PALETParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    }
}
