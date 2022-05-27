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

		//Actualizar grid
		public void actualizarGrid()
		{
			vISTAREFERENCIASBindingSource.DataSource = CargarGrids.catalogoReferencias(formContenedor.idEmpresa);
		}


		//Botones de datos de referencias

		#region

		//Actualiza el grid
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrid();
		}

		//Crea una referencia nueva
		private void simpleButtonAnadir_Click(object sender, EventArgs e)
		{
			if (textEditDescripcion.Text == "" | textEditPrecio.Text == "")
			{ MessageBox.Show("Por favor rellene todos los campos de la referencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			else
			{
				ProcedimientosAlmacenados.referencias(0, null, formContenedor.idEmpresa, textEditDescripcion.Text, decimal.Parse(textEditPrecio.Text.Replace(" €", "")), rutaGuardado, true);
				textEditPrecio.Text = "";
				textEditDescripcion.Text = "";
				actualizarGrid();

				//Para generar una copia de la imagen que elijamos dentro de las carpetas del programa

				try
				{
					File.Copy(xtraOpenFileDialog1.FileName.ToString(), formContenedor.rutaCarpetaDatos + rutaGuardado);
				}
				catch (Exception){}

				rutaGuardado = null;
				pictureEditCambiar.Image = null;
				xtraOpenFileDialog1.FileName = "";
			}
		}

		//Modifica la referencia seleccionada
		private void simpleButtonModificar_Click(object sender, EventArgs e)
		{
			V_REFERENCIAS vista = (V_REFERENCIAS)gridView1.GetRow(gridView1.FocusedRowHandle);

			if (vista != null)
			{
				string desc, ruta;
				decimal precio;
				
				//Si los campos estan vacios, simplemente deja la referencia igual que antes.

				if (String.IsNullOrEmpty(textEditDescripcion.Text)) { desc = vista.DES_REFERENCIA; }
				else { desc = textEditDescripcion.Text; }

				if (String.IsNullOrEmpty(textEditPrecio.Text)) { precio = decimal.Parse(vista.PRECIO.ToString());  }
				else { precio = decimal.Parse(textEditPrecio.Text.Replace(" €","")); }

				if (String.IsNullOrEmpty(xtraOpenFileDialog1.FileName.ToString())) { ruta = vista.IMAGEN; }
				else { ruta = rutaGuardado; }


				ProcedimientosAlmacenados.referencias(1,vista.COD_REFERENCIA, 0, desc, precio, ruta, true);
				
				actualizarGrid();
				textEditPrecio.Text = "";
				textEditDescripcion.Text = "";


				try{
					File.Copy(xtraOpenFileDialog1.FileName.ToString(), formContenedor.rutaCarpetaDatos + rutaGuardado);
						pictureEditVisualizar.Image = Image.FromFile(formContenedor.rutaCarpetaDatos + ruta);
				}
				catch{}

				rutaGuardado = null;
				pictureEditCambiar.Image = null;
				xtraOpenFileDialog1.FileName = "";
			}
		}

		//Cambia el estado de la referencia para deshabilitarla.
		private void clickCambiarEstadoReferencia(object sender, EventArgs e)
		{
			V_REFERENCIAS vista = (V_REFERENCIAS)gridView1.GetRow(gridView1.FocusedRowHandle);
			//Llama a la función pasando como parametro el boolean contrario al que tiene
			ProcedimientosAlmacenados.referencias(3, vista.COD_REFERENCIA,0, null, 0, null, !(bool)vista.ESTADO);
			actualizarGrid();
		}

		//Añade la imagen al editor 
		private void simpleButtonImagen_Click(object sender, EventArgs e)
		{
			//Codigo para introducir la imagen
			xtraOpenFileDialog1.FileName = "";
			xtraOpenFileDialog1.ShowDialog();
			if (!String.IsNullOrEmpty(xtraOpenFileDialog1.FileName.ToString())){

				try{
					Random random = new Random();

					//Codigo para generar un nombre de imagen aleatorio

					const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
					string nombreArchivoImagen = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());

					pictureEditCambiar.Image = Image.FromFile(xtraOpenFileDialog1.FileName.ToString());
					rutaGuardado = "\\Recursos\\img\\" + nombreArchivoImagen + ".jpeg";
				}
				catch (Exception){
					MessageBox.Show("Seleccione un archivo de imagen válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		#endregion

		//Codigo para mostrar los datos de la fila que pinchamos en el grid
		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{					
			
			V_REFERENCIAS vista = (V_REFERENCIAS)gridView1.GetRow(gridView1.FocusedRowHandle);

				try	{
					if (vista.IMAGEN != null) { 
					pictureEditVisualizar.Image = Image.FromFile(formContenedor.rutaCarpetaDatos + vista.IMAGEN);
					}

					else { 
					pictureEditVisualizar.Image = null;
					}

					textEditDescripcion.Text = vista.DES_REFERENCIA;
					textEditPrecio.Text = vista.PRECIO.ToString();
				}
				catch (Exception)
				{
					pictureEditVisualizar.Image = null;
				}

			pictureEditCambiar.Image = null;
			xtraOpenFileDialog1.FileName = "";

		}

		//Codigo para colorear las filas dependiendo de si la referencia esta habilitada o no	
		private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
		{

			

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

		
		
	}
}
