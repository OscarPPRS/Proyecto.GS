namespace FCT.Cliente.UI
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
			this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItemReferencias = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItemRecepciones = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarItemVisorRecepciones = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItemPedidos = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// navBarControl1
			// 
			this.navBarControl1.ActiveGroup = this.navBarGroup1;
			this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
			this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemReferencias,
            this.navBarSeparatorItem1,
            this.navBarItemRecepciones,
            this.navBarItemPedidos,
            this.navBarItemVisorRecepciones});
			this.navBarControl1.Location = new System.Drawing.Point(13, 13);
			this.navBarControl1.Name = "navBarControl1";
			this.navBarControl1.OptionsNavPane.ExpandedWidth = 164;
			this.navBarControl1.Size = new System.Drawing.Size(164, 687);
			this.navBarControl1.TabIndex = 3;
			this.navBarControl1.Text = "navBarControl1";
			// 
			// navBarGroup1
			// 
			this.navBarGroup1.Caption = "Referencias";
			this.navBarGroup1.Expanded = true;
			this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemReferencias)});
			this.navBarGroup1.Name = "navBarGroup1";
			// 
			// navBarItemReferencias
			// 
			this.navBarItemReferencias.Caption = "Catálogo";
			this.navBarItemReferencias.Name = "navBarItemReferencias";
			this.navBarItemReferencias.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemReferencias_LinkClicked);
			// 
			// navBarGroup2
			// 
			this.navBarGroup2.Caption = "Recepciones";
			this.navBarGroup2.Expanded = true;
			this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRecepciones),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemVisorRecepciones)});
			this.navBarGroup2.Name = "navBarGroup2";
			// 
			// navBarItemRecepciones
			// 
			this.navBarItemRecepciones.Caption = "Crear avisos";
			this.navBarItemRecepciones.Name = "navBarItemRecepciones";
			this.navBarItemRecepciones.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemRecepciones_LinkClicked);
			// 
			// navBarItemVisorRecepciones
			// 
			this.navBarItemVisorRecepciones.Caption = "Visor recepciones";
			this.navBarItemVisorRecepciones.Name = "navBarItemVisorRecepciones";
			this.navBarItemVisorRecepciones.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemVisorRecepciones_LinkClicked);
			// 
			// navBarGroup3
			// 
			this.navBarGroup3.Caption = "Pedidos";
			this.navBarGroup3.Expanded = true;
			this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPedidos)});
			this.navBarGroup3.Name = "navBarGroup3";
			// 
			// navBarItemPedidos
			// 
			this.navBarItemPedidos.Caption = "Crear pedidos";
			this.navBarItemPedidos.Name = "navBarItemPedidos";
			this.navBarItemPedidos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPedidos_LinkClicked);
			// 
			// navBarSeparatorItem1
			// 
			this.navBarSeparatorItem1.CanDrag = false;
			this.navBarSeparatorItem1.Enabled = false;
			this.navBarSeparatorItem1.Hint = null;
			this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1489, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// formContenedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1489, 712);
			this.Controls.Add(this.navBarControl1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formContenedor";
			this.Text = "Cliente";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
			this.Load += new System.EventHandler(this.formContenedor_Load);
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraNavBar.NavBarControl navBarControl1;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
		private DevExpress.XtraNavBar.NavBarItem navBarItemReferencias;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
		private DevExpress.XtraNavBar.NavBarItem navBarItemRecepciones;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
		private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
		private DevExpress.XtraNavBar.NavBarItem navBarItemPedidos;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private DevExpress.XtraNavBar.NavBarItem navBarItemVisorRecepciones;
	}
}