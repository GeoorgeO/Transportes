namespace TransportBusiness
{
    partial class Frm_Gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gastos));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_Gasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Gasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_GastoIndirecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_GastoIndirecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Importe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo_Cambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Concepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textFactura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textCtas = new DevExpress.XtraEditors.TextEdit();
            this.btnCtas = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textConcepto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textGastosIndirectos = new DevExpress.XtraEditors.TextEdit();
            this.btnGastosIndirectos = new DevExpress.XtraEditors.SimpleButton();
            this.dateFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textImporte = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Nombre_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCtas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGastosIndirectos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).BeginInit();
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
            this.btnGuardar,
            this.btnSalir,
            this.btnEliminar,
            this.barLargeButtonItem1});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 67;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
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
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 53;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 65;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Importar";
            this.barLargeButtonItem1.Id = 66;
            this.barLargeButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.Image")));
            this.barLargeButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 63;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
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
            this.bEstado.Visible = false;
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
            this.barDockControlTop.Size = new System.Drawing.Size(684, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(684, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(59, 461);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(684, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(59, 156);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl2.Size = new System.Drawing.Size(625, 305);
            this.panelControl2.TabIndex = 21;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(7, 7);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(611, 291);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Gasto,
            this.Fecha_Gasto,
            this.Id_GastoIndirecto,
            this.Nombre_GastoIndirecto,
            this.Importe,
            this.Tipo_Cambio,
            this.Concepto,
            this.Factura,
            this.Id_Cuenta,
            this.Nombre_cuenta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Id_Gasto
            // 
            this.Id_Gasto.Caption = "Id Gasto";
            this.Id_Gasto.FieldName = "Id_Gasto";
            this.Id_Gasto.Name = "Id_Gasto";
            this.Id_Gasto.Visible = true;
            this.Id_Gasto.VisibleIndex = 0;
            // 
            // Fecha_Gasto
            // 
            this.Fecha_Gasto.Caption = "Fecha";
            this.Fecha_Gasto.FieldName = "Fecha_Gasto";
            this.Fecha_Gasto.Name = "Fecha_Gasto";
            this.Fecha_Gasto.Visible = true;
            this.Fecha_Gasto.VisibleIndex = 1;
            // 
            // Id_GastoIndirecto
            // 
            this.Id_GastoIndirecto.Caption = "Id Gasto";
            this.Id_GastoIndirecto.FieldName = "Id_GastoIndirecto";
            this.Id_GastoIndirecto.Name = "Id_GastoIndirecto";
            this.Id_GastoIndirecto.Visible = true;
            this.Id_GastoIndirecto.VisibleIndex = 2;
            // 
            // Nombre_GastoIndirecto
            // 
            this.Nombre_GastoIndirecto.Caption = "Gasto";
            this.Nombre_GastoIndirecto.FieldName = "Nombre_GastoIndirecto";
            this.Nombre_GastoIndirecto.Name = "Nombre_GastoIndirecto";
            this.Nombre_GastoIndirecto.Visible = true;
            this.Nombre_GastoIndirecto.VisibleIndex = 3;
            // 
            // Importe
            // 
            this.Importe.Caption = "Importe";
            this.Importe.FieldName = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:#.##}")});
            this.Importe.Visible = true;
            this.Importe.VisibleIndex = 4;
            // 
            // Tipo_Cambio
            // 
            this.Tipo_Cambio.Caption = "T.C.";
            this.Tipo_Cambio.FieldName = "Tipo_Cambio";
            this.Tipo_Cambio.Name = "Tipo_Cambio";
            this.Tipo_Cambio.Visible = true;
            this.Tipo_Cambio.VisibleIndex = 5;
            // 
            // Concepto
            // 
            this.Concepto.Caption = "Concepto";
            this.Concepto.FieldName = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.Visible = true;
            this.Concepto.VisibleIndex = 6;
            // 
            // Factura
            // 
            this.Factura.Caption = "Factura";
            this.Factura.FieldName = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.Visible = true;
            this.Factura.VisibleIndex = 7;
            // 
            // Id_Cuenta
            // 
            this.Id_Cuenta.Caption = "Id_Cuenta";
            this.Id_Cuenta.FieldName = "Id_Cuenta";
            this.Id_Cuenta.Name = "Id_Cuenta";
            this.Id_Cuenta.Visible = true;
            this.Id_Cuenta.VisibleIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(59, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl1.Size = new System.Drawing.Size(625, 156);
            this.panelControl1.TabIndex = 20;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textFactura);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.textCtas);
            this.groupControl1.Controls.Add(this.btnCtas);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.textConcepto);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textTC);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textGastosIndirectos);
            this.groupControl1.Controls.Add(this.btnGastosIndirectos);
            this.groupControl1.Controls.Add(this.dateFecha);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textImporte);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 132);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Estado";
            // 
            // textFactura
            // 
            this.textFactura.Location = new System.Drawing.Point(75, 104);
            this.textFactura.MenuManager = this.barManager1;
            this.textFactura.Name = "textFactura";
            this.textFactura.Size = new System.Drawing.Size(100, 20);
            this.textFactura.TabIndex = 22;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 106);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 13);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Factura:";
            // 
            // textCtas
            // 
            this.textCtas.Enabled = false;
            this.textCtas.Location = new System.Drawing.Point(105, 78);
            this.textCtas.MenuManager = this.barManager1;
            this.textCtas.Name = "textCtas";
            this.textCtas.Size = new System.Drawing.Size(296, 20);
            this.textCtas.TabIndex = 20;
            // 
            // btnCtas
            // 
            this.btnCtas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCtas.Location = new System.Drawing.Point(76, 76);
            this.btnCtas.Name = "btnCtas";
            this.btnCtas.Size = new System.Drawing.Size(24, 23);
            this.btnCtas.TabIndex = 19;
            this.btnCtas.Click += new System.EventHandler(this.btnCtas_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(19, 82);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Cta. Cont.:";
            // 
            // textConcepto
            // 
            this.textConcepto.Location = new System.Drawing.Point(75, 52);
            this.textConcepto.MenuManager = this.barManager1;
            this.textConcepto.Name = "textConcepto";
            this.textConcepto.Size = new System.Drawing.Size(326, 20);
            this.textConcepto.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Concepto:";
            // 
            // textTC
            // 
            this.textTC.Location = new System.Drawing.Point(402, 104);
            this.textTC.MenuManager = this.barManager1;
            this.textTC.Name = "textTC";
            this.textTC.Size = new System.Drawing.Size(100, 20);
            this.textTC.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(374, 106);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "T.C.:";
            // 
            // textGastosIndirectos
            // 
            this.textGastosIndirectos.Enabled = false;
            this.textGastosIndirectos.Location = new System.Drawing.Point(302, 115);
            this.textGastosIndirectos.MenuManager = this.barManager1;
            this.textGastosIndirectos.Name = "textGastosIndirectos";
            this.textGastosIndirectos.Size = new System.Drawing.Size(296, 20);
            this.textGastosIndirectos.TabIndex = 13;
            this.textGastosIndirectos.Visible = false;
            // 
            // btnGastosIndirectos
            // 
            this.btnGastosIndirectos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGastosIndirectos.ImageOptions.Image")));
            this.btnGastosIndirectos.Location = new System.Drawing.Point(273, 113);
            this.btnGastosIndirectos.Name = "btnGastosIndirectos";
            this.btnGastosIndirectos.Size = new System.Drawing.Size(24, 23);
            this.btnGastosIndirectos.TabIndex = 12;
            this.btnGastosIndirectos.Visible = false;
            this.btnGastosIndirectos.Click += new System.EventHandler(this.btnGastosIndirectos_Click);
            // 
            // dateFecha
            // 
            this.dateFecha.EditValue = null;
            this.dateFecha.Location = new System.Drawing.Point(402, 26);
            this.dateFecha.MenuManager = this.barManager1;
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFecha.Size = new System.Drawing.Size(100, 20);
            this.dateFecha.TabIndex = 10;
            this.dateFecha.EditValueChanged += new System.EventHandler(this.dateFecha_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(336, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Fecha gasto:";
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(247, 104);
            this.textImporte.MenuManager = this.barManager1;
            this.textImporte.Name = "textImporte";
            this.textImporte.Properties.Mask.EditMask = "n";
            this.textImporte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textImporte.Size = new System.Drawing.Size(100, 20);
            this.textImporte.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(199, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Importe:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(216, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Gasto Ind.:";
            this.labelControl2.Visible = false;
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(75, 26);
            this.textId.MenuManager = this.barManager1;
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id Gasto: ";
            // 
            // Nombre_cuenta
            // 
            this.Nombre_cuenta.Caption = "cuenta";
            this.Nombre_cuenta.FieldName = "Nombre_cuenta";
            this.Nombre_cuenta.Name = "Nombre_cuenta";
            this.Nombre_cuenta.Visible = true;
            this.Nombre_cuenta.VisibleIndex = 9;
            // 
            // Frm_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 486);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Gastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.Frm_Gastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCtas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGastosIndirectos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnLimpiar;
        private DevExpress.XtraBars.BarLargeButtonItem btnGuardar;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Gasto;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Gasto;
        private DevExpress.XtraGrid.Columns.GridColumn Id_GastoIndirecto;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_GastoIndirecto;
        private DevExpress.XtraGrid.Columns.GridColumn Importe;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo_Cambio;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textTC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textGastosIndirectos;
        private DevExpress.XtraEditors.SimpleButton btnGastosIndirectos;
        private DevExpress.XtraEditors.DateEdit dateFecha;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textImporte;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarLargeButtonItem btnEliminar;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraEditors.TextEdit textFactura;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textCtas;
        private DevExpress.XtraEditors.SimpleButton btnCtas;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textConcepto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn Concepto;
        private DevExpress.XtraGrid.Columns.GridColumn Factura;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_cuenta;
    }
}