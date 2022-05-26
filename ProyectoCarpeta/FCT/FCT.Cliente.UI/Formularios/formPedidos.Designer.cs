namespace FCT.Cliente.UI.Formularios
{
	partial class formPedidos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPedidos));
			this.gridControlPedidos = new DevExpress.XtraGrid.GridControl();
			this.lineaPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colalbaran = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcod_linea = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcod_referencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldescripcion_referencia = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridControlReferencias = new DevExpress.XtraGrid.GridControl();
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
			this.simpleButtonQuitarLinea = new DevExpress.XtraEditors.SimpleButton();
			this.spinEditCantidad = new DevExpress.XtraEditors.SpinEdit();
			this.simpleButtonAnadirLinea = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonGuardarPedido = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.textEditDireccion = new DevExpress.XtraEditors.TextEdit();
			this.textEditProvincia = new DevExpress.XtraEditors.TextEdit();
			this.textEditTelefono = new DevExpress.XtraEditors.TextEdit();
			this.textEditPoblacion = new DevExpress.XtraEditors.TextEdit();
			this.textEditCodigoPostal = new DevExpress.XtraEditors.TextEdit();
			this.listBoxControlPedidos = new DevExpress.XtraEditors.ListBoxControl();
			this.simpleButtonModificarPedido = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonEliminarPedido = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButtonTraspaso = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lineaPedidoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewReferencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDireccion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditProvincia.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditTelefono.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPoblacion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditCodigoPostal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.listBoxControlPedidos)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridControlPedidos
			// 
			this.gridControlPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlPedidos.DataSource = this.lineaPedidoBindingSource;
			this.gridControlPedidos.Location = new System.Drawing.Point(1124, 270);
			this.gridControlPedidos.MainView = this.gridViewPedidos;
			this.gridControlPedidos.Name = "gridControlPedidos";
			this.gridControlPedidos.Size = new System.Drawing.Size(508, 466);
			this.gridControlPedidos.TabIndex = 16;
			this.gridControlPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidos});
			// 
			// lineaPedidoBindingSource
			// 
			this.lineaPedidoBindingSource.DataSource = typeof(FCT.Negocio.LineaPedido);
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
            this.colalbaran,
            this.colcod_linea,
            this.colcod_referencia1,
            this.colcantidad,
            this.coldescripcion_referencia});
			this.gridViewPedidos.GridControl = this.gridControlPedidos;
			this.gridViewPedidos.Name = "gridViewPedidos";
			this.gridViewPedidos.OptionsBehavior.Editable = false;
			this.gridViewPedidos.OptionsBehavior.ReadOnly = true;
			this.gridViewPedidos.OptionsCustomization.AllowColumnMoving = false;
			this.gridViewPedidos.OptionsCustomization.AllowGroup = false;
			this.gridViewPedidos.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewPedidos_SelectionChanged);
			// 
			// colalbaran
			// 
			this.colalbaran.FieldName = "albaran";
			this.colalbaran.Name = "colalbaran";
			// 
			// colcod_linea
			// 
			this.colcod_linea.FieldName = "cod_linea";
			this.colcod_linea.Name = "colcod_linea";
			// 
			// colcod_referencia1
			// 
			this.colcod_referencia1.FieldName = "cod_referencia";
			this.colcod_referencia1.Name = "colcod_referencia1";
			// 
			// colcantidad
			// 
			this.colcantidad.Caption = "Cantidad";
			this.colcantidad.FieldName = "cantidad";
			this.colcantidad.Name = "colcantidad";
			this.colcantidad.Visible = true;
			this.colcantidad.VisibleIndex = 1;
			this.colcantidad.Width = 140;
			// 
			// coldescripcion_referencia
			// 
			this.coldescripcion_referencia.Caption = "Descripción de la referencia";
			this.coldescripcion_referencia.FieldName = "descripcion_referencia";
			this.coldescripcion_referencia.Name = "coldescripcion_referencia";
			this.coldescripcion_referencia.Visible = true;
			this.coldescripcion_referencia.VisibleIndex = 0;
			this.coldescripcion_referencia.Width = 473;
			// 
			// gridControlReferencias
			// 
			this.gridControlReferencias.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlReferencias.DataSource = this.vISTAREFERENCIASBindingSource;
			this.gridControlReferencias.Location = new System.Drawing.Point(135, 270);
			this.gridControlReferencias.MainView = this.gridViewReferencias;
			this.gridControlReferencias.Name = "gridControlReferencias";
			this.gridControlReferencias.Size = new System.Drawing.Size(744, 466);
			this.gridControlReferencias.TabIndex = 15;
			this.gridControlReferencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReferencias});
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
			this.colDES_REFERENCIA.Caption = "Descripción de la referencia";
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
			// simpleButtonQuitarLinea
			// 
			this.simpleButtonQuitarLinea.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonQuitarLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonQuitarLinea.Enabled = false;
			this.simpleButtonQuitarLinea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonQuitarLinea.ImageOptions.Image")));
			this.simpleButtonQuitarLinea.Location = new System.Drawing.Point(1648, 460);
			this.simpleButtonQuitarLinea.Name = "simpleButtonQuitarLinea";
			this.simpleButtonQuitarLinea.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonQuitarLinea.Size = new System.Drawing.Size(54, 58);
			this.simpleButtonQuitarLinea.TabIndex = 14;
			this.simpleButtonQuitarLinea.ToolTip = "Elimina la línea seleccionada";
			this.simpleButtonQuitarLinea.Click += new System.EventHandler(this.simpleButtonQuitarLinea_Click);
			// 
			// spinEditCantidad
			// 
			this.spinEditCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.spinEditCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditCantidad.Location = new System.Drawing.Point(945, 447);
			this.spinEditCantidad.Name = "spinEditCantidad";
			this.spinEditCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditCantidad.Properties.IsFloatValue = false;
			this.spinEditCantidad.Properties.MaskSettings.Set("mask", "d");
			this.spinEditCantidad.Properties.MaxLength = 4;
			this.spinEditCantidad.Size = new System.Drawing.Size(108, 20);
			this.spinEditCantidad.TabIndex = 13;
			// 
			// simpleButtonAnadirLinea
			// 
			this.simpleButtonAnadirLinea.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonAnadirLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonAnadirLinea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnadirLinea.ImageOptions.Image")));
			this.simpleButtonAnadirLinea.Location = new System.Drawing.Point(945, 473);
			this.simpleButtonAnadirLinea.Name = "simpleButtonAnadirLinea";
			this.simpleButtonAnadirLinea.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonAnadirLinea.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.simpleButtonAnadirLinea.Size = new System.Drawing.Size(108, 45);
			this.simpleButtonAnadirLinea.TabIndex = 12;
			this.simpleButtonAnadirLinea.ToolTip = "Añade la referencia\r\nseleccionada al pedido";
			this.simpleButtonAnadirLinea.Click += new System.EventHandler(this.simpleButtonAnadirLinea_Click);
			// 
			// simpleButtonGuardarPedido
			// 
			this.simpleButtonGuardarPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonGuardarPedido.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.simpleButtonGuardarPedido.Appearance.Options.UseFont = true;
			this.simpleButtonGuardarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonGuardarPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardarPedido.ImageOptions.Image")));
			this.simpleButtonGuardarPedido.Location = new System.Drawing.Point(1525, 162);
			this.simpleButtonGuardarPedido.Name = "simpleButtonGuardarPedido";
			this.simpleButtonGuardarPedido.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonGuardarPedido.Size = new System.Drawing.Size(107, 84);
			this.simpleButtonGuardarPedido.TabIndex = 18;
			this.simpleButtonGuardarPedido.ToolTip = "Guardar como nuevo\r\npedido en la lista";
			this.simpleButtonGuardarPedido.Click += new System.EventHandler(this.simpleButtonGenerarPedido_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(21, 26);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(126, 14);
			this.labelControl1.TabIndex = 19;
			this.labelControl1.Text = "Dirección de entrega";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(498, 26);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(85, 14);
			this.labelControl3.TabIndex = 20;
			this.labelControl3.Text = "Código Postal";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(34, 89);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(59, 14);
			this.labelControl4.TabIndex = 21;
			this.labelControl4.Text = "Población";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(310, 89);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(55, 14);
			this.labelControl5.TabIndex = 22;
			this.labelControl5.Text = "Provincia";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(530, 88);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(53, 14);
			this.labelControl6.TabIndex = 23;
			this.labelControl6.Text = "Teléfono";
			// 
			// textEditDireccion
			// 
			this.textEditDireccion.Location = new System.Drawing.Point(153, 23);
			this.textEditDireccion.Name = "textEditDireccion";
			this.textEditDireccion.Properties.MaxLength = 200;
			this.textEditDireccion.Size = new System.Drawing.Size(318, 20);
			this.textEditDireccion.TabIndex = 1;
			// 
			// textEditProvincia
			// 
			this.textEditProvincia.Location = new System.Drawing.Point(371, 86);
			this.textEditProvincia.Name = "textEditProvincia";
			this.textEditProvincia.Properties.MaxLength = 80;
			this.textEditProvincia.Size = new System.Drawing.Size(100, 20);
			this.textEditProvincia.TabIndex = 4;
			// 
			// textEditTelefono
			// 
			this.textEditTelefono.Location = new System.Drawing.Point(589, 86);
			this.textEditTelefono.Name = "textEditTelefono";
			this.textEditTelefono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
			this.textEditTelefono.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
			this.textEditTelefono.Properties.MaskSettings.Set("mask", "000000000");
			this.textEditTelefono.Size = new System.Drawing.Size(100, 20);
			this.textEditTelefono.TabIndex = 5;
			// 
			// textEditPoblacion
			// 
			this.textEditPoblacion.Location = new System.Drawing.Point(99, 86);
			this.textEditPoblacion.Name = "textEditPoblacion";
			this.textEditPoblacion.Properties.MaxLength = 80;
			this.textEditPoblacion.Size = new System.Drawing.Size(100, 20);
			this.textEditPoblacion.TabIndex = 3;
			// 
			// textEditCodigoPostal
			// 
			this.textEditCodigoPostal.Location = new System.Drawing.Point(589, 23);
			this.textEditCodigoPostal.Name = "textEditCodigoPostal";
			this.textEditCodigoPostal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
			this.textEditCodigoPostal.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d");
			this.textEditCodigoPostal.Size = new System.Drawing.Size(100, 20);
			this.textEditCodigoPostal.TabIndex = 2;
			// 
			// listBoxControlPedidos
			// 
			this.listBoxControlPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listBoxControlPedidos.Location = new System.Drawing.Point(374, 809);
			this.listBoxControlPedidos.Name = "listBoxControlPedidos";
			this.listBoxControlPedidos.Size = new System.Drawing.Size(188, 130);
			this.listBoxControlPedidos.TabIndex = 29;
			this.listBoxControlPedidos.SelectedIndexChanged += new System.EventHandler(this.listBoxControlPedidos_SelectedIndexChanged);
			// 
			// simpleButtonModificarPedido
			// 
			this.simpleButtonModificarPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonModificarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonModificarPedido.Enabled = false;
			this.simpleButtonModificarPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonModificarPedido.ImageOptions.Image")));
			this.simpleButtonModificarPedido.Location = new System.Drawing.Point(1439, 192);
			this.simpleButtonModificarPedido.Name = "simpleButtonModificarPedido";
			this.simpleButtonModificarPedido.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonModificarPedido.Size = new System.Drawing.Size(56, 54);
			this.simpleButtonModificarPedido.TabIndex = 30;
			this.simpleButtonModificarPedido.ToolTip = "Modifica el pedido seleccionado\r\ncon los datos de la cabecera escritos\r\ny las lín" +
    "eas de la tabla";
			this.simpleButtonModificarPedido.Click += new System.EventHandler(this.simpleButtonModificarPedido_Click);
			// 
			// simpleButtonEliminarPedido
			// 
			this.simpleButtonEliminarPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonEliminarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonEliminarPedido.Enabled = false;
			this.simpleButtonEliminarPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonEliminarPedido.ImageOptions.Image")));
			this.simpleButtonEliminarPedido.Location = new System.Drawing.Point(312, 852);
			this.simpleButtonEliminarPedido.Name = "simpleButtonEliminarPedido";
			this.simpleButtonEliminarPedido.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonEliminarPedido.Size = new System.Drawing.Size(56, 50);
			this.simpleButtonEliminarPedido.TabIndex = 31;
			this.simpleButtonEliminarPedido.ToolTip = "Elimina el pedido seleccionado";
			this.simpleButtonEliminarPedido.Click += new System.EventHandler(this.simpleButtonEliminarPedido_Click);
			// 
			// labelControl7
			// 
			this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Appearance.Options.UseForeColor = true;
			this.labelControl7.Location = new System.Drawing.Point(374, 782);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(163, 21);
			this.labelControl7.TabIndex = 32;
			this.labelControl7.Text = "Pedidos guardados";
			// 
			// simpleButtonTraspaso
			// 
			this.simpleButtonTraspaso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonTraspaso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonTraspaso.Enabled = false;
			this.simpleButtonTraspaso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonTraspaso.ImageOptions.Image")));
			this.simpleButtonTraspaso.Location = new System.Drawing.Point(582, 835);
			this.simpleButtonTraspaso.Name = "simpleButtonTraspaso";
			this.simpleButtonTraspaso.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonTraspaso.Size = new System.Drawing.Size(106, 84);
			this.simpleButtonTraspaso.TabIndex = 33;
			this.simpleButtonTraspaso.ToolTip = "Traspasa el pedido seleccionado a ICP";
			this.simpleButtonTraspaso.Click += new System.EventHandler(this.simpleButtonTraspaso_Click);
			// 
			// simpleButtonActualizar
			// 
			this.simpleButtonActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.ImageOptions.Image")));
			this.simpleButtonActualizar.Location = new System.Drawing.Point(64, 431);
			this.simpleButtonActualizar.Name = "simpleButtonActualizar";
			this.simpleButtonActualizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonActualizar.Size = new System.Drawing.Size(55, 52);
			this.simpleButtonActualizar.TabIndex = 34;
			this.simpleButtonActualizar.ToolTip = "Actualizar";
			this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.panel1.Controls.Add(this.textEditTelefono);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Controls.Add(this.labelControl3);
			this.panel1.Controls.Add(this.labelControl4);
			this.panel1.Controls.Add(this.labelControl5);
			this.panel1.Controls.Add(this.labelControl6);
			this.panel1.Controls.Add(this.textEditDireccion);
			this.panel1.Controls.Add(this.textEditCodigoPostal);
			this.panel1.Controls.Add(this.textEditProvincia);
			this.panel1.Controls.Add(this.textEditPoblacion);
			this.panel1.Location = new System.Drawing.Point(135, 115);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(744, 123);
			this.panel1.TabIndex = 35;
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(135, 49);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(119, 41);
			this.labelControl2.TabIndex = 96;
			this.labelControl2.Text = "PEDIDOS";
			// 
			// formPedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1829, 963);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.simpleButtonActualizar);
			this.Controls.Add(this.simpleButtonTraspaso);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.simpleButtonEliminarPedido);
			this.Controls.Add(this.simpleButtonModificarPedido);
			this.Controls.Add(this.listBoxControlPedidos);
			this.Controls.Add(this.simpleButtonGuardarPedido);
			this.Controls.Add(this.gridControlPedidos);
			this.Controls.Add(this.gridControlReferencias);
			this.Controls.Add(this.simpleButtonQuitarLinea);
			this.Controls.Add(this.spinEditCantidad);
			this.Controls.Add(this.simpleButtonAnadirLinea);
			this.Name = "formPedidos";
			this.Load += new System.EventHandler(this.formPedidos_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lineaPedidoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewReferencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDireccion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditProvincia.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditTelefono.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPoblacion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditCodigoPostal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.listBoxControlPedidos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraGrid.GridControl gridControlPedidos;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidos;
		private DevExpress.XtraGrid.Columns.GridColumn colalbaran;
		private DevExpress.XtraGrid.Columns.GridColumn colcod_linea;
		private DevExpress.XtraGrid.Columns.GridColumn colcod_referencia1;
		private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
		private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_referencia;
		private DevExpress.XtraGrid.GridControl gridControlReferencias;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewReferencias;
		private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colPRECIO;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_CREACION;
		private DevExpress.XtraGrid.Columns.GridColumn colIMAGEN;
		private DevExpress.XtraGrid.Columns.GridColumn colESTADO;
		private DevExpress.XtraGrid.Columns.GridColumn colSTOCK;
		private DevExpress.XtraEditors.SimpleButton simpleButtonQuitarLinea;
		private DevExpress.XtraEditors.SpinEdit spinEditCantidad;
		private DevExpress.XtraEditors.SimpleButton simpleButtonAnadirLinea;
		private DevExpress.XtraEditors.SimpleButton simpleButtonGuardarPedido;
		private System.Windows.Forms.BindingSource vISTAREFERENCIASBindingSource;
		private System.Windows.Forms.BindingSource lineaPedidoBindingSource;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.TextEdit textEditDireccion;
		private DevExpress.XtraEditors.TextEdit textEditProvincia;
		private DevExpress.XtraEditors.TextEdit textEditTelefono;
		private DevExpress.XtraEditors.TextEdit textEditPoblacion;
		private DevExpress.XtraEditors.TextEdit textEditCodigoPostal;
		private DevExpress.XtraEditors.ListBoxControl listBoxControlPedidos;
		private DevExpress.XtraEditors.SimpleButton simpleButtonModificarPedido;
		private DevExpress.XtraEditors.SimpleButton simpleButtonEliminarPedido;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.SimpleButton simpleButtonTraspaso;
		private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
	}
}