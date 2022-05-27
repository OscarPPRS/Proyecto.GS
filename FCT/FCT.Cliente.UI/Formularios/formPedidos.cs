
using FCT.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCT.Cliente.UI.Formularios
{
	public partial class formPedidos : Form
	{
		
		//Lista con las lineas del pedido que se está creando
		public BindingList<LineaPedido> lineasGrid = new BindingList<LineaPedido>();

		public formPedidos()
		{
			InitializeComponent();
		}

		
		//Activamos los grids
		private void formPedidos_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			actualizarGrids();
			actualizarListaPedidos();
		}

		//Actualizacion de componentes visuales
		#region 

		//Código para recargar el listbox con los archivos que hay guardados.
		private void actualizarListaPedidos()
		{
			this.listBoxControlPedidos.SelectedIndexChanged -= new EventHandler(listBoxControlPedidos_SelectedIndexChanged);
			listBoxControlPedidos.Items.Clear();
			try
			{
				var archivos = Directory.GetFiles(formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\guardados\\", "*.dat");
				foreach (var a in archivos)
				{
					using (Stream stream = File.Open(a, FileMode.Open))
					{

						BinaryFormatter formatter = new BinaryFormatter();
						CabeceraPedido cab = (CabeceraPedido)formatter.Deserialize(stream);
						//Solo añade los de la empresa que tengamos elegida.

						if (cab.nombre_cliente == formContenedor.idEmpresa)
						{
							listBoxControlPedidos.Items.Add(cab);
						}

					}
				}
			}
			catch (Exception){}

			listBoxControlPedidos.SelectedIndex = -1;

			this.listBoxControlPedidos.SelectedIndexChanged += new EventHandler(listBoxControlPedidos_SelectedIndexChanged);

		}

		//Funcion para actualizar los grids del formulario
		private void actualizarGrids()
		{

			vISTAREFERENCIASBindingSource.DataSource = CargarGrids.referenciasDisponibles(formContenedor.idEmpresa);
			lineaPedidoBindingSource.DataSource = lineasGrid;

		}

		#endregion


		//Gestion de botones
		#region

		//Actualiza el grid
		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}


		//Añade una linea nueva al pedido
		private void simpleButtonAnadirLinea_Click(object sender, EventArgs e)
		{
			//Desactiva el boton de traspaso mientras haya cambios sin guardar
			simpleButtonTraspaso.Enabled = false;

			if (spinEditCantidad.Value <= 0) { MessageBox.Show("Introduce un número mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			else
			{
				//Obtiene los datos de la referencia seleccionada
				V_REFERENCIAS referencia = (V_REFERENCIAS)gridViewReferencias.GetRow(gridViewReferencias.FocusedRowHandle);
				bool lineaRepetida = false;

				//Comprobacion de si las lineas que ya habian sido añadidas tienen la misma referencia, para sumar en vez de añadir una nueva.
				foreach (LineaPedido l in lineasGrid)
				{

					if (l.cod_referencia == referencia.COD_REFERENCIA)
					{
						lineaRepetida = true;
						l.cantidad += Convert.ToInt32(spinEditCantidad.Value);
						gridViewPedidos.RefreshData();
						actualizarGrids();
						break;
					}

				}
				//Añade una nueva linea si la referencia no es repetida
				if (!lineaRepetida)
				{
					LineaPedido linea = new LineaPedido(0, 0, referencia.COD_REFERENCIA, Convert.ToInt32(spinEditCantidad.Value), referencia.DES_REFERENCIA);
					lineasGrid.Add(linea);
				}

				spinEditCantidad.Value = 0;
				actualizarGrids();
			}
		}


		//Elimina la línea de la lista de lineas del pedido
		private void simpleButtonQuitarLinea_Click(object sender, EventArgs e)
		{
			simpleButtonTraspaso.Enabled = false;

			LineaPedido linea = (LineaPedido)gridViewPedidos.GetRow(gridViewPedidos.FocusedRowHandle);

			lineasGrid.Remove(linea);


		}


		//Genera el pedido y lo guarda en archivos.
		private void simpleButtonGenerarPedido_Click(object sender, EventArgs e)
		{
			//Confirmacion y comprobacion de errores
			var result = MessageBox.Show("¿Estás seguro de que deseas guardar un pedido nuevo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				if (textEditDireccion.Text == "" | textEditCodigoPostal.Text == "" | textEditPoblacion.Text == "" |
			textEditProvincia.Text == "" | textEditTelefono.Text == "")
				{ MessageBox.Show("Por favor rellene todos los campos de la cabecera del pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				else if (lineasGrid.Count == 0) { MessageBox.Show("Las lineas del pedido no pueden estar vacías.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error); }
				else
				{
					//Numera las lineas
					int n = 0;
					foreach (LineaPedido l in lineasGrid)
					{
						n++;
						l.cod_linea = n;
					}
					//Genera un nuevo objeto con los datos proporcionados
					Random r = new Random();

					int cod = r.Next(999999999);

					CabeceraPedido cab = new CabeceraPedido(cod, 1, formContenedor.idEmpresa, textEditDireccion.Text, textEditCodigoPostal.Text,
					textEditPoblacion.Text, textEditProvincia.Text, textEditTelefono.Text, DateTime.Now.ToShortDateString(), lineasGrid.ToList());

					//Limpia los controles y deshabilita los necesarios

					textEditDireccion.Text = "";
					textEditCodigoPostal.Text = "";
					textEditProvincia.Text = "";
					textEditPoblacion.Text = "";
					textEditTelefono.Text = "";

					simpleButtonTraspaso.Enabled = false;
					simpleButtonModificarPedido.Enabled = false;
					simpleButtonEliminarPedido.Enabled = false;

					string nombreArchivo = cod.ToString();

					//Serializa el archivo y lo guarda
					try
					{
						using (Stream stream = File.Open(formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\guardados\\" + nombreArchivo + ".dat", FileMode.Create))
						{
							BinaryFormatter formatter = new BinaryFormatter();

							formatter.Serialize(stream, cab);
						}
					}
					catch (Exception){}

					lineasGrid.Clear();
					actualizarListaPedidos();
				}
			}
		}


		//Codigo para borrar el pedido seleccionado
		private void simpleButtonEliminarPedido_Click(object sender, EventArgs e)
		{		

			var result = MessageBox.Show("¿Estás seguro de que deseas eliminar el pedido? No podrás recuperarlo después de esta acción.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
			//Elimina el archivo
				try
				{
					File.Delete(formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\guardados\\" + listBoxControlPedidos.SelectedItem + ".dat");
				}
				catch (Exception){}

				actualizarListaPedidos();

				textEditDireccion.Text = "";
				textEditCodigoPostal.Text = "";
				textEditProvincia.Text = "";
				textEditPoblacion.Text = "";
				textEditTelefono.Text = "";

				lineasGrid.Clear();

				//Codigo de los botones para desactivarlos tras eliminar una referencia
				if (listBoxControlPedidos.SelectedIndex >= 0)
				{
					simpleButtonTraspaso.Enabled = true;
					simpleButtonModificarPedido.Enabled = true;
					simpleButtonEliminarPedido.Enabled = true;
				}
				else
				{
					simpleButtonTraspaso.Enabled = false;
					simpleButtonModificarPedido.Enabled = false;
					simpleButtonEliminarPedido.Enabled = false;
				}

			}

		}


		//Modifica el archivo seleccionado, sobreescribiendolo con los nuevos datos proporcionados.
		private void simpleButtonModificarPedido_Click(object sender, EventArgs e)
		{

			
			try
			{
				//Modifica los datos de la cabecera seleccionada con los datos de los textbox

				CabeceraPedido cab = (CabeceraPedido)listBoxControlPedidos.SelectedItem;

				cab.direccion_entrega = textEditDireccion.Text;
				cab.cod_postal = textEditCodigoPostal.Text;
				cab.provincia = textEditProvincia.Text;
				cab.poblacion = textEditPoblacion.Text;
				cab.telefono = textEditTelefono.Text;

				cab.lineasPedido = lineasGrid.ToList();

				//Serializa el archivo y sobreescribe el archivo anterior.

				using (Stream stream = File.Create(formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\guardados\\" + cab.cod_peticion + ".dat"))
				{
					BinaryFormatter formatter = new BinaryFormatter();

					formatter.Serialize(stream, cab);
				}

				//Limpieza de controles

				textEditDireccion.Text = "";
				textEditCodigoPostal.Text = "";
				textEditProvincia.Text = "";
				textEditPoblacion.Text = "";
				textEditTelefono.Text = "";

				simpleButtonTraspaso.Enabled = false;
				simpleButtonModificarPedido.Enabled = false;
				simpleButtonEliminarPedido.Enabled = false;

				lineasGrid.Clear();
				actualizarListaPedidos();

			}

			catch (Exception){}
		}


		//Mueve el archivo a los traspasos donde será posteriormente analizado por el programa de gestion
		private void simpleButtonTraspaso_Click(object sender, EventArgs e)
		{

			var result = MessageBox.Show("¿Estás seguro de que deseas traspasar el pedido a ICP? No podrás editarlo después de esta acción.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{

				//Recuperamos los datos del pedido seleccionado

				CabeceraPedido cabeceraRecuperada = new CabeceraPedido();
				using (Stream stream = File.Open(formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\guardados\\" + listBoxControlPedidos.Text + ".dat", FileMode.Open))
				{
					BinaryFormatter formatter = new BinaryFormatter();
					cabeceraRecuperada = (CabeceraPedido)formatter.Deserialize(stream);
				}

				//Codigo para comprobar linea a linea si hay stock con respecto a la cantidad pedida, guarda los nombres de las referencias sin stock y las muestra.

				List<string> productosSinStock = new List<string>();

				bool hayStock = true;
				foreach (LineaPedido lineaRecuperada in cabeceraRecuperada.lineasPedido)
				{

					//Recorre los archivos traspasados para revisar si la suma de esas cantidades supera al stock

					foreach (string archivo in Directory.EnumerateFiles(formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\traspasados\\", "*.dat"))
					{
						string peticion;
						using (Stream stream = File.Open(archivo, FileMode.Open))
						{

							BinaryFormatter formatter = new BinaryFormatter();
							CabeceraPedido cabeceraRecuperadaComparada = (CabeceraPedido)formatter.Deserialize(stream);

							peticion = cabeceraRecuperadaComparada.cod_peticion.ToString();

							foreach (LineaPedido lineaRecuperadaComparada in cabeceraRecuperadaComparada.lineasPedido)
							{

								if (lineaRecuperada.cod_referencia == lineaRecuperadaComparada.cod_referencia)
								{

									lineaRecuperada.cantidad += lineaRecuperadaComparada.cantidad;

								}
							}

						}
					}

					//Comprueba la cantidad para ver si hay stock suficiente

					if (lineaRecuperada.cantidad > Consultas.stock(lineaRecuperada.cod_referencia))
					{
						hayStock = false;
						productosSinStock.Add(lineaRecuperada.descripcion_referencia);
					}
				}

				if (!hayStock)
				{
				//Muestra los articulos sin stock
					var mensaje = "Falta stock de los siguientes artículos: \n \n" + string.Join(Environment.NewLine, productosSinStock);
					MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


				}
				else if (cabeceraRecuperada.lineasPedido.Count <= 0)
				{

					MessageBox.Show("El pedido tiene que tener líneas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					//Si hay stock, cambia el archivo de carpeta, simulando que se ha traspasado a ICP para que lea el archivo y reciba la información del pedido.
					try
					{

						File.Move(formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\guardados\\" + cabeceraRecuperada.cod_peticion + ".dat",
									formContenedor.rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\traspasados\\" + cabeceraRecuperada.cod_peticion + ".dat");

					}
					catch (Exception){}

					//Limpieza de componentes
					MessageBox.Show("Pedido traspasado a ICP correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

					textEditDireccion.Text = "";
					textEditCodigoPostal.Text = "";
					textEditProvincia.Text = "";
					textEditPoblacion.Text = "";
					textEditTelefono.Text = "";

					lineasGrid.Clear();
					actualizarListaPedidos();

				}
			}

		}


		#endregion


		//Muestra los datos al seleccionar un elemento del listbox y activa los componentes necesarios.
		private void listBoxControlPedidos_SelectedIndexChanged(object sender, EventArgs e)
		{

			//Activa los botones solo si hay fila seleccionada
			if (listBoxControlPedidos.SelectedIndex >= 0)
			{
				simpleButtonTraspaso.Enabled = true;
				simpleButtonModificarPedido.Enabled = true;
				simpleButtonEliminarPedido.Enabled = true;
			}
			else
			{
				simpleButtonTraspaso.Enabled = false;
				simpleButtonModificarPedido.Enabled = false;
				simpleButtonEliminarPedido.Enabled = false;
			}

			try
			{
			//Muestra los datos del pedido que se ha seleccionado
				CabeceraPedido cab = (CabeceraPedido)listBoxControlPedidos.SelectedItem;
				lineasGrid = new BindingList<LineaPedido>(cab.lineasPedido);
				actualizarGrids();

				textEditDireccion.Text = cab.direccion_entrega;
				textEditCodigoPostal.Text = cab.cod_postal;
				textEditProvincia.Text = cab.provincia;
				textEditPoblacion.Text = cab.poblacion;
				textEditTelefono.Text = cab.telefono;
			}
			
			catch (Exception) {}
		}

		//Activa o desactiva el boton de eliminar lineas dependiendo de si hay algo seleccionado.
		private void gridViewPedidos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{

			//Activa los botones si hay linea seleccionada
			if (gridViewPedidos.SelectedRowsCount > 0)
			{
				simpleButtonQuitarLinea.Enabled = true;
			}
			else
			{
				simpleButtonQuitarLinea.Enabled = false;
			}
		}

		
	}
}
