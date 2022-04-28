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
			this.lineaAvisoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewRecepciones1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colalbaran = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcod_linea = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcod_referencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldescripcion_referencia = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridViewRecepciones = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.textEditFechaLlegada = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewReferencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lineaAvisoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecepciones1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecepciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaLlegada.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButtonAnadirLinea
			// 
			this.simpleButtonAnadirLinea.Location = new System.Drawing.Point(946, 386);
			this.simpleButtonAnadirLinea.Name = "simpleButtonAnadirLinea";
			this.simpleButtonAnadirLinea.Size = new System.Drawing.Size(114, 39);
			this.simpleButtonAnadirLinea.TabIndex = 2;
			this.simpleButtonAnadirLinea.Text = "Añadir línea\r\n de aviso ->";
			this.simpleButtonAnadirLinea.Click += new System.EventHandler(this.simpleButtonAnadirLinea_Click);
			// 
			// spinEditCantidad
			// 
			this.spinEditCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEditCantidad.Location = new System.Drawing.Point(946, 340);
			this.spinEditCantidad.Name = "spinEditCantidad";
			this.spinEditCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEditCantidad.Size = new System.Drawing.Size(114, 20);
			this.spinEditCantidad.TabIndex = 3;
			// 
			// simpleButtonQuitarLinea
			// 
			this.simpleButtonQuitarLinea.Location = new System.Drawing.Point(1370, 685);
			this.simpleButtonQuitarLinea.Name = "simpleButtonQuitarLinea";
			this.simpleButtonQuitarLinea.Size = new System.Drawing.Size(142, 39);
			this.simpleButtonQuitarLinea.TabIndex = 4;
			this.simpleButtonQuitarLinea.Text = "Quitar línea seleccionada";
			this.simpleButtonQuitarLinea.Click += new System.EventHandler(this.simpleButtonQuitarLinea_Click);
			// 
			// simpleButtonGenerarAviso
			// 
			this.simpleButtonGenerarAviso.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.simpleButtonGenerarAviso.Appearance.Options.UseFont = true;
			this.simpleButtonGenerarAviso.Location = new System.Drawing.Point(1486, 60);
			this.simpleButtonGenerarAviso.Name = "simpleButtonGenerarAviso";
			this.simpleButtonGenerarAviso.Size = new System.Drawing.Size(231, 80);
			this.simpleButtonGenerarAviso.TabIndex = 5;
			this.simpleButtonGenerarAviso.Text = "GENERAR AVISO";
			this.simpleButtonGenerarAviso.Click += new System.EventHandler(this.simpleButtonGenerarAviso_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(896, 93);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(85, 13);
			this.labelControl1.TabIndex = 7;
			this.labelControl1.Text = "Fecha de llegada:";
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
			// gridControlReferencias
			// 
			this.gridControlReferencias.DataSource = this.vISTAREFERENCIASBindingSource;
			this.gridControlReferencias.Location = new System.Drawing.Point(236, 201);
			this.gridControlReferencias.MainView = this.gridViewReferencias;
			this.gridControlReferencias.Name = "gridControlReferencias";
			this.gridControlReferencias.Size = new System.Drawing.Size(666, 466);
			this.gridControlReferencias.TabIndex = 9;
			this.gridControlReferencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReferencias});
			// 
			// gridControlPedidos
			// 
			this.gridControlPedidos.DataSource = this.lineaAvisoBindingSource;
			this.gridControlPedidos.Location = new System.Drawing.Point(1112, 201);
			this.gridControlPedidos.MainView = this.gridViewRecepciones1;
			this.gridControlPedidos.Name = "gridControlPedidos";
			this.gridControlPedidos.Size = new System.Drawing.Size(638, 466);
			this.gridControlPedidos.TabIndex = 10;
			this.gridControlPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecepciones1,
            this.gridViewRecepciones});
			// 
			// lineaAvisoBindingSource
			// 
			this.lineaAvisoBindingSource.DataSource = typeof(FCT.Negocio.LineaAviso);
			// 
			// gridViewRecepciones1
			// 
			this.gridViewRecepciones1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colalbaran,
            this.colcod_linea,
            this.colcod_referencia1,
            this.colcantidad,
            this.coldescripcion_referencia});
			this.gridViewRecepciones1.GridControl = this.gridControlPedidos;
			this.gridViewRecepciones1.Name = "gridViewRecepciones1";
			this.gridViewRecepciones1.OptionsBehavior.Editable = false;
			this.gridViewRecepciones1.OptionsBehavior.ReadOnly = true;
			this.gridViewRecepciones1.OptionsCustomization.AllowGroup = false;
			this.gridViewRecepciones1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewRecepciones1_SelectionChanged);
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
			this.colcantidad.Width = 143;
			// 
			// coldescripcion_referencia
			// 
			this.coldescripcion_referencia.Caption = "Descripción de la referencia";
			this.coldescripcion_referencia.FieldName = "descripcion_referencia";
			this.coldescripcion_referencia.Name = "coldescripcion_referencia";
			this.coldescripcion_referencia.Visible = true;
			this.coldescripcion_referencia.VisibleIndex = 0;
			this.coldescripcion_referencia.Width = 470;
			// 
			// gridViewRecepciones
			// 
			this.gridViewRecepciones.GridControl = this.gridControlPedidos;
			this.gridViewRecepciones.Name = "gridViewRecepciones";
			this.gridViewRecepciones.OptionsBehavior.Editable = false;
			this.gridViewRecepciones.OptionsBehavior.ReadOnly = true;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(957, 321);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(85, 13);
			this.labelControl2.TabIndex = 11;
			this.labelControl2.Text = "Cantidad a añadir";
			// 
			// textEditFechaLlegada
			// 
			this.textEditFechaLlegada.Location = new System.Drawing.Point(1001, 90);
			this.textEditFechaLlegada.Name = "textEditFechaLlegada";
			this.textEditFechaLlegada.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
			this.textEditFechaLlegada.Properties.MaskSettings.Set("mask", "d");
			this.textEditFechaLlegada.Properties.MaskSettings.Set("useAdvancingCaret", true);
			this.textEditFechaLlegada.Properties.UseMaskAsDisplayFormat = true;
			this.textEditFechaLlegada.Size = new System.Drawing.Size(111, 20);
			this.textEditFechaLlegada.TabIndex = 12;
			// 
			// formRecepciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1790, 902);
			this.Controls.Add(this.textEditFechaLlegada);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.gridControlPedidos);
			this.Controls.Add(this.gridControlReferencias);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.simpleButtonGenerarAviso);
			this.Controls.Add(this.simpleButtonQuitarLinea);
			this.Controls.Add(this.spinEditCantidad);
			this.Controls.Add(this.simpleButtonAnadirLinea);
			this.Name = "formRecepciones";
			this.Text = "Recepciones";
			this.Load += new System.EventHandler(this.formRecepciones_Load);
			((System.ComponentModel.ISupportInitialize)(this.spinEditCantidad.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewReferencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lineaAvisoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecepciones1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecepciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditFechaLlegada.Properties)).EndInit();
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
		private System.Windows.Forms.BindingSource lineaAvisoBindingSource;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraGrid.Columns.GridColumn colSTOCK;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecepciones;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecepciones1;
		private DevExpress.XtraGrid.Columns.GridColumn colalbaran;
		private DevExpress.XtraGrid.Columns.GridColumn colcod_linea;
		private DevExpress.XtraGrid.Columns.GridColumn colcod_referencia1;
		private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
		private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_referencia;
		private DevExpress.XtraEditors.TextEdit textEditFechaLlegada;
	}
}