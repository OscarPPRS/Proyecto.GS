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

		public formContenedor()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			//Procesamiento de los archivos de avisos y de pedidos

			List<string> cabeceraAviso = new List<string>();

			foreach (string archivo in Directory.EnumerateFiles("\\\\m2d96\\Publico\\Recursos\\data\\avisos\\pendientes\\", "*.txt"))
			{
				using (StreamReader sr = new StreamReader(archivo))
				{
					cabeceraAviso = sr.ReadLine().Split('#').ToList();

					string lineaTexto;

					ProcedimientosAlmacenados.recepcionesCabeceras(0, Convert.ToInt32(cabeceraAviso[0]), 1, Convert.ToInt32(cabeceraAviso[2]),
					Convert.ToDateTime(cabeceraAviso[3]), Convert.ToDateTime(cabeceraAviso[4]));

					while ((lineaTexto = sr.ReadLine()) != null)
					{

						List<string> listaAuxiliar = lineaTexto.Split('#').ToList();

						ProcedimientosAlmacenados.recepcionesLineas(0, Convert.ToInt32(cabeceraAviso[0]), Convert.ToInt32(listaAuxiliar[0]), listaAuxiliar[1], Convert.ToInt32(listaAuxiliar[2]));
					}
				}
				File.Move(archivo, "\\\\m2d96\\Publico\\Recursos\\data\\avisos\\finalizados\\" + cabeceraAviso[0] + ".txt");

			}

			foreach (string archivo in Directory.EnumerateFiles("\\\\m2d96\\Publico\\Recursos\\data\\pedidos\\traspasados\\", "*.dat"))
			{
				string peticion;
				using (Stream stream = File.Open(archivo, FileMode.Open))
				{

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

				File.Move(archivo, "\\\\m2d96\\Publico\\Recursos\\data\\pedidos\\finalizados\\" + peticion + ".dat");

			}

			//Asignacion de pedidos

			List<int> pedidosAsignables = Consultas.pickingPedidosAsignables();

			foreach (int pedido in pedidosAsignables)
			{

				List<ORDEN_SALIDA_LIN> lineasPedido = Consultas.obtenerLineasPedido(pedido);

				foreach (ORDEN_SALIDA_LIN linea in lineasPedido)
				{
					ProcedimientosAlmacenados.movimientosPicking(0, pedido, linea.COD_LINEA, 0);

				}

			}

		}

		private void timerSimulacionSalida_Tick(object sender, EventArgs e)
		{
			//Simular la salida de los camiones que se llevan los pedidos pendientes

			foreach (int pedido in Consultas.salidasCamiones())
			{

				ProcedimientosAlmacenados.salidasCabeceras(1, pedido, 5, null, null, null, null, null, null, null);


			}
		}

		private void formContenedor_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(10, 34, 64);
			Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage = Image.FromFile("\\\\m2d96\\Publico\\Recursos\\app\\ICP-background.png");
		}

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

		private void navBarItemRecepcionar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formRecepcionar));
		}

		private void navBarItemPicking_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formPicking));
		}

		private void navBarItemRevision_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formRevision));
		}

		private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formGestionPalets));
		}

		private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formUbicarRecepciones));
		}

		

		private void navBarItemIncidencias_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formIncidenciasPedidos));
		}
	}
}
