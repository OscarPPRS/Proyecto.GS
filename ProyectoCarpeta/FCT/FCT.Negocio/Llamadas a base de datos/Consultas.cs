
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
		public static int comprobarLogin(string usuario, string contrasena)

		{
			using (BDEntities bd = new BDEntities())
			{
				USUARIOS user = bd.USUARIOS.Where(s => s.NOM_USUARIO == usuario).FirstOrDefault();

				if (user == null)
				{ return 0; }

				else if (user.PASSWORD == contrasena)
				{ return user.ID_EMPRESA; }

				else return 0;
			}
		}

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

		public static BindingList<V_REFERENCIAS> gridCatalogoReferencias(int idEmpresa)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_REFERENCIAS.Load();
				var datosFiltrados = bd.V_REFERENCIAS.Local.ToBindingList()
				.Where(x => x.ID_EMPRESA == idEmpresa);
				return new BindingList<V_REFERENCIAS>(datosFiltrados.ToList());
			}
		}

		public static BindingList<V_REFERENCIAS> gridReferenciasAvisos(int idEmpresa)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_REFERENCIAS.Load();
				var datosFiltrados = bd.V_REFERENCIAS.Local.ToBindingList()
				.Where(x => x.ID_EMPRESA == idEmpresa && x.ESTADO == true);
				return new BindingList<V_REFERENCIAS>(datosFiltrados.ToList());
			}
		}

		public static BindingList<V_RECEPCIONES_LIN> gridRecepcionarAvisos(int albaran)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.V_RECEPCIONES_LIN.Load();
				var datosFiltrados = bd.V_RECEPCIONES_LIN.Local.ToBindingList()
				.Where(x => x.ALBARAN == albaran);
				return new BindingList<V_RECEPCIONES_LIN>(datosFiltrados.ToList());
			}
		}

		public static string nombreEmpresa(int id)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.EMPRESAS.Load();

				var empresa = (EMPRESAS)bd.EMPRESAS.Where(x => x.ID_EMPRESA == id).FirstOrDefault();
				return empresa.DES_EMPRESA;
			}
		}

		public static int idEmpresa(string nombreEmpresa)
		{
			using (BDEntities bd = new BDEntities())
			{
				bd.EMPRESAS.Load();
				var empresa = (EMPRESAS)bd.EMPRESAS.Where(x => x.DES_EMPRESA == nombreEmpresa).FirstOrDefault();
				return empresa.ID_EMPRESA;
			}
		}

		public static List<string> etiquetas(int albaran)
		{
			
				using (BDEntities bd = new BDEntities())
				{
					bd.PALETS.Load();

					return (from r in bd.PALETS
							where r.ALBARAN_RECEPCION == albaran
							select r.ETIQUETA).ToList();
				}			
		}

		public static string descripcionReferencia(string codReferencia)
		{

			using (BDEntities bd = new BDEntities())
			{
				bd.REFERENCIAS.Load();

				return (from r in bd.REFERENCIAS
						where r.COD_REFERENCIA == codReferencia
						select r.DES_REFERENCIA).ToString();
			}
		}

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




		public static BindingList<V_RECEPCIONES_CAB> gridVisorCab(int idEmpresa)
		{	
			
			using (BDEntities bd = new BDEntities())
			{				
				bd.V_RECEPCIONES_CAB.Load();
				var datos = bd.V_RECEPCIONES_CAB.Local
				.Where(x => x.PROVEEDOR == "XIAOMI");
				return new BindingList<V_RECEPCIONES_CAB>(datos.ToList());
			}
		}

		public static BindingList<V_RECEPCIONES_LIN> gridVisorLin(int albaran)
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


	}
}