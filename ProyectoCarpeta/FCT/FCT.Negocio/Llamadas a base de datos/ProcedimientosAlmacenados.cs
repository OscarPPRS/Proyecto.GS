
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCT.Negocio
{
	public static class ProcedimientosAlmacenados
	{
		public static string referencias(int invoker, string codReferencia,int idEmpresa, string descripcion, decimal precio, string imagen, bool estado)
		{
			using (BDEntities bd = new BDEntities())
			{				
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));

				bd.PA_REFERENCIAS(codReferencia, idEmpresa, descripcion, (double)precio, imagen, estado, invoker, retcode, mensaje);

				return mensaje.ToString();
			}
		}

		public static void recepcionesCabeceras(int invoker,int? albaran, int? estado, int? idEmpresa, DateTime? fechaCreacion, DateTime? fechaLlegada)
		{

			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_RECEPCIONES_CAB(albaran, estado, idEmpresa, fechaCreacion, fechaLlegada, invoker, retcode, mensaje);
			}
		}

		public static void recepcionesLineas(int invoker, int albaran, int codLinea, string codReferencia, int cantidad)
		{
			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_RECEPCIONES_LIN(albaran, codLinea, codReferencia, cantidad, invoker, retcode, mensaje);
			}
		}

		public static void palets(int invoker, string codReferencia, int codEstado, int cantidad, int albaran)
		{

			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_PALETS(codReferencia, codEstado, cantidad, albaran, null, null,invoker, retcode, mensaje);
			}
		}

		public static void enviarCorreo(string destinatario, string asunto, int albaran)
		{

			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_EMAIL_RECEPCIONES(destinatario, asunto, albaran, 0, retcode, mensaje);
			}
		}

		public static void salidasCabeceras(int invoker, int peticion, int estado, int? idEmpresa, string direccionEntrega, 
		string codigoPostal, string poblacion, string provincia, string telefono, DateTime? fechaCreacion)
		{

			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_ORDEN_SALIDA_CAB(peticion, estado, idEmpresa, direccionEntrega,codigoPostal,poblacion,provincia,telefono,fechaCreacion, invoker, retcode, mensaje);
			}
		}

		public static void salidasLineas(int invoker, int peticion, int codLinea, string codReferencia, int cantidad)
		{
			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_ORDEN_SALIDA_LIN(peticion, codLinea, codReferencia, cantidad, invoker, retcode, mensaje);
			}
		}

		public static void movimientosPicking(int invoker, int peticion, int codLinea, int codMovimiento)
		{
			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_MOVIMIENTOS_PICKING(peticion, codLinea, codMovimiento, invoker, retcode, mensaje);
			}
		}

		public static void salidasIncidencias(int invoker, int peticion, string descripcion)
		{
			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_ORDEN_SALIDA_INCIDENCIAS(peticion, descripcion, invoker, retcode, mensaje);
			}
		}

		public static void gestionarPalets(int invoker, int codPalet, string ubicacionNueva, int codPaletAbsorbido, int cantidadPartida)
		{
			using (BDEntities bd = new BDEntities())
			{
				ObjectParameter retcode = new ObjectParameter("RETCODE", typeof(int));
				ObjectParameter mensaje = new ObjectParameter("MENSAJE", typeof(string));
				bd.PA_GESTIONAR_PALETS(codPalet, ubicacionNueva, codPaletAbsorbido, cantidadPartida, invoker, retcode, mensaje);
			}
		}


	}
}