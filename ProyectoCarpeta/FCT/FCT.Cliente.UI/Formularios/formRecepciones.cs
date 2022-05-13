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

		public BindingList<LineaAviso> lineasGrid = new BindingList<LineaAviso>();
	
		public formRecepciones()
		{
			InitializeComponent();
		}

		private void formRecepciones_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			actualizarGrids();
			spinEditCantidad.Properties.Mask.EditMask = "f0";
			simpleButtonQuitarLinea.Enabled = false;
		}

		private void actualizarGrids() {

			vISTAREFERENCIASBindingSource.DataSource = CargarGrids.referenciasAvisos(formContenedor.idEmpresa);
			lineaAvisoBindingSource.DataSource = lineasGrid;	
		}

		private void simpleButtonAnadirLinea_Click(object sender, EventArgs e)
		{
			
			if (spinEditCantidad.Value <= 0) { MessageBox.Show("Introduce un número mayor que 0."); }
			else
			{
				V_REFERENCIAS referencia = (V_REFERENCIAS)gridViewReferencias.GetRow(gridViewReferencias.FocusedRowHandle);
				bool lineaRepetida = false;

				//Bucle que comprueba si estamos añadiendo una referencia que ya existe y suma la cantidad en vez de generar una linea nueva

				foreach (LineaAviso l in lineasGrid)
				{
					if (l.cod_referencia == referencia.COD_REFERENCIA)
					{
						lineaRepetida = true;
						l.cantidad += Convert.ToInt32(spinEditCantidad.Value);
						gridViewRecepciones1.RefreshData();
						actualizarGrids();
						break;
					}
				}

				if (!lineaRepetida)
				{
					LineaAviso linea = new LineaAviso(0, 0, referencia.COD_REFERENCIA, Convert.ToInt32(spinEditCantidad.Value), referencia.DES_REFERENCIA);
					lineasGrid.Add(linea);
				}

				spinEditCantidad.Value = 0;
				actualizarGrids();
			}
		}

		private void simpleButtonQuitarLinea_Click(object sender, EventArgs e)
		{
			//Quita una linea del grid
			LineaAviso linea = (LineaAviso)gridViewRecepciones1.GetRow(gridViewRecepciones1.FocusedRowHandle);

			lineasGrid.Remove(linea);
			int n = 0;

			foreach (LineaAviso l in lineasGrid) {
				n++;
				l.cod_linea = n;		
			}
		}

		private void simpleButtonGenerarAviso_Click(object sender, EventArgs e)
		{

			var result = MessageBox.Show("¿Estás seguro de que deseas generar el aviso?", "Aviso", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{

				if (textEditFechaLlegada.Text == "") { MessageBox.Show("Por favor escribe una fecha de llegada"); }
				else if (lineasGrid.Count == 0) { MessageBox.Show("Las lineas del aviso de recepción no pueden estar vacías."); }
				else
				{
					//Numera las lineas
					int n = 0;
					foreach (LineaAviso l in lineasGrid)
					{
						n++;
						l.cod_linea = n;
					}
					//Genera en un archivo de texto los datos de la recepcion

					Random r = new Random();
					string pedido;
					string albaran = r.Next(999999999).ToString();
					int proveedor = formContenedor.idEmpresa;

					pedido = albaran + "#" + "1" + "#" + proveedor.ToString() + "#" + DateTime.Now.ToShortDateString() + "#" + textEditFechaLlegada.Text;

					try
					{
						using (StreamWriter escribir = new StreamWriter("\\\\m2d96\\Publico" + "\\Recursos\\data\\avisos\\pendientes\\" + albaran + ".txt"))
						{
							escribir.WriteLine(pedido);
							foreach (LineaAviso l in lineasGrid)
							{
								string linea = l.cod_linea + "#" + l.cod_referencia + "#" + l.cantidad + "#" + l.descripcion_referencia;
								escribir.WriteLine(linea);
							}
						}
					}
					catch (Exception)
					{

						throw;
					}

					lineasGrid.Clear();
					textEditFechaLlegada.Text = "";
				}
			}
		}

		private void gridViewRecepciones1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{
			
				//Se encarga de activar los botones solamente si hay una fila seleccionada

				if (gridViewRecepciones1.SelectedRowsCount > 0)
				{
					simpleButtonQuitarLinea.Enabled = true;
				}
				else
				{
					simpleButtonQuitarLinea.Enabled = false;
				}
			
		}

		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}
	}
}
