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
			spinEditCantidadBuena.Properties.Mask.EditMask = "f0";
			spinEditCantidadMala.Properties.Mask.EditMask = "f0";
			textEditDescripcionReferencia.Enabled = false;
			textEditPrecio.Enabled = false;
			checkButtonAniadirReferencia.Appearance.BackColor = Color.LightBlue;
			checkButtonAniadirReferencia.Appearance.BackColor2 = Color.DarkBlue;
		}


		private void simpleButtonBuscar_Click(object sender, EventArgs e)
		{


			try
			{
				RECEPCIONES_CAB aviso = Consultas.buscarAviso(Convert.ToInt32(textEditAlbaran.Text));

				textEditNombreEmpresa.Text = aviso.PROVEEDOR;
				textEditFechaCreacionAviso.EditValue = Convert.ToDateTime(aviso.FECH_CREACION);
				textEditFechaLlegada.EditValue = Convert.ToDateTime(aviso.FECH_LLEGADA);

				vistaAvisos = Consultas.gridRecepcionarAvisos(Convert.ToInt32(textEditAlbaran.Text));
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
			if (checkButtonAniadirReferencia.Checked)
			{
				if (textEditDescripcionReferencia.Text == "" | textEditPrecio.Text == "")
				{ MessageBox.Show("Por favor rellena los campos de la referencia.");}
				else{
					string codRefe = ProcedimientosAlmacenados.referencias(0,null,Consultas.idEmpresa(textEditNombreEmpresa.Text), textEditDescripcionReferencia.Text,
					decimal.Parse(textEditPrecio.Text.Replace(".", ",")), null, true);

					LineaAviso linea = new LineaAviso(Convert.ToInt32(textEditAlbaran.Text), 0, codRefe, 
					Convert.ToInt32(spinEditCantidadBuena.Value), Convert.ToInt32(spinEditCantidadMala.Value), textEditDescripcionReferencia.Text);

					lineasRecibidas.Add(linea);

					spinEditCantidadBuena.Value = 0;
					spinEditCantidadMala.Value = 0;

					textEditDescripcionReferencia.Text = "";
					textEditPrecio.Text = "";
				}
			}	
			else{
				if (gridViewAviso.SelectedRowsCount > 0)
				{
					V_RECEPCIONES_LIN lineaGrid = (V_RECEPCIONES_LIN)gridViewAviso.GetRow(gridViewAviso.FocusedRowHandle);
					LineaAviso linea = new LineaAviso(lineaGrid.ALBARAN, 0, lineaGrid.COD_REFERENCIA,
					Convert.ToInt32(spinEditCantidadBuena.Value), Convert.ToInt32(spinEditCantidadMala.Value), lineaGrid.DES_REFERENCIA);				

					lineasRecibidas.Add(linea);

					vistaAvisos.Remove(lineaGrid);
					actualizarGrids();

					spinEditCantidadBuena.Value = 0;
					spinEditCantidadMala.Value = 0;
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
					ProcedimientosAlmacenados.recepcionesCabeceras(1,Convert.ToInt32(textEditAlbaran.Text), 2, textEditNombreEmpresa.Text,
					(DateTime)textEditFechaCreacionAviso.EditValue, (DateTime)textEditFechaLlegada.EditValue);

					//Borrar Lineas antiguas
					ProcedimientosAlmacenados.recepcionesLineas(2,Convert.ToInt32(textEditAlbaran.Text), 0, null, 0);

					
					
					int numerador = 0;

					foreach (LineaAviso l in lineasRecibidas)
					{
						numerador++;

						//Insertar lineas, insertar palets y enviar correo

						ProcedimientosAlmacenados.recepcionesLineas(0,l.albaran, numerador, l.cod_referencia, (int)l.cantidadBuena);

						if (l.cantidadBuena > 0) { ProcedimientosAlmacenados.palets(0, l.cod_referencia, 1, (int)l.cantidadBuena, l.albaran); }

						if (l.cantidadMala > 0) { ProcedimientosAlmacenados.palets(0, l.cod_referencia, 2, (int)l.cantidadMala, l.albaran); }
					}

					ProcedimientosAlmacenados.enviarCorreo("ols17697@gmail.com", "Material recibido en ICP " + textEditAlbaran.Text, Convert.ToInt32(textEditAlbaran.Text));

					//Generacion de etiquetas

					using (StreamWriter escribir = new StreamWriter(Application.StartupPath + "\\..\\..\\..\\Recursos\\eti\\imprimir.bat"))
					{
						escribir.WriteLine("copy " + Application.StartupPath + "\\..\\..\\..\\Recursos\\eti\\etiquetaPalet.eti" + " \\\\AWORK344\\ETI_ICP");
					}

					foreach (string etiqueta in Consultas.etiquetas(Convert.ToInt32(textEditAlbaran.Text))) {
						
						using (StreamWriter escribir = new StreamWriter(Application.StartupPath + "\\..\\..\\..\\Recursos\\eti\\etiquetaPalet.eti"))
						{
							escribir.WriteLine(etiqueta);
							
						}
						//System.Diagnostics.Process proc = new System.Diagnostics.Process();
						//proc.StartInfo.UseShellExecute = false;
						//proc.StartInfo.FileName = Application.StartupPath + "\\..\\..\\..\\Recursos\\eti\\imprimir.bat";
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

		
	}
}
