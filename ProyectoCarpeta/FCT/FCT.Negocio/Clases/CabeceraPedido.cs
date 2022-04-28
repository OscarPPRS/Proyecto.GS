using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCT.Negocio
{[Serializable]
	public partial class CabeceraPedido
	{

		public CabeceraPedido(int cod_peticion, int estado, string nombre_cliente, string direccion_entrega, string cod_postal, 
		string poblacion, string provincia, string telefono, string fech_creacion, List<LineaPedido> lineasPedido)
		{
			this.cod_peticion = cod_peticion;
			this.estado = estado;
			this.nombre_cliente = nombre_cliente;
			this.direccion_entrega = direccion_entrega;
			this.cod_postal = cod_postal;
			this.poblacion = poblacion;
			this.provincia = provincia;
			this.telefono = telefono;
			this.fech_creacion = fech_creacion;
			this.lineasPedido = lineasPedido;
		}

		public int cod_peticion { get; set; }
		public int estado { get; set; }
		public string nombre_cliente { get; set; }
		public string direccion_entrega { get; set; }
		public string cod_postal { get; set;}
		public string poblacion { get; set;}
		public string provincia { get; set; }
		public string telefono { get; set; }
		public string fech_creacion { get; set; }

		public List<LineaPedido> lineasPedido { get; set; }

		public override string ToString()
		{
			return this.cod_peticion.ToString();
		}
	}
}
