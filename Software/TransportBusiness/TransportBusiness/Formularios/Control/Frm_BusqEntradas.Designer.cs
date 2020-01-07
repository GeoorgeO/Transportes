namespace TransportBusiness
{
    partial class Frm_BusqEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BusqEntradas));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnSeleccionar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dtgRutas = new DevExpress.XtraGrid.GridControl();
            this.dtgValRutas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_Entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Cruce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValRutas)).BeginInit();
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
            this.btnSalir,
            this.btnSeleccionar});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 65;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSeleccionar),
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.Caption = "Seleccionar";
            this.btnSeleccionar.Id = 64;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.LargeImage")));
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSeleccionar_ItemClick);
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
            this.lblProveedor.Caption = "Salida:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(669, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 310);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(669, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(71, 310);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(669, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 310);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Caption = "Limpiar";
            this.btnLimpiar.Id = 50;
            this.btnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.Image")));
            this.btnLimpiar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.LargeImage")));
            this.btnLimpiar.Name = "btnLimpiar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 53;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
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
            this.panelControl1.Controls.Add(this.dtgRutas);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(71, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(598, 310);
            this.panelControl1.TabIndex = 8;
            // 
            // dtgRutas
            // 
            this.dtgRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRutas.Location = new System.Drawing.Point(7, 7);
            this.dtgRutas.MainView = this.dtgValRutas;
            this.dtgRutas.MenuManager = this.barManager1;
            this.dtgRutas.Name = "dtgRutas";
            this.dtgRutas.Size = new System.Drawing.Size(584, 296);
            this.dtgRutas.TabIndex = 0;
            this.dtgRutas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValRutas});
            this.dtgRutas.Click += new System.EventHandler(this.dtgRutas_Click);
            // 
            // dtgValRutas
            // 
            this.dtgValRutas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Entrada,
            this.Id_Salida,
            this.Fecha_Entrada,
            this.Fecha_Cruce,
            this.Id_Activo_P,
            this.Nombre_Activo_P,
            this.Id_Activo_1,
            this.Nombre_Activo_1,
            this.Id_Activo_2,
            this.Nombre_Activo_2});
            this.dtgValRutas.GridControl = this.dtgRutas;
            this.dtgValRutas.Name = "dtgValRutas";
            this.dtgValRutas.OptionsBehavior.Editable = false;
            this.dtgValRutas.OptionsFind.AlwaysVisible = true;
            this.dtgValRutas.OptionsView.ShowGroupPanel = false;
            // 
            // Id_Entrada
            // 
            this.Id_Entrada.Caption = "Id Entrada";
            this.Id_Entrada.FieldName = "Id_Entrada";
            this.Id_Entrada.Name = "Id_Entrada";
            this.Id_Entrada.Visible = true;
            this.Id_Entrada.VisibleIndex = 0;
            // 
            // Id_Salida
            // 
            this.Id_Salida.Caption = "Id Salida";
            this.Id_Salida.FieldName = "Id_Salida";
            this.Id_Salida.Name = "Id_Salida";
            this.Id_Salida.Visible = true;
            this.Id_Salida.VisibleIndex = 1;
            // 
            // Fecha_Entrada
            // 
            this.Fecha_Entrada.Caption = "Fecha Entrada";
            this.Fecha_Entrada.FieldName = "Fecha_Entrada";
            this.Fecha_Entrada.Name = "Fecha_Entrada";
            this.Fecha_Entrada.Visible = true;
            this.Fecha_Entrada.VisibleIndex = 2;
            // 
            // Fecha_Cruce
            // 
            this.Fecha_Cruce.Caption = "Fecha_Cruce";
            this.Fecha_Cruce.FieldName = "Fecha_Cruce";
            this.Fecha_Cruce.Name = "Fecha_Cruce";
            this.Fecha_Cruce.Visible = true;
            this.Fecha_Cruce.VisibleIndex = 3;
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
            this.Nombre_Activo_P.VisibleIndex = 4;
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
            this.Nombre_Activo_1.VisibleIndex = 5;
            // 
            // Nombre_Activo_2
            // 
            this.Nombre_Activo_2.Caption = "Activo Adicional";
            this.Nombre_Activo_2.FieldName = "Nombre_Activo_2";
            this.Nombre_Activo_2.Name = "Nombre_Activo_2";
            this.Nombre_Activo_2.Visible = true;
            this.Nombre_Activo_2.VisibleIndex = 6;
            // 
            // Id_Activo_2
            // 
            this.Id_Activo_2.Caption = "Id Activo 2";
            this.Id_Activo_2.FieldName = "Id_Activo_2";
            this.Id_Activo_2.Name = "Id_Activo_2";
            // 
            // Frm_BusqEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 335);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_BusqEntradas";
            this.Text = "Busqueda de Entradas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_BusqEntradas_FormClosed);
            this.Load += new System.EventHandler(this.Frm_BusqEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnSeleccionar;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnLimpiar;
        private DevExpress.XtraBars.BarLargeButtonItem btnGuardar;
        private DevExpress.XtraBars.BarLargeButtonItem btnEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dtgRutas;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValRutas;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Entrada;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Salida;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Entrada;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Cruce;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_P;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_P;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_1;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_1;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_2;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_2;
    }
}