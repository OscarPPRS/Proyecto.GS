
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
	public static class CargarGrids
	{
		
		//Referencias
		#region

		//Obtiene las referencias para esa empresa
		public static BindingList<V_REFERENCIAS> catalogoReferencias(int idEmpresa)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_REFERENCIAS.Load();
				var datosFiltrados = bd.V_REFERENCIAS.Local.ToBindingList()
				.Where(x => x.ID_EMPRESA == idEmpresa);
				return new BindingList<V_REFERENCIAS>(datosFiltrados.ToList());
			}
		}

		//Obtiene las referencias HABILITADAS de una empresa
		public static BindingList<V_REFERENCIAS> referenciasDisponibles(int idEmpresa)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_REFERENCIAS.Load();
				var datosFiltrados = bd.V_REFERENCIAS.Local.ToBindingList()
				.Where(x => x.ID_EMPRESA == idEmpresa && x.ESTADO == true);
				return new BindingList<V_REFERENCIAS>(datosFiltrados.ToList());
			}
		}
		#endregion

		//Recepciones
		#region

		//Obtiene las cabeceras de las recepciones de una empresa
		public static BindingList<V_RECEPCIONES_CAB> visorRecepcionesCabeceras(int idEmpresa)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.V_RECEPCIONES_CAB.Load();
				var datos = bd.V_RECEPCIONES_CAB.Local
				.Where(x => x.ID_EMPRESA == idEmpresa);
				return new BindingList<V_RECEPCIONES_CAB>(datos.ToList());
			}
		}

		//Obtiene las lineas del albaran introducido
		public static BindingList<V_RECEPCIONES_LIN> visorRecepcionesLineas(int albaran)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_RECEPCIONES_LIN.Load();
				var datosFiltrados = (from r in bd.V_RECEPCIONES_LIN
									  where r.ALBARAN == albaran
									  select r);
				return new BindingList<V_RECEPCIONES_LIN>(datosFiltrados.ToList());
			}
		}

		//Busca el albaran entre los albaranes PENDIENTES y luego carga sus lineas
		public static BindingList<V_RECEPCIONES_LIN> recepcionarAvisos(int albaran)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_RECEPCIONES_CAB.Load();
				int albaranPendiente = (from r in bd.V_RECEPCIONES_CAB
									  where r.ALBARAN == albaran
									  where r.ESTADO == 1
									  select r.ALBARAN).FirstOrDefault();

				bd.V_RECEPCIONES_LIN.Load();
				var datosFiltrados = (from r in bd.V_RECEPCIONES_LIN
									   where r.ALBARAN == albaranPendiente
									   select r);
				return new BindingList<V_RECEPCIONES_LIN>(datosFiltrados.ToList());
			}
		}
		#endregion

		//Palets
		#region

		//Obtiene todos los palets
		public static BindingList<V_PALETS> palets()
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_PALETS.Load();
				var datosFiltrados = (from r in bd.V_PALETS
									  select r);


				return new BindingList<V_PALETS>(datosFiltrados.ToList());
			}
		}

		//Obtiene los palets en la zona de descarga
		public static BindingList<V_PALETS> paletsRecepcionables()
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_PALETS.Load();
				var datosFiltrados = (from r in bd.V_PALETS
										where r.UBICACION == "ZD_01_01"
										select r);

				
				return new BindingList<V_PALETS>(datosFiltrados.ToList());
			}
		}

		//Obtiene los palets libres, para una referencia introducida y que sumado al palet introducido no supere la cantidad máxima.
		public static BindingList<V_PALETS> paletsCombinables(string referencia, int codPaletReceptor)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_PALETS.Load();

				int cantidadPaletReceptor = (int)(from r in bd.V_PALETS
											 where r.COD_PALET == codPaletReceptor
											 select r.CANTIDAD
											).FirstOrDefault();

				var datosFiltrados = (from r in bd.V_PALETS
									  where r.COD_REFERENCIA == referencia
									  where r.COD_ESTADO == 1
									  where r.COD_PALET != codPaletReceptor
									  where (r.CANTIDAD + cantidadPaletReceptor) <= 1000
									  select r);


				return new BindingList<V_PALETS>(datosFiltrados.ToList());
			}
		}

		//Obtiene los palets de una peticion
		public static BindingList<V_PALETS> paletsIncidencias(int peticion)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_PALETS.Load();
				var datosFiltrados = (from r in bd.V_PALETS
									  where r.PETICION_SALIDA == peticion
									  select r);


				return new BindingList<V_PALETS>(datosFiltrados.ToList());
			}
		}	
		#endregion

		//Salidas
		#region

		//Obtiene las cabeceras de un pedido dependiendo de la empresa
		public static BindingList<V_ORDEN_SALIDA_CAB> visorPedidosCabeceras(int idEmpresa)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_CAB.Load();
				var datos = bd.V_ORDEN_SALIDA_CAB.Local
				.Where(x => x.ID_EMPRESA == idEmpresa);
				return new BindingList<V_ORDEN_SALIDA_CAB>(datos.ToList());
			}
		}

		//Obtiene las lineas de un pedido
		public static BindingList<V_ORDEN_SALIDA_LIN> pedidosLineas(int peticion)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_LIN.Load();
				var datosFiltrados = (from r in bd.V_ORDEN_SALIDA_LIN
									  where r.COD_PETICION == peticion
									  select r);
				return new BindingList<V_ORDEN_SALIDA_LIN>(datosFiltrados.ToList());
			}
		}

		//Obtiene los pedidos asignados
		public static BindingList<V_ORDEN_SALIDA_CAB> pickingPedidos()
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_CAB.Load();
				var datosFiltrados = (from r in bd.V_ORDEN_SALIDA_CAB
									  where r.ESTADO == 2
									  select r);
				return new BindingList<V_ORDEN_SALIDA_CAB>(datosFiltrados.ToList());
			}
		}

		//Carga los movimientos de picking para una peticion
		public static BindingList<V_MOVIMIENTOS_PICKING> pickingMovimientos(int peticion)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_MOVIMIENTOS_PICKING.Load();
				var datosFiltrados = (from r in bd.V_MOVIMIENTOS_PICKING
									  where r.COD_PETICION == peticion
									  orderby r.REALIZADO ascending, r.UBICACION ascending
									  select r
									  );
				return new BindingList<V_MOVIMIENTOS_PICKING>(datosFiltrados.ToList());
			}
		}

		//Carga los pedidos ejecutados
		public static BindingList<V_ORDEN_SALIDA_CAB> revisionPedidos()
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_CAB.Load();
				var datosFiltrados = (from r in bd.V_ORDEN_SALIDA_CAB
									  where r.ESTADO == 3
									  select r);
				return new BindingList<V_ORDEN_SALIDA_CAB>(datosFiltrados.ToList());
			}
		}
		
		//Carga las incidencias de pedidos
		public static BindingList<V_ORDEN_SALIDA_INCIDENCIAS> incidenciasPedidosCabeceras()
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_INCIDENCIAS.Load();
				var datos = bd.V_ORDEN_SALIDA_INCIDENCIAS.Local
				.Where(x => x.ESTADO == 7);
				return new BindingList<V_ORDEN_SALIDA_INCIDENCIAS>(datos.ToList());
			}
		}		
		#endregion

	}
}