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
using FCT.Negocio;

namespace FCT.GestionICP.UI.Formularios
{
	public partial class formGestionPalets : Form
	{
		public formGestionPalets()
		{
			InitializeComponent();
			vPALETSBindingSource1.DataSource = CargarGrids.palets();
			xtraTabControlFunciones.Enabled = false;
		}
		V_PALETS paletBuscado = new V_PALETS();
		
		private void cargarDatos(){

			try
			{
				vPALETSBindingSource.DataSource = CargarGrids.paletsJuntar(paletBuscado.COD_REFERENCIA, paletBuscado.COD_PALET);					

			//Añadir datos de la funcion de ubicar
			
			labelControlUbicacionPrevia.Text = paletBuscado.DESC_UBICACION;
			comboBoxEditUbicaciones.Text = "";

			comboBoxEditUbicaciones.Properties.Items.Clear();

			foreach (string ubicacion in Consultas.ubicacionesDisponibles())
			{

				comboBoxEditUbicaciones.Properties.Items.Add(ubicacion);

			}

			//Añadir datos 

			spinEditHijo.Value = 0;
			spinEditPadre.Value = 0;

			cantidadTotal = (int)paletBuscado.CANTIDAD;
			spinEditPadre.Value = cantidadTotal;

			}
			catch (Exception ex) { }

		}
		private void simpleButtonBuscar_Click(object sender, EventArgs e)
		{

			cargarDatos();
		}

		private void simpleButtonUbicar_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("¿Quieres reubicar el palet "+ paletBuscado.COD_PALET + " a su nueva ubicación " + comboBoxEditUbicaciones.SelectedText +"?", "Aviso", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				ProcedimientosAlmacenados.gestionarPalets(0, paletBuscado.COD_PALET, comboBoxEditUbicaciones.SelectedText, 0,0);
				cargarDatos();
				vPALETSBindingSource1.DataSource = CargarGrids.palets();
			}


			}

		private void simpleButtonEliminar_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("¿Eliminar el palet con código "+ paletBuscado.COD_PALET + ".", "Aviso", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				ProcedimientosAlmacenados.gestionarPalets(1, paletBuscado.COD_PALET, "", 0,0);


				labelControlUbicacionPrevia.Text = "";
				vPALETSBindingSource1.DataSource = CargarGrids.palets();
				cargarDatos();
			}
			}

		private void simpleButtonJuntar_Click(object sender, EventArgs e)
		{
			V_PALETS vista = (V_PALETS)gridViewPalets.GetRow(gridViewPalets.FocusedRowHandle);
			ProcedimientosAlmacenados.gestionarPalets(3, paletBuscado.COD_PALET, "", vista.COD_PALET,0);

			labelControlUbicacionPaletJuntado.Text = "";
			labelControlCantidadPaletJuntado.Text = "";

			using (StreamWriter escribir = new StreamWriter("\\\\m2d96\\Publico\\Recursos\\eti\\imprimir.bat"))
			{
				escribir.WriteLine("copy \\\\m2d96\\Publico\\Recursos\\eti\\etiquetaPalet.eti \\\\AWORK344\\ETI_ICP");
			}

			foreach (string etiqueta in Consultas.etiquetasGestionPalets(paletBuscado.COD_PALET))
			{

				using (StreamWriter escribir = new StreamWriter("\\\\m2d96\\Publico\\Recursos\\eti\\etiquetaPalet.eti"))
				{
					escribir.WriteLine(etiqueta);

				}
				//System.Diagnostics.Process proc = new System.Diagnostics.Process();
				//proc.StartInfo.UseShellExecute = false;
				//proc.StartInfo.FileName = "\\\\m2d96\\Publico" + "\\Recursos\\eti\\imprimir.bat";
				//proc.Start();
				//proc.WaitForExit();
				//proc.Close();
			}
			vPALETSBindingSource1.DataSource = CargarGrids.palets();
			cargarDatos();
		}

		private void gridViewPalets_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			V_PALETS vista = (V_PALETS)gridViewPalets.GetRow(gridViewPalets.FocusedRowHandle);

			labelControlUbicacionPaletJuntado.Text = paletBuscado.DESC_UBICACION;
			labelControlCantidadPaletJuntado.Text = (vista.CANTIDAD + paletBuscado.CANTIDAD).ToString();
		}
		int cantidadTotal = 0;
		private void spinEditPadre_EditValueChanged(object sender, EventArgs e)
		{
			if (spinEditPadre.Value > cantidadTotal | spinEditPadre.Value < 0)
			{
				spinEditPadre.Value = cantidadTotal;
			}
			else { spinEditHijo.Value = cantidadTotal - spinEditPadre.Value; }
		}

		private void spinEditHijo_EditValueChanged(object sender, EventArgs e)
		{
			if (spinEditHijo.Value > cantidadTotal | spinEditHijo.Value < 0)
			{
				spinEditHijo.Value = cantidadTotal;
			}
			else { spinEditPadre.Value = cantidadTotal - spinEditHijo.Value; }
		}

		private void simpleButtonPartir_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("¿Deseas generar un nuevo palet hijo con "+spinEditHijo.Text+ " y restárselas al palet con número " + paletBuscado.COD_PALET+ "?", "Aviso", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				ProcedimientosAlmacenados.gestionarPalets(4, paletBuscado.COD_PALET, "", 0, Convert.ToInt32(spinEditHijo.Value));

				using (StreamWriter escribir = new StreamWriter("\\\\m2d96\\Publico\\Recursos\\eti\\imprimir.bat"))
				{
					escribir.WriteLine("copy \\\\m2d96\\Publico\\Recursos\\eti\\etiquetaPalet.eti \\\\AWORK344\\ETI_ICP");
				}

				foreach (string etiqueta in Consultas.etiquetasGestionPalets(paletBuscado.COD_PALET))
				{

					using (StreamWriter escribir = new StreamWriter("\\\\m2d96\\Publico\\Recursos\\eti\\etiquetaPalet.eti"))
					{
						escribir.WriteLine(etiqueta);

					}
					//System.Diagnostics.Process proc = new System.Diagnostics.Process();
					//proc.StartInfo.UseShellExecute = false;
					//proc.StartInfo.FileName = "\\\\m2d96\\Publico" + "\\Recursos\\eti\\imprimir.bat";
					//proc.Start();
					//proc.WaitForExit();
					//proc.Close();
				}
			}
			vPALETSBindingSource1.DataSource = CargarGrids.palets();

			cargarDatos();

		}

		private void gridViewPaletsTodos_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			V_PALETS paletSeleccionado = (V_PALETS)gridViewPaletsTodos.GetRow(gridViewPaletsTodos.FocusedRowHandle);

			paletBuscado = paletSeleccionado;
			cargarDatos();

			if (paletSeleccionado.COD_ESTADO == 1) { xtraTabControlFunciones.Enabled = true; }
			else{ xtraTabControlFunciones.Enabled = false; }

			
		}

		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			vPALETSBindingSource1.DataSource = CargarGrids.palets();
		}
	}

		
	}

