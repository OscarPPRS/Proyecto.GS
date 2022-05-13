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
	public partial class formRevision : Form
	{
		public formRevision()
		{
			InitializeComponent();

		}

		private void formRevision_Load(object sender, EventArgs e)
		{
			actualizarGrids();
			checkButtonIncidencia.Appearance.BackColor = Color.LightBlue;
			checkButtonIncidencia.Appearance.BackColor2 = Color.DarkBlue;
		}

		int peticion = 0;
		private void actualizarGrids()
		{
			vORDENSALIDACABBindingSource.DataSource = CargarGrids.revisionPedidos();
			vORDENSALIDALINBindingSource.DataSource = CargarGrids.revisionPedidosLineas(peticion);
		}

		private void gridViewPedidos_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			V_ORDEN_SALIDA_CAB lineaGrid = (V_ORDEN_SALIDA_CAB)gridViewPedidos.GetRow(gridViewPedidos.FocusedRowHandle);
			peticion = lineaGrid.COD_PETICION;

			vORDENSALIDALINBindingSource.DataSource = CargarGrids.revisionPedidosLineas(peticion);
		}

		private void checkButtonIncidencia_CheckedChanged(object sender, EventArgs e)
		{
			if (checkButtonIncidencia.Checked)
			{
				memoEditIncidencia.Enabled = true;
				checkButtonIncidencia.Appearance.BackColor = Color.LightGreen;
				checkButtonIncidencia.Appearance.BackColor2 = Color.DarkGreen;
				simpleButtonConfirmarRevision.ImageOptions.Image = Image.FromFile("\\\\m2d96\\Publico\\Recursos\\app\\iconos\\revision\\alert.png");
			}

			else
			{
				memoEditIncidencia.Enabled = false;
				checkButtonIncidencia.Appearance.BackColor = Color.LightBlue;
				checkButtonIncidencia.Appearance.BackColor2 = Color.DarkBlue;
				simpleButtonConfirmarRevision.ImageOptions.Image = Image.FromFile("\\\\m2d96\\Publico\\Recursos\\app\\iconos\\revision\\check.png");
			}
		}

		private void simpleButtonConfirmarRevision_Click(object sender, EventArgs e)
		{
			
			//Genera la incidencia o cambia el estado de la recepcion dependiendo del checked button

			V_ORDEN_SALIDA_CAB lineaGrid = (V_ORDEN_SALIDA_CAB)gridViewPedidos.GetRow(gridViewPedidos.FocusedRowHandle);

			if (checkButtonIncidencia.Checked)
			{
				ProcedimientosAlmacenados.salidasIncidencias(0, lineaGrid.COD_PETICION, memoEditIncidencia.Text);
				ProcedimientosAlmacenados.salidasCabeceras(1, lineaGrid.COD_PETICION, 7, null, null, null, null, null, null, null);
				MessageBox.Show("Incidencia generada.");
			}

			else
			{
				ProcedimientosAlmacenados.salidasCabeceras(1, lineaGrid.COD_PETICION, 4, null, null, null, null, null, null, null);
				peticion = 0;
				MessageBox.Show("Pedido revisado.");

			}

			actualizarGrids();
		}

		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}
	}
}
