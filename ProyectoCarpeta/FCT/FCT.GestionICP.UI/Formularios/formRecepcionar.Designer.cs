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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRecepcionar));
			this.gridControlAviso = new DevExpress.XtraGrid.GridControl();
			this.vRECEPCIONESLINBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewAviso = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colALBARAN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_LINEA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.textEditAlbaran = new DevExpress.XtraEditors.TextEdit();
			this.simpleButtonBuscar = new DevExpress.XtraEditors.SimpleButton();
			this.textEditFechaLlegada = new DevExpress.XtraEditors.TextEdit();
			this.textEditFechaCreacionAviso = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButtonConfirmarRecepcion = new DevExpress.XtraEditors.SimpleButton();
			this.textEditDescripcionReferencia = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.spinEditCantidadBuena = new DevExpress.XtraEditors.SpinEdit();
			this.spinEditCantidadMala = new DevExpress.XtraEditors.SpinEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButtonConfirmarLinea = new DevExpress.XtraEditors.SimpleButton();
			this.checkButtonAniadirReferencia = new DevExpress.XtraEditors.CheckButton();
			this.textEditPrecio = new DevExpress.XtraEditors.TextEdit();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textEditNombreEmpresa = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panel3 = new System.Windows.Forms.Panel();
			this.checkButtonExcedenteFalta = new DevExpress.XtraEditors.CheckButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.spinEditFalta = new DevExpress.XtraEditors.SpinEdit();
			this.spinEditExcedente = new DevExpress.XtraEditors.SpinEdit();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlAviso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESLINBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewAviso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditAlbaran.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaLlegada.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaCreacionAviso.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDescripcionReferencia.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadBuena.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadMala.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPrecio.Properties)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinEditFalta.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditExcedente.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlAviso
			// 
			this.gridControlAviso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlAviso.DataSource = this.vRECEPCIONESLINBindingSource;
			gridLevelNode1.RelationName = "Level1";
			this.gridControlAviso.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gridControlAviso.Location = new System.Drawing.Point(537, 135);
			this.gridControlAviso.MainView = this.gridViewAviso;
			this.gridControlAviso.Name = "gridControlAviso";
			this.gridControlAviso.Size = new System.Drawing.Size(760, 696);
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
			this.gridViewAviso.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridViewAviso_FocusedRowObjectChanged);
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
			// textEditAlbaran
			// 
			this.textEditAlbaran.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textEditAlbaran.Location = new System.Drawing.Point(227, 266);
			this.textEditAlbaran.Name = "textEditAlbaran";
			this.textEditAlbaran.Size = new System.Drawing.Size(156, 20);
			this.textEditAlbaran.TabIndex = 2;
			// 
			// simpleButtonBuscar
			// 
			this.simpleButtonBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonBuscar.ImageOptions.Image")));
			this.simpleButtonBuscar.Location = new System.Drawing.Point(391, 262);
			this.simpleButtonBuscar.Name = "simpleButtonBuscar";
			this.simpleButtonBuscar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonBuscar.Size = new System.Drawing.Size(26, 29);
			this.simpleButtonBuscar.TabIndex = 3;
			this.simpleButtonBuscar.Click += new System.EventHandler(this.simpleButtonBuscar_Click);
			// 
			// textEditFechaLlegada
			// 
			this.textEditFechaLlegada.Location = new System.Drawing.Point(186, 150);
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
			this.textEditFechaCreacionAviso.Location = new System.Drawing.Point(186, 97);
			this.textEditFechaCreacionAviso.Name = "textEditFechaCreacionAviso";
			this.textEditFechaCreacionAviso.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
			this.textEditFechaCreacionAviso.Properties.MaskSettings.Set("mask", "d");
			this.textEditFechaCreacionAviso.Properties.MaskSettings.Set("useAdvancingCaret", true);
			this.textEditFechaCreacionAviso.Properties.UseMaskAsDisplayFormat = true;
			this.textEditFechaCreacionAviso.Size = new System.Drawing.Size(111, 20);
			this.textEditFechaCreacionAviso.TabIndex = 4;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(25, 50);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(84, 19);
			this.labelControl2.TabIndex = 16;
			this.labelControl2.Text = "Proveedor";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(25, 98);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(145, 19);
			this.labelControl3.TabIndex = 17;
			this.labelControl3.Text = "Fecha de creación";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(25, 148);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(137, 19);
			this.labelControl4.TabIndex = 18;
			this.labelControl4.Text = "Fecha de llegada";
			// 
			// simpleButtonConfirmarRecepcion
			// 
			this.simpleButtonConfirmarRecepcion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonConfirmarRecepcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.simpleButtonConfirmarRecepcion.Appearance.Options.UseFont = true;
			this.simpleButtonConfirmarRecepcion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonConfirmarRecepcion.ImageOptions.Image")));
			this.simpleButtonConfirmarRecepcion.Location = new System.Drawing.Point(1599, 15);
			this.simpleButtonConfirmarRecepcion.Name = "simpleButtonConfirmarRecepcion";
			this.simpleButtonConfirmarRecepcion.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonConfirmarRecepcion.Size = new System.Drawing.Size(108, 109);
			this.simpleButtonConfirmarRecepcion.TabIndex = 19;
			this.simpleButtonConfirmarRecepcion.ToolTip = "Confirmar aviso";
			this.simpleButtonConfirmarRecepcion.Click += new System.EventHandler(this.simpleButtonConfirmarRecepcion_Click);
			// 
			// textEditDescripcionReferencia
			// 
			this.textEditDescripcionReferencia.Location = new System.Drawing.Point(162, 24);
			this.textEditDescripcionReferencia.Name = "textEditDescripcionReferencia";
			this.textEditDescripcionReferencia.Size = new System.Drawing.Size(116, 20);
			this.textEditDescripcionReferencia.TabIndex = 23;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(55, 22);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(73, 19);
			this.labelControl7.TabIndex = 24;
			this.labelControl7.Text = "Producto";
			// 
			// spinEditCantidadBuena
			// 
			this.spinEditCantidadBuena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.spinEditCantidadBuena.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditCantidadBuena.Location = new System.Drawing.Point(80, 81);
			this.spinEditCantidadBuena.Name = "spinEditCantidadBuena";
			this.spinEditCantidadBuena.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditCantidadBuena.Properties.MaskSettings.Set("mask", "d");
			this.spinEditCantidadBuena.Size = new System.Drawing.Size(48, 20);
			this.spinEditCantidadBuena.TabIndex = 25;
			this.spinEditCantidadBuena.EditValueChanged += new System.EventHandler(this.spinEditCantidadBuena_EditValueChanged);
			// 
			// spinEditCantidadMala
			// 
			this.spinEditCantidadMala.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.spinEditCantidadMala.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditCantidadMala.Location = new System.Drawing.Point(200, 81);
			this.spinEditCantidadMala.Name = "spinEditCantidadMala";
			this.spinEditCantidadMala.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditCantidadMala.Properties.MaskSettings.Set("mask", "d");
			this.spinEditCantidadMala.Size = new System.Drawing.Size(48, 20);
			this.spinEditCantidadMala.TabIndex = 26;
			this.spinEditCantidadMala.EditValueChanged += new System.EventHandler(this.spinEditCantidadMala_EditValueChanged);
			// 
			// labelControl6
			// 
			this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(55, 56);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(101, 19);
			this.labelControl6.TabIndex = 27;
			this.labelControl6.Text = "Buen estado";
			// 
			// labelControl8
			// 
			this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(183, 56);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(89, 19);
			this.labelControl8.TabIndex = 28;
			this.labelControl8.Text = "Mal estado";
			// 
			// simpleButtonConfirmarLinea
			// 
			this.simpleButtonConfirmarLinea.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonConfirmarLinea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonConfirmarLinea.ImageOptions.Image")));
			this.simpleButtonConfirmarLinea.Location = new System.Drawing.Point(1678, 345);
			this.simpleButtonConfirmarLinea.Name = "simpleButtonConfirmarLinea";
			this.simpleButtonConfirmarLinea.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonConfirmarLinea.Size = new System.Drawing.Size(63, 60);
			this.simpleButtonConfirmarLinea.TabIndex = 29;
			this.simpleButtonConfirmarLinea.Click += new System.EventHandler(this.simpleButtonConfirmarLinea_Click);
			// 
			// checkButtonAniadirReferencia
			// 
			this.checkButtonAniadirReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkButtonAniadirReferencia.Appearance.BackColor = System.Drawing.Color.White;
			this.checkButtonAniadirReferencia.Appearance.BackColor2 = System.Drawing.Color.Transparent;
			this.checkButtonAniadirReferencia.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkButtonAniadirReferencia.Appearance.Options.UseBackColor = true;
			this.checkButtonAniadirReferencia.Appearance.Options.UseFont = true;
			this.checkButtonAniadirReferencia.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonAniadirReferencia.AppearanceDisabled.Options.UseBackColor = true;
			this.checkButtonAniadirReferencia.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonAniadirReferencia.AppearanceHovered.Options.UseBackColor = true;
			this.checkButtonAniadirReferencia.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonAniadirReferencia.AppearancePressed.BorderColor = System.Drawing.Color.Black;
			this.checkButtonAniadirReferencia.AppearancePressed.Options.UseBackColor = true;
			this.checkButtonAniadirReferencia.AppearancePressed.Options.UseBorderColor = true;
			this.checkButtonAniadirReferencia.Location = new System.Drawing.Point(1429, 476);
			this.checkButtonAniadirReferencia.Name = "checkButtonAniadirReferencia";
			this.checkButtonAniadirReferencia.Size = new System.Drawing.Size(125, 40);
			this.checkButtonAniadirReferencia.TabIndex = 30;
			this.checkButtonAniadirReferencia.Text = "Referencia\r\ndesconocida";
			this.checkButtonAniadirReferencia.CheckedChanged += new System.EventHandler(this.checkButtonAniadirReferencia_CheckedChanged);
			// 
			// textEditPrecio
			// 
			this.textEditPrecio.Location = new System.Drawing.Point(162, 50);
			this.textEditPrecio.Name = "textEditPrecio";
			this.textEditPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEditPrecio.Properties.MaskSettings.Set("mask", "c");
			this.textEditPrecio.Size = new System.Drawing.Size(116, 20);
			this.textEditPrecio.TabIndex = 80;
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl9.Appearance.Options.UseFont = true;
			this.labelControl9.Location = new System.Drawing.Point(55, 48);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(51, 19);
			this.labelControl9.TabIndex = 81;
			this.labelControl9.Text = "Precio";
			// 
			// labelControl5
			// 
			this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Appearance.Options.UseForeColor = true;
			this.labelControl5.Location = new System.Drawing.Point(186, 15);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(386, 41);
			this.labelControl5.TabIndex = 97;
			this.labelControl5.Text = "CONFIRMACIÓN DE AVISOS";
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.panel1.Controls.Add(this.textEditNombreEmpresa);
			this.panel1.Controls.Add(this.labelControl2);
			this.panel1.Controls.Add(this.textEditFechaLlegada);
			this.panel1.Controls.Add(this.textEditFechaCreacionAviso);
			this.panel1.Controls.Add(this.labelControl3);
			this.panel1.Controls.Add(this.labelControl4);
			this.panel1.Location = new System.Drawing.Point(153, 336);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(318, 213);
			this.panel1.TabIndex = 98;
			// 
			// textEditNombreEmpresa
			// 
			this.textEditNombreEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEditNombreEmpresa.Appearance.Options.UseFont = true;
			this.textEditNombreEmpresa.Location = new System.Drawing.Point(186, 53);
			this.textEditNombreEmpresa.Name = "textEditNombreEmpresa";
			this.textEditNombreEmpresa.Size = new System.Drawing.Size(0, 16);
			this.textEditNombreEmpresa.TabIndex = 19;
			// 
			// labelControl10
			// 
			this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl10.Appearance.Options.UseFont = true;
			this.labelControl10.Appearance.Options.UseForeColor = true;
			this.labelControl10.Location = new System.Drawing.Point(268, 218);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(101, 30);
			this.labelControl10.TabIndex = 99;
			this.labelControl10.Text = "ALBARAN";
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.panel2.Controls.Add(this.labelControl1);
			this.panel2.Controls.Add(this.spinEditCantidadBuena);
			this.panel2.Controls.Add(this.spinEditCantidadMala);
			this.panel2.Controls.Add(this.labelControl6);
			this.panel2.Controls.Add(this.labelControl8);
			this.panel2.Location = new System.Drawing.Point(1324, 312);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(335, 126);
			this.panel2.TabIndex = 100;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(90, 19);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(169, 19);
			this.labelControl1.TabIndex = 30;
			this.labelControl1.Text = "Cantidades recibidas";
			// 
			// panel3
			// 
			this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.panel3.Controls.Add(this.textEditDescripcionReferencia);
			this.panel3.Controls.Add(this.labelControl7);
			this.panel3.Controls.Add(this.textEditPrecio);
			this.panel3.Controls.Add(this.labelControl9);
			this.panel3.Location = new System.Drawing.Point(1324, 530);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(335, 90);
			this.panel3.TabIndex = 101;
			// 
			// checkButtonExcedenteFalta
			// 
			this.checkButtonExcedenteFalta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkButtonExcedenteFalta.Appearance.BackColor = System.Drawing.Color.White;
			this.checkButtonExcedenteFalta.Appearance.BackColor2 = System.Drawing.Color.Transparent;
			this.checkButtonExcedenteFalta.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkButtonExcedenteFalta.Appearance.Options.UseBackColor = true;
			this.checkButtonExcedenteFalta.Appearance.Options.UseFont = true;
			this.checkButtonExcedenteFalta.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonExcedenteFalta.AppearanceDisabled.Options.UseBackColor = true;
			this.checkButtonExcedenteFalta.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonExcedenteFalta.AppearanceHovered.Options.UseBackColor = true;
			this.checkButtonExcedenteFalta.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkButtonExcedenteFalta.AppearancePressed.BorderColor = System.Drawing.Color.Black;
			this.checkButtonExcedenteFalta.AppearancePressed.Options.UseBackColor = true;
			this.checkButtonExcedenteFalta.AppearancePressed.Options.UseBorderColor = true;
			this.checkButtonExcedenteFalta.Location = new System.Drawing.Point(1429, 666);
			this.checkButtonExcedenteFalta.Name = "checkButtonExcedenteFalta";
			this.checkButtonExcedenteFalta.Size = new System.Drawing.Size(125, 40);
			this.checkButtonExcedenteFalta.TabIndex = 102;
			this.checkButtonExcedenteFalta.Text = "EXCEDENTE/FALTA";
			this.checkButtonExcedenteFalta.CheckedChanged += new System.EventHandler(this.checkButtonExcedenteFalta_CheckedChanged);
			// 
			// panel4
			// 
			this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.panel4.Controls.Add(this.spinEditFalta);
			this.panel4.Controls.Add(this.spinEditExcedente);
			this.panel4.Controls.Add(this.labelControl11);
			this.panel4.Controls.Add(this.labelControl12);
			this.panel4.Location = new System.Drawing.Point(1324, 720);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(335, 90);
			this.panel4.TabIndex = 103;
			// 
			// spinEditFalta
			// 
			this.spinEditFalta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.spinEditFalta.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditFalta.Location = new System.Drawing.Point(200, 50);
			this.spinEditFalta.Name = "spinEditFalta";
			this.spinEditFalta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditFalta.Properties.MaskSettings.Set("mask", "d");
			this.spinEditFalta.Size = new System.Drawing.Size(48, 20);
			this.spinEditFalta.TabIndex = 82;
			this.spinEditFalta.EditValueChanged += new System.EventHandler(this.spinEditFalta_EditValueChanged);
			// 
			// spinEditExcedente
			// 
			this.spinEditExcedente.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.spinEditExcedente.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditExcedente.Location = new System.Drawing.Point(200, 24);
			this.spinEditExcedente.Name = "spinEditExcedente";
			this.spinEditExcedente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditExcedente.Properties.MaskSettings.Set("mask", "d");
			this.spinEditExcedente.Size = new System.Drawing.Size(48, 20);
			this.spinEditExcedente.TabIndex = 31;
			// 
			// labelControl11
			// 
			this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl11.Appearance.Options.UseFont = true;
			this.labelControl11.Location = new System.Drawing.Point(55, 22);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(85, 19);
			this.labelControl11.TabIndex = 24;
			this.labelControl11.Text = "Excedente";
			// 
			// labelControl12
			// 
			this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl12.Appearance.Options.UseFont = true;
			this.labelControl12.Location = new System.Drawing.Point(55, 48);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(41, 19);
			this.labelControl12.TabIndex = 81;
			this.labelControl12.Text = "Falta";
			// 
			// formRecepcionar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1819, 928);
			this.Controls.Add(this.checkButtonExcedenteFalta);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.checkButtonAniadirReferencia);
			this.Controls.Add(this.simpleButtonConfirmarLinea);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.simpleButtonConfirmarRecepcion);
			this.Controls.Add(this.simpleButtonBuscar);
			this.Controls.Add(this.textEditAlbaran);
			this.Controls.Add(this.gridControlAviso);
			this.Name = "formRecepcionar";
			this.Load += new System.EventHandler(this.formRecepcionar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlAviso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESLINBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewAviso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditAlbaran.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaLlegada.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaCreacionAviso.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDescripcionReferencia.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadBuena.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidadMala.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPrecio.Properties)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinEditFalta.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditExcedente.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlAviso;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewAviso;
		private DevExpress.XtraEditors.TextEdit textEditAlbaran;
		private DevExpress.XtraEditors.SimpleButton simpleButtonBuscar;
		private DevExpress.XtraEditors.TextEdit textEditFechaLlegada;
		private DevExpress.XtraEditors.TextEdit textEditFechaCreacionAviso;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmarRecepcion;
		private DevExpress.XtraEditors.TextEdit textEditDescripcionReferencia;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.SpinEdit spinEditCantidadBuena;
		private DevExpress.XtraEditors.SpinEdit spinEditCantidadMala;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmarLinea;
		private DevExpress.XtraEditors.CheckButton checkButtonAniadirReferencia;
		private DevExpress.XtraEditors.TextEdit textEditPrecio;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraGrid.Columns.GridColumn colALBARAN;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_LINEA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colPRECIO;
		private System.Windows.Forms.BindingSource vRECEPCIONESLINBindingSource;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl textEditNombreEmpresa;
		private DevExpress.XtraEditors.CheckButton checkButtonExcedenteFalta;
		private System.Windows.Forms.Panel panel4;
		private DevExpress.XtraEditors.SpinEdit spinEditFalta;
		private DevExpress.XtraEditors.SpinEdit spinEditExcedente;
		private DevExpress.XtraEditors.LabelControl labelControl11;
		private DevExpress.XtraEditors.LabelControl labelControl12;
	}
}