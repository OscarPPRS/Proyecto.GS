using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCT.Negocio;
namespace FCT.Cliente.UI.Formularios
{
	public partial class formVisorPedidos : Form
	{
		public formVisorPedidos()
		{
			InitializeComponent();
			actualizarGrids();
		}

		//Variable para almacenar el pedido seleccionado
		int pedido = 0;

		//Actualizar grids
		private void actualizarGrids()
		{
			vORDENSALIDACABBindingSource.DataSource = CargarGrids.visorPedidosCabeceras(formContenedor.idEmpresa);
			vORDENSALIDALINBindingSource.DataSource = CargarGrids.pedidosLineas(pedido);
		}
		//Cambia el codigo de la peticion y actualiza
		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			V_ORDEN_SALIDA_CAB vista = (V_ORDEN_SALIDA_CAB)gridView1.GetRow(gridView1.FocusedRowHandle);
			pedido = vista.COD_PETICION;
			actualizarGrids();
		}

		//Actualiza los grids
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}
	}
}
