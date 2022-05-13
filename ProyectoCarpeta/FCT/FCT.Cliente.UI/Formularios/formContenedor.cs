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
		public formContenedor(int id)
		{
			InitializeComponent();
			idEmpresa = id;
		}

		private void formContenedor_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(10, 34, 64);
			Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage =Image.FromFile("\\\\m2d96\\Publico"  + Consultas.logoEmpresa(idEmpresa));
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
		private void navBarItemReferencias_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formReferencias));
		}
		private void navBarItemRecepciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formRecepciones));
		}

		private void navBarItemPedidos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formPedidos));
		}

		private void navBarItemVisorRecepciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formVisorRecepciones));
		}

		private void navBarItemVisorPedidos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			cargarFrm(typeof(formVisorPedidos));
		}
	}
}

