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
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
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
			this.SuspendLayout();
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(1072, 335);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(85, 13);
			this.labelControl2.TabIndex = 17;
			this.labelControl2.Text = "Cantidad a añadir";
			// 
			// gridControlPedidos
			// 
			this.gridControlPedidos.DataSource = this.lineaPedidoBindingSource;
			this.gridControlPedidos.Location = new System.Drawing.Point(1265, 211);
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
			this.gridControlReferencias.DataSource = this.vISTAREFERENCIASBindingSource;
			this.gridControlReferencias.Location = new System.Drawing.Point(259, 211);
			this.gridControlReferencias.MainView = this.gridViewReferencias;
			this.gridControlReferencias.Name = "gridControlReferencias";
			this.gridControlReferencias.Size = new System.Drawing.Size(717, 466);
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
			this.simpleButtonQuitarLinea.Location = new System.Drawing.Point(1631, 698);
			this.simpleButtonQuitarLinea.Name = "simpleButtonQuitarLinea";
			this.simpleButtonQuitarLinea.Size = new System.Drawing.Size(142, 39);
			this.simpleButtonQuitarLinea.TabIndex = 14;
			this.simpleButtonQuitarLinea.Text = "Quitar línea seleccionada";
			this.simpleButtonQuitarLinea.Click += new System.EventHandler(this.simpleButtonQuitarLinea_Click);
			// 
			// spinEditCantidad
			// 
			this.spinEditCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditCantidad.Location = new System.Drawing.Point(1061, 354);
			this.spinEditCantidad.Name = "spinEditCantidad";
			this.spinEditCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditCantidad.Size = new System.Drawing.Size(114, 20);
			this.spinEditCantidad.TabIndex = 13;
			// 
			// simpleButtonAnadirLinea
			// 
			this.simpleButtonAnadirLinea.Location = new System.Drawing.Point(1061, 400);
			this.simpleButtonAnadirLinea.Name = "simpleButtonAnadirLinea";
			this.simpleButtonAnadirLinea.Size = new System.Drawing.Size(114, 39);
			this.simpleButtonAnadirLinea.TabIndex = 12;
			this.simpleButtonAnadirLinea.Text = "Añadir línea\r\n de pedido ->";
			this.simpleButtonAnadirLinea.Click += new System.EventHandler(this.simpleButtonAnadirLinea_Click);
			// 
			// simpleButtonGuardarPedido
			// 
			this.simpleButtonGuardarPedido.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.simpleButtonGuardarPedido.Appearance.Options.UseFont = true;
			this.simpleButtonGuardarPedido.Location = new System.Drawing.Point(1533, 89);
			this.simpleButtonGuardarPedido.Name = "simpleButtonGuardarPedido";
			this.simpleButtonGuardarPedido.Size = new System.Drawing.Size(231, 80);
			this.simpleButtonGuardarPedido.TabIndex = 18;
			this.simpleButtonGuardarPedido.Text = "GUARDAR EN\r\n NUEVO PEDIDO";
			this.simpleButtonGuardarPedido.Click += new System.EventHandler(this.simpleButtonGenerarPedido_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(259, 93);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(99, 13);
			this.labelControl1.TabIndex = 19;
			this.labelControl1.Text = "Dirección de entrega";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(744, 89);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(65, 13);
			this.labelControl3.TabIndex = 20;
			this.labelControl3.Text = "Código Postal";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(259, 156);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(45, 13);
			this.labelControl4.TabIndex = 21;
			this.labelControl4.Text = "Población";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(502, 156);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(43, 13);
			this.labelControl5.TabIndex = 22;
			this.labelControl5.Text = "Provincia";
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(744, 156);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(42, 13);
			this.labelControl6.TabIndex = 23;
			this.labelControl6.Text = "Teléfono";
			// 
			// textEditDireccion
			// 
			this.textEditDireccion.Location = new System.Drawing.Point(370, 90);
			this.textEditDireccion.Name = "textEditDireccion";
			this.textEditDireccion.Size = new System.Drawing.Size(318, 20);
			this.textEditDireccion.TabIndex = 1;
			// 
			// textEditProvincia
			// 
			this.textEditProvincia.Location = new System.Drawing.Point(588, 153);
			this.textEditProvincia.Name = "textEditProvincia";
			this.textEditProvincia.Size = new System.Drawing.Size(100, 20);
			this.textEditProvincia.TabIndex = 4;
			// 
			// textEditTelefono
			// 
			this.textEditTelefono.Location = new System.Drawing.Point(868, 153);
			this.textEditTelefono.Name = "textEditTelefono";
			this.textEditTelefono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
			this.textEditTelefono.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
			this.textEditTelefono.Properties.MaskSettings.Set("mask", "000000000");
			this.textEditTelefono.Size = new System.Drawing.Size(100, 20);
			this.textEditTelefono.TabIndex = 5;
			// 
			// textEditPoblacion
			// 
			this.textEditPoblacion.Location = new System.Drawing.Point(370, 153);
			this.textEditPoblacion.Name = "textEditPoblacion";
			this.textEditPoblacion.Size = new System.Drawing.Size(100, 20);
			this.textEditPoblacion.TabIndex = 3;
			// 
			// textEditCodigoPostal
			// 
			this.textEditCodigoPostal.Location = new System.Drawing.Point(868, 86);
			this.textEditCodigoPostal.Name = "textEditCodigoPostal";
			this.textEditCodigoPostal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
			this.textEditCodigoPostal.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d");
			this.textEditCodigoPostal.Size = new System.Drawing.Size(100, 20);
			this.textEditCodigoPostal.TabIndex = 2;
			// 
			// listBoxControlPedidos
			// 
			this.listBoxControlPedidos.Location = new System.Drawing.Point(259, 718);
			this.listBoxControlPedidos.Name = "listBoxControlPedidos";
			this.listBoxControlPedidos.Size = new System.Drawing.Size(188, 130);
			this.listBoxControlPedidos.TabIndex = 29;
			this.listBoxControlPedidos.SelectedIndexChanged += new System.EventHandler(this.listBoxControlPedidos_SelectedIndexChanged);
			// 
			// simpleButtonModificarPedido
			// 
			this.simpleButtonModificarPedido.Location = new System.Drawing.Point(453, 764);
			this.simpleButtonModificarPedido.Name = "simpleButtonModificarPedido";
			this.simpleButtonModificarPedido.Size = new System.Drawing.Size(102, 39);
			this.simpleButtonModificarPedido.TabIndex = 30;
			this.simpleButtonModificarPedido.Text = "Modificar selección";
			this.simpleButtonModificarPedido.Click += new System.EventHandler(this.simpleButtonModificarPedido_Click);
			// 
			// simpleButtonEliminarPedido
			// 
			this.simpleButtonEliminarPedido.Location = new System.Drawing.Point(453, 809);
			this.simpleButtonEliminarPedido.Name = "simpleButtonEliminarPedido";
			this.simpleButtonEliminarPedido.Size = new System.Drawing.Size(102, 39);
			this.simpleButtonEliminarPedido.TabIndex = 31;
			this.simpleButtonEliminarPedido.Text = "Eliminar selección";
			this.simpleButtonEliminarPedido.Click += new System.EventHandler(this.simpleButtonEliminarPedido_Click);
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(259, 699);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(95, 13);
			this.labelControl7.TabIndex = 32;
			this.labelControl7.Text = "Pedidos guardados:";
			// 
			// simpleButtonTraspaso
			// 
			this.simpleButtonTraspaso.Location = new System.Drawing.Point(453, 718);
			this.simpleButtonTraspaso.Name = "simpleButtonTraspaso";
			this.simpleButtonTraspaso.Size = new System.Drawing.Size(102, 39);
			this.simpleButtonTraspaso.TabIndex = 33;
			this.simpleButtonTraspaso.Text = "TRASPASAR A ICP";
			this.simpleButtonTraspaso.Click += new System.EventHandler(this.simpleButtonTraspaso_Click);
			// 
			// formPedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1829, 831);
			this.Controls.Add(this.simpleButtonTraspaso);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.simpleButtonEliminarPedido);
			this.Controls.Add(this.simpleButtonModificarPedido);
			this.Controls.Add(this.listBoxControlPedidos);
			this.Controls.Add(this.textEditCodigoPostal);
			this.Controls.Add(this.textEditPoblacion);
			this.Controls.Add(this.textEditTelefono);
			this.Controls.Add(this.textEditProvincia);
			this.Controls.Add(this.textEditDireccion);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.simpleButtonGuardarPedido);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.gridControlPedidos);
			this.Controls.Add(this.gridControlReferencias);
			this.Controls.Add(this.simpleButtonQuitarLinea);
			this.Controls.Add(this.spinEditCantidad);
			this.Controls.Add(this.simpleButtonAnadirLinea);
			this.Name = "formPedidos";
			this.Text = "Pedidos";
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl2;
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
	}
}