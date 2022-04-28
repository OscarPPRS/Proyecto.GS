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

		int albaranSeleccionado = 0;
		public formVisorRecepciones()
		{
			InitializeComponent();
			actualizarGrids();
		}

		private void actualizarGrids(){
			vRECEPCIONESCABBindingSource.DataSource = Consultas.gridVisorCab(formContenedor.idEmpresa);
			vRECEPCIONESLINBindingSource.DataSource = Consultas.gridVisorLin(albaranSeleccionado);
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			V_RECEPCIONES_CAB vista = (V_RECEPCIONES_CAB)gridView1.GetRow(gridView1.FocusedRowHandle);
			albaranSeleccionado = vista.ALBARAN;
			actualizarGrids();
		}
	}
}
