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

namespace FCT.Cliente.UI
{
	public partial class formLogin : Form
	{
		public formLogin()
		{
			InitializeComponent();
			textEditUsuario.Text = "xiaomi";
			textEditContrasena.Text = "123";
		}

		private void simpleButtonLogin_Click(object sender, EventArgs e)
		{
			//Consulta a base de datos para obtener el id de la empresa o devolver un 0 en el caso de que no haya un match
			try
			{
				int result = Consultas.comprobarLogin(textEditUsuario.EditValue.ToString(), textEditContrasena.EditValue.ToString());
				if (result == 0)
				{
					MessageBox.Show("Usuario o contraseña inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				else
				{
					formContenedor form = new formContenedor(result);
					form.Show();
					this.Hide();
				}
			}
			catch (Exception) { }

			
		}

		
	}
}
