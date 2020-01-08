namespace TransportBusiness
{
    partial class Frm_Entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Entradas));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnEliminar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBusqSalida = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaEntrada = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textSalida = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textActivoAdicional = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textActivoSec = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textActivoPrincipal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEntrada = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_Entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEntrada.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textActivoAdicional.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textActivoSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textActivoPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btnEliminar,
            this.btnSalir});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 64;
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
            // 
            // lblProveedor
            // 
            this.lblProveedor.Caption = "Entradas:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(827, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 418);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(827, 35);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(65, 418);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(827, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 418);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 57;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(65, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(12);
            this.panelControl1.Size = new System.Drawing.Size(762, 236);
            this.panelControl1.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnBusqSalida);
            this.groupControl1.Controls.Add(this.dtFechaEntrada);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textSalida);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textActivoAdicional);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textActivoSec);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textActivoPrincipal);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEntrada);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(14, 14);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(734, 208);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Entrada Activos en Ruta";
            // 
            // btnBusqSalida
            // 
            this.btnBusqSalida.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBusqSalida.ImageOptions.Image")));
            this.btnBusqSalida.Location = new System.Drawing.Point(255, 74);
            this.btnBusqSalida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBusqSalida.Name = "btnBusqSalida";
            this.btnBusqSalida.Size = new System.Drawing.Size(28, 28);
            this.btnBusqSalida.TabIndex = 81;
            this.btnBusqSalida.Click += new System.EventHandler(this.btnBusqSalida_Click_1);
            // 
            // dtFechaEntrada
            // 
            this.dtFechaEntrada.EditValue = null;
            this.dtFechaEntrada.Location = new System.Drawing.Point(369, 43);
            this.dtFechaEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaEntrada.MenuManager = this.barManager1;
            this.dtFechaEntrada.Name = "dtFechaEntrada";
            this.dtFechaEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEntrada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEntrada.Size = new System.Drawing.Size(104, 22);
            this.dtFechaEntrada.TabIndex = 80;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(297, 49);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 16);
            this.labelControl6.TabIndex = 79;
            this.labelControl6.Text = "F. Entrada:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 81);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 16);
            this.labelControl5.TabIndex = 78;
            this.labelControl5.Text = "Folio Salida:";
            // 
            // textSalida
            // 
            this.textSalida.Enabled = false;
            this.textSalida.Location = new System.Drawing.Point(141, 75);
            this.textSalida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSalida.MenuManager = this.barManager1;
            this.textSalida.Name = "textSalida";
            this.textSalida.Size = new System.Drawing.Size(107, 22);
            this.textSalida.TabIndex = 77;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 177);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 16);
            this.labelControl4.TabIndex = 75;
            this.labelControl4.Text = "Activo Adcional:";
            // 
            // textActivoAdicional
            // 
            this.textActivoAdicional.Enabled = false;
            this.textActivoAdicional.Location = new System.Drawing.Point(141, 171);
            this.textActivoAdicional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textActivoAdicional.MenuManager = this.barManager1;
            this.textActivoAdicional.Name = "textActivoAdicional";
            this.textActivoAdicional.Size = new System.Drawing.Size(273, 22);
            this.textActivoAdicional.TabIndex = 74;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 145);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 16);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "Activo Secundario:";
            // 
            // textActivoSec
            // 
            this.textActivoSec.Enabled = false;
            this.textActivoSec.Location = new System.Drawing.Point(141, 139);
            this.textActivoSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textActivoSec.MenuManager = this.barManager1;
            this.textActivoSec.Name = "textActivoSec";
            this.textActivoSec.Size = new System.Drawing.Size(273, 22);
            this.textActivoSec.TabIndex = 72;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 113);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 16);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "Activo Principal:";
            // 
            // textActivoPrincipal
            // 
            this.textActivoPrincipal.Enabled = false;
            this.textActivoPrincipal.Location = new System.Drawing.Point(141, 107);
            this.textActivoPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textActivoPrincipal.MenuManager = this.barManager1;
            this.textActivoPrincipal.Name = "textActivoPrincipal";
            this.textActivoPrincipal.Size = new System.Drawing.Size(273, 22);
            this.textActivoPrincipal.TabIndex = 70;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 16);
            this.labelControl1.TabIndex = 69;
            this.labelControl1.Text = "Folio Entrada:";
            // 
            // textEntrada
            // 
            this.textEntrada.Enabled = false;
            this.textEntrada.Location = new System.Drawing.Point(141, 43);
            this.textEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEntrada.MenuManager = this.barManager1;
            this.textEntrada.Name = "textEntrada";
            this.textEntrada.Size = new System.Drawing.Size(107, 22);
            this.textEntrada.TabIndex = 68;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(65, 236);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(12);
            this.panelControl2.Size = new System.Drawing.Size(762, 182);
            this.panelControl2.TabIndex = 18;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(14, 14);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(734, 154);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Entrada,
            this.Id_Salida,
            this.Id_Activo_P,
            this.Nombre_Activo_P,
            this.Id_Activo_1,
            this.Nombre_Activo_1,
            this.Id_Activo_2,
            this.Nombre_Activo_2,
            this.Fecha_Entrada});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Id_Entrada
            // 
            this.Id_Entrada.Caption = "Entrada";
            this.Id_Entrada.FieldName = "Id_Entrada";
            this.Id_Entrada.Name = "Id_Entrada";
            this.Id_Entrada.Visible = true;
            this.Id_Entrada.VisibleIndex = 1;
            // 
            // Id_Salida
            // 
            this.Id_Salida.Caption = "Salida";
            this.Id_Salida.FieldName = "Id_Salida";
            this.Id_Salida.Name = "Id_Salida";
            this.Id_Salida.Visible = true;
            this.Id_Salida.VisibleIndex = 2;
            // 
            // Id_Activo_P
            // 
            this.Id_Activo_P.Caption = "Id Activo P";
            this.Id_Activo_P.FieldName = "Id_Activo_P";
            this.Id_Activo_P.Name = "Id_Activo_P";
            // 
            // Nombre_Activo_P
            // 
            this.Nombre_Activo_P.Caption = "Activo Principal";
            this.Nombre_Activo_P.FieldName = "Nombre_Activo_P";
            this.Nombre_Activo_P.Name = "Nombre_Activo_P";
            this.Nombre_Activo_P.Visible = true;
            this.Nombre_Activo_P.VisibleIndex = 3;
            // 
            // Id_Activo_1
            // 
            this.Id_Activo_1.Caption = "Id Activo 1";
            this.Id_Activo_1.FieldName = "Id_Activo_1";
            this.Id_Activo_1.Name = "Id_Activo_1";
            // 
            // Nombre_Activo_1
            // 
            this.Nombre_Activo_1.Caption = "Activo Secundario";
            this.Nombre_Activo_1.FieldName = "Nombre_Activo_1";
            this.Nombre_Activo_1.Name = "Nombre_Activo_1";
            this.Nombre_Activo_1.Visible = true;
            this.Nombre_Activo_1.VisibleIndex = 4;
            // 
            // Id_Activo_2
            // 
            this.Id_Activo_2.Caption = "Id Activo 2";
            this.Id_Activo_2.FieldName = "Id_Activo_2";
            this.Id_Activo_2.Name = "Id_Activo_2";
            // 
            // Nombre_Activo_2
            // 
            this.Nombre_Activo_2.Caption = "Activo Adicional";
            this.Nombre_Activo_2.FieldName = "Nombre_Activo_2";
            this.Nombre_Activo_2.Name = "Nombre_Activo_2";
            this.Nombre_Activo_2.Visible = true;
            this.Nombre_Activo_2.VisibleIndex = 5;
            // 
            // Fecha_Entrada
            // 
            this.Fecha_Entrada.Caption = "F Entrada";
            this.Fecha_Entrada.FieldName = "Fecha_Entrada";
            this.Fecha_Entrada.Name = "Fecha_Entrada";
            this.Fecha_Entrada.Visible = true;
            this.Fecha_Entrada.VisibleIndex = 0;
            // 
            // Frm_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 453);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Entradas";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Frm_Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEntrada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textActivoAdicional.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textActivoSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textActivoPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textSalida;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textActivoAdicional;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textActivoSec;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textActivoPrincipal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEntrada;
        private DevExpress.XtraEditors.DateEdit dtFechaEntrada;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnBusqSalida;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Entrada;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Salida;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_P;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_P;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_1;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_1;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_2;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_2;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Entrada;
    }
}