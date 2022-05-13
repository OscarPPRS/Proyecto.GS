using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using FCT.Negocio;
using System.Data.Entity;
using System.IO;
using System.Configuration;
using System.Globalization;

namespace FCT.Cliente.UI
{
	public partial class formReferencias : Form
	{

		static string rutaGuardado;

		public formReferencias()
		{
			InitializeComponent();		
		}

		private void formMenu_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			actualizarGrid();
		}
	
		//Botones de datos de referencias

		private void simpleButtonAnadir_Click(object sender, EventArgs e)
		{
			if (textEditDescripcion.Text == "" | textEditPrecio.Text == "")
			{ MessageBox.Show("Por favor rellene todos los campos de la referencia."); }
			else
			{
				ProcedimientosAlmacenados.referencias(0, null, formContenedor.idEmpresa, textEditDescripcion.Text, decimal.Parse(textEditPrecio.Text.Replace(".", ",")), rutaGuardado, true);
				textEditPrecio.Text = "";
				textEditDescripcion.Text = "";
				actualizarGrid();

				//Para generar una copia de la imagen que elijamos dentro de las carpetas del programa

				try
				{
					File.Copy(xtraOpenFileDialog1.FileName.ToString(), "\\\\m2d96\\Publico" + rutaGuardado);
				}
				catch (Exception)
				{


				}

				rutaGuardado = null;
				pictureEditCambiar.Image = null;
				xtraOpenFileDialog1.FileName = "";
			}
		}

		private void simpleButtonModificar_Click(object sender, EventArgs e)
		{
			V_REFERENCIAS vista = (V_REFERENCIAS)gridView1.GetRow(gridView1.FocusedRowHandle);
			if (vista != null)
			{
				string desc, ruta;
				decimal precio;
				

				if (String.IsNullOrEmpty(textEditDescripcion.Text)) { desc = vista.DES_REFERENCIA; }
				else { desc = textEditDescripcion.Text; }

				if (String.IsNullOrEmpty(textEditPrecio.Text)) { precio = decimal.Parse(vista.PRECIO.ToString().Replace(".", ","));  }
				else { precio = decimal.Parse(textEditPrecio.Text.Replace(".", ",")); }

				if (String.IsNullOrEmpty(xtraOpenFileDialog1.FileName.ToString())) { ruta = vista.IMAGEN; }
				else { ruta = rutaGuardado; }

				ProcedimientosAlmacenados.referencias(1,vista.COD_REFERENCIA, 0, desc, precio, ruta, true);
				
				actualizarGrid();
				textEditPrecio.Text = "";
				textEditDescripcion.Text = "";
				try
				{
					File.Copy(xtraOpenFileDialog1.FileName.ToString(), "\\\\m2d96\\Publico" + rutaGuardado);
						pictureEditVisualizar.Image = Image.FromFile("\\\\m2d96\\Publico" + ruta);
				}
						catch
				{

				}
			rutaGuardado = null;
						pictureEditCambiar.Image = null;
						xtraOpenFileDialog1.FileName = "";
			}
		}

		private void clickCambiarEstadoReferencia(object sender, EventArgs e)
		{
			V_REFERENCIAS vista = (V_REFERENCIAS)gridView1.GetRow(gridView1.FocusedRowHandle);
			//Llama a la función pasando como parametro el boolean contrario al que tiene
			ProcedimientosAlmacenados.referencias(3, vista.COD_REFERENCIA,0, null, 0, null, !(bool)vista.ESTADO);
			actualizarGrid();
		}

		private void simpleButtonImagen_Click(object sender, EventArgs e)
		{
			//Codigo para introducir la imagen
			xtraOpenFileDialog1.FileName = "";
			xtraOpenFileDialog1.ShowDialog();
			if (!String.IsNullOrEmpty(xtraOpenFileDialog1.FileName.ToString()))
			{
				pictureEditCambiar.Image = Image.FromFile(xtraOpenFileDialog1.FileName.ToString());
				rutaGuardado = "\\Recursos\\img\\" + FuncionesAuxiliares.randomString(8) + ".jpeg";
			}

		}

		//Eventos del gridview
		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			
			//Codigo para mostrar los datos de la fila que pinchamos en el grid
			
			V_REFERENCIAS vista = (V_REFERENCIAS)gridView1.GetRow(gridView1.FocusedRowHandle);

				try
				{
				if (vista.IMAGEN != null) { pictureEditVisualizar.Image = Image.FromFile("\\\\m2d96\\Publico" + vista.IMAGEN); }
				else { pictureEditVisualizar.Image = null; }
				}
				catch (Exception)
				{
					pictureEditVisualizar.Image = null;
				}

			pictureEditCambiar.Image = null;
			xtraOpenFileDialog1.FileName = "";

		}

		private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
		{

			//Codigo para colorear las filas dependiendo de si la referencia esta habilitada o no	

			if (e.RowHandle < 0) return;
			GridView view = sender as GridView;
			V_REFERENCIAS vista = (V_REFERENCIAS)view.GetRow(e.RowHandle);
			if (!(bool)vista.ESTADO)
			{
				e.Appearance.BackColor = Color.PaleVioletRed;
			}
			else
			{
				e.Appearance.BackColor = Color.White;
			}
		}

		//Funciones auxiliares
		

		public void actualizarGrid()
		{
			vISTAREFERENCIASBindingSource.DataSource = CargarGrids.catalogoReferencias(formContenedor.idEmpresa);
		}

		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrid();
		}
	}
}
