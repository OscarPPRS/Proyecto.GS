
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
	public static class Consultas
	{
		//Comprueba el login introducido
		public static int comprobarLogin(string usuario, string contrasena)

		{
			using (BDEntities bd = new BDEntities())
			{
				EMPRESAS user = bd.EMPRESAS.Where(s => s.NOM_USUARIO == usuario).FirstOrDefault();

				if (user == null)
				{ return 0; }

				else if (user.PASSWORD == contrasena)
				{ return user.ID_EMPRESA; }

				else return 0;
			}
		}

		//Obtiene la imagen del logo de la empresa usando el ID
		public static string logoEmpresa(int idEmpresa)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.EMPRESAS.Load();

				return (from r in bd.EMPRESAS
						where r.ID_EMPRESA == idEmpresa
						select r.LOGO).FirstOrDefault();
			}
		}

		//Obtiene el nombre de la empresa con el ID
		public static string nombreEmpresa(int id)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.EMPRESAS.Load();

				var empresa = (EMPRESAS)bd.EMPRESAS.Where(x => x.ID_EMPRESA == id).FirstOrDefault();
				return empresa.DES_EMPRESA;
			}
		}

		//Obtiene el id de la empresa con el nombre
		public static int idEmpresa(string nombreEmpresa)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.EMPRESAS.Load();
				var empresa = (EMPRESAS)bd.EMPRESAS.Where(x => x.DES_EMPRESA == nombreEmpresa).FirstOrDefault();
				return empresa.ID_EMPRESA;
			}
		}

		//Obtiene el stock de una referencia
		public static int stock(string cod_referencia)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_REFERENCIAS.Load();
				return (int)(from r in bd.V_REFERENCIAS
							 where r.COD_REFERENCIA == cod_referencia
							 select r.STOCK).First();
			}
		}

		//Genera las etiquetas del material recepcionado
		public static List<string> etiquetasRecepcion(int albaran)
		{
			
				using (BDEntities bd = new BDEntities())
				{
					bd.PALETS.Load();

					return (from r in bd.PALETS
							where r.ALBARAN_RECEPCION == albaran
							select r.ETIQUETA).ToList();
				}			
		}

		//Genera las etiquetas de las picadas al picar
		public static List<string> etiquetasPicking(int codMovimiento)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.PALETS.Load();
				bd.MOVIMIENTOS_PICKING.Load();

				//Consulta para obtener la etiqueta del palet del que hemos extraido, asi como el palet hijo de este
				return (from pal in bd.PALETS

						join mov in bd.MOVIMIENTOS_PICKING
						on pal.COD_PALET equals mov.COD_PALET
						into paletsMovimientos

						from palMov in paletsMovimientos.DefaultIfEmpty()

						where palMov.COD_MOVIMIENTO == codMovimiento
						|| pal.PALET_PADRE == (from pal2 in bd.PALETS

											   join mov2 in bd.MOVIMIENTOS_PICKING
											   on pal2.COD_PALET equals mov2.COD_PALET
											   into paletsMovimientos2

											   from palMov2 in paletsMovimientos2.DefaultIfEmpty()
											   where palMov2.COD_MOVIMIENTO == codMovimiento
											   select pal2.COD_PALET
												).FirstOrDefault()

						select pal.ETIQUETA).ToList();

			}
		}

		//Genera las etiquetas para las gestiones de palets, como juntar o partir
		public static List<string> etiquetasGestionPalets(int codPalet)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.PALETS.Load();

				//Consulta para obtener la etiqueta del palet y su hijo
				return (from pal in bd.PALETS
						where pal.COD_PALET == codPalet
						|| pal.PALET_PADRE == codPalet
						select pal.ETIQUETA).ToList();

			}
		}

		//Obtiene todas las ubicaciones disponibles
		public static List<string> ubicacionesDisponibles()
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.UBICACIONES.Load();

				return (from r in bd.UBICACIONES
						where r.LLENA == false
						select r.DESC_UBICACION).ToList();
			}
		}

		//Obtiene la ubicacion disponible por orden de calles y posiciones
		public static UBICACIONES siguienteUbicacionDisponible()
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.UBICACIONES.Load();
				var datosFiltrados = (from r in bd.UBICACIONES
									  where r.LLENA == false
									  orderby r.COD_UBICACION
									  select r).FirstOrDefault();
				return datosFiltrados;
			}
		}

		//Busca el aviso introducido
		public static RECEPCIONES_CAB buscarAviso(int albaran)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.RECEPCIONES_CAB.Load();
				var datosFiltrados = (from r in bd.RECEPCIONES_CAB
									 where r.ALBARAN == albaran
									 select r).FirstOrDefault();
				return datosFiltrados;
			}
		}

		//Obtiene las lineas para un pedido escrito
		public static List<ORDEN_SALIDA_LIN> obtenerLineasPedido(int peticion)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.ORDEN_SALIDA_LIN.Load();
				var datosFiltrados = (from r in bd.ORDEN_SALIDA_LIN
									  where r.COD_PETICION == peticion
									  select r);
				return datosFiltrados.ToList();
			}


		}	

		//Obtiene la referencia que se ha insertado con esa descripcion
		public static string referenciaInsertada(string descripcionRef)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.REFERENCIAS.Load();

				return (from r in bd.REFERENCIAS
						where r.DES_REFERENCIA == descripcionRef
						orderby r.COD_REFERENCIA descending
						select r.COD_REFERENCIA
						).FirstOrDefault();
			}
		}

		//Obtiene una lista con el codigo de los pedidos asignables
		public static List<int> pickingPedidosAsignables()
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_CAB.Load();
				var datosFiltrados = (from r in bd.V_ORDEN_SALIDA_CAB
									  where r.ESTADO == 1
									  select r.COD_PETICION);
				return datosFiltrados.ToList();
			}
		}

		//OBtiene una lista con el codigo de los pedidos que ya se van a enviar
		public static List<int> salidasCamiones()
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_CAB.Load();
				var datosFiltrados = (from r in bd.V_ORDEN_SALIDA_CAB
									  where r.ESTADO == 4
									  select r.COD_PETICION);
				return datosFiltrados.ToList();
			}
		}



	}
}