using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCT.GestionICP.UI
{
	public partial class LineaAviso
	{
		public LineaAviso(int albaran, int cod_linea, string cod_referencia, int cantidadBuena, int cantidadMala, string descripcion_referencia)
		{
			this.albaran = albaran;
			this.cod_linea = cod_linea;
			this.cod_referencia = cod_referencia;
			this.cantidadBuena = cantidadBuena;
			this.cantidadMala = cantidadMala;
			this.descripcion_referencia = descripcion_referencia;
		}

		public int albaran { get; set; }
		public int cod_linea { get; set; }
		public string cod_referencia { get; set; }
		public int cantidadBuena { get; set; }
		public int cantidadMala { get; set; }
		public string descripcion_referencia { get; set; }
	}
}
