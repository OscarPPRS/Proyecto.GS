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
		}

		private void simpleButtonLogin_Click(object sender, EventArgs e)
		{
			int result = Negocio.Consultas.comprobarLogin(textEditUsuario.EditValue.ToString(), textEditContrasena.EditValue.ToString());

			if (result == 0)
			{
				System.Windows.Forms.MessageBox.Show("Usuario o contraseña inválidos.");
			}

			else 
			{
				formContenedor form = new formContenedor(result);
				form.Show();
				this.Hide();
			}
		}

		
	}
}
