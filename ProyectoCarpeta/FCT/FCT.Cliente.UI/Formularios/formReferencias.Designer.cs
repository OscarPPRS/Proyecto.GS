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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReferencias));
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
			this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEditVisualizar.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPrecio.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEditCambiar.Properties)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// simpleButtonImagen
			// 
			this.simpleButtonImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonImagen.Location = new System.Drawing.Point(138, 284);
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
			this.gridControlReferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridControlReferencias.Location = new System.Drawing.Point(483, 167);
			this.gridControlReferencias.MainView = this.gridView1;
			this.gridControlReferencias.Name = "gridControlReferencias";
			this.gridControlReferencias.Size = new System.Drawing.Size(784, 782);
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
			this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent;
			this.gridView1.Appearance.Empty.Options.UseBackColor = true;
			this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
			this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridView1.Appearance.Row.Options.UseBackColor = true;
			this.gridView1.Appearance.Row.Options.UseFont = true;
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
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(74, 387);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(69, 27);
			this.labelControl3.TabIndex = 85;
			this.labelControl3.Text = "Precio";
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(74, 330);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(125, 27);
			this.labelControl2.TabIndex = 84;
			this.labelControl2.Text = "Descripción";
			// 
			// pictureEditVisualizar
			// 
			this.pictureEditVisualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureEditVisualizar.Location = new System.Drawing.Point(78, 281);
			this.pictureEditVisualizar.Name = "pictureEditVisualizar";
			this.pictureEditVisualizar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.pictureEditVisualizar.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEditVisualizar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEditVisualizar.Properties.NullText = " ";
			this.pictureEditVisualizar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEditVisualizar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEditVisualizar.Size = new System.Drawing.Size(363, 570);
			this.pictureEditVisualizar.TabIndex = 83;
			// 
			// textEditPrecio
			// 
			this.textEditPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textEditPrecio.Location = new System.Drawing.Point(223, 394);
			this.textEditPrecio.Name = "textEditPrecio";
			this.textEditPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEditPrecio.Properties.MaskSettings.Set("mask", "c");
			this.textEditPrecio.Size = new System.Drawing.Size(124, 20);
			this.textEditPrecio.TabIndex = 79;
			// 
			// simpleButtonCambiarEstado
			// 
			this.simpleButtonCambiarEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonCambiarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonCambiarEstado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCambiarEstado.ImageOptions.Image")));
			this.simpleButtonCambiarEstado.Location = new System.Drawing.Point(1595, 766);
			this.simpleButtonCambiarEstado.Name = "simpleButtonCambiarEstado";
			this.simpleButtonCambiarEstado.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonCambiarEstado.Size = new System.Drawing.Size(57, 65);
			this.simpleButtonCambiarEstado.TabIndex = 82;
			this.simpleButtonCambiarEstado.Click += new System.EventHandler(this.clickCambiarEstadoReferencia);
			// 
			// simpleButtonModificar
			// 
			this.simpleButtonModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonModificar.ImageOptions.Image")));
			this.simpleButtonModificar.Location = new System.Drawing.Point(1484, 768);
			this.simpleButtonModificar.Name = "simpleButtonModificar";
			this.simpleButtonModificar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonModificar.Size = new System.Drawing.Size(58, 61);
			this.simpleButtonModificar.TabIndex = 81;
			this.simpleButtonModificar.Click += new System.EventHandler(this.simpleButtonModificar_Click);
			// 
			// simpleButtonAnadir
			// 
			this.simpleButtonAnadir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonAnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonAnadir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnadir.ImageOptions.Image")));
			this.simpleButtonAnadir.Location = new System.Drawing.Point(1382, 770);
			this.simpleButtonAnadir.Name = "simpleButtonAnadir";
			this.simpleButtonAnadir.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonAnadir.Size = new System.Drawing.Size(55, 57);
			this.simpleButtonAnadir.TabIndex = 80;
			this.simpleButtonAnadir.Click += new System.EventHandler(this.simpleButtonAnadir_Click);
			// 
			// xtraOpenFileDialog1
			// 
			this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
			// 
			// textEditDescripcion
			// 
			this.textEditDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textEditDescripcion.Location = new System.Drawing.Point(223, 337);
			this.textEditDescripcion.Name = "textEditDescripcion";
			this.textEditDescripcion.Size = new System.Drawing.Size(124, 20);
			this.textEditDescripcion.TabIndex = 88;
			// 
			// pictureEditCambiar
			// 
			this.pictureEditCambiar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureEditCambiar.Location = new System.Drawing.Point(138, 46);
			this.pictureEditCambiar.Name = "pictureEditCambiar";
			this.pictureEditCambiar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEditCambiar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEditCambiar.Size = new System.Drawing.Size(157, 232);
			this.pictureEditCambiar.TabIndex = 89;
			// 
			// simpleButtonActualizar
			// 
			this.simpleButtonActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.ImageOptions.Image")));
			this.simpleButtonActualizar.Location = new System.Drawing.Point(422, 167);
			this.simpleButtonActualizar.Name = "simpleButtonActualizar";
			this.simpleButtonActualizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonActualizar.Size = new System.Drawing.Size(55, 56);
			this.simpleButtonActualizar.TabIndex = 90;
			this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.panel1.Controls.Add(this.pictureEditCambiar);
			this.panel1.Controls.Add(this.textEditPrecio);
			this.panel1.Controls.Add(this.labelControl2);
			this.panel1.Controls.Add(this.textEditDescripcion);
			this.panel1.Controls.Add(this.simpleButtonImagen);
			this.panel1.Controls.Add(this.labelControl3);
			this.panel1.Location = new System.Drawing.Point(1294, 281);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(435, 479);
			this.panel1.TabIndex = 92;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(211, 222);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(88, 41);
			this.labelControl1.TabIndex = 93;
			this.labelControl1.Text = "Visor";
			// 
			// labelControl4
			// 
			this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Appearance.Options.UseForeColor = true;
			this.labelControl4.Location = new System.Drawing.Point(1368, 222);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(297, 41);
			this.labelControl4.TabIndex = 94;
			this.labelControl4.Text = "Editar referencias";
			// 
			// labelControl5
			// 
			this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Appearance.Options.UseForeColor = true;
			this.labelControl5.Location = new System.Drawing.Point(161, 40);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(189, 41);
			this.labelControl5.TabIndex = 96;
			this.labelControl5.Text = "REFERENCIAS";
			// 
			// formReferencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1814, 1036);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.simpleButtonCambiarEstado);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.simpleButtonModificar);
			this.Controls.Add(this.simpleButtonActualizar);
			this.Controls.Add(this.gridControlReferencias);
			this.Controls.Add(this.pictureEditVisualizar);
			this.Controls.Add(this.simpleButtonAnadir);
			this.Name = "formReferencias";
			this.Load += new System.EventHandler(this.formMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlReferencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vISTAREFERENCIASBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEditVisualizar.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPrecio.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEditCambiar.Properties)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
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
		private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
	}
}