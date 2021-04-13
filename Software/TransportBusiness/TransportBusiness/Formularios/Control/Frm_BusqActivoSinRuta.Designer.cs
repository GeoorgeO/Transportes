namespace TransportBusiness
{
    partial class Frm_BusqActivoSinRuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BusqActivoSinRuta));
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
            this.Id_Activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Costo_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Alta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Baja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarjeta_Circulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Placas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Tipo_Placa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Tipo_Placa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Tipo_Activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Tipo_Activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Color = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Tipo_Transporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Tipo_Transporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Poliza_Seguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Empresa_Aseguradora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Empresa_Aseguradora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Asignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Folio_Tarjeta_Circulacion = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.lblProveedor.Caption = "Activo:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(929, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 299);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(929, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(71, 299);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(929, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 299);
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
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl1.Size = new System.Drawing.Size(858, 299);
            this.panelControl1.TabIndex = 7;
            // 
            // dtgRutas
            // 
            this.dtgRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRutas.Location = new System.Drawing.Point(7, 7);
            this.dtgRutas.MainView = this.dtgValRutas;
            this.dtgRutas.MenuManager = this.barManager1;
            this.dtgRutas.Name = "dtgRutas";
            this.dtgRutas.Size = new System.Drawing.Size(844, 285);
            this.dtgRutas.TabIndex = 0;
            this.dtgRutas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValRutas});
            this.dtgRutas.Click += new System.EventHandler(this.dtgRutas_Click);
            this.dtgRutas.DoubleClick += new System.EventHandler(this.dtgRutas_DoubleClick);
            // 
            // dtgValRutas
            // 
            this.dtgValRutas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Activo,
            this.Nombre_Interno,
            this.Costo_Unidad,
            this.Fecha_Alta,
            this.Fecha_Baja,
            this.Serie,
            this.Tarjeta_Circulacion,
            this.Placas,
            this.Id_Tipo_Placa,
            this.Nombre_Tipo_Placa,
            this.Id_Tipo_Activo,
            this.Nombre_Tipo_Activo,
            this.Color,
            this.Modelo,
            this.Id_Marca,
            this.Nombre_Marca,
            this.Descripcion,
            this.Id_Tipo_Transporte,
            this.Nombre_Tipo_Transporte,
            this.Poliza_Seguro,
            this.Id_Empresa_Aseguradora,
            this.Nombre_Empresa_Aseguradora,
            this.Status,
            this.Asignado,
            this.Id_Empleado,
            this.Nombre_Empleado,
            this.Id_Empresa,
            this.Nombre_Empresa,
            this.Id_Factura,
            this.Folio_Tarjeta_Circulacion});
            this.dtgValRutas.GridControl = this.dtgRutas;
            this.dtgValRutas.Name = "dtgValRutas";
            this.dtgValRutas.OptionsBehavior.Editable = false;
            this.dtgValRutas.OptionsFind.AlwaysVisible = true;
            this.dtgValRutas.OptionsView.ShowGroupPanel = false;
            // 
            // Id_Activo
            // 
            this.Id_Activo.Caption = "Id Activo";
            this.Id_Activo.FieldName = "Id_Activo";
            this.Id_Activo.Name = "Id_Activo";
            this.Id_Activo.Visible = true;
            this.Id_Activo.VisibleIndex = 0;
            // 
            // Nombre_Interno
            // 
            this.Nombre_Interno.Caption = "Activo";
            this.Nombre_Interno.FieldName = "Nombre_Interno";
            this.Nombre_Interno.Name = "Nombre_Interno";
            this.Nombre_Interno.Visible = true;
            this.Nombre_Interno.VisibleIndex = 1;
            // 
            // Costo_Unidad
            // 
            this.Costo_Unidad.Caption = "Costo Unidad";
            this.Costo_Unidad.FieldName = "Costo_Unidad";
            this.Costo_Unidad.Name = "Costo_Unidad";
            // 
            // Fecha_Alta
            // 
            this.Fecha_Alta.Caption = "Fecha Alta";
            this.Fecha_Alta.FieldName = "Fecha_Alta";
            this.Fecha_Alta.Name = "Fecha_Alta";
            // 
            // Fecha_Baja
            // 
            this.Fecha_Baja.Caption = "Fecha Baja";
            this.Fecha_Baja.FieldName = "Fecha_Baja";
            this.Fecha_Baja.Name = "Fecha_Baja";
            // 
            // Serie
            // 
            this.Serie.Caption = "Serie";
            this.Serie.FieldName = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.Visible = true;
            this.Serie.VisibleIndex = 2;
            // 
            // Tarjeta_Circulacion
            // 
            this.Tarjeta_Circulacion.Caption = "T Circulacion";
            this.Tarjeta_Circulacion.FieldName = "Tarjeta_Circulacion";
            this.Tarjeta_Circulacion.Name = "Tarjeta_Circulacion";
            // 
            // Placas
            // 
            this.Placas.Caption = "Placas";
            this.Placas.FieldName = "Placas";
            this.Placas.Name = "Placas";
            // 
            // Id_Tipo_Placa
            // 
            this.Id_Tipo_Placa.Caption = "Id Tipo Placa";
            this.Id_Tipo_Placa.FieldName = "Id_Tipo_Placa";
            this.Id_Tipo_Placa.Name = "Id_Tipo_Placa";
            // 
            // Nombre_Tipo_Placa
            // 
            this.Nombre_Tipo_Placa.Caption = "Tipo Placa";
            this.Nombre_Tipo_Placa.FieldName = "Nombre_Tipo_Placa";
            this.Nombre_Tipo_Placa.Name = "Nombre_Tipo_Placa";
            // 
            // Id_Tipo_Activo
            // 
            this.Id_Tipo_Activo.Caption = "Id Tipo Activo";
            this.Id_Tipo_Activo.FieldName = "Id_Tipo_Activo";
            this.Id_Tipo_Activo.Name = "Id_Tipo_Activo";
            // 
            // Nombre_Tipo_Activo
            // 
            this.Nombre_Tipo_Activo.Caption = "Tipo Activo";
            this.Nombre_Tipo_Activo.FieldName = "Nombre_Tipo_Activo";
            this.Nombre_Tipo_Activo.Name = "Nombre_Tipo_Activo";
            this.Nombre_Tipo_Activo.Visible = true;
            this.Nombre_Tipo_Activo.VisibleIndex = 3;
            // 
            // Color
            // 
            this.Color.Caption = "Color";
            this.Color.FieldName = "Color";
            this.Color.Name = "Color";
            // 
            // Modelo
            // 
            this.Modelo.Caption = "Modelo";
            this.Modelo.FieldName = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Visible = true;
            this.Modelo.VisibleIndex = 4;
            // 
            // Id_Marca
            // 
            this.Id_Marca.Caption = "Id Marca";
            this.Id_Marca.FieldName = "Id_Marca";
            this.Id_Marca.Name = "Id_Marca";
            // 
            // Nombre_Marca
            // 
            this.Nombre_Marca.Caption = "Marca";
            this.Nombre_Marca.FieldName = "Nombre_Marca";
            this.Nombre_Marca.Name = "Nombre_Marca";
            this.Nombre_Marca.Visible = true;
            this.Nombre_Marca.VisibleIndex = 5;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 6;
            // 
            // Id_Tipo_Transporte
            // 
            this.Id_Tipo_Transporte.Caption = "Id Tipo Transporte";
            this.Id_Tipo_Transporte.FieldName = "Id_Tipo_Transporte";
            this.Id_Tipo_Transporte.Name = "Id_Tipo_Transporte";
            // 
            // Nombre_Tipo_Transporte
            // 
            this.Nombre_Tipo_Transporte.Caption = "Tipo Transporte";
            this.Nombre_Tipo_Transporte.FieldName = "Nombre_Tipo_Transporte";
            this.Nombre_Tipo_Transporte.Name = "Nombre_Tipo_Transporte";
            this.Nombre_Tipo_Transporte.Visible = true;
            this.Nombre_Tipo_Transporte.VisibleIndex = 7;
            // 
            // Poliza_Seguro
            // 
            this.Poliza_Seguro.Caption = "Poliza Seguro";
            this.Poliza_Seguro.FieldName = "Poliza_Seguro";
            this.Poliza_Seguro.Name = "Poliza_Seguro";
            // 
            // Id_Empresa_Aseguradora
            // 
            this.Id_Empresa_Aseguradora.Caption = "Id Aseguradora";
            this.Id_Empresa_Aseguradora.FieldName = "Id_Empresa_Aseguradora";
            this.Id_Empresa_Aseguradora.Name = "Id_Empresa_Aseguradora";
            // 
            // Nombre_Empresa_Aseguradora
            // 
            this.Nombre_Empresa_Aseguradora.Caption = "Aseguradora";
            this.Nombre_Empresa_Aseguradora.FieldName = "Nombre_Empresa_Aseguradora";
            this.Nombre_Empresa_Aseguradora.Name = "Nombre_Empresa_Aseguradora";
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            // 
            // Asignado
            // 
            this.Asignado.Caption = "Asignado";
            this.Asignado.FieldName = "Asignado";
            this.Asignado.Name = "Asignado";
            // 
            // Id_Empleado
            // 
            this.Id_Empleado.Caption = "Id Operador";
            this.Id_Empleado.FieldName = "Id_Empleado";
            this.Id_Empleado.Name = "Id_Empleado";
            // 
            // Nombre_Empleado
            // 
            this.Nombre_Empleado.Caption = "Operador";
            this.Nombre_Empleado.FieldName = "Nombre_Empleado";
            this.Nombre_Empleado.Name = "Nombre_Empleado";
            this.Nombre_Empleado.Visible = true;
            this.Nombre_Empleado.VisibleIndex = 8;
            // 
            // Id_Empresa
            // 
            this.Id_Empresa.Caption = "Id Empresa";
            this.Id_Empresa.FieldName = "Id_Empresa";
            this.Id_Empresa.Name = "Id_Empresa";
            // 
            // Nombre_Empresa
            // 
            this.Nombre_Empresa.Caption = "Empresa";
            this.Nombre_Empresa.FieldName = "Nombre_Empresa";
            this.Nombre_Empresa.Name = "Nombre_Empresa";
            // 
            // Id_Factura
            // 
            this.Id_Factura.Caption = "Id Factura";
            this.Id_Factura.FieldName = "Id_Factura";
            this.Id_Factura.Name = "Id_Factura";
            // 
            // Folio_Tarjeta_Circulacion
            // 
            this.Folio_Tarjeta_Circulacion.Caption = "Tarjeta Circulacion";
            this.Folio_Tarjeta_Circulacion.FieldName = "Folio_Tarjeta_Circulacion";
            this.Folio_Tarjeta_Circulacion.Name = "Folio_Tarjeta_Circulacion";
            // 
            // Frm_BusqActivoSinRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 324);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_BusqActivoSinRuta";
            this.Text = "Frm_BusqActivoSinRuta";
            this.Load += new System.EventHandler(this.Frm_BusqActivoSinRuta_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Interno;
        private DevExpress.XtraGrid.Columns.GridColumn Costo_Unidad;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Alta;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Baja;
        private DevExpress.XtraGrid.Columns.GridColumn Serie;
        private DevExpress.XtraGrid.Columns.GridColumn Tarjeta_Circulacion;
        private DevExpress.XtraGrid.Columns.GridColumn Placas;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Tipo_Placa;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Tipo_Placa;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Tipo_Activo;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Tipo_Activo;
        private DevExpress.XtraGrid.Columns.GridColumn Color;
        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Marca;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Marca;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Tipo_Transporte;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Tipo_Transporte;
        private DevExpress.XtraGrid.Columns.GridColumn Poliza_Seguro;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Empresa_Aseguradora;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Empresa_Aseguradora;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn Asignado;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Factura;
        private DevExpress.XtraGrid.Columns.GridColumn Folio_Tarjeta_Circulacion;
    }
}