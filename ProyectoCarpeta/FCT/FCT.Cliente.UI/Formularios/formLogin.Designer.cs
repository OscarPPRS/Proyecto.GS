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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
			this.textEditUsuario = new DevExpress.XtraEditors.TextEdit();
			this.textEditContrasena = new DevExpress.XtraEditors.TextEdit();
			this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.textEditUsuario.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditContrasena.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textEditUsuario
			// 
			this.textEditUsuario.Location = new System.Drawing.Point(116, 21);
			this.textEditUsuario.Name = "textEditUsuario";
			this.textEditUsuario.Size = new System.Drawing.Size(100, 20);
			this.textEditUsuario.TabIndex = 0;
			// 
			// textEditContrasena
			// 
			this.textEditContrasena.Location = new System.Drawing.Point(116, 61);
			this.textEditContrasena.Name = "textEditContrasena";
			this.textEditContrasena.Properties.Name = "textEditContrasena";
			this.textEditContrasena.Properties.PasswordChar = '●';
			this.textEditContrasena.Size = new System.Drawing.Size(100, 20);
			this.textEditContrasena.TabIndex = 1;
			// 
			// simpleButtonLogin
			// 
			this.simpleButtonLogin.Location = new System.Drawing.Point(83, 99);
			this.simpleButtonLogin.Name = "simpleButtonLogin";
			this.simpleButtonLogin.Size = new System.Drawing.Size(100, 29);
			this.simpleButtonLogin.TabIndex = 2;
			this.simpleButtonLogin.Text = "Entrar";
			this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(39, 24);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(40, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Usuario:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(39, 64);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(60, 13);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Contraseña:";
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(107, 42);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
			this.pictureEdit1.Size = new System.Drawing.Size(255, 213);
			this.pictureEdit1.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.simpleButtonLogin);
			this.panel1.Controls.Add(this.textEditUsuario);
			this.panel1.Controls.Add(this.labelControl2);
			this.panel1.Controls.Add(this.textEditContrasena);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Location = new System.Drawing.Point(107, 261);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(255, 144);
			this.panel1.TabIndex = 6;
			// 
			// formLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(459, 428);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureEdit1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formLogin";
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.textEditUsuario.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditContrasena.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit textEditUsuario;
		private DevExpress.XtraEditors.TextEdit textEditContrasena;
		private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private System.Windows.Forms.Panel panel1;
	}
}