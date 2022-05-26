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

namespace FCT.Cliente.UI.Formularios
{
	public partial class formRecepciones : Form
	{
		
		//Lineas que vamos a añadir al aviso
		public BindingList<V_RECEPCIONES_LIN> lineasGridAviso = new BindingList<V_RECEPCIONES_LIN>();
	
		public formRecepciones()
		{
			InitializeComponent();
		}

		private void formRecepciones_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			actualizarGrids();
		}

		//Actualizacion de grids
		private void actualizarGrids() {

			vISTAREFERENCIASBindingSource.DataSource = CargarGrids.referenciasDisponibles(formContenedor.idEmpresa);
			vRECEPCIONESLINBindingSource.DataSource = lineasGridAviso;	
		}

		//Gestion de los botones
		#region

		//Actualizar grid
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}

		//Añade la referencia a la linea de aviso
		private void simpleButtonAnadirLinea_Click(object sender, EventArgs e)
		{
			
			if (spinEditCantidad.Value <= 0) { MessageBox.Show("Introduce un número mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			else
			{
				V_REFERENCIAS referencia = (V_REFERENCIAS)gridViewReferencias.GetRow(gridViewReferencias.FocusedRowHandle);
				bool lineaRepetida = false;

				//Bucle que comprueba si estamos añadiendo una referencia que ya existe y suma la cantidad en vez de generar una linea nueva

				foreach (V_RECEPCIONES_LIN l in lineasGridAviso)
				{
					if (l.COD_REFERENCIA == referencia.COD_REFERENCIA)
					{
						lineaRepetida = true;
						l.CANTIDAD += Convert.ToInt32(spinEditCantidad.Value);
						gridViewRecepciones1.RefreshData();
						actualizarGrids();
						break;
					}
				}

				if (!lineaRepetida)
				{

					V_RECEPCIONES_LIN linea = new V_RECEPCIONES_LIN();
					linea.ALBARAN = 0;
					linea.COD_LINEA = 0;
					linea.COD_REFERENCIA = referencia.COD_REFERENCIA;
					linea.CANTIDAD = Convert.ToInt32(spinEditCantidad.Value);
					linea.CANTIDAD_MAL_ESTADO = 0;
					linea.EXCEDENTE = 0;
					linea.FALTA = 0;
					linea.DES_REFERENCIA = referencia.DES_REFERENCIA;

					lineasGridAviso.Add(linea);
				}

				spinEditCantidad.Value = 0;
				actualizarGrids();
			}
		}

		//Elimina la linea seleccionada del grid
		private void simpleButtonQuitarLinea_Click(object sender, EventArgs e)
		{
			//Quita una linea del grid
			V_RECEPCIONES_LIN linea = (V_RECEPCIONES_LIN)gridViewRecepciones1.GetRow(gridViewRecepciones1.FocusedRowHandle);

			lineasGridAviso.Remove(linea);
			int n = 0;

			foreach (V_RECEPCIONES_LIN l in lineasGridAviso) {
				n++;
				l.COD_LINEA = n;		
			}
		}
		
		//Genera el aviso con las lineas del grid
		private void simpleButtonGenerarAviso_Click(object sender, EventArgs e)
		{

			var result = MessageBox.Show("¿Estás seguro de que deseas generar el aviso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{

				if (textEditFechaLlegada.Text == "") { MessageBox.Show("Por favor escribe una fecha de llegada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				else if (lineasGridAviso.Count == 0) { MessageBox.Show("Las lineas del aviso de recepción no pueden estar vacías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }				
				else
				{
					//Numera las lineas
					int n = 0;
					foreach (V_RECEPCIONES_LIN l in lineasGridAviso)
					{
						n++;
						l.COD_LINEA = n;
					}
					//Genera en un archivo de texto los datos de la recepcion

					Random r = new Random();
					string textoPedido;
					string albaran = r.Next(999999999).ToString();
					int proveedor = formContenedor.idEmpresa;

					textoPedido = albaran + "#" + "1" + "#" + proveedor.ToString() + "#" + DateTime.Now.ToShortDateString() + "#" + textEditFechaLlegada.Text;

					try
					{
						using (StreamWriter escribir = new StreamWriter(formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\avisos\\pendientes\\" + albaran + ".txt"))
						{
							escribir.WriteLine(textoPedido);
							foreach (V_RECEPCIONES_LIN l in lineasGridAviso)
							{
								string linea = l.COD_LINEA + "#" + l.COD_REFERENCIA + "#" + l.CANTIDAD + "#" + l.DES_REFERENCIA;
								escribir.WriteLine(linea);
							}
						}
					}
					catch (Exception){}

					lineasGridAviso.Clear();
					textEditFechaLlegada.Text = "";
				}
			}
		}

		#endregion

		//Se encarga de activar los botones solamente si hay una fila seleccionada
		private void gridViewRecepciones1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{	

				if (gridViewRecepciones1.SelectedRowsCount > 0)
				{
					simpleButtonQuitarLinea.Enabled = true;
				}
				else
				{
					simpleButtonQuitarLinea.Enabled = false;
				}
			
		}		


		//Comprobación de la fecha de llegada al clickar fuera del textedit
		private void textEditFechaLlegada_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Convert.ToDateTime(textEditFechaLlegada.Text) < DateTime.Now)
				{
					MessageBox.Show("La fecha no puede ser inferior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textEditFechaLlegada.Text = "";
				}
			}
			catch (Exception){}
		}
	}
}
