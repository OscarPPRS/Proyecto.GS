using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCT.Cliente.UI
{
	public static class FuncionesAuxiliares
	{
		public static string randomString(int tamanio)
		{
			Random random = new Random();
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, tamanio)
				.Select(s => s[random.Next(s.Length)]).ToArray());
		}

	

	}
}
