namespace FCT.GestionICP.UI.Formularios
{
	partial class formUbicarRecepciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUbicarRecepciones));
			this.gridControlPalets = new DevExpress.XtraGrid.GridControl();
			this.vPALETSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewPalets = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCOD_PALET = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDESC_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOD_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFECH_INSERT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colALBARAN_RECEPCION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
			this.textEditPosicion = new DevExpress.XtraEditors.TextEdit();
			this.textEditCalle = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButtonUbicacionDisponible = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonConfirmarUbicacion = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControlPalets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vPALETSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPalets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPosicion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditCalle.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlPalets
			// 
			this.gridControlPalets.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridControlPalets.DataSource = this.vPALETSBindingSource;
			gridLevelNode1.RelationName = "Level1";
			this.gridControlPalets.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gridControlPalets.Location = new System.Drawing.Point(159, 107);
			this.gridControlPalets.MainView = this.gridViewPalets;
			this.gridControlPalets.Name = "gridControlPalets";
			this.gridControlPalets.Size = new System.Drawing.Size(870, 664);
			this.gridControlPalets.TabIndex = 1;
			this.gridControlPalets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPalets});
			// 
			// vPALETSBindingSource
			// 
			this.vPALETSBindingSource.DataSource = typeof(FCT.Negocio.V_PALETS);
			// 
			// gridViewPalets
			// 
			this.gridViewPalets.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_PALET,
            this.colDESC_ESTADO,
            this.colCOD_REFERENCIA,
            this.colCANTIDAD,
            this.colFECH_INSERT,
            this.colALBARAN_RECEPCION});
			this.gridViewPalets.GridControl = this.gridControlPalets;
			this.gridViewPalets.Name = "gridViewPalets";
			this.gridViewPalets.OptionsBehavior.Editable = false;
			this.gridViewPalets.OptionsBehavior.ReadOnly = true;
			this.gridViewPalets.OptionsCustomization.AllowGroup = false;
			// 
			// colCOD_PALET
			// 
			this.colCOD_PALET.FieldName = "COD_PALET";
			this.colCOD_PALET.Name = "colCOD_PALET";
			this.colCOD_PALET.Visible = true;
			this.colCOD_PALET.VisibleIndex = 0;
			// 
			// colDESC_ESTADO
			// 
			this.colDESC_ESTADO.FieldName = "DESC_ESTADO";
			this.colDESC_ESTADO.Name = "colDESC_ESTADO";
			this.colDESC_ESTADO.Visible = true;
			this.colDESC_ESTADO.VisibleIndex = 1;
			// 
			// colCOD_REFERENCIA
			// 
			this.colCOD_REFERENCIA.FieldName = "COD_REFERENCIA";
			this.colCOD_REFERENCIA.Name = "colCOD_REFERENCIA";
			this.colCOD_REFERENCIA.Visible = true;
			this.colCOD_REFERENCIA.VisibleIndex = 2;
			// 
			// colCANTIDAD
			// 
			this.colCANTIDAD.FieldName = "CANTIDAD";
			this.colCANTIDAD.Name = "colCANTIDAD";
			this.colCANTIDAD.Visible = true;
			this.colCANTIDAD.VisibleIndex = 3;
			// 
			// colFECH_INSERT
			// 
			this.colFECH_INSERT.FieldName = "FECH_INSERT";
			this.colFECH_INSERT.Name = "colFECH_INSERT";
			this.colFECH_INSERT.Visible = true;
			this.colFECH_INSERT.VisibleIndex = 4;
			// 
			// colALBARAN_RECEPCION
			// 
			this.colALBARAN_RECEPCION.FieldName = "ALBARAN_RECEPCION";
			this.colALBARAN_RECEPCION.Name = "colALBARAN_RECEPCION";
			this.colALBARAN_RECEPCION.Visible = true;
			this.colALBARAN_RECEPCION.VisibleIndex = 5;
			// 
			// simpleButtonActualizar
			// 
			this.simpleButtonActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.ImageOptions.Image")));
			this.simpleButtonActualizar.Location = new System.Drawing.Point(75, 217);
			this.simpleButtonActualizar.Name = "simpleButtonActualizar";
			this.simpleButtonActualizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.simpleButtonActualizar.Size = new System.Drawing.Size(58, 60);
			this.simpleButtonActualizar.TabIndex = 36;
			this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
			// 
			// textEditPosicion
			// 
			this.textEditPosicion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textEditPosicion.EditValue = "";
			this.textEditPosicion.Location = new System.Drawing.Point(1365, 426);
			this.textEditPosicion.Name = "textEditPosicion";
			this.textEditPosicion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 40F);
			this.textEditPosicion.Properties.Appearance.Options.UseFont = true;
			this.textEditPosicion.Properties.ReadOnly = true;
			this.textEditPosicion.Size = new System.Drawing.Size(68, 70);
			this.textEditPosicion.TabIndex = 40;
			// 
			// textEditCalle
			// 
			this.textEditCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textEditCalle.EditValue = "";
			this.textEditCalle.Location = new System.Drawing.Point(1365, 313);
			this.textEditCalle.Name = "textEditCalle";
			this.textEditCalle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 40F);
			this.textEditCalle.Properties.Appearance.Options.UseFont = true;
			this.textEditCalle.Properties.ReadOnly = true;
			this.textEditCalle.Size = new System.Drawing.Size(68, 70);
			this.textEditCalle.TabIndex = 39;
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(1105, 429);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(222, 64);
			this.labelControl2.TabIndex = 38;
			this.labelControl2.Text = "Posición";
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(53)))));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(1105, 316);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(130, 64);
			this.labelControl1.TabIndex = 37;
			this.labelControl1.Text = "Calle";
			// 
			// simpleButtonUbicacionDisponible
			// 
			this.simpleButtonUbicacionDisponible.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonUbicacionDisponible.Location = new System.Drawing.Point(1118, 136);
			this.simpleButtonUbicacionDisponible.Name = "simpleButtonUbicacionDisponible";
			this.simpleButtonUbicacionDisponible.Size = new System.Drawing.Size(289, 89);
			this.simpleButtonUbicacionDisponible.TabIndex = 41;
			this.simpleButtonUbicacionDisponible.Text = "UBICACION DISPONIBLE";
			this.simpleButtonUbicacionDisponible.Click += new System.EventHandler(this.simpleButtonUbicacionDisponible_Click);
			// 
			// simpleButtonConfirmarUbicacion
			// 
			this.simpleButtonConfirmarUbicacion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButtonConfirmarUbicacion.Location = new System.Drawing.Point(1118, 582);
			this.simpleButtonConfirmarUbicacion.Name = "simpleButtonConfirmarUbicacion";
			this.simpleButtonConfirmarUbicacion.Size = new System.Drawing.Size(289, 89);
			this.simpleButtonConfirmarUbicacion.TabIndex = 42;
			this.simpleButtonConfirmarUbicacion.Text = "CONFIRMAR UBICACION";
			this.simpleButtonConfirmarUbicacion.Click += new System.EventHandler(this.simpleButtonConfirmarUbicacion_Click);
			// 
			// formUbicarRecepciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1566, 783);
			this.Controls.Add(this.simpleButtonConfirmarUbicacion);
			this.Controls.Add(this.simpleButtonUbicacionDisponible);
			this.Controls.Add(this.textEditPosicion);
			this.Controls.Add(this.textEditCalle);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.simpleButtonActualizar);
			this.Controls.Add(this.gridControlPalets);
			this.Name = "formUbicarRecepciones";
			this.Text = "formUbicarRecepciones";
			((System.ComponentModel.ISupportInitialize)(this.gridControlPalets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vPALETSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPalets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditPosicion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditCalle.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlPalets;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewPalets;
		private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
		private System.Windows.Forms.BindingSource vPALETSBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_PALET;
		private DevExpress.XtraGrid.Columns.GridColumn colDESC_ESTADO;
		private DevExpress.XtraGrid.Columns.GridColumn colCOD_REFERENCIA;
		private DevExpress.XtraGrid.Columns.GridColumn colCANTIDAD;
		private DevExpress.XtraGrid.Columns.GridColumn colFECH_INSERT;
		private DevExpress.XtraGrid.Columns.GridColumn colALBARAN_RECEPCION;
		private DevExpress.XtraEditors.TextEdit textEditPosicion;
		private DevExpress.XtraEditors.TextEdit textEditCalle;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton simpleButtonUbicacionDisponible;
		private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmarUbicacion;
	}
}