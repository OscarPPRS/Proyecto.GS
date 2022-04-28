namespace FCT.GestionICP.UI.Formularios
{
	partial class formPicking
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
			this.gridControlPedidos = new DevExpress.XtraGrid.GridControl();
			this.gridViewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.simpleButtonComenzarPicking = new DevExpress.XtraEditors.SimpleButton();
			this.gridControlMovimientos = new DevExpress.XtraGrid.GridControl();
			this.gridViewMovimientos = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.simpleButtonConfirmarMovimiento = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlMovimientos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewMovimientos)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlPedidos
			// 
			this.gridControlPedidos.Location = new System.Drawing.Point(362, 29);
			this.gridControlPedidos.MainView = this.gridViewPedidos;
			this.gridControlPedidos.Name = "gridControlPedidos";
			this.gridControlPedidos.Size = new System.Drawing.Size(980, 282);
			this.gridControlPedidos.TabIndex = 0;
			this.gridControlPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidos});
			// 
			// gridViewPedidos
			// 
			this.gridViewPedidos.GridControl = this.gridControlPedidos;
			this.gridViewPedidos.Name = "gridViewPedidos";
			this.gridViewPedidos.OptionsBehavior.Editable = false;
			this.gridViewPedidos.OptionsBehavior.ReadOnly = true;
			this.gridViewPedidos.OptionsCustomization.AllowGroup = false;
			// 
			// simpleButtonComenzarPicking
			// 
			this.simpleButtonComenzarPicking.Location = new System.Drawing.Point(1385, 77);
			this.simpleButtonComenzarPicking.Name = "simpleButtonComenzarPicking";
			this.simpleButtonComenzarPicking.Size = new System.Drawing.Size(185, 48);
			this.simpleButtonComenzarPicking.TabIndex = 1;
			this.simpleButtonComenzarPicking.Text = "Iniciar picking";
			// 
			// gridControlMovimientos
			// 
			this.gridControlMovimientos.Location = new System.Drawing.Point(362, 518);
			this.gridControlMovimientos.MainView = this.gridViewMovimientos;
			this.gridControlMovimientos.Name = "gridControlMovimientos";
			this.gridControlMovimientos.Size = new System.Drawing.Size(980, 282);
			this.gridControlMovimientos.TabIndex = 2;
			this.gridControlMovimientos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMovimientos});
			// 
			// gridViewMovimientos
			// 
			this.gridViewMovimientos.GridControl = this.gridControlMovimientos;
			this.gridViewMovimientos.Name = "gridViewMovimientos";
			this.gridViewMovimientos.OptionsBehavior.Editable = false;
			this.gridViewMovimientos.OptionsBehavior.ReadOnly = true;
			this.gridViewMovimientos.OptionsCustomization.AllowGroup = false;
			// 
			// simpleButtonConfirmarMovimiento
			// 
			this.simpleButtonConfirmarMovimiento.Location = new System.Drawing.Point(1385, 558);
			this.simpleButtonConfirmarMovimiento.Name = "simpleButtonConfirmarMovimiento";
			this.simpleButtonConfirmarMovimiento.Size = new System.Drawing.Size(185, 55);
			this.simpleButtonConfirmarMovimiento.TabIndex = 3;
			this.simpleButtonConfirmarMovimiento.Text = "Confirmar movimiento";
			// 
			// formPicking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1756, 844);
			this.Controls.Add(this.simpleButtonConfirmarMovimiento);
			this.Controls.Add(this.gridControlMovimientos);
			this.Controls.Add(this.simpleButtonComenzarPicking);
			this.Controls.Add(this.gridControlPedidos);
			this.Name = "formPicking";
			this.Text = "formPicking";
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlMovimientos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewMovimientos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlPedidos;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidos;
		private DevExpress.XtraEditors.SimpleButton simpleButtonComenzarPicking;
		private DevExpress.XtraGrid.GridControl gridControlMovimientos;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewMovimientos;
		private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmarMovimiento;
	}
}