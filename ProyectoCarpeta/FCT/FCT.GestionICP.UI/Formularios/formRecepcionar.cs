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
using DevExpress.XtraEditors;
using FCT.Negocio;

namespace FCT.GestionICP.UI.Formularios
{
	public partial class formRecepcionar : Form
	{
		public formRecepcionar()
		{
			InitializeComponent();
		}

		BindingList<V_RECEPCIONES_LIN> vistaAvisos = new BindingList<V_RECEPCIONES_LIN>();
		public void actualizarGrids()
		{
			vRECEPCIONESLINBindingSource.DataSource = vistaAvisos;
		}
		private void formRecepcionar_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			textEditDescripcionReferencia.Enabled = false;
			textEditPrecio.Enabled = false;
			spinEditExcedente.Enabled = false;
			spinEditFalta.Enabled = false;
			checkButtonAniadirReferencia.Appearance.BackColor = Color.LightBlue;
			checkButtonAniadirReferencia.Appearance.BackColor2 = Color.DarkBlue;
			checkButtonExcedenteFalta.Appearance.BackColor = Color.LightBlue;
			checkButtonExcedenteFalta.Appearance.BackColor2 = Color.DarkBlue;
		}


		private void simpleButtonBuscar_Click(object sender, EventArgs e)
		{

			//Busca el numero de albaran introducido entre los albaranes de la base de datos y muestra los datos del aviso
			try
			{
				RECEPCIONES_CAB aviso = Consultas.buscarAviso(Convert.ToInt32(textEditAlbaran.Text));

				textEditNombreEmpresa.Text = Consultas.nombreEmpresa((int)aviso.ID_EMPRESA);
				textEditFechaCreacionAviso.EditValue = Convert.ToDateTime(aviso.FECH_CREACION);
				textEditFechaLlegada.EditValue = Convert.ToDateTime(aviso.FECH_LLEGADA);

				vistaAvisos = CargarGrids.recepcionarAvisos(Convert.ToInt32(textEditAlbaran.Text));
				lineasRecibidas.Clear();

				actualizarGrids();
			}
			catch (Exception)
			{
				MessageBox.Show("El número de albarán no ha sido encontrado entre los avisos.", "Error");
			}																
		}

		

		private void checkButtonAniadirReferencia_CheckedChanged(object sender, EventArgs e)
		{
				

			if (checkButtonAniadirReferencia.Checked)
			{
				textEditDescripcionReferencia.Enabled = true;
				textEditPrecio.Enabled = true;
				checkButtonAniadirReferencia.Appearance.BackColor = Color.LightGreen;
				checkButtonAniadirReferencia.Appearance.BackColor2 = Color.DarkGreen;
			}

			else {
				textEditDescripcionReferencia.Enabled = false;
				textEditPrecio.Enabled = false;
				checkButtonAniadirReferencia.Appearance.BackColor = Color.LightBlue;
				checkButtonAniadirReferencia.Appearance.BackColor2 = Color.DarkBlue;
			}
		}

