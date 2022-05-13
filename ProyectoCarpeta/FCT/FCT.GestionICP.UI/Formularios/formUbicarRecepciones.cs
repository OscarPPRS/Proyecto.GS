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

		private void actualizarGrid() {

			vPALETSBindingSource.DataSource = CargarGrids.paletsRecepcion();
		
		}

		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrid();
		}
		UBICACIONES ubicacionDisponible = new UBICACIONES();
		private void simpleButtonUbicacionDisponible_Click(object sender, EventArgs e)
		{
			//Obtener ubicacion disponible para colocar el palet

			ubicacionDisponible = Consultas.siguienteUbicacionDisponible();

			textEditCalle.Text = ubicacionDisponible.CALLE;
			textEditPosicion.Text = ubicacionDisponible.POSICION;
		}

		private void simpleButtonConfirmarUbicacion_Click(object sender, EventArgs e)
		{

			V_PALETS vista = (V_PALETS)gridViewPalets.GetRow(gridViewPalets.FocusedRowHandle);
			
			ProcedimientosAlmacenados.gestionarPalets(2, vista.COD_PALET, ubicacionDisponible.COD_UBICACION, 0, 0);

			textEditCalle.Text = "";
			textEditPosicion.Text = "";

			ubicacionDisponible = null;

			actualizarGrid();
		}
	}
}
