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

namespace FCT.GestionICP.UI.Formularios
{
	public partial class formContenedor : Form
	{
		//Ruta de la carpeta en la que están los recursos del programa
		public static string rutaCarpetaDatos = "D:\\Users\\ols17\\Documents\\GitHub\\Proyecto.GS\\ProyectoCarpeta";
		public formContenedor()
		{
			InitializeComponent();
		}
		
		//Cambia el color del fondo y pone la imagen de la empresa
		private void formContenedor_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(10, 34, 64);
			Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage = Image.FromFile(rutaCarpetaDatos+"\\Recursos\\app\\ICP-background.png");
		}

		//Timer que procesa los archivos de pedidos y avisos y tambien asigna los pedidos 
		private void timer1_Tick(object sender, EventArgs e)
		{

			try
			{
				//Procesamiento de los avisos

				List<string> cabeceraAviso = new List<string>();

				foreach (string archivo in Directory.EnumerateFiles(rutaCarpetaDatos + "\\Recursos\\data\\avisos\\pendientes\\", "*.txt"))
				{
					using (StreamReader sr = new StreamReader(archivo))
					{
						//Lee el texto y separa por # paara introducirlo en un PA e insertarlo
						cabeceraAviso = sr.ReadLine().Split('#').ToList();

						string lineaTexto;

						ProcedimientosAlmacenados.recepcionesCabeceras(0, Convert.ToInt32(cabeceraAviso[0]), 1, Convert.ToInt32(cabeceraAviso[2]),
						Convert.ToDateTime(cabeceraAviso[3]), Convert.ToDateTime(cabeceraAviso[4]));

						while ((lineaTexto = sr.ReadLine()) != null)
						{

							List<string> listaAuxiliar = lineaTexto.Split('#').ToList();

							ProcedimientosAlmacenados.recepcionesLineas(0, Convert.ToInt32(cabeceraAviso[0]), Convert.ToInt32(listaAuxiliar[0]), listaAuxiliar[1], Convert.ToInt32(listaAuxiliar[2]), 0, 0, 0);
						}
					}
					//Mueve el archivo a finaliado
					File.Move(archivo, rutaCarpetaDatos + "\\Recursos\\data\\avisos\\finalizados\\" + cabeceraAviso[0] + ".txt");

				}

				//Procesamiento de pedidos
				foreach (string archivo in Directory.EnumerateFiles(rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\traspasados\\", "*.dat"))
				{
					string peticion;
					using (Stream stream = File.Open(archivo, FileMode.Open))
					{

						//Deserializa e inserta.

						BinaryFormatter formatter = new BinaryFormatter();
						CabeceraPedido cab = (CabeceraPedido)formatter.Deserialize(stream);

						peticion = cab.cod_peticion.ToString();

						ProcedimientosAlmacenados.salidasCabeceras(0, cab.cod_peticion, cab.estado, cab.nombre_cliente, cab.direccion_entrega, cab.cod_postal, cab.poblacion,
						cab.provincia, cab.telefono, Convert.ToDateTime(cab.fech_creacion));



						foreach (LineaPedido lin in cab.lineasPedido)
						{

							ProcedimientosAlmacenados.salidasLineas(0, cab.cod_peticion, lin.cod_linea, lin.cod_referencia, lin.cantidad);

						}

					}
					//Mueve el archivo 
					File.Move(archivo, rutaCarpetaDatos + "\\Recursos\\data\\pedidos\\finalizados\\" + peticion + ".dat");

				}

				//Asignacion de pedidos

				//Consulta si el pedido es asignable a traves de la funcio
				List<int> pedidosAsignables = Consultas.pickingPedidosAsignables();

				foreach (int pedido in pedidosAsignables)
				{
					//Obtiene las lineas del pedido y las recorre generando los movimientos
					List<ORDEN_SALIDA_LIN> lineasPedido = Consultas.obtenerLineasPedido(pedido);

					foreach (ORDEN_SALIDA_LIN linea in lineasPedido)
					{
						ProcedimientosAlmacenados.movimientosPicking(0, pedido, linea.COD_LINEA, 0);

					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		//Timer que simula la salida de camiones
		private void timerSimulacionSalida_Tick(object sender, EventArgs e)
		{
			try
			{
				//Simular la salida de los camiones que se llevan los pedidos pendientes

				foreach (int pedido in Consultas.salidasCamiones())
				{

					ProcedimientosAlmacenados.salidasCabeceras(1, pedido, 5, null, null, null, null, null, null, null);


				}
			}
			catch (Exception) {}
		}

		//Codigo para cargar formularios
		public void cargarFrm(Type tipoFrm)
		{
		
			foreach (Form fhijo in MdiChildren)
			{
				if (fhijo.GetType() == tipoFrm)
				{
					fhijo.BringToFront();
					return;
				}
			}

			Form f = (Form)Activator.CreateInstance(tipoFrm);
			f.MdiParent = this;
			f.WindowState = FormWindowState.Maximized;
			f.Show();
		}


		//Mensaje de confirmacion al cerrar la aplicacion
		private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult resul = MessageBox.Show("¿Está seguro de que quiere salir de la aplicación?", "Salir de la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

			if (resul == DialogResult.Yes)
				try
				{
					Application.ExitThread();
				}
				catch (Exception)
				{
					MessageBox.Show("Problema encontrado a la hora de cerrar la aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				}
			else
				e.Cancel = true;
		}

		//Metodos para abrir los formularios
		#region 
		private void navBarItemRecepcionar_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formRecepcionar));
			tileNavPane1.HideDropDownWindow();
		}

		private void navBarItemPicking_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formPicking));
			tileNavPane1.HideDropDownWindow();
		}

		private void navBarItemRevision_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formRevision));
			tileNavPane1.HideDropDownWindow();
		}

		private void navBarItemGestionPalets_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formGestionPalets));
			tileNavPane1.HideDropDownWindow();
		}

		private void navBarItemUbicarRecepciones_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formUbicarRecepciones));
			tileNavPane1.HideDropDownWindow();
		}

		
		private void navBarItemIncidencias_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formIncidenciasPedidos));
			tileNavPane1.HideDropDownWindow();
		}
		#endregion
	}
}