		List<LineaAviso> lineasRecibidas = new List<LineaAviso>();
		private void simpleButtonConfirmarLinea_Click(object sender, EventArgs e)
		{
			
			//Si hay referencia nueva, la genera y posteriormente añade una linea con ella.

			if (checkButtonAniadirReferencia.Checked)
			{
				if (textEditDescripcionReferencia.Text == "" | textEditPrecio.Text == "")
				{ MessageBox.Show("Por favor rellena los campos de la referencia.");}
				else{
					string codRefe = ProcedimientosAlmacenados.referencias(0,null,Consultas.idEmpresa(textEditNombreEmpresa.Text), textEditDescripcionReferencia.Text,
					decimal.Parse(textEditPrecio.Text.Replace(".", ",")), null, true);

					LineaAviso linea = new LineaAviso(Convert.ToInt32(textEditAlbaran.Text), 0, codRefe, 
					Convert.ToInt32(spinEditCantidadBuena.Value), Convert.ToInt32(spinEditCantidadMala.Value), 0,0,textEditDescripcionReferencia.Text);

					lineasRecibidas.Add(linea);

					spinEditCantidadBuena.Value = 0;
					spinEditCantidadMala.Value = 0;
					spinEditExcedente.Value = 0;
					spinEditFalta.Value = 0;

					textEditDescripcionReferencia.Text = "";
					textEditPrecio.Text = "";
				}
			}	

			//Añade los datos de la referencia del aviso

			else{
				if (gridViewAviso.SelectedRowsCount > 0)
				{
					V_RECEPCIONES_LIN lineaGrid = (V_RECEPCIONES_LIN)gridViewAviso.GetRow(gridViewAviso.FocusedRowHandle);
					LineaAviso linea = new LineaAviso(lineaGrid.ALBARAN, 0, lineaGrid.COD_REFERENCIA,
					Convert.ToInt32(spinEditCantidadBuena.Value), Convert.ToInt32(spinEditCantidadMala.Value), Convert.ToInt32(spinEditExcedente.Value),
					Convert.ToInt32(spinEditFalta.Value),lineaGrid.DES_REFERENCIA);				

					lineasRecibidas.Add(linea);

					vistaAvisos.Remove(lineaGrid);
					actualizarGrids();

					spinEditCantidadBuena.Value = 0;
					spinEditCantidadMala.Value = 0;
					spinEditExcedente.Value = 0;
					spinEditFalta.Value = 0;
				}
				else
				{
					MessageBox.Show("Seleccione una línea para confirmar");
				}
			}
			
			
		}

