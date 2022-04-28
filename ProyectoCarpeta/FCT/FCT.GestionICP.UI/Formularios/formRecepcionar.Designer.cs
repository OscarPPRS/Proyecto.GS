namespace FCT.GestionICP.UI.Formularios
{
	partial class formRecepcionar
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			this.gridControlAviso = new DevExpress.XtraGrid.GridControl();
			this.vRECEPCIONESLINBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewAviso = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colALBARAN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_LINEA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.textEditAlbaran = new DevExpress.XtraEditors.TextEdit();
			this.simpleButtonBuscar = new DevExpress.XtraEditors.SimpleButton();
			this.textEditFechaLlegada = new DevExpress.XtraEditors.TextEdit();
			this.textEditFechaCreacionAviso = new DevExpress.XtraEditors.TextEdit();
			this.textEditNombreEmpresa = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButtonConfirmarRecepcion = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.textEditDescripcionReferencia = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.spinEditCantidadBuena = new DevExpress.XtraEditors.SpinEdit();
			this.spinEditCantidadMala = new DevExpress.XtraEditors.SpinEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButtonConfirmarLinea = new DevExpress.XtraEditors.SimpleButton();
			this.checkButtonAniadirReferencia = new DevExpress.XtraEditors.CheckButton();
			this.simpleButtonEliminarLinea = new DevExpress.XtraEditors.SimpleButton();
			this.textEditPrecio = new DevExpress.XtraEditors.TextEdit();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlAviso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESLINBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewAviso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditAlbaran.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaLlegada.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaCreacionAviso.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditNombreEmpresa.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDescripcionReferencia.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadBuena.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadMala.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPrecio.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlAviso
			// 
			this.gridControlAviso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.gridControlAviso.DataSource = this.vRECEPCIONESLINBindingSource;
			gridLevelNode1.RelationName = "Level1";
			this.gridControlAviso.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gridControlAviso.Location = new System.Drawing.Point(225, 177);
			this.gridControlAviso.MainView = this.gridViewAviso;
			this.gridControlAviso.Name = "gridControlAviso";
			this.gridControlAviso.Size = new System.Drawing.Size(760, 674);
			this.gridControlAviso.TabIndex = 0;
			this.gridControlAviso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAviso});
			// 
			// vRECEPCIONESLINBindingSource
			// 
			this.vRECEPCIONESLINBindingSource.DataSource = typeof(FCT.Negocio.V_RECEPCIONES_LIN);
			// 
			// gridViewAviso
			// 
			this.gridViewAviso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colALBARAN,
            this.colCOD_LINEA,
            this.colCOD_REFERENCIA,
            this.colCANTIDAD,
            this.colDES_REFERENCIA,
            this.colPRECIO});
			this.gridViewAviso.GridControl = this.gridControlAviso;
			this.gridViewAviso.Name = "gridViewAviso";
			this.gridViewAviso.OptionsBehavior.Editable = false;
			this.gridViewAviso.OptionsBehavior.ReadOnly = true;
			this.gridViewAviso.OptionsCustomization.AllowGroup = false;
			// 
			// colALBARAN
			// 
			this.colALBARAN.FieldName = "ALBARAN";
			this.colALBARAN.Name = "colALBARAN";
			// 
			// colCOD_LINEA
			// 
			this.colCOD_LINEA.Caption = " ";
			this.colCOD_LINEA.FieldName = "COD_LINEA";
			this.colCOD_LINEA.Name = "colCOD_LINEA";
			this.colCOD_LINEA.Visible = true;
			this.colCOD_LINEA.VisibleIndex = 0;
			this.colCOD_LINEA.Width = 26;
			// 
			// colCOD_REFERENCIA
			// 
			this.colCOD_REFERENCIA.Caption = "Referencia";
			this.colCOD_REFERENCIA.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA.Name = "colCOD_REFERENCIA";
			this.colCOD_REFERENCIA.Visible = true;
			this.colCOD_REFERENCIA.VisibleIndex = 1;
			this.colCOD_REFERENCIA.Width = 174;
			// 
			// colCANTIDAD
			// 
			this.colCANTIDAD.Caption = "Cantidad";
			this.colCANTIDAD.FieldName = "CANTIDAD";
			this.colCANTIDAD.Name = "colCANTIDAD";
			this.colCANTIDAD.Visible = true;
			this.colCANTIDAD.VisibleIndex = 3;
			this.colCANTIDAD.Width = 58;
			// 
			// colDES_REFERENCIA
			// 
			this.colDES_REFERENCIA.Caption = "Producto";
			this.colDES_REFERENCIA.FieldName = "DES_REFERENCIA";
			this.colDES_REFERENCIA.Name = "colDES_REFERENCIA";
			this.colDES_REFERENCIA.Visible = true;
			this.colDES_REFERENCIA.VisibleIndex = 2;
			this.colDES_REFERENCIA.Width = 380;
			// 
			// colPRECIO
			// 
			this.colPRECIO.Caption = "Precio";
			this.colPRECIO.FieldName = "PRECIO";
			this.colPRECIO.Name = "colPRECIO";
			this.colPRECIO.Visible = true;
			this.colPRECIO.VisibleIndex = 4;
			this.colPRECIO.Width = 97;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(260, 34);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(88, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Escribe el albarán:";
			// 
			// textEditAlbaran
			// 
			this.textEditAlbaran.Location = new System.Drawing.Point(361, 31);
			this.textEditAlbaran.Name = "textEditAlbaran";
			this.textEditAlbaran.Size = new System.Drawing.Size(156, 20);
			this.textEditAlbaran.TabIndex = 2;
			// 
			// simpleButtonBuscar
			// 
			this.simpleButtonBuscar.Location = new System.Drawing.Point(523, 32);
			this.simpleButtonBuscar.Name = "simpleButtonBuscar";
			this.simpleButtonBuscar.Size = new System.Drawing.Size(56, 17);
			this.simpleButtonBuscar.TabIndex = 3;
			this.simpleButtonBuscar.Text = "Buscar";
			this.simpleButtonBuscar.Click += new System.EventHandler(this.simpleButtonBuscar_Click);
			// 
			// textEditFechaLlegada
			// 
			this.textEditFechaLlegada.Location = new System.Drawing.Point(811, 80);
			this.textEditFechaLlegada.Name = "textEditFechaLlegada";
			this.textEditFechaLlegada.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
			this.textEditFechaLlegada.Properties.MaskSettings.Set("mask", "d");
			this.textEditFechaLlegada.Properties.MaskSettings.Set("useAdvancingCaret", true);
			this.textEditFechaLlegada.Properties.UseMaskAsDisplayFormat = true;
			this.textEditFechaLlegada.Size = new System.Drawing.Size(111, 20);
			this.textEditFechaLlegada.TabIndex = 5;
			// 
			// textEditFechaCreacionAviso
			// 
			this.textEditFechaCreacionAviso.Location = new System.Drawing.Point(583, 80);
			this.textEditFechaCreacionAviso.Name = "textEditFechaCreacionAviso";
			this.textEditFechaCreacionAviso.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
			this.textEditFechaCreacionAviso.Properties.MaskSettings.Set("mask", "d");
			this.textEditFechaCreacionAviso.Properties.MaskSettings.Set("useAdvancingCaret", true);
			this.textEditFechaCreacionAviso.Properties.UseMaskAsDisplayFormat = true;
			this.textEditFechaCreacionAviso.Size = new System.Drawing.Size(111, 20);
			this.textEditFechaCreacionAviso.TabIndex = 4;
			// 
			// textEditNombreEmpresa
			// 
			this.textEditNombreEmpresa.Location = new System.Drawing.Point(323, 80);
			this.textEditNombreEmpresa.Name = "textEditNombreEmpresa";
			this.textEditNombreEmpresa.Properties.ReadOnly = true;
			this.textEditNombreEmpresa.Size = new System.Drawing.Size(100, 20);
			this.textEditNombreEmpresa.TabIndex = 3;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(263, 83);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(54, 13);
			this.labelControl2.TabIndex = 16;
			this.labelControl2.Text = "Proveedor:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(443, 83);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(134, 13);
			this.labelControl3.TabIndex = 17;
			this.labelControl3.Text = "Fecha de creación de aviso:";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(720, 83);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(85, 13);
			this.labelControl4.TabIndex = 18;
			this.labelControl4.Text = "Fecha de llegada:";
			// 
			// simpleButtonConfirmarRecepcion
			// 
			this.simpleButtonConfirmarRecepcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.simpleButtonConfirmarRecepcion.Appearance.Options.UseFont = true;
			this.simpleButtonConfirmarRecepcion.Location = new System.Drawing.Point(1210, 20);
			this.simpleButtonConfirmarRecepcion.Name = "simpleButtonConfirmarRecepcion";
			this.simpleButtonConfirmarRecepcion.Size = new System.Drawing.Size(313, 80);
			this.simpleButtonConfirmarRecepcion.TabIndex = 19;
			this.simpleButtonConfirmarRecepcion.Text = "CONFIRMAR RECEPCIÓN";
			this.simpleButtonConfirmarRecepcion.Click += new System.EventHandler(this.simpleButtonConfirmarRecepcion_Click);
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(505, 138);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(207, 33);
			this.labelControl5.TabIndex = 20;
			this.labelControl5.Text = "Supuesto avisado";
			// 
			// textEditDescripcionReferencia
			// 
			this.textEditDescripcionReferencia.Location = new System.Drawing.Point(1376, 313);
			this.textEditDescripcionReferencia.Name = "textEditDescripcionReferencia";
			this.textEditDescripcionReferencia.Size = new System.Drawing.Size(116, 20);
			this.textEditDescripcionReferencia.TabIndex = 23;
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(1270, 316);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(104, 13);
			this.labelControl7.TabIndex = 24;
			this.labelControl7.Text = "Nombre del producto:";
			// 
			// spinEditCantidadBuena
			// 
			this.spinEditCantidadBuena.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditCantidadBuena.Location = new System.Drawing.Point(1290, 461);
			this.spinEditCantidadBuena.Name = "spinEditCantidadBuena";
			this.spinEditCantidadBuena.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditCantidadBuena.Size = new System.Drawing.Size(48, 20);
			this.spinEditCantidadBuena.TabIndex = 25;
			// 
			// spinEditCantidadMala
			// 
			this.spinEditCantidadMala.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditCantidadMala.Location = new System.Drawing.Point(1433, 461);
			this.spinEditCantidadMala.Name = "spinEditCantidadMala";
			this.spinEditCantidadMala.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditCantidadMala.Size = new System.Drawing.Size(48, 20);
			this.spinEditCantidadMala.TabIndex = 26;
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(1249, 442);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(121, 13);
			this.labelControl6.TabIndex = 27;
			this.labelControl6.Text = "Cantidad en buen estado";
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(1399, 442);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(113, 13);
			this.labelControl8.TabIndex = 28;
			this.labelControl8.Text = "Cantidad en mal estado";
			// 
			// simpleButtonConfirmarLinea
			// 
			this.simpleButtonConfirmarLinea.Location = new System.Drawing.Point(1304, 513);
			this.simpleButtonConfirmarLinea.Name = "simpleButtonConfirmarLinea";
			this.simpleButtonConfirmarLinea.Size = new System.Drawing.Size(168, 39);
			this.simpleButtonConfirmarLinea.TabIndex = 29;
			this.simpleButtonConfirmarLinea.Text = "Confirmar línea";
			this.simpleButtonConfirmarLinea.Click += new System.EventHandler(this.simpleButtonConfirmarLinea_Click);
			// 
			// checkButtonAniadirReferencia
			// 
			this.checkButtonAniadirReferencia.Appearance.BackColor = System.Drawing.Color.White;
			this.checkButtonAniadirReferencia.Appearance.BackColor2 = System.Drawing.Color.Transparent;
			this.checkButtonAniadirReferencia.Appearance.Options.UseBackColor = true;
			this.checkButtonAniadirReferencia.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonAniadirReferencia.AppearanceDisabled.Options.UseBackColor = true;
			this.checkButtonAniadirReferencia.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonAniadirReferencia.AppearanceHovered.Options.UseBackColor = true;
			this.checkButtonAniadirReferencia.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonAniadirReferencia.AppearancePressed.BorderColor = System.Drawing.Color.Black;
			this.checkButtonAniadirReferencia.AppearancePressed.Options.UseBackColor = true;
			this.checkButtonAniadirReferencia.AppearancePressed.Options.UseBorderColor = true;
			this.checkButtonAniadirReferencia.Location = new System.Drawing.Point(1320, 259);
			this.checkButtonAniadirReferencia.Name = "checkButtonAniadirReferencia";
			this.checkButtonAniadirReferencia.Size = new System.Drawing.Size(123, 30);
			this.checkButtonAniadirReferencia.TabIndex = 30;
			this.checkButtonAniadirReferencia.Text = "Referencia desconocida";
			this.checkButtonAniadirReferencia.CheckedChanged += new System.EventHandler(this.checkButtonAniadirReferencia_CheckedChanged);
			// 
			// simpleButtonEliminarLinea
			// 
			this.simpleButtonEliminarLinea.Location = new System.Drawing.Point(1304, 595);
			this.simpleButtonEliminarLinea.Name = "simpleButtonEliminarLinea";
			this.simpleButtonEliminarLinea.Size = new System.Drawing.Size(168, 39);
			this.simpleButtonEliminarLinea.TabIndex = 31;
			this.simpleButtonEliminarLinea.Text = "Eliminar línea";
			this.simpleButtonEliminarLinea.Click += new System.EventHandler(this.simpleButtonEliminarLinea_Click);
			// 
			// textEditPrecio
			// 
			this.textEditPrecio.Location = new System.Drawing.Point(1376, 339);
			this.textEditPrecio.Name = "textEditPrecio";
			this.textEditPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEditPrecio.Properties.MaskSettings.Set("mask", "c");
			this.textEditPrecio.Size = new System.Drawing.Size(116, 20);
			this.textEditPrecio.TabIndex = 80;
			// 
			// labelControl9
			// 
			this.labelControl9.Location = new System.Drawing.Point(1270, 342);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(33, 13);
			this.labelControl9.TabIndex = 81;
			this.labelControl9.Text = "Precio:";
			// 
			// formRecepcionar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1819, 863);
			this.Controls.Add(this.labelControl9);
			this.Controls.Add(this.textEditPrecio);
			this.Controls.Add(this.simpleButtonEliminarLinea);
			this.Controls.Add(this.checkButtonAniadirReferencia);
			this.Controls.Add(this.simpleButtonConfirmarLinea);
			this.Controls.Add(this.labelControl8);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.spinEditCantidadMala);
			this.Controls.Add(this.spinEditCantidadBuena);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.textEditDescripcionReferencia);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.simpleButtonConfirmarRecepcion);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.textEditNombreEmpresa);
			this.Controls.Add(this.textEditFechaCreacionAviso);
			this.Controls.Add(this.textEditFechaLlegada);
			this.Controls.Add(this.simpleButtonBuscar);
			this.Controls.Add(this.textEditAlbaran);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.gridControlAviso);
			this.Name = "formRecepcionar";
			this.Text = "formRecepcionar";
			this.Load += new System.EventHandler(this.formRecepcionar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlAviso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESLINBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewAviso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditAlbaran.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaLlegada.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaCreacionAviso.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditNombreEmpresa.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDescripcionReferencia.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadBuena.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadMala.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPrecio.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlAviso;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewAviso;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit textEditAlbaran;
		private DevExpress.XtraEditors.SimpleButton simpleButtonBuscar;
		private DevExpress.XtraEditors.TextEdit textEditFechaLlegada;
		private DevExpress.XtraEditors.TextEdit textEditFechaCreacionAviso;
		private DevExpress.XtraEditors.TextEdit textEditNombreEmpresa;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmarRecepcion;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.TextEdit textEditDescripcionReferencia;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.SpinEdit spinEditCantidadBuena;
		private DevExpress.XtraEditors.SpinEdit spinEditCantidadMala;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmarLinea;
		private DevExpress.XtraEditors.CheckButton checkButtonAniadirReferencia;
		private DevExpress.XtraEditors.SimpleButton simpleButtonEliminarLinea;
		private DevExpress.XtraEditors.TextEdit textEditPrecio;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraGrid.Columns.GridColumn colALBARAN;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_LINEA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colPRECIO;
		private System.Windows.Forms.BindingSource vRECEPCIONESLINBindingSource;
	}
}