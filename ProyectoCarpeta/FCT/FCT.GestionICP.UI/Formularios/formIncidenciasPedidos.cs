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

namespace FCT.GestionICP.UI.Formularios
{
	public partial class formIncidenciasPedidos : Form
	{
		public formIncidenciasPedidos()
		{
			InitializeComponent();
			actualizarGrids();
		}

		//Variables que almacenan el dato de la incidencia
		int peticionSeleccionada = -1;
		string textoIncidencia;

		//Actualizar grids
		private void actualizarGrids() {

			vORDENSALIDAINCIDENCIASBindingSource.DataSource = CargarGrids.incidenciasPedidosCabeceras();
			vORDENSALIDALINBindingSource.DataSource = CargarGrids.pedidosLineas(peticionSeleccionada);
			vPALETSBindingSource.DataSource = CargarGrids.paletsIncidencias(peticionSeleccionada);
			
		}

	
		//Actualiar grids
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}

		//Marcar incidencia como resuelta
		private void simpleButtonResolverIncidencia_Click(object sender, EventArgs e)
		{
			try
			{

				ProcedimientosAlmacenados.salidasCabeceras(1, peticionSeleccionada, 4, null, null, null, null, null, null, null);
				textoIncidencia = "";
				labelControl1.Text = textoIncidencia;
				peticionSeleccionada = -1;
				actualizarGrids();
			}
			catch (Exception){}
		}

		//Obtener los datos del pedido seleccionado y cargarlo
		private void gridViewIncidencias_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			try
			{
				V_ORDEN_SALIDA_INCIDENCIAS incidencia = (V_ORDEN_SALIDA_INCIDENCIAS)gridViewIncidencias.GetRow(gridViewIncidencias.FocusedRowHandle);

				peticionSeleccionada = (int)incidencia.COD_PETICION;

				vORDENSALIDALINBindingSource.DataSource = CargarGrids.pedidosLineas(peticionSeleccionada);
				vPALETSBindingSource.DataSource = CargarGrids.paletsIncidencias(peticionSeleccionada);

				textoIncidencia = incidencia.DES_INCIDENCIA;

				labelControl1.Text = textoIncidencia;
			}
			catch (Exception ex) { }
		}
	}
}
