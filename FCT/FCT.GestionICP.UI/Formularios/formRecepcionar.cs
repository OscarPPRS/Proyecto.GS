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

		private void formRecepcionar_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			checkButtonAniadirReferencia.Appearance.BackColor = Color.LightBlue;
			checkButtonAniadirReferencia.Appearance.BackColor2 = Color.DarkBlue;
			checkButtonFalta.Appearance.BackColor = Color.LightBlue;
			checkButtonFalta.Appearance.BackColor2 = Color.DarkBlue;
			checkButtonExcedente.Appearance.BackColor = Color.LightBlue;
			checkButtonExcedente.Appearance.BackColor2 = Color.DarkBlue;
		}

		//Variables para guardar la informacion del aviso

		BindingList<V_RECEPCIONES_LIN> vistaAvisos = new BindingList<V_RECEPCIONES_LIN>();
		V_RECEPCIONES_LIN lineaGrid = new V_RECEPCIONES_LIN();
		BindingList<V_RECEPCIONES_LIN> lineasRecepcionadas = new BindingList<V_RECEPCIONES_LIN>();

		//Actualizar grids
		public void actualizarGrids()
		{
			vRECEPCIONESLINBindingSource.DataSource = vistaAvisos;
			vRECEPCIONESLINBindingSource1.DataSource = lineasRecepcionadas;
		}

		//Comportamiento de botones
		#region

		//Busca el numero de albaran introducido entre los albaranes de la base de datos y muestra los datos del aviso
		private void simpleButtonBuscar_Click(object sender, EventArgs e)
		{

			
			try
			{
				RECEPCIONES_CAB aviso = Consultas.buscarAviso(Convert.ToInt32(textEditAlbaran.Text));

				labelControlNombreEmpresa.Text = Consultas.nombreEmpresa((int)aviso.ID_EMPRESA);
				labelControlFechaCreacion.Text = Convert.ToDateTime(aviso.FECH_CREACION).Date.ToString("dd/MM/yyyy");
				textEditFechaLlegada.EditValue = Convert.ToDateTime(aviso.FECH_LLEGADA);

				vistaAvisos = CargarGrids.recepcionarAvisos(Convert.ToInt32(textEditAlbaran.Text));
				lineasRecepcionadas.Clear();
				
				actualizarGrids();
			}
			catch (Exception)
			{
				MessageBox.Show("El número de albarán no ha sido encontrado entre los avisos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}																
		}
		
		private void simpleButtonConfirmarLinea_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("¿Estás seguro de que deseas confirmar la línea?.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				//Si hay referencia nueva, la genera y posteriormente añade una linea con ella.

				if (checkButtonAniadirReferencia.Checked)
				{
					if (textEditDescripcionReferencia.Text == "" | textEditPrecio.Text == "")
					{ MessageBox.Show("Por favor rellena los campos de la referencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
					else
					{
						try
						{
							//Introducimos la referencia en l abase de datos
							ProcedimientosAlmacenados.referencias(0, null, Consultas.idEmpresa(labelControlNombreEmpresa.Text), textEditDescripcionReferencia.Text,
										decimal.Parse(textEditPrecio.Text.Replace(" €", "")), null, true);

							//Obtenemos el codigo de esa referencia
							string codRefe = Consultas.referenciaInsertada(textEditDescripcionReferencia.Text);

							V_RECEPCIONES_LIN linea = new V_RECEPCIONES_LIN();

							linea.ALBARAN = Convert.ToInt32(textEditAlbaran.Text);
							linea.COD_LINEA = 0;
							linea.COD_REFERENCIA = codRefe;
							linea.CANTIDAD = Convert.ToInt32(spinEditCantidadBuena.Value);
							linea.CANTIDAD_MAL_ESTADO = Convert.ToInt32(spinEditCantidadMala.Value);
							linea.EXCEDENTE = Convert.ToInt32(spinEditExcedente.Value);
							linea.FALTA = Convert.ToInt32(spinEditFalta.Value);
							linea.DES_REFERENCIA = textEditDescripcionReferencia.Text;

							//La añadimos al grid
							lineasRecepcionadas.Add(linea);

							spinEditCantidadBuena.Value = 0;
							spinEditCantidadMala.Value = 0;
							spinEditExcedente.Value = 0;
							spinEditFalta.Value = 0;


							textEditDescripcionReferencia.Text = "";
							textEditPrecio.Text = "";

						}
						catch (Exception ex)
						{

							MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

						checkButtonAniadirReferencia.Checked = false;
						checkButtonFalta.Checked = false;
						checkButtonExcedente.Checked = false;
					}
				}


				//Añade los datos de la referencia del aviso

				else
				{
					if (gridViewAviso.SelectedRowsCount > 0)
					{
						try
						{
							//Añadimos los datos del grid del aviso a la linea confirmada
							V_RECEPCIONES_LIN linea = new V_RECEPCIONES_LIN();

							linea.ALBARAN = lineaGrid.ALBARAN;
							linea.COD_LINEA = 0;
							linea.COD_REFERENCIA = lineaGrid.COD_REFERENCIA;
							linea.CANTIDAD = Convert.ToInt32(spinEditCantidadBuena.Value);
							linea.CANTIDAD_MAL_ESTADO = Convert.ToInt32(spinEditCantidadMala.Value);
							linea.EXCEDENTE = Convert.ToInt32(spinEditExcedente.Value);
							linea.FALTA = Convert.ToInt32(spinEditFalta.Value);
							linea.DES_REFERENCIA = lineaGrid.DES_REFERENCIA;

							lineasRecepcionadas.Add(linea);

							//La quitamos del grid de aviso
							vistaAvisos.Remove(lineaGrid);
							actualizarGrids();

							spinEditCantidadBuena.Value = 0;
							spinEditCantidadMala.Value = 0;
							spinEditExcedente.Value = 0;
							spinEditFalta.Value = 0;
							if (gridViewAviso.DataRowCount == 0) { simpleButtonConfirmarRecepcion.Enabled = true; }
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

						checkButtonAniadirReferencia.Checked = false;
						checkButtonFalta.Checked = false;
						checkButtonExcedente.Checked = false;

					}
					else
					{
						MessageBox.Show("Seleccione una línea para confirmar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}


				}

				

			}
			
			
		}

		private void simpleButtonConfirmarRecepcion_Click(object sender, EventArgs e)
		{
			if (textEditAlbaran.Text == ""  |
			textEditFechaLlegada.Text == "") { MessageBox.Show("Por favor rellene todos los campos de la cabecera del aviso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

			else if (gridViewAviso.RowCount > 0) { MessageBox.Show("Por favor, confirme todas las líneas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

			else 
			{
				var result = MessageBox.Show("¿Estás seguro de que deseas confirmar la recepción?.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					
					//Modificar Cabecera
					ProcedimientosAlmacenados.recepcionesCabeceras(1,Convert.ToInt32(textEditAlbaran.Text), 2, Consultas.idEmpresa(labelControlNombreEmpresa.Text),
					Convert.ToDateTime(labelControlFechaCreacion.Text), (DateTime)textEditFechaLlegada.EditValue);

					//Borrar Lineas antiguas
					ProcedimientosAlmacenados.recepcionesLineas(2,Convert.ToInt32(textEditAlbaran.Text), 0, null, 0, 0, 0, 0 );
				
					int numerador = 0;

					foreach (V_RECEPCIONES_LIN l in lineasRecepcionadas)
					{
						numerador++;

						//Insertar lineas, insertar palets y enviar correo

						ProcedimientosAlmacenados.recepcionesLineas(0,l.ALBARAN, numerador, l.COD_REFERENCIA, (int)l.CANTIDAD,
						(int)l.CANTIDAD_MAL_ESTADO, (int)l.EXCEDENTE, (int)l.FALTA);

						if (l.CANTIDAD > 0) { ProcedimientosAlmacenados.palets(0, l.COD_REFERENCIA, 3, (int)l.CANTIDAD, l.ALBARAN); }

						if (l.CANTIDAD_MAL_ESTADO > 0) { ProcedimientosAlmacenados.palets(0, l.COD_REFERENCIA, 6, (int)l.CANTIDAD_MAL_ESTADO, l.ALBARAN); }

						if (l.EXCEDENTE > 0) { ProcedimientosAlmacenados.palets(0, l.COD_REFERENCIA, 3, (int)l.EXCEDENTE, l.ALBARAN); }
					}

					ProcedimientosAlmacenados.enviarCorreo("ols17697@gmail.com", "Material recibido en ICP " + textEditAlbaran.Text, Convert.ToInt32(textEditAlbaran.Text));

					//Generacion de etiquetas

					//using (StreamWriter escribir = new StreamWriter(formContenedor.rutaCarpetaDatos + "\\Recursos\\eti\\imprimir.bat"))
					//{
					//	escribir.WriteLine("copy " + formContenedor.rutaCarpetaDatos + "\\Recursos\\eti\\etiquetaPalet.eti \\\\AWORK344\\ETI_ICP");
					//}

					//foreach (string etiqueta in Consultas.etiquetasRecepcion(Convert.ToInt32(textEditAlbaran.Text)))
					//{

					//	using (StreamWriter escribir = new StreamWriter(formContenedor.rutaCarpetaDatos + "\\Recursos\\eti\\etiquetaPalet.eti"))
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

				}

				//Limpieza de controles
				simpleButtonConfirmarRecepcion.Enabled = false;
				lineasRecepcionadas.Clear();
							
				
				foreach (var textboxitem in this.Controls.OfType<TextEdit>())
				{
					textboxitem.Text = "";
				}

			}
		}


		#endregion

		//Comportamiento checkbuttons, activan o desactivan otros controles dependiendo de lo que haya activado, excedente y falta no pueden estar activos a la vez
		#region
		private void checkButtonAniadirReferencia_CheckedChanged(object sender, EventArgs e)
		{


			if (checkButtonAniadirReferencia.Checked)
			{

				textEditDescripcionReferencia.Enabled = true;
				textEditPrecio.Enabled = true;
				checkButtonAniadirReferencia.Appearance.BackColor = Color.LightGreen;
				checkButtonAniadirReferencia.Appearance.BackColor2 = Color.DarkGreen;
				cantidadTotal = 0;
				panelReferenciaDesconocida.Visible = true;
			}

			else
			{

				textEditDescripcionReferencia.Enabled = false;
				textEditPrecio.Enabled = false;
				checkButtonAniadirReferencia.Appearance.BackColor = Color.LightBlue;
				checkButtonAniadirReferencia.Appearance.BackColor2 = Color.DarkBlue;

				try
				{
					cantidadTotal = Convert.ToInt32(lineaGrid.CANTIDAD);
				}
				catch (Exception) { }

				spinEditCantidadBuena.Value = cantidadTotal;
				panelReferenciaDesconocida.Visible = false;

			}
		}

		private void checkButtonFalta_CheckedChanged(object sender, EventArgs e)
		{
			if (checkButtonFalta.Checked)
			{
				panelFalta.Visible = true;
				checkButtonExcedente.Checked = false;
				checkButtonFalta.Appearance.BackColor = Color.LightGreen;
				checkButtonFalta.Appearance.BackColor2 = Color.DarkGreen;
			}

			else
			{
				panelFalta.Visible = false;
				spinEditFalta.Value = 0;
				checkButtonFalta.Appearance.BackColor = Color.LightBlue;
				checkButtonFalta.Appearance.BackColor2 = Color.DarkBlue;
			}
		}

		private void checkButtonExcedente_CheckedChanged(object sender, EventArgs e)
		{
			if (checkButtonExcedente.Checked)
			{
				panelExcedente.Visible = true;
				checkButtonFalta.Checked = false;
				checkButtonExcedente.Appearance.BackColor = Color.LightGreen;
				checkButtonExcedente.Appearance.BackColor2 = Color.DarkGreen;
			}

			else
			{
				panelExcedente.Visible = false;
				spinEditExcedente.Value = 0;
				checkButtonExcedente.Appearance.BackColor = Color.LightBlue;
				checkButtonExcedente.Appearance.BackColor2 = Color.DarkBlue;
			}
		}

		#endregion

		//Comportamiento spinedits
		#region
		int cantidadTotal = 0;
		int diferencia = 0;
		private void spinEditCantidadBuena_EditValueChanged(object sender, EventArgs e)
		{
			//Primero revisa si la cantidad de la linea es 0, esto seria por ejemplo al añadir referencia desconocida que no recibimos una linea, aqui 
			// el codigo ignora el control de cantidad
			if (cantidadTotal != 0){

				//Si escribimos mas cantidad de la que trae la linea, fija el total 
				if (spinEditCantidadBuena.Value > cantidadTotal)
				{
					spinEditCantidadBuena.Value = cantidadTotal;
					spinEditCantidadMala.Value = 0;
				}

				//Si baja de 0, lo pone en 0
				else if (spinEditCantidadBuena.Value < 0)
				{
					spinEditCantidadBuena.Value = 0;
				}

				//Si escribimos mas del limite actual que podemos escribir, lo escribe en ese limite
				else if (spinEditCantidadBuena.Value > diferencia)
				{
					spinEditCantidadBuena.Value = diferencia;
					spinEditCantidadMala.Value = 0;
				}

				//Al cambiar la cantidad, escribe la cantidad cambiada en el otro spinedit
				spinEditCantidadMala.Value = diferencia - spinEditCantidadBuena.Value;

			}

			//Esto gestiona el texto de la cantidad total recibida, dependiendo de si es referencia desconocida o no
			if (checkButtonAniadirReferencia.Checked) {
				labelControlDiferencia.Text = (spinEditCantidadBuena.Value + spinEditCantidadMala.Value + spinEditExcedente.Value).ToString();
			}
			else{
				labelControlDiferencia.Text = (diferencia + (int)spinEditExcedente.Value).ToString();
			}
			

		}

		private void spinEditCantidadMala_EditValueChanged(object sender, EventArgs e)
		{

			

			if (cantidadTotal != 0)
			{
				if (spinEditCantidadMala.Value > cantidadTotal)
				{
					spinEditCantidadMala.Value = cantidadTotal;
					spinEditCantidadBuena.Value = 0;
				}

				else if (spinEditCantidadMala.Value < 0)
				{
					spinEditCantidadMala.Value = 0;
				}

				else if (spinEditCantidadMala.Value > diferencia)
				{
					spinEditCantidadMala.Value = diferencia;
					spinEditCantidadBuena.Value = 0;
				}

				spinEditCantidadBuena.Value = diferencia - spinEditCantidadMala.Value;
			}

			if(checkButtonAniadirReferencia.Checked) {
				labelControlDiferencia.Text = (spinEditCantidadBuena.Value + spinEditCantidadMala.Value + spinEditExcedente.Value).ToString();
			}
			else
			{
				labelControlDiferencia.Text = (diferencia + (int)spinEditExcedente.Value).ToString();
			}


		}

		private void spinEditFalta_EditValueChanged(object sender, EventArgs e)
		{


			if (cantidadTotal != 0)
			{

				diferencia = cantidadTotal - (int)spinEditFalta.Value;

				if (spinEditFalta.Value > cantidadTotal)
				{
					spinEditFalta.Value = cantidadTotal;
					spinEditCantidadBuena.Value = 0;
					spinEditCantidadMala.Value = 0;
				}

				else if (spinEditFalta.Value < 0)
				{
					spinEditFalta.Value = 0;
					spinEditCantidadBuena.Value = cantidadTotal;
					spinEditCantidadMala.Value = 0;
				}

				spinEditCantidadBuena.Value = diferencia;
			}

			if (checkButtonAniadirReferencia.Checked)
			{
				labelControlDiferencia.Text = (spinEditCantidadBuena.Value + spinEditCantidadMala.Value + spinEditExcedente.Value).ToString();
			}
			else
			{
				labelControlDiferencia.Text = (diferencia + (int)spinEditExcedente.Value).ToString();
			}


		}

		private void spinEditExcedente_EditValueChanged(object sender, EventArgs e)
		{
			if (checkButtonAniadirReferencia.Checked)
			{
				labelControlDiferencia.Text = (spinEditCantidadBuena.Value + spinEditCantidadMala.Value + spinEditExcedente.Value).ToString();
			}
			else
			{
				labelControlDiferencia.Text = (diferencia + (int)spinEditExcedente.Value).ToString();
			}
		}
		#endregion

		//Obtener datos de la linea del aviso seleccionada
		private void gridViewAviso_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
		{
			lineaGrid = (V_RECEPCIONES_LIN)gridViewAviso.GetRow(gridViewAviso.FocusedRowHandle);

			spinEditCantidadBuena.Value = 0;
			spinEditCantidadMala.Value = 0;

			try { 
				cantidadTotal = Convert.ToInt32(lineaGrid.CANTIDAD);
				diferencia = Convert.ToInt32(lineaGrid.CANTIDAD);
				spinEditCantidadBuena.Value = cantidadTotal;
			}
			catch (Exception ex) { }
			
		}

		//Para buscar al darle al enter
		private void textEditAlbaran_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				simpleButtonBuscar_Click(this, new EventArgs());
			}
		}

		
	}
}
