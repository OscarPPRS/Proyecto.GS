
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

		public static BindingList<V_REFERENCIAS> referenciasAvisos(int idEmpresa)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_REFERENCIAS.Load();
				var datosFiltrados = bd.V_REFERENCIAS.Local.ToBindingList()
				.Where(x => x.ID_EMPRESA == idEmpresa && x.ESTADO == true);
				return new BindingList<V_REFERENCIAS>(datosFiltrados.ToList());
			}
		}

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

		public static BindingList<V_PALETS> paletsRecepcion()
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

		public static BindingList<V_PALETS> paletsJuntar(string referencia, int codPaletReceptor)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_PALETS.Load();
				var datosFiltrados = (from r in bd.V_PALETS
									  where r.COD_REFERENCIA == referencia
									  where r.COD_ESTADO == 1
									  where r.COD_PALET != codPaletReceptor
									  select r);


				return new BindingList<V_PALETS>(datosFiltrados.ToList());
			}
		}

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

		public static BindingList<V_RECEPCIONES_CAB> visorRecepcionesCab(int idEmpresa)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.V_RECEPCIONES_CAB.Load();
				var datos = bd.V_RECEPCIONES_CAB.Local
				.Where(x => x.ID_EMPRESA == idEmpresa);
				return new BindingList<V_RECEPCIONES_CAB>(datos.ToList());
			}
		}

		public static BindingList<V_RECEPCIONES_LIN> visorRecepcionesLin(int albaran)
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

		public static BindingList<V_MOVIMIENTOS_PICKING> pickingMovimientos(int peticion)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_MOVIMIENTOS_PICKING.Load();
				var datosFiltrados = (from r in bd.V_MOVIMIENTOS_PICKING
									  where r.COD_PETICION == peticion			  
									  orderby r.UBICACION
									  orderby r.REALIZADO ascending
									  select r
									  );
				return new BindingList<V_MOVIMIENTOS_PICKING>(datosFiltrados.ToList());
			}
		}

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

		public static BindingList<V_ORDEN_SALIDA_LIN> revisionPedidosLineas(int peticion)
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

		public static BindingList<V_ORDEN_SALIDA_CAB> visorSalidasCab(int idEmpresa)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_CAB.Load();
				var datos = bd.V_ORDEN_SALIDA_CAB.Local
				.Where(x => x.ID_EMPRESA == idEmpresa);
				return new BindingList<V_ORDEN_SALIDA_CAB>(datos.ToList());
			}
		}

		public static BindingList<V_ORDEN_SALIDA_INCIDENCIAS> incidenciasSalidasCab()
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.V_ORDEN_SALIDA_INCIDENCIAS.Load();
				var datos = bd.V_ORDEN_SALIDA_INCIDENCIAS.Local
				.Where(x => x.ESTADO == 7);
				return new BindingList<V_ORDEN_SALIDA_INCIDENCIAS>(datos.ToList());
			}
		}

		public static BindingList<V_ORDEN_SALIDA_LIN> visorSalidasLin(int peticion)
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

	}
}