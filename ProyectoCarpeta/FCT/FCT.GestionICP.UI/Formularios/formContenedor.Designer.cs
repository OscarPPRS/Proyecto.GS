namespace FCT.GestionICP.UI.Formularios
{
	partial class formContenedor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formContenedor));
			this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItemRecepcionar = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItemPicking = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarItemRevision = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarItemIncidencias = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.timerProcesarDatos = new System.Windows.Forms.Timer(this.components);
			this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
			this.timerSimulacionSalida = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// navBarControl1
			// 
			this.navBarControl1.ActiveGroup = this.navBarGroup3;
			this.navBarControl1.Appearance.Background.BackColor = System.Drawing.Color.Transparent;
			this.navBarControl1.Appearance.Background.Options.UseBackColor = true;
			this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.navBarControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
			this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemRecepcionar,
            this.navBarItemPicking,
            this.navBarItemRevision,
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItemIncidencias});
			this.navBarControl1.Location = new System.Drawing.Point(0, 0);
			this.navBarControl1.Name = "navBarControl1";
			this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
			this.navBarControl1.Size = new System.Drawing.Size(140, 837);
			this.navBarControl1.TabIndex = 0;
			this.navBarControl1.Text = "navBarControl1";
			// 
			// navBarGroup3
			// 
			this.navBarGroup3.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup3.Appearance.Options.UseFont = true;
			this.navBarGroup3.AppearanceHotTracked.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup3.AppearanceHotTracked.Options.UseFont = true;
			this.navBarGroup3.Caption = "Otros";
			this.navBarGroup3.Expanded = true;
			this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRecepcionar)});
			this.navBarGroup3.Name = "navBarGroup3";
			// 
			// navBarItemRecepcionar
			// 
			this.navBarItemRecepcionar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItemRecepcionar.Appearance.Options.UseFont = true;
			this.navBarItemRecepcionar.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItemRecepcionar.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItemRecepcionar.Caption = "Recepcionar";
			this.navBarItemRecepcionar.Name = "navBarItemRecepcionar";
			this.navBarItemRecepcionar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemRecepcionar_LinkClicked);
			// 
			// navBarGroup1
			// 
			this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup1.Appearance.Options.UseFont = true;
			this.navBarGroup1.AppearanceHotTracked.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup1.AppearanceHotTracked.Options.UseFont = true;
			this.navBarGroup1.Caption = "Pedidos";
			this.navBarGroup1.Expanded = true;
			this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPicking),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRevision),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemIncidencias)});
			this.navBarGroup1.Name = "navBarGroup1";
			// 
			// navBarItemPicking
			// 
			this.navBarItemPicking.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItemPicking.Appearance.Options.UseFont = true;
			this.navBarItemPicking.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItemPicking.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItemPicking.Caption = "Picking";
			this.navBarItemPicking.Name = "navBarItemPicking";
			this.navBarItemPicking.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPicking_LinkClicked);
			// 
			// navBarItemRevision
			// 
			this.navBarItemRevision.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItemRevision.Appearance.Options.UseFont = true;
			this.navBarItemRevision.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItemRevision.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItemRevision.Caption = "Revision";
			this.navBarItemRevision.Name = "navBarItemRevision";
			this.navBarItemRevision.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemRevision_LinkClicked);
			// 
			// navBarItemIncidencias
			// 
			this.navBarItemIncidencias.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItemIncidencias.Appearance.Options.UseFont = true;
			this.navBarItemIncidencias.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItemIncidencias.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItemIncidencias.Caption = "Incidencias";
			this.navBarItemIncidencias.Name = "navBarItemIncidencias";
			this.navBarItemIncidencias.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemIncidencias_LinkClicked);
			// 
			// navBarGroup2
			// 
			this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup2.Appearance.Options.UseFont = true;
			this.navBarGroup2.AppearanceHotTracked.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup2.AppearanceHotTracked.Options.UseFont = true;
			this.navBarGroup2.Caption = "Palets";
			this.navBarGroup2.Expanded = true;
			this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
			this.navBarGroup2.Name = "navBarGroup2";
			// 
			// navBarItem1
			// 
			this.navBarItem1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItem1.Appearance.Options.UseFont = true;
			this.navBarItem1.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItem1.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem1.Caption = "Gestionar";
			this.navBarItem1.Name = "navBarItem1";
			this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
			// 
			// navBarItem2
			// 
			this.navBarItem2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItem2.Appearance.Options.UseFont = true;
			this.navBarItem2.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarItem2.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem2.Caption = "Ubicar";
			this.navBarItem2.Name = "navBarItem2";
			this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1776, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// timerProcesarDatos
			// 
			this.timerProcesarDatos.Enabled = true;
			this.timerProcesarDatos.Interval = 5000;
			this.timerProcesarDatos.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// navBarGroup4
			// 
			this.navBarGroup4.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup4.Appearance.Options.UseFont = true;
			this.navBarGroup4.AppearanceHotTracked.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup4.AppearanceHotTracked.Options.UseFont = true;
			this.navBarGroup4.Caption = "Pedidos";
			this.navBarGroup4.Expanded = true;
			this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPicking),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRevision)});
			this.navBarGroup4.Name = "navBarGroup4";
			// 
			// navBarGroup5
			// 
			this.navBarGroup5.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup5.Appearance.Options.UseFont = true;
			this.navBarGroup5.AppearanceHotTracked.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.navBarGroup5.AppearanceHotTracked.Options.UseFont = true;
			this.navBarGroup5.Caption = "Pedidos";
			this.navBarGroup5.Expanded = true;
			this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPicking),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRevision)});
			this.navBarGroup5.Name = "navBarGroup5";
			// 
			// timerSimulacionSalida
			// 
			this.timerSimulacionSalida.Enabled = true;
			this.timerSimulacionSalida.Interval = 30000;
			this.timerSimulacionSalida.Tick += new System.EventHandler(this.timerSimulacionSalida_Tick);
			// 
			// formContenedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(1776, 837);
			this.Controls.Add(this.navBarControl1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "formContenedor";
			this.Text = "Gestión ICP";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
			this.Load += new System.EventHandler(this.formContenedor_Load);
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraNavBar.NavBarControl navBarControl1;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private DevExpress.XtraNavBar.NavBarItem navBarItemRecepcionar;
		private DevExpress.XtraNavBar.NavBarItem navBarItemPicking;
		private DevExpress.XtraNavBar.NavBarItem navBarItemRevision;
		private System.Windows.Forms.Timer timerProcesarDatos;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
		private System.Windows.Forms.Timer timerSimulacionSalida;
		private DevExpress.XtraNavBar.NavBarItem navBarItem1;
		private DevExpress.XtraNavBar.NavBarItem navBarItem2;
		private DevExpress.XtraNavBar.NavBarItem navBarItemIncidencias;
	}
}