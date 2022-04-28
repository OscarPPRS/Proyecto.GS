namespace FCT.Cliente.UI
{
	partial class formReferencias
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
			this.simpleButtonImagen = new DevExpress.XtraEditors.SimpleButton();
			this.gridControlReferencias = new DevExpress.XtraGrid.GridControl();
			this.vISTAREFERENCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFECH_CREACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIMAGEN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.pictureEditVisualizar = new DevExpress.XtraEditors.PictureEdit();
			this.textEditPrecio = new DevExpress.XtraEditors.TextEdit();
			this.simpleButtonCambiarEstado = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonModificar = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonAnadir = new DevExpress.XtraEditors.SimpleButton();
			this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
			this.textEditDescripcion = new DevExpress.XtraEditors.TextEdit();
			this.pictureEditCambiar = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEditVisualizar.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPrecio.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEditCambiar.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButtonImagen
			// 
			this.simpleButtonImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonImagen.Location = new System.Drawing.Point(1490, 426);
			this.simpleButtonImagen.Name = "simpleButtonImagen";
			this.simpleButtonImagen.Size = new System.Drawing.Size(157, 27);
			this.simpleButtonImagen.TabIndex = 87;
			this.simpleButtonImagen.Text = "Añadir imagen...";
			this.simpleButtonImagen.Click += new System.EventHandler(this.simpleButtonImagen_Click);
			// 
			// gridControlReferencias
			// 
			this.gridControlReferencias.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlReferencias.DataSource = this.vISTAREFERENCIASBindingSource;
			this.gridControlReferencias.Location = new System.Drawing.Point(571, 12);
			this.gridControlReferencias.MainView = this.gridView1;
			this.gridControlReferencias.Name = "gridControlReferencias";
			this.gridControlReferencias.Size = new System.Drawing.Size(784, 831);
			this.gridControlReferencias.TabIndex = 86;
			this.gridControlReferencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// vISTAREFERENCIASBindingSource
			// 
			this.vISTAREFERENCIASBindingSource.DataSource = typeof(FCT.Negocio.V_REFERENCIAS);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_REFERENCIA,
            this.colID_EMPRESA,
            this.colDES_REFERENCIA,
            this.colPRECIO,
            this.colFECH_CREACION,
            this.colIMAGEN,
            this.colESTADO,
            this.colSTOCK});
			this.gridView1.GridControl = this.gridControlReferencias;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsCustomization.AllowGroup = false;
			this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// colCOD_REFERENCIA
			// 
			this.colCOD_REFERENCIA.Caption = "Código de la referencia";
			this.colCOD_REFERENCIA.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA.Name = "colCOD_REFERENCIA";
			this.colCOD_REFERENCIA.Visible = true;
			this.colCOD_REFERENCIA.VisibleIndex = 0;
			this.colCOD_REFERENCIA.Width = 163;
			// 
			// colID_EMPRESA
			// 
			this.colID_EMPRESA.FieldName = "ID_EMPRESA";
			this.colID_EMPRESA.Name = "colID_EMPRESA";
			// 
			// colDES_REFERENCIA
			// 
			this.colDES_REFERENCIA.Caption = "Descripción de la referencia";
			this.colDES_REFERENCIA.FieldName = "DES_REFERENCIA";
			this.colDES_REFERENCIA.Name = "colDES_REFERENCIA";
			this.colDES_REFERENCIA.Visible = true;
			this.colDES_REFERENCIA.VisibleIndex = 1;
			this.colDES_REFERENCIA.Width = 318;
			// 
			// colPRECIO
			// 
			this.colPRECIO.Caption = "Precio";
			this.colPRECIO.FieldName = "PRECIO";
			this.colPRECIO.Name = "colPRECIO";
			this.colPRECIO.Visible = true;
			this.colPRECIO.VisibleIndex = 2;
			this.colPRECIO.Width = 80;
			// 
			// colFECH_CREACION
			// 
			this.colFECH_CREACION.Caption = "Fecha creación";
			this.colFECH_CREACION.FieldName = "FECH_CREACION";
			this.colFECH_CREACION.Name = "colFECH_CREACION";
			this.colFECH_CREACION.Visible = true;
			this.colFECH_CREACION.VisibleIndex = 3;
			this.colFECH_CREACION.Width = 117;
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
			this.colSTOCK.VisibleIndex = 4;
			this.colSTOCK.Width = 90;
			// 
			// labelControl3
			// 
			this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl3.Location = new System.Drawing.Point(1460, 547);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(29, 13);
			this.labelControl3.TabIndex = 85;
			this.labelControl3.Text = "Precio";
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl2.Location = new System.Drawing.Point(1460, 490);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(54, 13);
			this.labelControl2.TabIndex = 84;
			this.labelControl2.Text = "Descripción";
			// 
			// pictureEditVisualizar
			// 
			this.pictureEditVisualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureEditVisualizar.Location = new System.Drawing.Point(186, 114);
			this.pictureEditVisualizar.Name = "pictureEditVisualizar";
			this.pictureEditVisualizar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEditVisualizar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEditVisualizar.Size = new System.Drawing.Size(363, 620);
			this.pictureEditVisualizar.TabIndex = 83;
			// 
			// textEditPrecio
			// 
			this.textEditPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textEditPrecio.Location = new System.Drawing.Point(1570, 544);
			this.textEditPrecio.Name = "textEditPrecio";
			this.textEditPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEditPrecio.Properties.MaskSettings.Set("mask", "c");
			this.textEditPrecio.Size = new System.Drawing.Size(124, 20);
			this.textEditPrecio.TabIndex = 79;
			// 
			// simpleButtonCambiarEstado
			// 
			this.simpleButtonCambiarEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonCambiarEstado.Location = new System.Drawing.Point(1653, 608);
			this.simpleButtonCambiarEstado.Name = "simpleButtonCambiarEstado";
			this.simpleButtonCambiarEstado.Size = new System.Drawing.Size(126, 50);
			this.simpleButtonCambiarEstado.TabIndex = 82;
			this.simpleButtonCambiarEstado.Text = "Cambiar disponibilidad";
			this.simpleButtonCambiarEstado.Click += new System.EventHandler(this.clickCambiarEstadoReferencia);
			// 
			// simpleButtonModificar
			// 
			this.simpleButtonModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonModificar.Location = new System.Drawing.Point(1521, 608);
			this.simpleButtonModificar.Name = "simpleButtonModificar";
			this.simpleButtonModificar.Size = new System.Drawing.Size(126, 50);
			this.simpleButtonModificar.TabIndex = 81;
			this.simpleButtonModificar.Text = "Modificar selección";
			this.simpleButtonModificar.Click += new System.EventHandler(this.simpleButtonModificar_Click);
			// 
			// simpleButtonAnadir
			// 
			this.simpleButtonAnadir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonAnadir.Location = new System.Drawing.Point(1389, 608);
			this.simpleButtonAnadir.Name = "simpleButtonAnadir";
			this.simpleButtonAnadir.Size = new System.Drawing.Size(126, 50);
			this.simpleButtonAnadir.TabIndex = 80;
			this.simpleButtonAnadir.Text = "Añadir nueva referencia";
			this.simpleButtonAnadir.Click += new System.EventHandler(this.simpleButtonAnadir_Click);
			// 
			// xtraOpenFileDialog1
			// 
			this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
			// 
			// textEditDescripcion
			// 
			this.textEditDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textEditDescripcion.Location = new System.Drawing.Point(1570, 487);
			this.textEditDescripcion.Name = "textEditDescripcion";
			this.textEditDescripcion.Size = new System.Drawing.Size(124, 20);
			this.textEditDescripcion.TabIndex = 88;
			// 
			// pictureEditCambiar
			// 
			this.pictureEditCambiar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureEditCambiar.Location = new System.Drawing.Point(1490, 178);
			this.pictureEditCambiar.Name = "pictureEditCambiar";
			this.pictureEditCambiar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEditCambiar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEditCambiar.Size = new System.Drawing.Size(157, 232);
			this.pictureEditCambiar.TabIndex = 89;
			// 
			// formReferencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1814, 855);
			this.Controls.Add(this.pictureEditCambiar);
			this.Controls.Add(this.textEditDescripcion);
			this.Controls.Add(this.simpleButtonImagen);
			this.Controls.Add(this.gridControlReferencias);
			this.Controls.Add(this.simpleButtonAnadir);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.simpleButtonModificar);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.simpleButtonCambiarEstado);
			this.Controls.Add(this.pictureEditVisualizar);
			this.Controls.Add(this.textEditPrecio);
			this.Name = "formReferencias";
			this.Text = "Referencias";
			this.Load += new System.EventHandler(this.formMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEditVisualizar.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPrecio.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEditCambiar.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraEditors.SimpleButton simpleButtonImagen;
		private DevExpress.XtraGrid.GridControl gridControlReferencias;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.PictureEdit pictureEditVisualizar;
		private DevExpress.XtraEditors.TextEdit textEditPrecio;
		private DevExpress.XtraEditors.SimpleButton simpleButtonCambiarEstado;
		private DevExpress.XtraEditors.SimpleButton simpleButtonModificar;
		private DevExpress.XtraEditors.SimpleButton simpleButtonAnadir;
		private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
		private System.Windows.Forms.BindingSource vISTAREFERENCIASBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colPRECIO;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_CREACION;
		private DevExpress.XtraGrid.Columns.GridColumn colIMAGEN;
		private DevExpress.XtraGrid.Columns.GridColumn colESTADO;
		private DevExpress.XtraGrid.Columns.GridColumn colSTOCK;
		private DevExpress.XtraEditors.TextEdit textEditDescripcion;
		private DevExpress.XtraEditors.PictureEdit pictureEditCambiar;
	}
}