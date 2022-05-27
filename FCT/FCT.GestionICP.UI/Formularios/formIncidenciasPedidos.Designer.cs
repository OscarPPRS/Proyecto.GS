namespace FCT.GestionICP.UI.Formularios
{
	partial class formIncidenciasPedidos
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
			DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIncidenciasPedidos));
			this.gridControlIncidencias = new DevExpress.XtraGrid.GridControl();
			this.vORDENSALIDAINCIDENCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewIncidencias = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID_INCIDENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_PETICION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDIRECCION_ENTREGA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_POSTAL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPOBLACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_INCIDENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButtonResolverIncidencia = new DevExpress.XtraEditors.SimpleButton();
			this.gridControlLineasPeticion = new DevExpress.XtraGrid.GridControl();
			this.vORDENSALIDALINBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewLineasPeticion = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_PETICION1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_LINEA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDES_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridControlPalets = new DevExpress.XtraGrid.GridControl();
			this.vPALETSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewPalets = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_PALET = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDESC_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDESC_UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCALLE = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPOSICION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFECH_INSERT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colALBARAN_RECEPCION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPETICION_SALIDA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPALET_PADRE = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlIncidencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDAINCIDENCIASBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewIncidencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlLineasPeticion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDALINBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewLineasPeticion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPalets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vPALETSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPalets)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridControlIncidencias
			// 
			this.gridControlIncidencias.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlIncidencias.DataSource = this.vORDENSALIDAINCIDENCIASBindingSource;
			gridLevelNode1.RelationName = "Level1";
			this.gridControlIncidencias.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gridControlIncidencias.Location = new System.Drawing.Point(204, 94);
			this.gridControlIncidencias.MainView = this.gridViewIncidencias;
			this.gridControlIncidencias.Name = "gridControlIncidencias";
			this.gridControlIncidencias.Size = new System.Drawing.Size(1063, 360);
			this.gridControlIncidencias.TabIndex = 1;
			this.gridControlIncidencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIncidencias});
			// 
			// vORDENSALIDAINCIDENCIASBindingSource
			// 
			this.vORDENSALIDAINCIDENCIASBindingSource.DataSource = typeof(FCT.Negocio.V_ORDEN_SALIDA_INCIDENCIAS);
			// 
			// gridViewIncidencias
			// 
			this.gridViewIncidencias.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewIncidencias.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridViewIncidencias.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridViewIncidencias.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridViewIncidencias.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewIncidencias.Appearance.Row.Options.UseFont = true;
			this.gridViewIncidencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_INCIDENCIA,
            this.colCOD_PETICION,
            this.colID_EMPRESA,
            this.colDIRECCION_ENTREGA,
            this.colCOD_POSTAL,
            this.colPOBLACION,
            this.colDES_INCIDENCIA,
            this.colESTADO});
			this.gridViewIncidencias.GridControl = this.gridControlIncidencias;
			this.gridViewIncidencias.Name = "gridViewIncidencias";
			this.gridViewIncidencias.OptionsBehavior.Editable = false;
			this.gridViewIncidencias.OptionsBehavior.ReadOnly = true;
			this.gridViewIncidencias.OptionsCustomization.AllowColumnMoving = false;
			this.gridViewIncidencias.OptionsCustomization.AllowGroup = false;
			this.gridViewIncidencias.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridViewIncidencias_FocusedRowObjectChanged);
			// 
			// colID_INCIDENCIA
			// 
			this.colID_INCIDENCIA.Caption = "ID de incidencia";
			this.colID_INCIDENCIA.FieldName = "ID_INCIDENCIA";
			this.colID_INCIDENCIA.Name = "colID_INCIDENCIA";
			this.colID_INCIDENCIA.Visible = true;
			this.colID_INCIDENCIA.VisibleIndex = 0;
			// 
			// colCOD_PETICION
			// 
			this.colCOD_PETICION.Caption = "Petición";
			this.colCOD_PETICION.FieldName = "COD_PETICION";
			this.colCOD_PETICION.Name = "colCOD_PETICION";
			this.colCOD_PETICION.Visible = true;
			this.colCOD_PETICION.VisibleIndex = 1;
			// 
			// colID_EMPRESA
			// 
			this.colID_EMPRESA.FieldName = "ID_EMPRESA";
			this.colID_EMPRESA.Name = "colID_EMPRESA";
			// 
			// colDIRECCION_ENTREGA
			// 
			this.colDIRECCION_ENTREGA.Caption = "Dirección de entrega";
			this.colDIRECCION_ENTREGA.FieldName = "DIRECCION_ENTREGA";
			this.colDIRECCION_ENTREGA.Name = "colDIRECCION_ENTREGA";
			this.colDIRECCION_ENTREGA.Visible = true;
			this.colDIRECCION_ENTREGA.VisibleIndex = 2;
			// 
			// colCOD_POSTAL
			// 
			this.colCOD_POSTAL.Caption = "Código postal";
			this.colCOD_POSTAL.FieldName = "COD_POSTAL";
			this.colCOD_POSTAL.Name = "colCOD_POSTAL";
			this.colCOD_POSTAL.Visible = true;
			this.colCOD_POSTAL.VisibleIndex = 3;
			// 
			// colPOBLACION
			// 
			this.colPOBLACION.Caption = "Población";
			this.colPOBLACION.FieldName = "POBLACION";
			this.colPOBLACION.Name = "colPOBLACION";
			this.colPOBLACION.Visible = true;
			this.colPOBLACION.VisibleIndex = 4;
			// 
			// colDES_INCIDENCIA
			// 
			this.colDES_INCIDENCIA.FieldName = "DES_INCIDENCIA";
			this.colDES_INCIDENCIA.Name = "colDES_INCIDENCIA";
			// 
			// colESTADO
			// 
			this.colESTADO.FieldName = "ESTADO";
			this.colESTADO.Name = "colESTADO";
			// 
			// simpleButtonResolverIncidencia
			// 
			this.simpleButtonResolverIncidencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonResolverIncidencia.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.simpleButtonResolverIncidencia.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButtonResolverIncidencia.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.simpleButtonResolverIncidencia.Appearance.Options.UseBackColor = true;
			this.simpleButtonResolverIncidencia.Appearance.Options.UseFont = true;
			this.simpleButtonResolverIncidencia.Appearance.Options.UseForeColor = true;
			this.simpleButtonResolverIncidencia.Location = new System.Drawing.Point(152, 294);
			this.simpleButtonResolverIncidencia.Name = "simpleButtonResolverIncidencia";
			this.simpleButtonResolverIncidencia.Size = new System.Drawing.Size(149, 48);
			this.simpleButtonResolverIncidencia.TabIndex = 2;
			this.simpleButtonResolverIncidencia.Text = "RESOLVER\r\nINCIDENCIA";
			this.simpleButtonResolverIncidencia.Click += new System.EventHandler(this.simpleButtonResolverIncidencia_Click);
			// 
			// gridControlLineasPeticion
			// 
			this.gridControlLineasPeticion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlLineasPeticion.DataSource = this.vORDENSALIDALINBindingSource;
			gridLevelNode2.RelationName = "Level1";
			this.gridControlLineasPeticion.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
			this.gridControlLineasPeticion.Location = new System.Drawing.Point(204, 460);
			this.gridControlLineasPeticion.MainView = this.gridViewLineasPeticion;
			this.gridControlLineasPeticion.Name = "gridControlLineasPeticion";
			this.gridControlLineasPeticion.Size = new System.Drawing.Size(634, 394);
			this.gridControlLineasPeticion.TabIndex = 3;
			this.gridControlLineasPeticion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLineasPeticion});
			// 
			// vORDENSALIDALINBindingSource
			// 
			this.vORDENSALIDALINBindingSource.DataSource = typeof(FCT.Negocio.V_ORDEN_SALIDA_LIN);
			// 
			// gridViewLineasPeticion
			// 
			this.gridViewLineasPeticion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewLineasPeticion.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridViewLineasPeticion.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridViewLineasPeticion.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridViewLineasPeticion.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewLineasPeticion.Appearance.Row.Options.UseFont = true;
			this.gridViewLineasPeticion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_PETICION1,
            this.colCOD_LINEA,
            this.colCOD_REFERENCIA,
            this.colDES_REFERENCIA,
            this.colCANTIDAD,
            this.colPRECIO,
            this.colSTOCK});
			this.gridViewLineasPeticion.GridControl = this.gridControlLineasPeticion;
			this.gridViewLineasPeticion.Name = "gridViewLineasPeticion";
			this.gridViewLineasPeticion.OptionsBehavior.Editable = false;
			this.gridViewLineasPeticion.OptionsBehavior.ReadOnly = true;
			this.gridViewLineasPeticion.OptionsCustomization.AllowColumnMoving = false;
			this.gridViewLineasPeticion.OptionsCustomization.AllowGroup = false;
			// 
			// colCOD_PETICION1
			// 
			this.colCOD_PETICION1.FieldName = "COD_PETICION";
			this.colCOD_PETICION1.Name = "colCOD_PETICION1";
			// 
			// colCOD_LINEA
			// 
			this.colCOD_LINEA.Caption = " ";
			this.colCOD_LINEA.FieldName = "COD_LINEA";
			this.colCOD_LINEA.Name = "colCOD_LINEA";
			this.colCOD_LINEA.Visible = true;
			this.colCOD_LINEA.VisibleIndex = 0;
			this.colCOD_LINEA.Width = 42;
			// 
			// colCOD_REFERENCIA
			// 
			this.colCOD_REFERENCIA.Caption = "Referencia";
			this.colCOD_REFERENCIA.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA.Name = "colCOD_REFERENCIA";
			this.colCOD_REFERENCIA.Visible = true;
			this.colCOD_REFERENCIA.VisibleIndex = 1;
			this.colCOD_REFERENCIA.Width = 111;
			// 
			// colDES_REFERENCIA
			// 
			this.colDES_REFERENCIA.Caption = "Producto";
			this.colDES_REFERENCIA.FieldName = "DES_REFERENCIA";
			this.colDES_REFERENCIA.Name = "colDES_REFERENCIA";
			this.colDES_REFERENCIA.Visible = true;
			this.colDES_REFERENCIA.VisibleIndex = 2;
			this.colDES_REFERENCIA.Width = 196;
			// 
			// colCANTIDAD
			// 
			this.colCANTIDAD.Caption = "Cantidad";
			this.colCANTIDAD.FieldName = "CANTIDAD";
			this.colCANTIDAD.Name = "colCANTIDAD";
			this.colCANTIDAD.Visible = true;
			this.colCANTIDAD.VisibleIndex = 3;
			this.colCANTIDAD.Width = 86;
			// 
			// colPRECIO
			// 
			this.colPRECIO.Caption = "Precio unitario";
			this.colPRECIO.FieldName = "PRECIO";
			this.colPRECIO.Name = "colPRECIO";
			this.colPRECIO.Visible = true;
			this.colPRECIO.VisibleIndex = 4;
			this.colPRECIO.Width = 104;
			// 
			// colSTOCK
			// 
			this.colSTOCK.Caption = "Stock";
			this.colSTOCK.FieldName = "STOCK";
			this.colSTOCK.Name = "colSTOCK";
			this.colSTOCK.Visible = true;
			this.colSTOCK.VisibleIndex = 5;
			this.colSTOCK.Width = 70;
			// 
			// gridControlPalets
			// 
			this.gridControlPalets.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlPalets.DataSource = this.vPALETSBindingSource;
			gridLevelNode3.RelationName = "Level1";
			this.gridControlPalets.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
			this.gridControlPalets.Location = new System.Drawing.Point(844, 460);
			this.gridControlPalets.MainView = this.gridViewPalets;
			this.gridControlPalets.Name = "gridControlPalets";
			this.gridControlPalets.Size = new System.Drawing.Size(912, 394);
			this.gridControlPalets.TabIndex = 4;
			this.gridControlPalets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPalets});
			// 
			// vPALETSBindingSource
			// 
			this.vPALETSBindingSource.DataSource = typeof(FCT.Negocio.V_PALETS);
			// 
			// gridViewPalets
			// 
			this.gridViewPalets.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewPalets.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridViewPalets.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridViewPalets.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridViewPalets.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewPalets.Appearance.Row.Options.UseFont = true;
			this.gridViewPalets.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_PALET,
            this.colCOD_ESTADO,
            this.colDESC_ESTADO,
            this.colCOD_REFERENCIA1,
            this.colCANTIDAD1,
            this.colUBICACION,
            this.colDESC_UBICACION,
            this.colCALLE,
            this.colPOSICION,
            this.colFECH_INSERT,
            this.colALBARAN_RECEPCION,
            this.colPETICION_SALIDA,
            this.colPALET_PADRE});
			this.gridViewPalets.GridControl = this.gridControlPalets;
			this.gridViewPalets.Name = "gridViewPalets";
			this.gridViewPalets.OptionsBehavior.Editable = false;
			this.gridViewPalets.OptionsBehavior.ReadOnly = true;
			this.gridViewPalets.OptionsCustomization.AllowColumnMoving = false;
			this.gridViewPalets.OptionsCustomization.AllowGroup = false;
			// 
			// colCOD_PALET
			// 
			this.colCOD_PALET.Caption = "Código de palet";
			this.colCOD_PALET.FieldName = "COD_PALET";
			this.colCOD_PALET.Name = "colCOD_PALET";
			this.colCOD_PALET.Visible = true;
			this.colCOD_PALET.VisibleIndex = 0;
			this.colCOD_PALET.Width = 111;
			// 
			// colCOD_ESTADO
			// 
			this.colCOD_ESTADO.FieldName = "COD_ESTADO";
			this.colCOD_ESTADO.Name = "colCOD_ESTADO";
			// 
			// colDESC_ESTADO
			// 
			this.colDESC_ESTADO.Caption = "Estado";
			this.colDESC_ESTADO.FieldName = "DESC_ESTADO";
			this.colDESC_ESTADO.Name = "colDESC_ESTADO";
			this.colDESC_ESTADO.Visible = true;
			this.colDESC_ESTADO.VisibleIndex = 1;
			this.colDESC_ESTADO.Width = 96;
			// 
			// colCOD_REFERENCIA1
			// 
			this.colCOD_REFERENCIA1.Caption = "Referencia";
			this.colCOD_REFERENCIA1.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA1.Name = "colCOD_REFERENCIA1";
			this.colCOD_REFERENCIA1.Visible = true;
			this.colCOD_REFERENCIA1.VisibleIndex = 2;
			this.colCOD_REFERENCIA1.Width = 96;
			// 
			// colCANTIDAD1
			// 
			this.colCANTIDAD1.Caption = "Cantidad";
			this.colCANTIDAD1.FieldName = "CANTIDAD";
			this.colCANTIDAD1.Name = "colCANTIDAD1";
			this.colCANTIDAD1.Visible = true;
			this.colCANTIDAD1.VisibleIndex = 3;
			this.colCANTIDAD1.Width = 64;
			// 
			// colUBICACION
			// 
			this.colUBICACION.FieldName = "UBICACION";
			this.colUBICACION.Name = "colUBICACION";
			// 
			// colDESC_UBICACION
			// 
			this.colDESC_UBICACION.Caption = "Ubicación";
			this.colDESC_UBICACION.FieldName = "DESC_UBICACION";
			this.colDESC_UBICACION.Name = "colDESC_UBICACION";
			this.colDESC_UBICACION.Visible = true;
			this.colDESC_UBICACION.VisibleIndex = 4;
			this.colDESC_UBICACION.Width = 128;
			// 
			// colCALLE
			// 
			this.colCALLE.FieldName = "CALLE";
			this.colCALLE.Name = "colCALLE";
			// 
			// colPOSICION
			// 
			this.colPOSICION.FieldName = "POSICION";
			this.colPOSICION.Name = "colPOSICION";
			// 
			// colFECH_INSERT
			// 
			this.colFECH_INSERT.Caption = "Fecha de creación";
			this.colFECH_INSERT.FieldName = "FECH_INSERT";
			this.colFECH_INSERT.Name = "colFECH_INSERT";
			this.colFECH_INSERT.Visible = true;
			this.colFECH_INSERT.VisibleIndex = 5;
			this.colFECH_INSERT.Width = 116;
			// 
			// colALBARAN_RECEPCION
			// 
			this.colALBARAN_RECEPCION.Caption = "Albarán";
			this.colALBARAN_RECEPCION.FieldName = "ALBARAN_RECEPCION";
			this.colALBARAN_RECEPCION.Name = "colALBARAN_RECEPCION";
			this.colALBARAN_RECEPCION.Visible = true;
			this.colALBARAN_RECEPCION.VisibleIndex = 6;
			this.colALBARAN_RECEPCION.Width = 86;
			// 
			// colPETICION_SALIDA
			// 
			this.colPETICION_SALIDA.Caption = "Petición ";
			this.colPETICION_SALIDA.FieldName = "PETICION_SALIDA";
			this.colPETICION_SALIDA.Name = "colPETICION_SALIDA";
			this.colPETICION_SALIDA.Visible = true;
			this.colPETICION_SALIDA.VisibleIndex = 7;
			this.colPETICION_SALIDA.Width = 89;
			// 
			// colPALET_PADRE
			// 
			this.colPALET_PADRE.Caption = "Palet padre";
			this.colPALET_PADRE.FieldName = "PALET_PADRE";
			this.colPALET_PADRE.Name = "colPALET_PADRE";
			this.colPALET_PADRE.Visible = true;
			this.colPALET_PADRE.VisibleIndex = 8;
			this.colPALET_PADRE.Width = 101;
			// 
			// simpleButtonActualizar
			// 
			this.simpleButtonActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.ImageOptions.Image")));
			this.simpleButtonActualizar.Location = new System.Drawing.Point(143, 94);
			this.simpleButtonActualizar.Name = "simpleButtonActualizar";
			this.simpleButtonActualizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonActualizar.Size = new System.Drawing.Size(55, 52);
			this.simpleButtonActualizar.TabIndex = 36;
			this.simpleButtonActualizar.ToolTip = "Actualizar";
			this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
			// 
			// labelControl5
			// 
			this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Lemon/Milk", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Appearance.Options.UseForeColor = true;
			this.labelControl5.Location = new System.Drawing.Point(204, 29);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(348, 41);
			this.labelControl5.TabIndex = 98;
			this.labelControl5.Text = "INCIDENCIAS DE PEDIDOS";
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Controls.Add(this.simpleButtonResolverIncidencia);
			this.panel1.Location = new System.Drawing.Point(1293, 94);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(463, 360);
			this.panel1.TabIndex = 99;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Location = new System.Drawing.Point(90, 39);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(276, 235);
			this.labelControl1.TabIndex = 3;
			// 
			// formIncidenciasPedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1835, 891);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.simpleButtonActualizar);
			this.Controls.Add(this.gridControlPalets);
			this.Controls.Add(this.gridControlLineasPeticion);
			this.Controls.Add(this.gridControlIncidencias);
			this.Name = "formIncidenciasPedidos";
			((System.ComponentModel.ISupportInitialize)(this.gridControlIncidencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDAINCIDENCIASBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewIncidencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlLineasPeticion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vORDENSALIDALINBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewLineasPeticion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPalets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vPALETSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPalets)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlIncidencias;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewIncidencias;
		private DevExpress.XtraEditors.SimpleButton simpleButtonResolverIncidencia;
		private DevExpress.XtraGrid.GridControl gridControlLineasPeticion;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewLineasPeticion;
		private DevExpress.XtraGrid.GridControl gridControlPalets;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewPalets;
		private System.Windows.Forms.BindingSource vORDENSALIDAINCIDENCIASBindingSource;
		private System.Windows.Forms.BindingSource vORDENSALIDALINBindingSource;
		private System.Windows.Forms.BindingSource vPALETSBindingSource;
		private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
		private DevExpress.XtraGrid.Columns.GridColumn colID_INCIDENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_PETICION;
		private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
		private DevExpress.XtraGrid.Columns.GridColumn colDIRECCION_ENTREGA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_POSTAL;
		private DevExpress.XtraGrid.Columns.GridColumn colPOBLACION;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_INCIDENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colESTADO;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_PETICION1;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_LINEA;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colDES_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD;
		private DevExpress.XtraGrid.Columns.GridColumn colPRECIO;
		private DevExpress.XtraGrid.Columns.GridColumn colSTOCK;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_PALET;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_ESTADO;
		private DevExpress.XtraGrid.Columns.GridColumn colDESC_ESTADO;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA1;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD1;
		private DevExpress.XtraGrid.Columns.GridColumn colUBICACION;
		private DevExpress.XtraGrid.Columns.GridColumn colDESC_UBICACION;
		private DevExpress.XtraGrid.Columns.GridColumn colCALLE;
		private DevExpress.XtraGrid.Columns.GridColumn colPOSICION;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_INSERT;
		private DevExpress.XtraGrid.Columns.GridColumn colALBARAN_RECEPCION;
		private DevExpress.XtraGrid.Columns.GridColumn colPETICION_SALIDA;
		private DevExpress.XtraGrid.Columns.GridColumn colPALET_PADRE;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}