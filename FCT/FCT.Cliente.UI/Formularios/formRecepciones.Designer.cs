namespace FCT.Cliente.UI.Formularios
{
	partial class formRecepciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRecepciones));
			this.simpleButtonAnadirLinea = new DevExpress.XtraEditors.SimpleButton();
			this.spinEditCantidad = new DevExpress.XtraEditors.SpinEdit();
			this.simpleButtonQuitarLinea = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonGenerarAviso = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.vISTAREFERENCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewReferencias = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFECH_CREACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIMAGEN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridControlReferencias = new DevExpress.XtraGrid.GridControl();
			this.gridControlPedidos = new DevExpress.XtraGrid.GridControl();
			this.gridViewRecepciones1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridViewRecepciones = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.textEditFechaLlegada = new DevExpress.XtraEditors.TextEdit();
			this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.colCOD_REFERENCIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.vRECEPCIONESLINBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewReferencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecepciones1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecepciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaLlegada.Properties)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESLINBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButtonAnadirLinea
			// 
			this.simpleButtonAnadirLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonAnadirLinea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnadirLinea.ImageOptions.Image")));
			this.simpleButtonAnadirLinea.Location = new System.Drawing.Point(861, 524);
			this.simpleButtonAnadirLinea.Name = "simpleButtonAnadirLinea";
			this.simpleButtonAnadirLinea.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonAnadirLinea.Size = new System.Drawing.Size(99, 67);
			this.simpleButtonAnadirLinea.TabIndex = 2;
			this.simpleButtonAnadirLinea.Text = " ";
			this.simpleButtonAnadirLinea.ToolTip = "Añadir línea de la referencia\r\nseleccionada al aviso";
			this.simpleButtonAnadirLinea.Click += new System.EventHandler(this.simpleButtonAnadirLinea_Click);
			// 
			// spinEditCantidad
			// 
			this.spinEditCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditCantidad.Location = new System.Drawing.Point(861, 498);
			this.spinEditCantidad.Name = "spinEditCantidad";
			this.spinEditCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditCantidad.Properties.IsFloatValue = false;
			this.spinEditCantidad.Properties.MaskSettings.Set("mask", "d");
			this.spinEditCantidad.Properties.MaxLength = 4;
			this.spinEditCantidad.Size = new System.Drawing.Size(99, 20);
			this.spinEditCantidad.TabIndex = 3;
			// 
			// simpleButtonQuitarLinea
			// 
			this.simpleButtonQuitarLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonQuitarLinea.Enabled = false;
			this.simpleButtonQuitarLinea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonQuitarLinea.ImageOptions.Image")));
			this.simpleButtonQuitarLinea.Location = new System.Drawing.Point(1654, 524);
			this.simpleButtonQuitarLinea.Name = "simpleButtonQuitarLinea";
			this.simpleButtonQuitarLinea.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonQuitarLinea.Size = new System.Drawing.Size(57, 56);
			this.simpleButtonQuitarLinea.TabIndex = 4;
			this.simpleButtonQuitarLinea.Text = " ";
			this.simpleButtonQuitarLinea.ToolTip = "Eliminar línea seleccionada";
			this.simpleButtonQuitarLinea.Click += new System.EventHandler(this.simpleButtonQuitarLinea_Click);
			// 
			// simpleButtonGenerarAviso
			// 
			this.simpleButtonGenerarAviso.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.simpleButtonGenerarAviso.Appearance.Options.UseFont = true;
			this.simpleButtonGenerarAviso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonGenerarAviso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGenerarAviso.ImageOptions.Image")));
			this.simpleButtonGenerarAviso.Location = new System.Drawing.Point(1539, 141);
			this.simpleButtonGenerarAviso.Name = "simpleButtonGenerarAviso";
			this.simpleButtonGenerarAviso.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonGenerarAviso.Size = new System.Drawing.Size(109, 101);
			this.simpleButtonGenerarAviso.TabIndex = 5;
			this.simpleButtonGenerarAviso.Text = " ";
			this.simpleButtonGenerarAviso.ToolTip = "Generar aviso y enviar a ICP";
			this.simpleButtonGenerarAviso.Click += new System.EventHandler(this.simpleButtonGenerarAviso_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(69, 23);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(183, 27);
			this.labelControl1.TabIndex = 7;
			this.labelControl1.Text = "Fecha de llegada";
			// 
			// vISTAREFERENCIASBindingSource
			// 
			this.vISTAREFERENCIASBindingSource.DataSource = typeof(FCT.Negocio.V_REFERENCIAS);
			// 
			// gridViewReferencias
			// 
			this.gridViewReferencias.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewReferencias.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridViewReferencias.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridViewReferencias.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridViewReferencias.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewReferencias.Appearance.Row.Options.UseFont = true;
			this.gridViewReferencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_EMPRESA,
            this.colCOD_REFERENCIA,
            this.colDES_REFERENCIA,
            this.colPRECIO,
            this.colFECH_CREACION,
            this.colIMAGEN,
            this.colESTADO,
            this.colSTOCK});
			this.gridViewReferencias.GridControl = this.gridControlReferencias;
			this.gridViewReferencias.Name = "gridViewReferencias";
			this.gridViewReferencias.OptionsBehavior.Editable = false;
			this.gridViewReferencias.OptionsBehavior.ReadOnly = true;
			this.gridViewReferencias.OptionsCustomization.AllowColumnMoving = false;
			this.gridViewReferencias.OptionsCustomization.AllowGroup = false;
			// 
			// colID_EMPRESA
			// 
			this.colID_EMPRESA.FieldName = "ID_EMPRESA";
			this.colID_EMPRESA.Name = "colID_EMPRESA";
			// 
			// colCOD_REFERENCIA
			// 
			this.colCOD_REFERENCIA.Caption = "Código de la referencia";
			this.colCOD_REFERENCIA.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA.Name = "colCOD_REFERENCIA";
			this.colCOD_REFERENCIA.Visible = true;
			this.colCOD_REFERENCIA.VisibleIndex = 0;
			this.colCOD_REFERENCIA.Width = 160;
			// 
			// colDES_REFERENCIA
			// 
			this.colDES_REFERENCIA.Caption = "Producto";
			this.colDES_REFERENCIA.FieldName = "DES_REFERENCIA";
			this.colDES_REFERENCIA.Name = "colDES_REFERENCIA";
			this.colDES_REFERENCIA.Visible = true;
			this.colDES_REFERENCIA.VisibleIndex = 1;
			this.colDES_REFERENCIA.Width = 320;
			// 
			// colPRECIO
			// 
			this.colPRECIO.Caption = "Precio";
			this.colPRECIO.FieldName = "PRECIO";
			this.colPRECIO.Name = "colPRECIO";
			this.colPRECIO.Visible = true;
			this.colPRECIO.VisibleIndex = 2;
			this.colPRECIO.Width = 79;
			// 
			// colFECH_CREACION
			// 
			this.colFECH_CREACION.FieldName = "FECH_CREACION";
			this.colFECH_CREACION.Name = "colFECH_CREACION";
			// 
			// colIMAGEN
			// 
			this.colIMAGEN.FieldName = "IMAGEN";
			this.colIMAGEN.Name = "colIMAGEN";
			// 
			// colESTADO
			// 
			this.colESTADO.FieldName = "ESTADO";
			this.colESTADO.Name = "colESTADO";
			// 
			// colSTOCK
			// 
			this.colSTOCK.Caption = "Stock";
			this.colSTOCK.FieldName = "STOCK";
			this.colSTOCK.Name = "colSTOCK";
			this.colSTOCK.Visible = true;
			this.colSTOCK.VisibleIndex = 3;
			this.colSTOCK.Width = 82;
			// 
			// gridControlReferencias
			// 
			this.gridControlReferencias.DataSource = this.vISTAREFERENCIASBindingSource;
			this.gridControlReferencias.Location = new System.Drawing.Point(152, 263);
			this.gridControlReferencias.MainView = this.gridViewReferencias;
			this.gridControlReferencias.Name = "gridControlReferencias";
			this.gridControlReferencias.Size = new System.Drawing.Size(666, 611);
			this.gridControlReferencias.TabIndex = 9;
			this.gridControlReferencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReferencias});
			// 
			// gridControlPedidos
			// 
			this.gridControlPedidos.DataSource = this.vRECEPCIONESLINBindingSource;
			this.gridControlPedidos.Location = new System.Drawing.Point(1010, 263);
			this.gridControlPedidos.MainView = this.gridViewRecepciones1;
			this.gridControlPedidos.Name = "gridControlPedidos";
			this.gridControlPedidos.Size = new System.Drawing.Size(638, 611);
			this.gridControlPedidos.TabIndex = 10;
			this.gridControlPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecepciones1,
            this.gridViewRecepciones});
			// 
			// gridViewRecepciones1
			// 
			this.gridViewRecepciones1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewRecepciones1.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridViewRecepciones1.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridViewRecepciones1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridViewRecepciones1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewRecepciones1.Appearance.Row.Options.UseFont = true;
			this.gridViewRecepciones1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_REFERENCIA1,
            this.colDES_REFERENCIA1,
            this.colCANTIDAD});
			this.gridViewRecepciones1.GridControl = this.gridControlPedidos;
			this.gridViewRecepciones1.Name = "gridViewRecepciones1";
			this.gridViewRecepciones1.OptionsBehavior.Editable = false;
			this.gridViewRecepciones1.OptionsBehavior.ReadOnly = true;
			this.gridViewRecepciones1.OptionsCustomization.AllowColumnMoving = false;
			this.gridViewRecepciones1.OptionsCustomization.AllowGroup = false;
			this.gridViewRecepciones1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewRecepciones1_SelectionChanged);
			// 
			// gridViewRecepciones
			// 
			this.gridViewRecepciones.GridControl = this.gridControlPedidos;
			this.gridViewRecepciones.Name = "gridViewRecepciones";
			this.gridViewRecepciones.OptionsBehavior.Editable = false;
			this.gridViewRecepciones.OptionsBehavior.ReadOnly = true;
			// 
			// textEditFechaLlegada
			// 
			this.textEditFechaLlegada.Location = new System.Drawing.Point(107, 68);
			this.textEditFechaLlegada.Name = "textEditFechaLlegada";
			this.textEditFechaLlegada.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
			this.textEditFechaLlegada.Properties.MaskSettings.Set("mask", "d");
			this.textEditFechaLlegada.Properties.MaskSettings.Set("useAdvancingCaret", true);
			this.textEditFechaLlegada.Properties.UseMaskAsDisplayFormat = true;
			this.textEditFechaLlegada.Size = new System.Drawing.Size(111, 20);
			this.textEditFechaLlegada.TabIndex = 12;
			this.textEditFechaLlegada.Leave += new System.EventHandler(this.textEditFechaLlegada_Leave);
			// 
			// simpleButtonActualizar
			// 
			this.simpleButtonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.ImageOptions.Image")));
			this.simpleButtonActualizar.Location = new System.Drawing.Point(84, 524);
			this.simpleButtonActualizar.Name = "simpleButtonActualizar";
			this.simpleButtonActualizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonActualizar.Size = new System.Drawing.Size(62, 56);
			this.simpleButtonActualizar.TabIndex = 13;
			this.simpleButtonActualizar.Text = " ";
			this.simpleButtonActualizar.ToolTip = "Actualizar";
			this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.panel1.Controls.Add(this.textEditFechaLlegada);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Location = new System.Drawing.Point(750, 107);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(322, 119);
			this.panel1.TabIndex = 14;
			// 
			// labelControl4
			// 
			this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Appearance.Options.UseForeColor = true;
			this.labelControl4.Location = new System.Drawing.Point(152, 38);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(293, 41);
			this.labelControl4.TabIndex = 95;
			this.labelControl4.Text = "AVISOS DE LLEGADA";
			// 
			// colCOD_REFERENCIA1
			// 
			this.colCOD_REFERENCIA1.Caption = "Código de la referencia";
			this.colCOD_REFERENCIA1.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA1.Name = "colCOD_REFERENCIA1";
			this.colCOD_REFERENCIA1.Visible = true;
			this.colCOD_REFERENCIA1.VisibleIndex = 0;
			// 
			// colDES_REFERENCIA1
			// 
			this.colDES_REFERENCIA1.Caption = "Producto";
			this.colDES_REFERENCIA1.FieldName = "DES_REFERENCIA";
			this.colDES_REFERENCIA1.Name = "colDES_REFERENCIA1";
			this.colDES_REFERENCIA1.Visible = true;
			this.colDES_REFERENCIA1.VisibleIndex = 1;
			// 
			// colCANTIDAD
			// 
			this.colCANTIDAD.Caption = "Cantidad";
			this.colCANTIDAD.FieldName = "CANTIDAD";
			this.colCANTIDAD.Name = "colCANTIDAD";
			this.colCANTIDAD.Visible = true;
			this.colCANTIDAD.VisibleIndex = 2;
			// 
			// vRECEPCIONESLINBindingSource
			// 
			this.vRECEPCIONESLINBindingSource.DataSource = typeof(FCT.Negocio.V_RECEPCIONES_LIN);
			// 
			// formRecepciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1790, 1000);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.simpleButtonActualizar);
			this.Controls.Add(this.gridControlPedidos);
			this.Controls.Add(this.gridControlReferencias);
			this.Controls.Add(this.simpleButtonGenerarAviso);
			this.Controls.Add(this.simpleButtonQuitarLinea);
			this.Controls.Add(this.spinEditCantidad);
			this.Controls.Add(this.simpleButtonAnadirLinea);
			this.Name = "formRecepciones";
			this.Load += new System.EventHandler(this.formRecepciones_Load);
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewReferencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecepciones1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecepciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaLlegada.Properties)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESLINBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraEditors.SimpleButton simpleButtonAnadirLinea;
		private DevExpress.XtraEditors.SpinEdit spinEditCantidad;
		private DevExpress.XtraEditors.SimpleButton simpleButtonQuitarLinea;
		private DevExpress.XtraEditors.SimpleButton simpleButtonGenerarAviso;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.BindingSource vISTAREFERENCIASBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewReferencias;
		private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colPRECIO;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_CREACION;
		private DevExpress.XtraGrid.Columns.GridColumn colIMAGEN;
		private DevExpress.XtraGrid.Columns.GridColumn colESTADO;
		private DevExpress.XtraGrid.GridControl gridControlReferencias;
		private DevExpress.XtraGrid.GridControl gridControlPedidos;
		private DevExpress.XtraGrid.Columns.GridColumn colSTOCK;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecepciones;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecepciones1;
		private DevExpress.XtraEditors.TextEdit textEditFechaLlegada;
		private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA1;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA1;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD;
		private System.Windows.Forms.BindingSource vRECEPCIONESLINBindingSource;
	}
}