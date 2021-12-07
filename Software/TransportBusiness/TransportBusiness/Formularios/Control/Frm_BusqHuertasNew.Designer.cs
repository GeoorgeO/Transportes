namespace TransportBusiness
{
    partial class Frm_BusqHuertasNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BusqHuertasNew));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
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
            this.Id_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Registro_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Duenio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Duenio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Ciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Ciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Calidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Calidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Cultivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Cultivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zona_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.banda_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.este_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.norte_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.asnm_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.latitud_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.longitud_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Activa_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bEstado.Visible = false;
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
            this.barDockControlTop.Size = new System.Drawing.Size(798, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 339);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(71, 339);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 339);
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
            this.panelControl1.Size = new System.Drawing.Size(727, 339);
            this.panelControl1.TabIndex = 9;
            // 
            // dtgRutas
            // 
            this.dtgRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRutas.Location = new System.Drawing.Point(7, 7);
            this.dtgRutas.MainView = this.dtgValRutas;
            this.dtgRutas.MenuManager = this.barManager1;
            this.dtgRutas.Name = "dtgRutas";
            this.dtgRutas.Size = new System.Drawing.Size(713, 325);
            this.dtgRutas.TabIndex = 0;
            this.dtgRutas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValRutas});
            this.dtgRutas.Click += new System.EventHandler(this.dtgRutas_Click);
            // 
            // dtgValRutas
            // 
            this.dtgValRutas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Huerta,
            this.Nombre_Huerta,
            this.Registro_Huerta,
            this.Id_Duenio,
            this.Nombre_Duenio,
            this.Id_Estado,
            this.Nombre_Estado,
            this.Id_Ciudad,
            this.Nombre_Ciudad,
            this.Id_Calidad,
            this.Nombre_Calidad,
            this.Id_Cultivo,
            this.Nombre_Cultivo,
            this.zona_Huerta,
            this.banda_Huerta,
            this.este_Huerta,
            this.norte_Huerta,
            this.asnm_Huerta,
            this.latitud_Huerta,
            this.longitud_Huerta,
            this.Activa_Huerta});
            this.dtgValRutas.GridControl = this.dtgRutas;
            this.dtgValRutas.Name = "dtgValRutas";
            this.dtgValRutas.OptionsBehavior.Editable = false;
            this.dtgValRutas.OptionsFind.AlwaysVisible = true;
            this.dtgValRutas.OptionsView.ShowGroupPanel = false;
            // 
            // Id_Huerta
            // 
            this.Id_Huerta.Caption = "Id_Huerta";
            this.Id_Huerta.FieldName = "Id_Huerta";
            this.Id_Huerta.Name = "Id_Huerta";
            this.Id_Huerta.Visible = true;
            this.Id_Huerta.VisibleIndex = 0;
            // 
            // Nombre_Huerta
            // 
            this.Nombre_Huerta.Caption = "Nombre_Huerta";
            this.Nombre_Huerta.FieldName = "Nombre_Huerta";
            this.Nombre_Huerta.Name = "Nombre_Huerta";
            this.Nombre_Huerta.Visible = true;
            this.Nombre_Huerta.VisibleIndex = 1;
            // 
            // Registro_Huerta
            // 
            this.Registro_Huerta.Caption = "Registro_Huerta";
            this.Registro_Huerta.FieldName = "Registro_Huerta";
            this.Registro_Huerta.Name = "Registro_Huerta";
            this.Registro_Huerta.Visible = true;
            this.Registro_Huerta.VisibleIndex = 2;
            // 
            // Id_Duenio
            // 
            this.Id_Duenio.Caption = "Id_Duenio";
            this.Id_Duenio.FieldName = "Id_Duenio";
            this.Id_Duenio.Name = "Id_Duenio";
            // 
            // Nombre_Duenio
            // 
            this.Nombre_Duenio.Caption = "Nombre_Duenio";
            this.Nombre_Duenio.FieldName = "Nombre_Duenio";
            this.Nombre_Duenio.Name = "Nombre_Duenio";
            this.Nombre_Duenio.Visible = true;
            this.Nombre_Duenio.VisibleIndex = 3;
            // 
            // Id_Estado
            // 
            this.Id_Estado.Caption = "Id_Estado";
            this.Id_Estado.FieldName = "Id_Estado";
            this.Id_Estado.Name = "Id_Estado";
            // 
            // Nombre_Estado
            // 
            this.Nombre_Estado.Caption = "Nombre_Estado";
            this.Nombre_Estado.FieldName = "Nombre_Estado";
            this.Nombre_Estado.Name = "Nombre_Estado";
            this.Nombre_Estado.Visible = true;
            this.Nombre_Estado.VisibleIndex = 4;
            // 
            // Id_Ciudad
            // 
            this.Id_Ciudad.Caption = "Id_Ciudad";
            this.Id_Ciudad.FieldName = "Id_Ciudad";
            this.Id_Ciudad.Name = "Id_Ciudad";
            // 
            // Nombre_Ciudad
            // 
            this.Nombre_Ciudad.Caption = "Nombre_Ciudad";
            this.Nombre_Ciudad.FieldName = "Nombre_Ciudad";
            this.Nombre_Ciudad.Name = "Nombre_Ciudad";
            this.Nombre_Ciudad.Visible = true;
            this.Nombre_Ciudad.VisibleIndex = 5;
            // 
            // Id_Calidad
            // 
            this.Id_Calidad.Caption = "Id_Calidad";
            this.Id_Calidad.FieldName = "Id_Calidad";
            this.Id_Calidad.Name = "Id_Calidad";
            // 
            // Nombre_Calidad
            // 
            this.Nombre_Calidad.Caption = "Nombre_Calidad";
            this.Nombre_Calidad.FieldName = "Nombre_Calidad";
            this.Nombre_Calidad.Name = "Nombre_Calidad";
            this.Nombre_Calidad.Visible = true;
            this.Nombre_Calidad.VisibleIndex = 6;
            // 
            // Id_Cultivo
            // 
            this.Id_Cultivo.Caption = "Id_Cultivo";
            this.Id_Cultivo.FieldName = "Id_Cultivo";
            this.Id_Cultivo.Name = "Id_Cultivo";
            // 
            // Nombre_Cultivo
            // 
            this.Nombre_Cultivo.Caption = "Nombre_Cultivo";
            this.Nombre_Cultivo.FieldName = "Nombre_Cultivo";
            this.Nombre_Cultivo.Name = "Nombre_Cultivo";
            this.Nombre_Cultivo.Visible = true;
            this.Nombre_Cultivo.VisibleIndex = 7;
            // 
            // zona_Huerta
            // 
            this.zona_Huerta.Caption = "zona_Huerta";
            this.zona_Huerta.FieldName = "zona_Huerta";
            this.zona_Huerta.Name = "zona_Huerta";
            this.zona_Huerta.Visible = true;
            this.zona_Huerta.VisibleIndex = 8;
            // 
            // banda_Huerta
            // 
            this.banda_Huerta.Caption = "banda_Huerta";
            this.banda_Huerta.FieldName = "banda_Huerta";
            this.banda_Huerta.Name = "banda_Huerta";
            this.banda_Huerta.Visible = true;
            this.banda_Huerta.VisibleIndex = 9;
            // 
            // este_Huerta
            // 
            this.este_Huerta.Caption = "este_Huerta";
            this.este_Huerta.FieldName = "este_Huerta";
            this.este_Huerta.Name = "este_Huerta";
            // 
            // norte_Huerta
            // 
            this.norte_Huerta.Caption = "norte_Huerta";
            this.norte_Huerta.FieldName = "norte_Huerta";
            this.norte_Huerta.Name = "norte_Huerta";
            // 
            // asnm_Huerta
            // 
            this.asnm_Huerta.Caption = "asnm_Huerta";
            this.asnm_Huerta.FieldName = "asnm_Huerta";
            this.asnm_Huerta.Name = "asnm_Huerta";
            // 
            // latitud_Huerta
            // 
            this.latitud_Huerta.Caption = "latitud_Huerta";
            this.latitud_Huerta.FieldName = "latitud_Huerta";
            this.latitud_Huerta.Name = "latitud_Huerta";
            // 
            // longitud_Huerta
            // 
            this.longitud_Huerta.Caption = "longitud_Huerta";
            this.longitud_Huerta.FieldName = "longitud_Huerta";
            this.longitud_Huerta.Name = "longitud_Huerta";
            // 
            // Activa_Huerta
            // 
            this.Activa_Huerta.Caption = "Activa_Huerta";
            this.Activa_Huerta.FieldName = "Activa_Huerta";
            this.Activa_Huerta.Name = "Activa_Huerta";
            // 
            // Frm_BusqHuertasNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 364);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_BusqHuertasNew";
            this.Text = "Frm_BusqHuertasNew";
            
            this.Load += new System.EventHandler(this.Frm_BusqHuertasNew_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn Id_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn Registro_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Duenio;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Duenio;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Ciudad;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Ciudad;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Calidad;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Calidad;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Cultivo;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Cultivo;
        private DevExpress.XtraGrid.Columns.GridColumn zona_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn banda_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn este_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn norte_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn asnm_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn latitud_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn longitud_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn Activa_Huerta;
    }
}