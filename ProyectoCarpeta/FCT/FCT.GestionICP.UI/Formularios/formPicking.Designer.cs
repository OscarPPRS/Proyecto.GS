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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPicking));
			this.gridControlPedidos = new DevExpress.XtraGrid.GridControl();
			this.vORDENSALIDACABBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_PETICION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPOBLACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPROVINCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFECH_CREACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD_LINEAS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButtonComenzarPicking = new DevExpress.XtraEditors.SimpleButton();
			this.gridControlMovimientos = new DevExpress.XtraGrid.GridControl();
			this.vMOVIMIENTOSPICKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewMovimientos = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_MOVIMIENTO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_PALET = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButtonConfirmarMovimiento = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.textEditCalle = new DevExpress.XtraEditors.TextEdit();
			this.textEditPosicion = new DevExpress.XtraEditors.TextEdit();
			this.textEditCantidad = new DevExpress.XtraEditors.TextEdit();
			this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDACABBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlMovimientos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vMOVIMIENTOSPICKINGBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewMovimientos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditCalle.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPosicion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditCantidad.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlPedidos
			// 
			this.gridControlPedidos.DataSource = this.vORDENSALIDACABBindingSource;
			this.gridControlPedidos.Location = new System.Drawing.Point(251, 88);
			this.gridControlPedidos.MainView = this.gridViewPedidos;
			this.gridControlPedidos.Name = "gridControlPedidos";
			this.gridControlPedidos.Size = new System.Drawing.Size(980, 282);
			this.gridControlPedidos.TabIndex = 0;
			this.gridControlPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidos});
			// 
			// vORDENSALIDACABBindingSource
			// 
			this.vORDENSALIDACABBindingSource.DataSource = typeof(FCT.Negocio.V_ORDEN_SALIDA_CAB);
			// 
			// gridViewPedidos
			// 
			this.gridViewPedidos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewPedidos.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridViewPedidos.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridViewPedidos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridViewPedidos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewPedidos.Appearance.Row.Options.UseFont = true;
			this.gridViewPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_PETICION,
            this.colDES_EMPRESA,
            this.colPOBLACION,
            this.colPROVINCIA,
            this.colFECH_CREACION,
            this.colCANTIDAD_LINEAS});
			this.gridViewPedidos.GridControl = this.gridControlPedidos;
			this.gridViewPedidos.Name = "gridViewPedidos";
			this.gridViewPedidos.OptionsBehavior.Editable = false;
			this.gridViewPedidos.OptionsBehavior.ReadOnly = true;
			this.gridViewPedidos.OptionsCustomization.AllowColumnMoving = false;
			this.gridViewPedidos.OptionsCustomization.AllowGroup = false;
			// 
			// colCOD_PETICION
			// 
			this.colCOD_PETICION.Caption = "Petición";
			this.colCOD_PETICION.FieldName = "COD_PETICION";
			this.colCOD_PETICION.Name = "colCOD_PETICION";
			this.colCOD_PETICION.Visible = true;
			this.colCOD_PETICION.VisibleIndex = 0;
			// 
			// colDES_EMPRESA
			// 
			this.colDES_EMPRESA.Caption = "Empresa";
			this.colDES_EMPRESA.FieldName = "DES_EMPRESA";
			this.colDES_EMPRESA.Name = "colDES_EMPRESA";
			this.colDES_EMPRESA.Visible = true;
			this.colDES_EMPRESA.VisibleIndex = 1;
			// 
			// colPOBLACION
			// 
			this.colPOBLACION.Caption = "Población";
			this.colPOBLACION.FieldName = "POBLACION";
			this.colPOBLACION.Name = "colPOBLACION";
			this.colPOBLACION.Visible = true;
			this.colPOBLACION.VisibleIndex = 2;
			// 
			// colPROVINCIA
			// 
			this.colPROVINCIA.Caption = "Provincia";
			this.colPROVINCIA.FieldName = "PROVINCIA";
			this.colPROVINCIA.Name = "colPROVINCIA";
			this.colPROVINCIA.Visible = true;
			this.colPROVINCIA.VisibleIndex = 3;
			// 
			// colFECH_CREACION
			// 
			this.colFECH_CREACION.Caption = "Fecha de creación";
			this.colFECH_CREACION.FieldName = "FECH_CREACION";
			this.colFECH_CREACION.Name = "colFECH_CREACION";
			this.colFECH_CREACION.Visible = true;
			this.colFECH_CREACION.VisibleIndex = 4;
			// 
			// colCANTIDAD_LINEAS
			// 
			this.colCANTIDAD_LINEAS.Caption = "Cantidad de líneas";
			this.colCANTIDAD_LINEAS.FieldName = "CANTIDAD_LINEAS";
			this.colCANTIDAD_LINEAS.Name = "colCANTIDAD_LINEAS";
			this.colCANTIDAD_LINEAS.Visible = true;
			this.colCANTIDAD_LINEAS.VisibleIndex = 5;
			// 
			// simpleButtonComenzarPicking
			// 
			this.simpleButtonComenzarPicking.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButtonComenzarPicking.Appearance.Options.UseFont = true;
			this.simpleButtonComenzarPicking.Location = new System.Drawing.Point(1291, 162);
			this.simpleButtonComenzarPicking.Name = "simpleButtonComenzarPicking";
			this.simpleButtonComenzarPicking.Size = new System.Drawing.Size(275, 124);
			this.simpleButtonComenzarPicking.TabIndex = 1;
			this.simpleButtonComenzarPicking.Text = "INICIAR\r\nPICKING";
			this.simpleButtonComenzarPicking.Click += new System.EventHandler(this.simpleButtonComenzarPicking_Click);
			// 
			// gridControlMovimientos
			// 
			this.gridControlMovimientos.DataSource = this.vMOVIMIENTOSPICKINGBindingSource;
			this.gridControlMovimientos.Location = new System.Drawing.Point(251, 565);
			this.gridControlMovimientos.MainView = this.gridViewMovimientos;
			this.gridControlMovimientos.Name = "gridControlMovimientos";
			this.gridControlMovimientos.Size = new System.Drawing.Size(980, 346);
			this.gridControlMovimientos.TabIndex = 2;
			this.gridControlMovimientos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMovimientos});
			// 
			// vMOVIMIENTOSPICKINGBindingSource
			// 
			this.vMOVIMIENTOSPICKINGBindingSource.DataSource = typeof(FCT.Negocio.V_MOVIMIENTOS_PICKING);
			// 
			// gridViewMovimientos
			// 
			this.gridViewMovimientos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewMovimientos.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridViewMovimientos.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridViewMovimientos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridViewMovimientos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewMovimientos.Appearance.Row.Options.UseFont = true;
			this.gridViewMovimientos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_MOVIMIENTO,
            this.colCOD_PALET,
            this.colCOD_REFERENCIA,
            this.colDES_REFERENCIA,
            this.colCANTIDAD,
            this.colUBICACION});
			this.gridViewMovimientos.GridControl = this.gridControlMovimientos;
			this.gridViewMovimientos.Name = "gridViewMovimientos";
			this.gridViewMovimientos.OptionsBehavior.Editable = false;
			this.gridViewMovimientos.OptionsBehavior.ReadOnly = true;
			this.gridViewMovimientos.OptionsCustomization.AllowColumnMoving = false;
			this.gridViewMovimientos.OptionsCustomization.AllowGroup = false;
			this.gridViewMovimientos.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
			this.gridViewMovimientos.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridViewMovimientos_FocusedRowObjectChanged);
			// 
			// colCOD_MOVIMIENTO
			// 
			this.colCOD_MOVIMIENTO.Caption = "Código de movimiento";
			this.colCOD_MOVIMIENTO.FieldName = "COD_MOVIMIENTO";
			this.colCOD_MOVIMIENTO.Name = "colCOD_MOVIMIENTO";
			this.colCOD_MOVIMIENTO.Visible = true;
			this.colCOD_MOVIMIENTO.VisibleIndex = 0;
			this.colCOD_MOVIMIENTO.Width = 135;
			// 
			// colCOD_PALET
			// 
			this.colCOD_PALET.Caption = "Código de palet";
			this.colCOD_PALET.FieldName = "COD_PALET";
			this.colCOD_PALET.Name = "colCOD_PALET";
			this.colCOD_PALET.Visible = true;
			this.colCOD_PALET.VisibleIndex = 1;
			this.colCOD_PALET.Width = 116;
			// 
			// colCOD_REFERENCIA
			// 
			this.colCOD_REFERENCIA.Caption = "Código de referencia";
			this.colCOD_REFERENCIA.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA.Name = "colCOD_REFERENCIA";
			this.colCOD_REFERENCIA.Visible = true;
			this.colCOD_REFERENCIA.VisibleIndex = 3;
			this.colCOD_REFERENCIA.Width = 151;
			// 
			// colDES_REFERENCIA
			// 
			this.colDES_REFERENCIA.Caption = "Producto";
			this.colDES_REFERENCIA.FieldName = "DES_REFERENCIA";
			this.colDES_REFERENCIA.Name = "colDES_REFERENCIA";
			this.colDES_REFERENCIA.Visible = true;
			this.colDES_REFERENCIA.VisibleIndex = 4;
			this.colDES_REFERENCIA.Width = 311;
			// 
			// colCANTIDAD
			// 
			this.colCANTIDAD.Caption = "Cantidad";
			this.colCANTIDAD.FieldName = "CANTIDAD";
			this.colCANTIDAD.Name = "colCANTIDAD";
			this.colCANTIDAD.Visible = true;
			this.colCANTIDAD.VisibleIndex = 5;
			this.colCANTIDAD.Width = 120;
			// 
			// colUBICACION
			// 
			this.colUBICACION.Caption = "Ubicación del palet";
			this.colUBICACION.FieldName = "UBICACION";
			this.colUBICACION.Name = "colUBICACION";
			this.colUBICACION.Visible = true;
			this.colUBICACION.VisibleIndex = 2;
			this.colUBICACION.Width = 122;
			// 
			// simpleButtonConfirmarMovimiento
			// 
			this.simpleButtonConfirmarMovimiento.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButtonConfirmarMovimiento.Appearance.Options.UseFont = true;
			this.simpleButtonConfirmarMovimiento.Enabled = false;
			this.simpleButtonConfirmarMovimiento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonConfirmarMovimiento.ImageOptions.Image")));
			this.simpleButtonConfirmarMovimiento.Location = new System.Drawing.Point(1379, 678);
			this.simpleButtonConfirmarMovimiento.Name = "simpleButtonConfirmarMovimiento";
			this.simpleButtonConfirmarMovimiento.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonConfirmarMovimiento.Size = new System.Drawing.Size(127, 124);
			this.simpleButtonConfirmarMovimiento.TabIndex = 3;
			this.simpleButtonConfirmarMovimiento.ToolTip = "Confirmar línea\r\nseleccionada como picada";
			this.simpleButtonConfirmarMovimiento.Click += new System.EventHandler(this.simpleButtonConfirmarMovimiento_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(251, 441);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(130, 64);
			this.labelControl1.TabIndex = 4;
			this.labelControl1.Text = "Calle";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(517, 441);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(222, 64);
			this.labelControl2.TabIndex = 5;
			this.labelControl2.Text = "Posición";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Appearance.Options.UseForeColor = true;
			this.labelControl3.Location = new System.Drawing.Point(861, 441);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(237, 64);
			this.labelControl3.TabIndex = 6;
			this.labelControl3.Text = "Cantidad";
			// 
			// textEditCalle
			// 
			this.textEditCalle.EditValue = "";
			this.textEditCalle.Location = new System.Drawing.Point(387, 438);
			this.textEditCalle.Name = "textEditCalle";
			this.textEditCalle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 40F);
			this.textEditCalle.Properties.Appearance.Options.UseFont = true;
			this.textEditCalle.Properties.ReadOnly = true;
			this.textEditCalle.Size = new System.Drawing.Size(68, 70);
			this.textEditCalle.TabIndex = 7;
			// 
			// textEditPosicion
			// 
			this.textEditPosicion.EditValue = "";
			this.textEditPosicion.Location = new System.Drawing.Point(745, 438);
			this.textEditPosicion.Name = "textEditPosicion";
			this.textEditPosicion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 40F);
			this.textEditPosicion.Properties.Appearance.Options.UseFont = true;
			this.textEditPosicion.Properties.ReadOnly = true;
			this.textEditPosicion.Size = new System.Drawing.Size(68, 70);
			this.textEditPosicion.TabIndex = 8;
			// 
			// textEditCantidad
			// 
			this.textEditCantidad.EditValue = "";
			this.textEditCantidad.Location = new System.Drawing.Point(1104, 438);
			this.textEditCantidad.Name = "textEditCantidad";
			this.textEditCantidad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 40F);
			this.textEditCantidad.Properties.Appearance.Options.UseFont = true;
			this.textEditCantidad.Properties.ReadOnly = true;
			this.textEditCantidad.Size = new System.Drawing.Size(127, 70);
			this.textEditCantidad.TabIndex = 9;
			// 
			// simpleButtonActualizar
			// 
			this.simpleButtonActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.ImageOptions.Image")));
			this.simpleButtonActualizar.Location = new System.Drawing.Point(190, 199);
			this.simpleButtonActualizar.Name = "simpleButtonActualizar";
			this.simpleButtonActualizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonActualizar.Size = new System.Drawing.Size(55, 52);
			this.simpleButtonActualizar.TabIndex = 35;
			this.simpleButtonActualizar.ToolTip = "Actualizar";
			this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
			// 
			// labelControl4
			// 
			this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Appearance.Options.UseForeColor = true;
			this.labelControl4.Location = new System.Drawing.Point(251, 12);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(117, 41);
			this.labelControl4.TabIndex = 96;
			this.labelControl4.Text = "PICKING";
			// 
			// formPicking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1756, 964);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.simpleButtonActualizar);
			this.Controls.Add(this.textEditCantidad);
			this.Controls.Add(this.textEditPosicion);
			this.Controls.Add(this.textEditCalle);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.simpleButtonConfirmarMovimiento);
			this.Controls.Add(this.gridControlMovimientos);
			this.Controls.Add(this.simpleButtonComenzarPicking);
			this.Controls.Add(this.gridControlPedidos);
			this.Name = "formPicking";
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDACABBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlMovimientos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vMOVIMIENTOSPICKINGBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewMovimientos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditCalle.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPosicion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditCantidad.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlPedidos;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidos;
		private DevExpress.XtraEditors.SimpleButton simpleButtonComenzarPicking;
		private DevExpress.XtraGrid.GridControl gridControlMovimientos;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewMovimientos;
		private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmarMovimiento;
		private System.Windows.Forms.BindingSource vORDENSALIDACABBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_PETICION;
		private DevExpress.XtraGrid.Columns.GridColumn colPOBLACION;
		private DevExpress.XtraGrid.Columns.GridColumn colPROVINCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_CREACION;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD_LINEAS;
		private System.Windows.Forms.BindingSource vMOVIMIENTOSPICKINGBindingSource;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit textEditCalle;
		private DevExpress.XtraEditors.TextEdit textEditPosicion;
		private DevExpress.XtraEditors.TextEdit textEditCantidad;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_EMPRESA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_MOVIMIENTO;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_PALET;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD;
		private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraGrid.Columns.GridColumn colUBICACION;
	}
}