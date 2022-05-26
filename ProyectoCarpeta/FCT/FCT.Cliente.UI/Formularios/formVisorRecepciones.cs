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
	public partial class formVisorRecepciones : Form
	{
		
		
		public formVisorRecepciones()
		{
			InitializeComponent();
			actualizarGrids();
		}

		//Variable para almacenar la recepcion seleccionada

		int albaranSeleccionado = 0;

		//Actualiza los grids
		private void actualizarGrids(){
			vRECEPCIONESCABBindingSource.DataSource = CargarGrids.visorRecepcionesCabeceras(formContenedor.idEmpresa);
			vRECEPCIONESLINBindingSource.DataSource = CargarGrids.visorRecepcionesLineas(albaranSeleccionado);
		}

		//Cambia el albaran seleccionado y actualiza
		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			V_RECEPCIONES_CAB vista = (V_RECEPCIONES_CAB)gridView1.GetRow(gridView1.FocusedRowHandle);
			albaranSeleccionado = vista.ALBARAN;
			actualizarGrids();
		}

		//Actualiza los grids
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}
	}
}
