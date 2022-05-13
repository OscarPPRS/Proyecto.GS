
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
		
		public BindingList<LineaPedido> lineasGrid = new BindingList<LineaPedido>();

		public formPedidos()
		{
			InitializeComponent();
		}

		private void formPedidos_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			actualizarGrids();
			actualizarListaPedidos();
			spinEditCantidad.Properties.Mask.EditMask = "f0";

			simpleButtonTraspaso.Enabled = false;
			simpleButtonModificarPedido.Enabled = false;
			simpleButtonEliminarPedido.Enabled = false;
			simpleButtonQuitarLinea.Enabled = false;
		}		


		private void actualizarGrids()
		{

			vISTAREFERENCIASBindingSource.DataSource = Negocio.CargarGrids.referenciasAvisos(formContenedor.idEmpresa);
			lineaPedidoBindingSource.DataSource = lineasGrid;

		}

		private void simpleButtonAnadirLinea_Click(object sender, EventArgs e)
		{

			if (spinEditCantidad.Value <= 0) { MessageBox.Show("Introduce un número mayor que 0."); }
			else
			{
				V_REFERENCIAS referencia = (V_REFERENCIAS)gridViewReferencias.GetRow(gridViewReferencias.FocusedRowHandle);
				bool lineaRepetida = false;


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

				if (!lineaRepetida)
				{


					LineaPedido linea = new LineaPedido(0, 0, referencia.COD_REFERENCIA, Convert.ToInt32(spinEditCantidad.Value), referencia.DES_REFERENCIA);

					lineasGrid.Add(linea);
				}

				spinEditCantidad.Value = 0;
				actualizarGrids();
			}
		}

		private void simpleButtonQuitarLinea_Click(object sender, EventArgs e)
		{

			
			LineaPedido linea = (LineaPedido)gridViewPedidos.GetRow(gridViewPedidos.FocusedRowHandle);

			lineasGrid.Remove(linea);

			
		}

		private void simpleButtonGenerarPedido_Click(object sender, EventArgs e)
		{

			if (textEditDireccion.Text == "" | textEditCodigoPostal.Text == "" | textEditPoblacion.Text == "" |
			textEditProvincia.Text == "" | textEditTelefono.Text == "")
			{ MessageBox.Show("Por favor rellene todos los campos de la cabecera del pedido."); }
			else if (lineasGrid.Count == 0) { MessageBox.Show("Las lineas del pedido no pueden estar vacías."); }
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

				textEditDireccion.Text = "";
				textEditCodigoPostal.Text = "";
				textEditProvincia.Text = "";
				textEditPoblacion.Text = "";
				textEditTelefono.Text = "";

				string nombreArchivo = cod.ToString();

				//Serializa el archivo y lo guarda
				try
				{
					using (Stream stream = File.Open("\\\\m2d96\\Publico" + "\\Recursos\\data\\pedidos\\guardados\\" + nombreArchivo + ".dat", FileMode.Create))
					{
						BinaryFormatter formatter = new BinaryFormatter();

						formatter.Serialize(stream, cab);
					}
				}
				catch (Exception)
				{

					throw;
				}


				lineasGrid.Clear();
				actualizarListaPedidos();
			}
		}

		private void actualizarListaPedidos() {
			this.listBoxControlPedidos.SelectedIndexChanged -= new EventHandler(listBoxControlPedidos_SelectedIndexChanged);
			listBoxControlPedidos.Items.Clear();
			try
			{
				var archivos = Directory.GetFiles("\\\\m2d96\\Publico\\Recursos\\data\\pedidos\\guardados\\", "*.dat");
				foreach (var a in archivos)
				{
					using (Stream stream = File.Open(a, FileMode.Open))
					{

						BinaryFormatter formatter = new BinaryFormatter();
						CabeceraPedido cab = (CabeceraPedido)formatter.Deserialize(stream);
						if (cab.nombre_cliente == formContenedor.idEmpresa)
						{
							listBoxControlPedidos.Items.Add(cab);
						}

					}
				}
			}
			catch (Exception)
			{

				throw;
			}

			listBoxControlPedidos.SelectedIndex = -1;

			this.listBoxControlPedidos.SelectedIndexChanged += new EventHandler(listBoxControlPedidos_SelectedIndexChanged);

		}

		private void simpleButtonEliminarPedido_Click(object sender, EventArgs e)
		{
			//Codigo para borrar el pedido seleccionado

			var result = MessageBox.Show("¿Estás seguro de que deseas eliminar el pedido? No podrás recuperarlo después de esta acción.", "Aviso", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{

				try
				{
					File.Delete("\\\\m2d96\\Publico\\Recursos\\data\\pedidos\\guardados\\" + listBoxControlPedidos.SelectedItem + ".dat");
				}
				catch (Exception)
				{

					throw;
				}
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
			
			catch (Exception) { }
		}

		private void simpleButtonModificarPedido_Click(object sender, EventArgs e)
		{

			//Modifica el archivo seleccionado, sobreescribiendolo con los nuevos datos proporcionados.
			try
			{
				CabeceraPedido cab = (CabeceraPedido)listBoxControlPedidos.SelectedItem;

				cab.direccion_entrega = textEditDireccion.Text;
				cab.cod_postal = textEditCodigoPostal.Text;
				cab.provincia = textEditProvincia.Text;
				cab.poblacion = textEditPoblacion.Text;
				cab.telefono = textEditTelefono.Text;

				cab.lineasPedido = lineasGrid.ToList();

				using (Stream stream = File.Create("\\\\m2d96\\Publico\\Recursos\\data\\pedidos\\guardados\\" + cab.cod_peticion + ".dat")) { 
				BinaryFormatter formatter = new BinaryFormatter();

				formatter.Serialize(stream, cab);
				}

				textEditDireccion.Text = "";
				textEditCodigoPostal.Text = "";
				textEditProvincia.Text = "";
				textEditPoblacion.Text = "";
				textEditTelefono.Text = "";

				lineasGrid.Clear();
				actualizarListaPedidos();

			}

			catch (Exception) { }
		}

		private void simpleButtonTraspaso_Click(object sender, EventArgs e)
		{
			
			var result = MessageBox.Show("¿Estás seguro de que deseas traspasar el pedido a ICP? No podrás editarlo después de esta acción.", "Aviso", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{

				//Codigo para comprobar linea a linea si hay stock con respecto a la cantidad pedida, guarda los nombres de las referencias sin stock y las muestra.
				CabeceraPedido cab = (CabeceraPedido)listBoxControlPedidos.SelectedItem;
				List<string> faltaStock = new List<string>();

				bool hayStock = true;
				foreach (LineaPedido l in cab.lineasPedido)
				{
					
					//Recorre los archivos traspasados para revisar si la suma de esas cantidades supera al stock

					foreach (string archivo in Directory.EnumerateFiles("\\\\m2d96\\Publico\\Recursos\\data\\pedidos\\traspasados\\", "*.dat"))
					{
						string peticion;
						using (Stream stream = File.Open(archivo, FileMode.Open))
						{

							BinaryFormatter formatter = new BinaryFormatter();
							CabeceraPedido cab2 = (CabeceraPedido)formatter.Deserialize(stream);

							peticion = cab2.cod_peticion.ToString();

							foreach (LineaPedido lin in cab2.lineasPedido)
							{

								if(l.cod_referencia == lin.cod_referencia){

									l.cantidad += lin.cantidad;

								}
							}

						}
					}

					//Comprueba la cantidad para ver si hay stock suficiente

						if (l.cantidad > Consultas.stock(l.cod_referencia))
					{
						hayStock = false;
						faltaStock.Add(l.descripcion_referencia);
					}
				}

				if (hayStock)
				{

					//Si hay stock, cambia el archivo de carpeta, simulando que se ha traspasado a ICP para que lea el archivo y reciba la información del pedido.
					try
					{

						File.Move("\\\\m2d96\\Publico\\Recursos\\data\\pedidos\\guardados\\" + cab.cod_peticion + ".dat",
									"\\\\m2d96\\Publico\\Recursos\\data\\pedidos\\traspasados\\" + cab.cod_peticion + ".dat");

					}
					catch (Exception)
					{

						throw;
					}

					MessageBox.Show("Pedido traspasado a ICP correctamente.");

					textEditDireccion.Text = "";
					textEditCodigoPostal.Text = "";
					textEditProvincia.Text = "";
					textEditPoblacion.Text = "";
					textEditTelefono.Text = "";

					lineasGrid.Clear();
					actualizarListaPedidos();

				}

				else
				{
					var mensaje = "Falta stock de los siguientes artículos: \n \n" + string.Join(Environment.NewLine, faltaStock);
					MessageBox.Show(mensaje, "Error");

				}
			}		

		}

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

		private void simpleButtonActualizar_Click(object sender, EventArgs e)
		{
			actualizarGrids();
		}
	}
}