		private void simpleButtonConfirmarRecepcion_Click(object sender, EventArgs e)
		{
			if (textEditAlbaran.Text == "" | textEditNombreEmpresa.Text == "" | textEditFechaCreacionAviso.Text == "" |
			textEditFechaLlegada.Text == "") { MessageBox.Show("Por favor rellene todos los campos de la cabecera del aviso."); }

			else if (gridViewAviso.RowCount > 0) { MessageBox.Show("Por favor, confirme todas las líneas."); }

			else 
			{
				var result = MessageBox.Show("¿Estás seguro de que deseas confirmar la recepción?.", "Aviso", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					
					//Modificar Cabecera
					ProcedimientosAlmacenados.recepcionesCabeceras(1,Convert.ToInt32(textEditAlbaran.Text), 2, Consultas.idEmpresa(textEditNombreEmpresa.Text),
					(DateTime)textEditFechaCreacionAviso.EditValue, (DateTime)textEditFechaLlegada.EditValue);

					//Borrar Lineas antiguas
					ProcedimientosAlmacenados.recepcionesLineas(2,Convert.ToInt32(textEditAlbaran.Text), 0, null, 0);
				
					int numerador = 0;

					foreach (LineaAviso l in lineasRecibidas)
					{
						numerador++;

						//Insertar lineas, insertar palets y enviar correo

						ProcedimientosAlmacenados.recepcionesLineas(0,l.albaran, numerador, l.cod_referencia, (int)l.cantidadBuena);

						if (l.cantidadBuena > 0) { ProcedimientosAlmacenados.palets(0, l.cod_referencia, 3, (int)l.cantidadBuena, l.albaran); }

						if (l.cantidadMala > 0) { ProcedimientosAlmacenados.palets(0, l.cod_referencia, 6, (int)l.cantidadMala, l.albaran); }

						if (l.excedente > 0) { ProcedimientosAlmacenados.palets(0, l.cod_referencia, 3, (int)l.excedente, l.albaran); }

						if (l.falta > 0) { 
						
								
						
						}
					}

					ProcedimientosAlmacenados.enviarCorreo("ols17697@gmail.com", "Material recibido en ICP " + textEditAlbaran.Text, Convert.ToInt32(textEditAlbaran.Text));

					//Generacion de etiquetas

					using (StreamWriter escribir = new StreamWriter("\\\\m2d96\\Publico\\Recursos\\eti\\imprimir.bat"))
					{
						escribir.WriteLine("copy \\\\m2d96\\Publico\\Recursos\\eti\\etiquetaPalet.eti \\\\AWORK344\\ETI_ICP");
					}

					foreach (string etiqueta in Consultas.etiquetasRecepcion(Convert.ToInt32(textEditAlbaran.Text))) {
						
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

				//Limpieza de controles

				lineasRecibidas.Clear();
							
				
				foreach (var textboxitem in this.Controls.OfType<TextEdit>())
				{
					textboxitem.Text = "";
				}

			}
		}

		private void simpleButtonEliminarLinea_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("¿Estás seguro de que deseas eliminar la línea?.", "Aviso", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				V_RECEPCIONES_LIN lineaGrid = (V_RECEPCIONES_LIN)gridViewAviso.GetRow(gridViewAviso.FocusedRowHandle);
				vistaAvisos.Remove(lineaGrid);
				actualizarGrids();
			}
		}

		private void checkButtonExcedenteFalta_CheckedChanged(object sender, EventArgs e)
		{

			if (checkButtonExcedenteFalta.Checked)
			{
				spinEditExcedente.Enabled = true;
				spinEditFalta.Enabled = true;
				checkButtonExcedenteFalta.Appearance.BackColor = Color.LightGreen;
				checkButtonExcedenteFalta.Appearance.BackColor2 = Color.DarkGreen;
			}

			else
			{
				spinEditExcedente.Enabled = false;
				spinEditFalta.Enabled = false;
				checkButtonExcedenteFalta.Appearance.BackColor = Color.LightBlue;
				checkButtonExcedenteFalta.Appearance.BackColor2 = Color.DarkBlue;
			}
		}
		int cantidadTotal = 0;
		private void spinEditCantidadBuena_EditValueChanged(object sender, EventArgs e)
		{
			if (spinEditCantidadBuena.Value > cantidadTotal | spinEditCantidadBuena.Value < 0)
			{
				spinEditCantidadBuena.Value = cantidadTotal;
			}
			else { spinEditCantidadMala.Value = cantidadTotal - spinEditCantidadBuena.Value; }
		}

		private void spinEditCantidadMala_EditValueChanged(object sender, EventArgs e)
		{
			if (spinEditCantidadMala.Value > cantidadTotal | spinEditCantidadMala.Value < 0)
			{
				spinEditCantidadMala.Value = cantidadTotal;
			}
			else { spinEditCantidadBuena.Value = cantidadTotal - spinEditCantidadMala.Value; }
		}

		private void spinEditFalta_EditValueChanged(object sender, EventArgs e)
		{
			V_RECEPCIONES_LIN lineaGrid = (V_RECEPCIONES_LIN)gridViewAviso.GetRow(gridViewAviso.FocusedRowHandle);

			if (spinEditFalta.Value > cantidadTotal | spinEditFalta.Value < 0)
			{
				spinEditFalta.Value = (int)lineaGrid.CANTIDAD;
			}

			try { cantidadTotal = (int)lineaGrid.CANTIDAD - Convert.ToInt32(spinEditFalta.Value); }
			catch (Exception ex) { cantidadTotal = 0; }

			spinEditCantidadBuena.Value = cantidadTotal - spinEditCantidadMala.Value;
		}

		private void gridViewAviso_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			V_RECEPCIONES_LIN lineaGrid = (V_RECEPCIONES_LIN)gridViewAviso.GetRow(gridViewAviso.FocusedRowHandle);

			spinEditCantidadBuena.Value = 0;
			spinEditCantidadMala.Value = 0;

			cantidadTotal = Convert.ToInt32(lineaGrid.CANTIDAD);
			spinEditCantidadBuena.Value = cantidadTotal;
		}

		
	}
}
