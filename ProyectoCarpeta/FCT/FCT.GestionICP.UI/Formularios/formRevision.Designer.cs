namespace FCT.GestionICP.UI.Formularios
{
	partial class formRevision
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRevision));
			this.gridControlPedidos = new DevExpress.XtraGrid.GridControl();
			this.vORDENSALIDACABBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_PETICION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFECH_CREACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD_LINEAS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridControlRevision = new DevExpress.XtraGrid.GridControl();
			this.vORDENSALIDALINBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewRevision = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_LINEA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButtonConfirmarRevision = new DevExpress.XtraEditors.SimpleButton();
			this.memoEditIncidencia = new DevExpress.XtraEditors.MemoEdit();
			this.checkButtonIncidencia = new DevExpress.XtraEditors.CheckButton();
			this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDACABBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlRevision)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDALINBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRevision)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.memoEditIncidencia.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlPedidos
			// 
			this.gridControlPedidos.DataSource = this.vORDENSALIDACABBindingSource;
			this.gridControlPedidos.Location = new System.Drawing.Point(329, 59);
			this.gridControlPedidos.MainView = this.gridViewPedidos;
			this.gridControlPedidos.Name = "gridControlPedidos";
			this.gridControlPedidos.Size = new System.Drawing.Size(980, 282);
			this.gridControlPedidos.TabIndex = 1;
			this.gridControlPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidos});
			// 
			// vORDENSALIDACABBindingSource
			// 
			this.vORDENSALIDACABBindingSource.DataSource = typeof(FCT.Negocio.V_ORDEN_SALIDA_CAB);
			// 
			// gridViewPedidos
			// 
			this.gridViewPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_PETICION,
            this.colDES_EMPRESA,
            this.colFECH_CREACION,
            this.colCANTIDAD_LINEAS});
			this.gridViewPedidos.GridControl = this.gridControlPedidos;
			this.gridViewPedidos.Name = "gridViewPedidos";
			this.gridViewPedidos.OptionsBehavior.Editable = false;
			this.gridViewPedidos.OptionsBehavior.ReadOnly = true;
			this.gridViewPedidos.OptionsCustomization.AllowGroup = false;
			this.gridViewPedidos.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridViewPedidos_FocusedRowObjectChanged);
			// 
			// colCOD_PETICION
			// 
			this.colCOD_PETICION.Caption = "Pedido";
			this.colCOD_PETICION.FieldName = "COD_PETICION";
			this.colCOD_PETICION.Name = "colCOD_PETICION";
			this.colCOD_PETICION.Visible = true;
			this.colCOD_PETICION.VisibleIndex = 0;
			this.colCOD_PETICION.Width = 244;
			// 
			// colDES_EMPRESA
			// 
			this.colDES_EMPRESA.Caption = "Empresa";
			this.colDES_EMPRESA.FieldName = "DES_EMPRESA";
			this.colDES_EMPRESA.Name = "colDES_EMPRESA";
			this.colDES_EMPRESA.Visible = true;
			this.colDES_EMPRESA.VisibleIndex = 1;
			this.colDES_EMPRESA.Width = 299;
			// 
			// colFECH_CREACION
			// 
			this.colFECH_CREACION.Caption = "Fecha de creación";
			this.colFECH_CREACION.FieldName = "FECH_CREACION";
			this.colFECH_CREACION.Name = "colFECH_CREACION";
			this.colFECH_CREACION.Visible = true;
			this.colFECH_CREACION.VisibleIndex = 2;
			this.colFECH_CREACION.Width = 227;
			// 
			// colCANTIDAD_LINEAS
			// 
			this.colCANTIDAD_LINEAS.Caption = "Cantidad de líneas";
			this.colCANTIDAD_LINEAS.FieldName = "CANTIDAD_LINEAS";
			this.colCANTIDAD_LINEAS.Name = "colCANTIDAD_LINEAS";
			this.colCANTIDAD_LINEAS.Visible = true;
			this.colCANTIDAD_LINEAS.VisibleIndex = 3;
			this.colCANTIDAD_LINEAS.Width = 185;
			// 
			// gridControlRevision
			// 
			this.gridControlRevision.DataSource = this.vORDENSALIDALINBindingSource;
			this.gridControlRevision.Location = new System.Drawing.Point(329, 357);
			this.gridControlRevision.MainView = this.gridViewRevision;
			this.gridControlRevision.Name = "gridControlRevision";
			this.gridControlRevision.Size = new System.Drawing.Size(980, 488);
			this.gridControlRevision.TabIndex = 2;
			this.gridControlRevision.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRevision});
			// 
			// vORDENSALIDALINBindingSource
			// 
			this.vORDENSALIDALINBindingSource.DataSource = typeof(FCT.Negocio.V_ORDEN_SALIDA_LIN);
			// 
			// gridViewRevision
			// 
			this.gridViewRevision.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_LINEA,
            this.colCOD_REFERENCIA,
            this.colDES_REFERENCIA,
            this.colCANTIDAD});
			this.gridViewRevision.GridControl = this.gridControlRevision;
			this.gridViewRevision.Name = "gridViewRevision";
			this.gridViewRevision.OptionsBehavior.Editable = false;
			this.gridViewRevision.OptionsBehavior.ReadOnly = true;
			this.gridViewRevision.OptionsCustomization.AllowGroup = false;
			// 
			// colCOD_LINEA
			// 
			this.colCOD_LINEA.Caption = "Línea";
			this.colCOD_LINEA.FieldName = "COD_LINEA";
			this.colCOD_LINEA.Name = "colCOD_LINEA";
			this.colCOD_LINEA.Visible = true;
			this.colCOD_LINEA.VisibleIndex = 0;
			this.colCOD_LINEA.Width = 48;
			// 
			// colCOD_REFERENCIA
			// 
			this.colCOD_REFERENCIA.Caption = "Código de referencia";
			this.colCOD_REFERENCIA.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA.Name = "colCOD_REFERENCIA";
			this.colCOD_REFERENCIA.Visible = true;
			this.colCOD_REFERENCIA.VisibleIndex = 1;
			this.colCOD_REFERENCIA.Width = 195;
			// 
			// colDES_REFERENCIA
			// 
			this.colDES_REFERENCIA.Caption = "Producto";
			this.colDES_REFERENCIA.FieldName = "DES_REFERENCIA";
			this.colDES_REFERENCIA.Name = "colDES_REFERENCIA";
			this.colDES_REFERENCIA.Visible = true;
			this.colDES_REFERENCIA.VisibleIndex = 2;
			this.colDES_REFERENCIA.Width = 626;
			// 
			// colCANTIDAD
			// 
			this.colCANTIDAD.Caption = "Cantidad";
			this.colCANTIDAD.FieldName = "CANTIDAD";
			this.colCANTIDAD.Name = "colCANTIDAD";
			this.colCANTIDAD.Visible = true;
			this.colCANTIDAD.VisibleIndex = 3;
			this.colCANTIDAD.Width = 86;
			// 
			// simpleButtonConfirmarRevision
			// 
			this.simpleButtonConfirmarRevision.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButtonConfirmarRevision.Appearance.Options.UseFont = true;
			this.simpleButtonConfirmarRevision.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonConfirmarRevision.ImageOptions.Image")));
			this.simpleButtonConfirmarRevision.Location = new System.Drawing.Point(1450, 126);
			this.simpleButtonConfirmarRevision.Name = "simpleButtonConfirmarRevision";
			this.simpleButtonConfirmarRevision.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonConfirmarRevision.Size = new System.Drawing.Size(107, 95);
			this.simpleButtonConfirmarRevision.TabIndex = 5;
			this.simpleButtonConfirmarRevision.Click += new System.EventHandler(this.simpleButtonConfirmarRevision_Click);
			// 
			// memoEditIncidencia
			// 
			this.memoEditIncidencia.Enabled = false;
			this.memoEditIncidencia.Location = new System.Drawing.Point(1378, 519);
			this.memoEditIncidencia.Name = "memoEditIncidencia";
			this.memoEditIncidencia.Properties.NullText = "Por favor, describa la incidencia con detalle.";
			this.memoEditIncidencia.Size = new System.Drawing.Size(275, 267);
			this.memoEditIncidencia.TabIndex = 7;
			// 
			// checkButtonIncidencia
			// 
			this.checkButtonIncidencia.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkButtonIncidencia.Appearance.Options.UseFont = true;
			this.checkButtonIncidencia.Location = new System.Drawing.Point(1378, 446);
			this.checkButtonIncidencia.Name = "checkButtonIncidencia";
			this.checkButtonIncidencia.Size = new System.Drawing.Size(275, 58);
			this.checkButtonIncidencia.TabIndex = 8;
			this.checkButtonIncidencia.Text = "INCIDENCIA";
			this.checkButtonIncidencia.CheckedChanged += new System.EventHandler(this.checkButtonIncidencia_CheckedChanged);
			// 
			// simpleButtonActualizar
			// 
			this.simpleButtonActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.ImageOptions.Image")));
			this.simpleButtonActualizar.Location = new System.Drawing.Point(265, 156);
			this.simpleButtonActualizar.Name = "simpleButtonActualizar";
			this.simpleButtonActualizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonActualizar.Size = new System.Drawing.Size(58, 60);
			this.simpleButtonActualizar.TabIndex = 35;
			this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
			// 
			// formRevision
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1771, 857);
			this.Controls.Add(this.simpleButtonActualizar);
			this.Controls.Add(this.checkButtonIncidencia);
			this.Controls.Add(this.memoEditIncidencia);
			this.Controls.Add(this.simpleButtonConfirmarRevision);
			this.Controls.Add(this.gridControlRevision);
			this.Controls.Add(this.gridControlPedidos);
			this.Name = "formRevision";
			this.Load += new System.EventHandler(this.formRevision_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDACABBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlRevision)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDALINBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRevision)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.memoEditIncidencia.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlPedidos;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidos;
		private System.Windows.Forms.BindingSource vORDENSALIDACABBindingSource;
		private DevExpress.XtraGrid.GridControl gridControlRevision;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewRevision;
		private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmarRevision;
		private System.Windows.Forms.BindingSource vORDENSALIDALINBindingSource;
		private DevExpress.XtraEditors.MemoEdit memoEditIncidencia;
		private DevExpress.XtraEditors.CheckButton checkButtonIncidencia;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_PETICION;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_EMPRESA;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_CREACION;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD_LINEAS;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_LINEA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD;
		private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
	}
}