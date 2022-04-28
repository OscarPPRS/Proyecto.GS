namespace FCT.Cliente.UI
{
	partial class formLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textEditUsuario = new DevExpress.XtraEditors.TextEdit();
			this.textEditContrasena = new DevExpress.XtraEditors.TextEdit();
			this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.textEditUsuario.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditContrasena.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// textEditUsuario
			// 
			this.textEditUsuario.Location = new System.Drawing.Point(386, 256);
			this.textEditUsuario.Name = "textEditUsuario";
			this.textEditUsuario.Size = new System.Drawing.Size(100, 20);
			this.textEditUsuario.TabIndex = 0;
			// 
			// textEditContrasena
			// 
			this.textEditContrasena.Location = new System.Drawing.Point(386, 296);
			this.textEditContrasena.Name = "textEditContrasena";
			this.textEditContrasena.Size = new System.Drawing.Size(100, 20);
			this.textEditContrasena.TabIndex = 1;
			// 
			// simpleButtonLogin
			// 
			this.simpleButtonLogin.Location = new System.Drawing.Point(350, 347);
			this.simpleButtonLogin.Name = "simpleButtonLogin";
			this.simpleButtonLogin.Size = new System.Drawing.Size(100, 29);
			this.simpleButtonLogin.TabIndex = 2;
			this.simpleButtonLogin.Text = "Entrar";
			this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(309, 259);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(40, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Usuario:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(309, 299);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(60, 13);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Contraseña:";
			// 
			// formLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.simpleButtonLogin);
			this.Controls.Add(this.textEditContrasena);
			this.Controls.Add(this.textEditUsuario);
			this.Name = "formLogin";
			this.Text = "formLogin";
			((System.ComponentModel.ISupportInitialize)(this.textEditUsuario.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditContrasena.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit textEditUsuario;
		private DevExpress.XtraEditors.TextEdit textEditContrasena;
		private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
	}
}