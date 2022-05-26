using FCT.Cliente.UI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCT.Negocio;

namespace FCT.Cliente.UI
{
	public partial class formContenedor : Form
	{
		public static int idEmpresa;

		//Ruta de la carpeta en la que están los recursos del programa
		public static string rutaCarpetaDatos = "D:\\Users\\ols17\\Desktop\\ProyectoCarpeta\\ProyectoCarpeta";

		//Constructor que acepta un id de empresa para usar durante la ejecucion del programa
		public formContenedor(int id)
		{
			InitializeComponent();
			idEmpresa = id;
		}

		//Cambiar el fondo de la aplicacion al logo de la empresa y el color azul
		private void formContenedor_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(10, 34, 64);
			Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage =Image.FromFile(rutaCarpetaDatos + Consultas.logoEmpresa(idEmpresa));
		}


		public void cargarFrm(Type tipoFrm)
		{
			//Funcion para obtener los formularios y ocultarlos cuando se cambie entre ellos.
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

		
		//Confirmacion de cierre de la aplicacion
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

		//Funciones para abrir los distintos formularios dentro del contenedor MDI
		private void navBarItemReferencias_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formReferencias));
			tileNavPane1.HideDropDownWindow();
		}
		private void navBarItemRecepciones_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formRecepciones));
			tileNavPane1.HideDropDownWindow();
		}

		private void navBarItemPedidos_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formPedidos));
			tileNavPane1.HideDropDownWindow();
		}

		private void navBarItemVisorRecepciones_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formVisorRecepciones));
			tileNavPane1.HideDropDownWindow();
		}

		private void navBarItemVisorPedidos_LinkClicked(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			cargarFrm(typeof(formVisorPedidos));
			tileNavPane1.HideDropDownWindow();
		}
	}
}

