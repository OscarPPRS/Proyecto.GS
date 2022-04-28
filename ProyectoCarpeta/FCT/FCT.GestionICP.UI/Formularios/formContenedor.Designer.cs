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
			this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItemRecepcionar = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarItemPicking = new DevExpress.XtraNavBar.NavBarItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// navBarControl1
			// 
			this.navBarControl1.ActiveGroup = this.navBarGroup1;
			this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
			this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemRecepcionar,
            this.navBarItemPicking});
			this.navBarControl1.Location = new System.Drawing.Point(13, 12);
			this.navBarControl1.Name = "navBarControl1";
			this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
			this.navBarControl1.Size = new System.Drawing.Size(140, 813);
			this.navBarControl1.TabIndex = 0;
			this.navBarControl1.Text = "navBarControl1";
			// 
			// navBarGroup1
			// 
			this.navBarGroup1.Caption = "Recepciones";
			this.navBarGroup1.Expanded = true;
			this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRecepcionar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPicking)});
			this.navBarGroup1.Name = "navBarGroup1";
			// 
			// navBarItemRecepcionar
			// 
			this.navBarItemRecepcionar.Caption = "Recepcionar";
			this.navBarItemRecepcionar.Name = "navBarItemRecepcionar";
			this.navBarItemRecepcionar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemRecepcionar_LinkClicked);
			// 
			// navBarItemPicking
			// 
			this.navBarItemPicking.Caption = "Picking";
			this.navBarItemPicking.Name = "navBarItemPicking";
			this.navBarItemPicking.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPicking_LinkClicked);
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
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 12000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// formContenedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1776, 837);
			this.Controls.Add(this.navBarControl1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formContenedor";
			this.Text = "ICP";
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
		private System.Windows.Forms.Timer timer1;
		private DevExpress.XtraNavBar.NavBarItem navBarItemPicking;
	}
}