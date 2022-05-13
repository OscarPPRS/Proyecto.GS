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
		int peticionSeleccionada = 0;
		string textoIncidencia;
		private void actualizarGrids() {

			vORDENSALIDAINCIDENCIASBindingSource.DataSource = CargarGrids.incidenciasSalidasCab();
			vORDENSALIDALINBindingSource.DataSource = CargarGrids.visorSalidasLin(peticionSeleccionada);
			vPALETSBindingSource.DataSource = CargarGrids.paletsIncidencias(peticionSeleccionada);
			
		}

		private void gridViewIncidencias_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			V_ORDEN_SALIDA_INCIDENCIAS incidencia = (V_ORDEN_SALIDA_INCIDENCIAS)gridViewIncidencias.GetRow(gridViewIncidencias.FocusedRowHandle);

			peticionSeleccionada = (int)incidencia.COD_PETICION;

			vORDENSALIDALINBindingSource.DataSource = CargarGrids.visorSalidasLin(peticionSeleccionada);
			vPALETSBindingSource.DataSource = CargarGrids.paletsIncidencias(peticionSeleccionada);

			textoIncidencia = incidencia.DES_INCIDENCIA;

			memoEdit1.Text = textoIncidencia;
		}

		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}

		private void simpleButtonResolverIncidencia_Click(object sender, EventArgs e)
		{
			ProcedimientosAlmacenados.salidasCabeceras(1, peticionSeleccionada, 4, null, null, null, null, null, null, null);
			textoIncidencia = "";
			peticionSeleccionada = 0;
			actualizarGrids();
		}
	}
}
