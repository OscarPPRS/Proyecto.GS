using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using FCT.Negocio;

namespace FCT.GestionICP.UI.Formularios
{
	public partial class formPicking : Form
	{


		public formPicking()
		{
			InitializeComponent();
			actualizarGrid();
		}
		//Peticion seleccionada
		private int peticion = 0;

		//Actualizar grids
		private void actualizarGrid(){
			vORDENSALIDACABBindingSource.DataSource = CargarGrids.pickingPedidos();			
		}

		//Comportamiento de botones

		#region
		//Actualizar grids
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrid();
		}

		//Carga los movimientos en el grid
		private void simpleButtonComenzarPicking_Click(object sender, EventArgs e)
		{
			V_ORDEN_SALIDA_CAB vista = (V_ORDEN_SALIDA_CAB)gridViewPedidos.GetRow(gridViewPedidos.FocusedRowHandle);

			try
			{
				peticion = vista.COD_PETICION;

				vMOVIMIENTOSPICKINGBindingSource.DataSource = CargarGrids.pickingMovimientos(peticion);
				simpleButtonConfirmarMovimiento.Enabled = true;
			}
			catch (Exception )
			{
				MessageBox.Show("Seleccione un pedido para iniciar el picking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Confirma el movimiento seleccionado
		private void simpleButtonConfirmarMovimiento_Click(object sender, EventArgs e)
		{

			try
			{
				//Llama al PA de movimientos para confirmar ese movimiento, generando el log, las etiquetas y el palet

				V_MOVIMIENTOS_PICKING lineaGrid = (V_MOVIMIENTOS_PICKING)gridViewMovimientos.GetRow(gridViewMovimientos.FocusedRowHandle);

				ProcedimientosAlmacenados.movimientosPicking(1, peticion, 0, lineaGrid.COD_MOVIMIENTO);



				//Generacion de etiquetas

				//using (StreamWriter escribir = new StreamWriter(formContenedor.rutaCarpetaDatos+"\\Recursos\\eti\\imprimir.bat"))
				//{
				//	escribir.WriteLine("copy "+ formContenedor.rutaCarpetaDatos+ "\\Recursos\\eti\\etiquetaPalet.eti \\\\AWORK344\\ETI_ICP");
				//}

				//foreach (string etiqueta in Consultas.etiquetasPicking(lineaGrid.COD_MOVIMIENTO))
				//{

				//	using (StreamWriter escribir = new StreamWriter(formContenedor.rutaCarpetaDatos+"\\Recursos\\eti\\etiquetaPalet.eti"))
				//	{
				//		escribir.WriteLine(etiqueta);
				//	}
				//	System.Diagnostics.Process proc = new System.Diagnostics.Process();
				//	proc.StartInfo.UseShellExecute = false;
				//	proc.StartInfo.FileName = formContenedor.rutaCarpetaDatos + "\\Recursos\\eti\\imprimir.bat";
				//	proc.Start();
				//	proc.WaitForExit();
				//	proc.Close();

				//}
				actualizarGrid();
				vMOVIMIENTOSPICKINGBindingSource.DataSource = CargarGrids.pickingMovimientos(peticion);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		//Colorea las columnas en base a si el movimiento ha sido realizado o no
		private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
		{

			//Codigo para colorear las filas

			if (e.RowHandle < 0) return;
			GridView view = sender as GridView;
			V_MOVIMIENTOS_PICKING mov = (V_MOVIMIENTOS_PICKING)view.GetRow(e.RowHandle);

			

			if ((bool)mov.REALIZADO)
			{
				e.Appearance.BackColor = Color.PaleVioletRed;
			}
			else
			{
				e.Appearance.BackColor = Color.White;
			}
		}
		
		//Obtiene los datos del movimiento seleccionado y los representa en pantalla
		private void gridViewMovimientos_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			V_MOVIMIENTOS_PICKING vista = (V_MOVIMIENTOS_PICKING)gridViewMovimientos.GetRow(gridViewMovimientos.FocusedRowHandle);

			textEditCalle.Text = "";
			textEditPosicion.Text = "";
			textEditCantidad.Text = "";

			if (vista.REALIZADO == true) {
				simpleButtonConfirmarMovimiento.Enabled = false;
			}
			else{			
				textEditCalle.Text = vista.CALLE;
				textEditPosicion.Text = vista.POSICION;
				textEditCantidad.Text = vista.CANTIDAD.ToString();
				simpleButtonConfirmarMovimiento.Enabled = true;
			}
			
		}



	
	}
}
