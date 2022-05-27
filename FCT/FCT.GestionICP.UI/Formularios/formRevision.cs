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

		//Colorea el checkbutton
		private void formRevision_Load(object sender, EventArgs e)
		{
			actualizarGrids();
			checkButtonIncidencia.Appearance.BackColor = Color.LightBlue;
			checkButtonIncidencia.Appearance.BackColor2 = Color.DarkBlue;
		}

		//Actualizar grids
		private void actualizarGrids()
		{
			vORDENSALIDACABBindingSource.DataSource = CargarGrids.revisionPedidos();
			vORDENSALIDALINBindingSource.DataSource = CargarGrids.pedidosLineas(peticion);
		}
		//Variable para almacenar la peticion seleccionada

		int peticion = 0;

		//ACtualiza los frids
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}

		//Genera la incidencia o cambia el estado de la recepcion dependiendo del checked button
		private void simpleButtonConfirmarRevision_Click(object sender, EventArgs e)
		{
			

			try
			{
				V_ORDEN_SALIDA_CAB lineaGrid = (V_ORDEN_SALIDA_CAB)gridViewPedidos.GetRow(gridViewPedidos.FocusedRowHandle);

				//Genera incidencia
				if (checkButtonIncidencia.Checked)
				{
					ProcedimientosAlmacenados.salidasIncidencias(0, lineaGrid.COD_PETICION, memoEditIncidencia.Text);
					ProcedimientosAlmacenados.salidasCabeceras(1, lineaGrid.COD_PETICION, 7, null, null, null, null, null, null, null);
					MessageBox.Show("Incidencia generada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				//Cambia el estado del pedido
				else
				{
					ProcedimientosAlmacenados.salidasCabeceras(1, lineaGrid.COD_PETICION, 4, null, null, null, null, null, null, null);
					peticion = 0;
					MessageBox.Show("Pedido revisado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}

				memoEditIncidencia.Text = "";

				actualizarGrids();
			}
			catch (Exception) { }
		}


		//Obtiene los datos del pedido seleccionado
		private void gridViewPedidos_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			try
			{
				V_ORDEN_SALIDA_CAB lineaGrid = (V_ORDEN_SALIDA_CAB)gridViewPedidos.GetRow(gridViewPedidos.FocusedRowHandle);
				peticion = lineaGrid.COD_PETICION;

				vORDENSALIDALINBindingSource.DataSource = CargarGrids.pedidosLineas(peticion);
			}
			catch (Exception ex) { }
		}
		
		//Al activar el boton, muestra la caja para incidencias y permite generar incidencia
		private void checkButtonIncidencia_CheckedChanged(object sender, EventArgs e)
		{
			if (checkButtonIncidencia.Checked)
			{
				memoEditIncidencia.Enabled = true;
				memoEditIncidencia.Visible = true;
				checkButtonIncidencia.Appearance.BackColor = Color.LightGreen;
				checkButtonIncidencia.Appearance.BackColor2 = Color.DarkGreen;
				simpleButtonConfirmarRevision.ImageOptions.Image = Image.FromFile(formContenedor.rutaCarpetaDatos+"\\Recursos\\app\\iconos\\revision\\alert.png");
				simpleButtonConfirmarRevision.ToolTip = "Generar incidencia para este pedido";
			}

			else
			{
				memoEditIncidencia.Enabled = false;
				memoEditIncidencia.Visible = false;
				checkButtonIncidencia.Appearance.BackColor = Color.LightBlue;
				checkButtonIncidencia.Appearance.BackColor2 = Color.DarkBlue;
				simpleButtonConfirmarRevision.ImageOptions.Image = Image.FromFile(formContenedor.rutaCarpetaDatos+"\\Recursos\\app\\iconos\\revision\\check.png");
				simpleButtonConfirmarRevision.ToolTip = "Confirmar pedido como revisado";
			}
		}


	}
}
