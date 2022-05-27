using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCT.Negocio
{
	[Serializable]

	public partial class LineaPedido
	{
		public LineaPedido(int cod_peticion, int cod_linea, string cod_referencia, int cantidad, string descripcion_referencia)
		{
			this.cod_peticion = cod_peticion;
			this.cod_linea = cod_linea;
			this.cod_referencia = cod_referencia;
			this.cantidad = cantidad;
			this.descripcion_referencia = descripcion_referencia;
		}

		public int cod_peticion { get; set; }
		public int cod_linea { get; set; }
		public string cod_referencia { get; set; }
		public int cantidad { get; set; }
		public string descripcion_referencia { get; set; }

	}
}
