namespace FCT.Cliente.UI.Formularios
{
	partial class formVisorRecepciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVisorRecepciones));
			this.gridControlCab = new DevExpress.XtraGrid.GridControl();
			this.vRECEPCIONESCABBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colALBARAN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFECH_CREACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFECH_LLEGADA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD_LINEAS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridControlLin = new DevExpress.XtraGrid.GridControl();
			this.vRECEPCIONESLINBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_LINEA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlCab)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESCABBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlLin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESLINBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlCab
			// 
			this.gridControlCab.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlCab.DataSource = this.vRECEPCIONESCABBindingSource;
			this.gridControlCab.Location = new System.Drawing.Point(154, 90);
			this.gridControlCab.MainView = this.gridView1;
			this.gridControlCab.Name = "gridControlCab";
			this.gridControlCab.Size = new System.Drawing.Size(594, 765);
			this.gridControlCab.TabIndex = 0;
			this.gridControlCab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// vRECEPCIONESCABBindingSource
			// 
			this.vRECEPCIONESCABBindingSource.DataSource = typeof(FCT.Negocio.V_RECEPCIONES_CAB);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colALBARAN,
            this.colDES_ESTADO,
            this.colFECH_CREACION,
            this.colFECH_LLEGADA,
            this.colCANTIDAD_LINEAS});
			this.gridView1.GridControl = this.gridControlCab;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsCustomization.AllowGroup = false;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// colALBARAN
			// 
			this.colALBARAN.Caption = "Albarán";
			this.colALBARAN.FieldName = "ALBARAN";
			this.colALBARAN.Name = "colALBARAN";
			this.colALBARAN.Visible = true;
			this.colALBARAN.VisibleIndex = 0;
			this.colALBARAN.Width = 109;
			// 
			// colDES_ESTADO
			// 
			this.colDES_ESTADO.Caption = "Estado";
			this.colDES_ESTADO.FieldName = "DES_ESTADO";
			this.colDES_ESTADO.Name = "colDES_ESTADO";
			this.colDES_ESTADO.Visible = true;
			this.colDES_ESTADO.VisibleIndex = 1;
			this.colDES_ESTADO.Width = 143;
			// 
			// colFECH_CREACION
			// 
			this.colFECH_CREACION.Caption = "Fecha de creación";
			this.colFECH_CREACION.FieldName = "FECH_CREACION";
			this.colFECH_CREACION.Name = "colFECH_CREACION";
			this.colFECH_CREACION.Visible = true;
			this.colFECH_CREACION.VisibleIndex = 2;
			this.colFECH_CREACION.Width = 106;
			// 
			// colFECH_LLEGADA
			// 
			this.colFECH_LLEGADA.Caption = "Fecha de llegada";
			this.colFECH_LLEGADA.FieldName = "FECH_LLEGADA";
			this.colFECH_LLEGADA.Name = "colFECH_LLEGADA";
			this.colFECH_LLEGADA.Visible = true;
			this.colFECH_LLEGADA.VisibleIndex = 3;
			this.colFECH_LLEGADA.Width = 107;
			// 
			// colCANTIDAD_LINEAS
			// 
			this.colCANTIDAD_LINEAS.Caption = "Líneas";
			this.colCANTIDAD_LINEAS.FieldName = "CANTIDAD_LINEAS";
			this.colCANTIDAD_LINEAS.Name = "colCANTIDAD_LINEAS";
			this.colCANTIDAD_LINEAS.Visible = true;
			this.colCANTIDAD_LINEAS.VisibleIndex = 4;
			this.colCANTIDAD_LINEAS.Width = 46;
			// 
			// gridControlLin
			// 
			this.gridControlLin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlLin.DataSource = this.vRECEPCIONESLINBindingSource;
			this.gridControlLin.Location = new System.Drawing.Point(754, 90);
			this.gridControlLin.MainView = this.gridView2;
			this.gridControlLin.Name = "gridControlLin";
			this.gridControlLin.Size = new System.Drawing.Size(891, 765);
			this.gridControlLin.TabIndex = 1;
			this.gridControlLin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// vRECEPCIONESLINBindingSource
			// 
			this.vRECEPCIONESLINBindingSource.DataSource = typeof(FCT.Negocio.V_RECEPCIONES_LIN);
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_LINEA,
            this.colCOD_REFERENCIA,
            this.colDES_REFERENCIA,
            this.colCANTIDAD,
            this.colPRECIO,
            this.colSTOCK});
			this.gridView2.GridControl = this.gridControlLin;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsBehavior.Editable = false;
			this.gridView2.OptionsBehavior.ReadOnly = true;
			this.gridView2.OptionsCustomization.AllowGroup = false;
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
			this.colCOD_REFERENCIA.Caption = "Código de Referencia";
			this.colCOD_REFERENCIA.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA.Name = "colCOD_REFERENCIA";
			this.colCOD_REFERENCIA.Visible = true;
			this.colCOD_REFERENCIA.VisibleIndex = 1;
			this.colCOD_REFERENCIA.Width = 179;
			// 
			// colDES_REFERENCIA
			// 
			this.colDES_REFERENCIA.Caption = "Producto";
			this.colDES_REFERENCIA.FieldName = "DES_REFERENCIA";
			this.colDES_REFERENCIA.Name = "colDES_REFERENCIA";
			this.colDES_REFERENCIA.Visible = true;
			this.colDES_REFERENCIA.VisibleIndex = 2;
			this.colDES_REFERENCIA.Width = 339;
			// 
			// colCANTIDAD
			// 
			this.colCANTIDAD.Caption = "Cantidad";
			this.colCANTIDAD.FieldName = "CANTIDAD";
			this.colCANTIDAD.Name = "colCANTIDAD";
			this.colCANTIDAD.Visible = true;
			this.colCANTIDAD.VisibleIndex = 3;
			this.colCANTIDAD.Width = 102;
			// 
			// colPRECIO
			// 
			this.colPRECIO.Caption = "Precio unitario";
			this.colPRECIO.FieldName = "PRECIO";
			this.colPRECIO.Name = "colPRECIO";
			this.colPRECIO.Visible = true;
			this.colPRECIO.VisibleIndex = 4;
			this.colPRECIO.Width = 102;
			// 
			// colSTOCK
			// 
			this.colSTOCK.Caption = "Stock en ICP";
			this.colSTOCK.FieldName = "STOCK";
			this.colSTOCK.Name = "colSTOCK";
			this.colSTOCK.Visible = true;
			this.colSTOCK.VisibleIndex = 5;
			this.colSTOCK.Width = 118;
			// 
			// simpleButtonActualizar
			// 
			this.simpleButtonActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.simpleButtonActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.ImageOptions.Image")));
			this.simpleButtonActualizar.Location = new System.Drawing.Point(86, 422);
			this.simpleButtonActualizar.Name = "simpleButtonActualizar";
			this.simpleButtonActualizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonActualizar.Size = new System.Drawing.Size(62, 52);
			this.simpleButtonActualizar.TabIndex = 2;
			this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
			// 
			// labelControl4
			// 
			this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Appearance.Options.UseForeColor = true;
			this.labelControl4.Location = new System.Drawing.Point(154, 12);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(334, 41);
			this.labelControl4.TabIndex = 96;
			this.labelControl4.Text = "VISOR DE RECEPCIONES";
			// 
			// formVisorRecepciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1815, 889);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.simpleButtonActualizar);
			this.Controls.Add(this.gridControlLin);
			this.Controls.Add(this.gridControlCab);
			this.Name = "formVisorRecepciones";
			((System.ComponentModel.ISupportInitialize)(this.gridControlCab)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESCABBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlLin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vRECEPCIONESLINBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlCab;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControlLin;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private System.Windows.Forms.BindingSource vRECEPCIONESCABBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colALBARAN;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_ESTADO;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_CREACION;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_LLEGADA;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD_LINEAS;
		private System.Windows.Forms.BindingSource vRECEPCIONESLINBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_LINEA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD;
		private DevExpress.XtraGrid.Columns.GridColumn colPRECIO;
		private DevExpress.XtraGrid.Columns.GridColumn colSTOCK;
		private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
		private DevExpress.XtraEditors.LabelControl labelControl4;
	}
}