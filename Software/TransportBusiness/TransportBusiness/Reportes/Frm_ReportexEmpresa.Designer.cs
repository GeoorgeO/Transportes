namespace TransportBusiness
{
    partial class Frm_ReportexEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReportexEmpresa));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnBuscar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnFolios = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnActualizarPedido = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGeneraArchivos = new DevExpress.XtraBars.BarLargeButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboEmpresas = new DevExpress.XtraEditors.ComboBoxEdit();
            this.radioMoneda = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateAl = new DevExpress.XtraEditors.DateEdit();
            this.dateDel = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dtgReporte = new DevExpress.XtraGrid.GridControl();
            this.dtgValReporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColGasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUtilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmpresas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDel.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bIconos,
            this.bEstado});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblProveedor,
            this.btnLimpiar,
            this.btnFolios,
            this.btnGuardar,
            this.btnActualizarPedido,
            this.btnCancelar,
            this.btnBuscar,
            this.btnImprimir,
            this.btnGeneraArchivos,
            this.btnSalir});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 63;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bEstado;
            // 
            // bIconos
            // 
            this.bIconos.BarName = "Menú principal";
            this.bIconos.DockCol = 0;
            this.bIconos.DockRow = 0;
            this.bIconos.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bIconos.FloatLocation = new System.Drawing.Point(42, 184);
            this.bIconos.FloatSize = new System.Drawing.Size(1106, 535);
            this.bIconos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLimpiar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBuscar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.bIconos.OptionsBar.AllowCollapse = true;
            this.bIconos.OptionsBar.AllowQuickCustomization = false;
            this.bIconos.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bIconos.OptionsBar.DisableClose = true;
            this.bIconos.OptionsBar.DisableCustomization = true;
            this.bIconos.OptionsBar.DrawBorder = false;
            this.bIconos.OptionsBar.DrawDragBorder = false;
            this.bIconos.OptionsBar.RotateWhenVertical = false;
            this.bIconos.OptionsBar.UseWholeRow = true;
            this.bIconos.Text = "Menú principal";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Caption = "Limpiar";
            this.btnLimpiar.Id = 50;
            this.btnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.Image")));
            this.btnLimpiar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.LargeImage")));
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLimpiar_ItemClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Caption = "Buscar";
            this.btnBuscar.Id = 59;
            this.btnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.Image")));
            this.btnBuscar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.LargeImage")));
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuscar_ItemClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 60;
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.LargeImage")));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImprimir_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 62;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            // 
            // bEstado
            // 
            this.bEstado.BarName = "Barra de estado";
            this.bEstado.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bEstado.DockCol = 0;
            this.bEstado.DockRow = 0;
            this.bEstado.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bEstado.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblProveedor)});
            this.bEstado.OptionsBar.AllowQuickCustomization = false;
            this.bEstado.OptionsBar.DrawDragBorder = false;
            this.bEstado.OptionsBar.UseWholeRow = true;
            this.bEstado.Text = "Barra de estado";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Caption = "Proveedor:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(791, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 387);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(791, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(53, 387);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(791, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 387);
            // 
            // btnFolios
            // 
            this.btnFolios.Caption = "Buscar \r\n Folios";
            this.btnFolios.Id = 51;
            this.btnFolios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFolios.ImageOptions.Image")));
            this.btnFolios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFolios.ImageOptions.LargeImage")));
            this.btnFolios.Name = "btnFolios";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar \r\n Pedido";
            this.btnGuardar.Id = 53;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            // 
            // btnActualizarPedido
            // 
            this.btnActualizarPedido.Caption = "Actualizar \r\n Pedido";
            this.btnActualizarPedido.Id = 55;
            this.btnActualizarPedido.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarPedido.ImageOptions.Image")));
            this.btnActualizarPedido.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarPedido.ImageOptions.LargeImage")));
            this.btnActualizarPedido.Name = "btnActualizarPedido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar \r\n Pedido";
            this.btnCancelar.Id = 57;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.LargeImage")));
            this.btnCancelar.Name = "btnCancelar";
            // 
            // btnGeneraArchivos
            // 
            this.btnGeneraArchivos.Caption = "  Genera \r\nArchivos E/S";
            this.btnGeneraArchivos.Id = 61;
            this.btnGeneraArchivos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneraArchivos.ImageOptions.Image")));
            this.btnGeneraArchivos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGeneraArchivos.ImageOptions.LargeImage")));
            this.btnGeneraArchivos.Name = "btnGeneraArchivos";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.comboEmpresas);
            this.panelControl1.Controls.Add(this.radioMoneda);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dateAl);
            this.panelControl1.Controls.Add(this.dateDel);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(53, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(738, 73);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(139, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 83;
            this.labelControl2.Text = "Empresa:";
            // 
            // comboEmpresas
            // 
            this.comboEmpresas.Location = new System.Drawing.Point(188, 27);
            this.comboEmpresas.MenuManager = this.barManager1;
            this.comboEmpresas.Name = "comboEmpresas";
            this.comboEmpresas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboEmpresas.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboEmpresas.Size = new System.Drawing.Size(257, 20);
            this.comboEmpresas.TabIndex = 82;
            // 
            // radioMoneda
            // 
            this.radioMoneda.Location = new System.Drawing.Point(451, 17);
            this.radioMoneda.MenuManager = this.barManager1;
            this.radioMoneda.Name = "radioMoneda";
            this.radioMoneda.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioMoneda.Properties.Appearance.Options.UseBackColor = true;
            this.radioMoneda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioMoneda.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Pesos", true, "Pesos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Dólares", true, "Dólares")});
            this.radioMoneda.Size = new System.Drawing.Size(67, 40);
            this.radioMoneda.TabIndex = 81;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 80;
            this.labelControl1.Text = "Al:";
            // 
            // dateAl
            // 
            this.dateAl.EditValue = null;
            this.dateAl.Location = new System.Drawing.Point(45, 38);
            this.dateAl.Name = "dateAl";
            this.dateAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAl.Size = new System.Drawing.Size(82, 20);
            this.dateAl.TabIndex = 79;
            // 
            // dateDel
            // 
            this.dateDel.EditValue = null;
            this.dateDel.Location = new System.Drawing.Point(45, 12);
            this.dateDel.Name = "dateDel";
            this.dateDel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDel.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDel.Size = new System.Drawing.Size(82, 20);
            this.dateDel.TabIndex = 78;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(19, 13);
            this.labelControl6.TabIndex = 77;
            this.labelControl6.Text = "Del:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dtgReporte);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(53, 73);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl2.Size = new System.Drawing.Size(738, 314);
            this.panelControl2.TabIndex = 5;
            // 
            // dtgReporte
            // 
            this.dtgReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgReporte.Location = new System.Drawing.Point(12, 12);
            this.dtgReporte.MainView = this.dtgValReporte;
            this.dtgReporte.MenuManager = this.barManager1;
            this.dtgReporte.Name = "dtgReporte";
            this.dtgReporte.Size = new System.Drawing.Size(714, 290);
            this.dtgReporte.TabIndex = 0;
            this.dtgReporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValReporte});
            // 
            // dtgValReporte
            // 
            this.dtgValReporte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.ColIngreso,
            this.ColGasto,
            this.ColUtilidad});
            this.dtgValReporte.GridControl = this.dtgReporte;
            this.dtgValReporte.Name = "dtgValReporte";
            this.dtgValReporte.OptionsView.ShowFooter = true;
            this.dtgValReporte.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id Activo";
            this.gridColumn1.FieldName = "Id_Activo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 74;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre Activo";
            this.gridColumn2.FieldName = "Nombre_Interno";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 233;
            // 
            // ColIngreso
            // 
            this.ColIngreso.Caption = "Ingreso";
            this.ColIngreso.FieldName = "Monto_Factura";
            this.ColIngreso.Name = "ColIngreso";
            this.ColIngreso.OptionsColumn.AllowEdit = false;
            this.ColIngreso.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto_Factura", "Total = $ {0:#.##}")});
            this.ColIngreso.Visible = true;
            this.ColIngreso.VisibleIndex = 2;
            this.ColIngreso.Width = 129;
            // 
            // ColGasto
            // 
            this.ColGasto.Caption = "Gasto";
            this.ColGasto.FieldName = "Gasto_Total";
            this.ColGasto.Name = "ColGasto";
            this.ColGasto.OptionsColumn.AllowEdit = false;
            this.ColGasto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gasto_Total", "Total = $ {0:#.##}")});
            this.ColGasto.Visible = true;
            this.ColGasto.VisibleIndex = 3;
            this.ColGasto.Width = 129;
            // 
            // ColUtilidad
            // 
            this.ColUtilidad.Caption = "Utilidad";
            this.ColUtilidad.FieldName = "Utilidad";
            this.ColUtilidad.Name = "ColUtilidad";
            this.ColUtilidad.OptionsColumn.AllowEdit = false;
            this.ColUtilidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Utilidad", "Total = $ {0:#.##}")});
            this.ColUtilidad.Visible = true;
            this.ColUtilidad.VisibleIndex = 4;
            this.ColUtilidad.Width = 135;
            // 
            // Frm_ReportexEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 414);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_ReportexEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Frm_ReportexEmpresa_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmpresas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDel.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnFolios;
        private DevExpress.XtraBars.BarLargeButtonItem btnGuardar;
        private DevExpress.XtraBars.BarLargeButtonItem btnLimpiar;
        private DevExpress.XtraBars.BarLargeButtonItem btnCancelar;
        private DevExpress.XtraBars.BarLargeButtonItem btnActualizarPedido;
        private DevExpress.XtraBars.BarLargeButtonItem btnBuscar;
        private DevExpress.XtraBars.BarLargeButtonItem btnImprimir;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.BarLargeButtonItem btnGeneraArchivos;
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dtgReporte;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValReporte;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboEmpresas;
        private DevExpress.XtraEditors.RadioGroup radioMoneda;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateAl;
        private DevExpress.XtraEditors.DateEdit dateDel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn ColGasto;
        private DevExpress.XtraGrid.Columns.GridColumn ColUtilidad;
    }
}