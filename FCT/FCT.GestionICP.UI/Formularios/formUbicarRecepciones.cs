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
	public partial class formUbicarRecepciones : Form
	{
		public formUbicarRecepciones()
		{
			InitializeComponent();
			actualizarGrid();
		}

		//Actualizar grids
		private void actualizarGrid() {

			vPALETSBindingSource.DataSource = CargarGrids.paletsRecepcionables();
		
		}

		//Actualizar grids
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrid();
		}

		UBICACIONES ubicacionDisponible = new UBICACIONES();

		//Obtener ubicacion disponible para colocar el palet
		private void simpleButtonUbicacionDisponible_Click(object sender, EventArgs e)
		{
			
			ubicacionDisponible = Consultas.siguienteUbicacionDisponible();

			textEditCalle.Text = ubicacionDisponible.CALLE;
			textEditPosicion.Text = ubicacionDisponible.POSICION;

			simpleButtonConfirmarUbicacion.Enabled = true;
		}

		//Cambia el palet a la ubicacion seleccionada
		private void simpleButtonConfirmarUbicacion_Click(object sender, EventArgs e)
		{

			V_PALETS vista = (V_PALETS)gridViewPalets.GetRow(gridViewPalets.FocusedRowHandle);
			try
			{
				ProcedimientosAlmacenados.gestionarPalets(2, vista.COD_PALET, ubicacionDisponible.COD_UBICACION, 0, 0);
			}

			catch (Exception) { }

			textEditCalle.Text = "";
			textEditPosicion.Text = "";

			ubicacionDisponible = null;
			simpleButtonConfirmarUbicacion.Enabled=false;

			actualizarGrid();
		}
	}
}
