namespace TransportBusiness
{
    partial class Frm_BusqSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BusqSalidas));
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
            this.Id_Salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_Principal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_Principal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Operador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Operador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Ayudante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Ayudante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_Secundario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_Secundario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Activo_Adicional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Activo_Adicional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Ruta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Ruta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_MotivoSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_MotivoSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.km_Inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.km_Fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dias_Viaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lts_Km = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EsNacional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_ClienteAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_ClienteAd = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.dtgRutas.DoubleClick += new System.EventHandler(this.dtgRutas_DoubleClick);
            // 
            // dtgValRutas
            // 
            this.dtgValRutas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Salida,
            this.Fecha_Salida,
            this.Id_Activo_Principal,
            this.Nombre_Activo_Principal,
            this.Id_Operador,
            this.Nombre_Operador,
            this.Id_Ayudante,
            this.Nombre_Ayudante,
            this.Id_Activo_Secundario,
            this.Nombre_Activo_Secundario,
            this.Id_Activo_Adicional,
            this.Nombre_Activo_Adicional,
            this.Id_Ruta,
            this.Nombre_Ruta,
            this.Origen,
            this.Destino,
            this.Id_MotivoSalida,
            this.Nombre_MotivoSalida,
            this.Id_Cliente,
            this.Nombre_Cliente,
            this.km_Inicio,
            this.km_Fin,
            this.Dias_Viaje,
            this.Lts_Km,
            this.Id_Huerta,
            this.Nombre_Huerta,
            this.Observaciones,
            this.EsNacional,
            this.Id_ClienteAd,
            this.Nombre_ClienteAd});
            this.dtgValRutas.GridControl = this.dtgRutas;
            this.dtgValRutas.Name = "dtgValRutas";
            this.dtgValRutas.OptionsBehavior.Editable = false;
            this.dtgValRutas.OptionsFind.AlwaysVisible = true;
            this.dtgValRutas.OptionsView.ShowGroupPanel = false;
            // 
            // Id_Salida
            // 
            this.Id_Salida.Caption = "Id Salida";
            this.Id_Salida.FieldName = "Id_Salida";
            this.Id_Salida.Name = "Id_Salida";
            this.Id_Salida.Visible = true;
            this.Id_Salida.VisibleIndex = 0;
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.Caption = "Fecha Salida";
            this.Fecha_Salida.FieldName = "Fecha_Salida";
            this.Fecha_Salida.Name = "Fecha_Salida";
            this.Fecha_Salida.Visible = true;
            this.Fecha_Salida.VisibleIndex = 1;
            // 
            // Id_Activo_Principal
            // 
            this.Id_Activo_Principal.Caption = "Id ActivoPrincipal";
            this.Id_Activo_Principal.FieldName = "Id_Activo_Principal";
            this.Id_Activo_Principal.Name = "Id_Activo_Principal";
            // 
            // Nombre_Activo_Principal
            // 
            this.Nombre_Activo_Principal.Caption = "Activo";
            this.Nombre_Activo_Principal.FieldName = "Nombre_Activo_Principal";
            this.Nombre_Activo_Principal.Name = "Nombre_Activo_Principal";
            this.Nombre_Activo_Principal.Visible = true;
            this.Nombre_Activo_Principal.VisibleIndex = 2;
            // 
            // Id_Operador
            // 
            this.Id_Operador.Caption = "Id Operador";
            this.Id_Operador.FieldName = "Id_Operador";
            this.Id_Operador.Name = "Id_Operador";
            // 
            // Nombre_Operador
            // 
            this.Nombre_Operador.Caption = "Operador";
            this.Nombre_Operador.FieldName = "Nombre_Operador";
            this.Nombre_Operador.Name = "Nombre_Operador";
            this.Nombre_Operador.Visible = true;
            this.Nombre_Operador.VisibleIndex = 3;
            // 
            // Id_Ayudante
            // 
            this.Id_Ayudante.Caption = "Id Ayudante";
            this.Id_Ayudante.FieldName = "Id_Ayudante";
            this.Id_Ayudante.Name = "Id_Ayudante";
            // 
            // Nombre_Ayudante
            // 
            this.Nombre_Ayudante.Caption = "Ayudante";
            this.Nombre_Ayudante.FieldName = "Nombre_Ayudante";
            this.Nombre_Ayudante.Name = "Nombre_Ayudante";
            // 
            // Id_Activo_Secundario
            // 
            this.Id_Activo_Secundario.Caption = "Id ActivoSecundario";
            this.Id_Activo_Secundario.FieldName = "Id_Activo_Secundario";
            this.Id_Activo_Secundario.Name = "Id_Activo_Secundario";
            // 
            // Nombre_Activo_Secundario
            // 
            this.Nombre_Activo_Secundario.Caption = "Activo Secundario";
            this.Nombre_Activo_Secundario.FieldName = "Nombre_Activo_Secundario";
            this.Nombre_Activo_Secundario.Name = "Nombre_Activo_Secundario";
            // 
            // Id_Activo_Adicional
            // 
            this.Id_Activo_Adicional.Caption = "Id ActivoAdicional";
            this.Id_Activo_Adicional.FieldName = "Id_Activo_Adicional";
            this.Id_Activo_Adicional.Name = "Id_Activo_Adicional";
            // 
            // Nombre_Activo_Adicional
            // 
            this.Nombre_Activo_Adicional.Caption = "Activo Adicional";
            this.Nombre_Activo_Adicional.FieldName = "Nombre_Activo_Adicional";
            this.Nombre_Activo_Adicional.Name = "Nombre_Activo_Adicional";
            // 
            // Id_Ruta
            // 
            this.Id_Ruta.Caption = "Id Ruta";
            this.Id_Ruta.FieldName = "Id_Ruta";
            this.Id_Ruta.Name = "Id_Ruta";
            // 
            // Nombre_Ruta
            // 
            this.Nombre_Ruta.Caption = "Ruta";
            this.Nombre_Ruta.FieldName = "Nombre_Ruta";
            this.Nombre_Ruta.Name = "Nombre_Ruta";
            // 
            // Origen
            // 
            this.Origen.Caption = "Origen";
            this.Origen.FieldName = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.Visible = true;
            this.Origen.VisibleIndex = 4;
            // 
            // Destino
            // 
            this.Destino.Caption = "Destino";
            this.Destino.FieldName = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.Visible = true;
            this.Destino.VisibleIndex = 5;
            // 
            // Id_MotivoSalida
            // 
            this.Id_MotivoSalida.Caption = "Id MotivoSalida";
            this.Id_MotivoSalida.FieldName = "Id_MotivoSalida";
            this.Id_MotivoSalida.Name = "Id_MotivoSalida";
            // 
            // Nombre_MotivoSalida
            // 
            this.Nombre_MotivoSalida.Caption = "Motivo Salida";
            this.Nombre_MotivoSalida.FieldName = "Nombre_MotivoSalida";
            this.Nombre_MotivoSalida.Name = "Nombre_MotivoSalida";
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.Caption = "Id Cliente";
            this.Id_Cliente.FieldName = "Id_Cliente";
            this.Id_Cliente.Name = "Id_Cliente";
            // 
            // Nombre_Cliente
            // 
            this.Nombre_Cliente.Caption = "Cliente";
            this.Nombre_Cliente.FieldName = "Nombre_Cliente";
            this.Nombre_Cliente.Name = "Nombre_Cliente";
            // 
            // km_Inicio
            // 
            this.km_Inicio.Caption = "km Inicio";
            this.km_Inicio.FieldName = "km_Inicio";
            this.km_Inicio.Name = "km_Inicio";
            // 
            // km_Fin
            // 
            this.km_Fin.Caption = "km Fin";
            this.km_Fin.FieldName = "km_Fin";
            this.km_Fin.Name = "km_Fin";
            // 
            // Dias_Viaje
            // 
            this.Dias_Viaje.Caption = "Dias Viaje";
            this.Dias_Viaje.FieldName = "Dias_Viaje";
            this.Dias_Viaje.Name = "Dias_Viaje";
            // 
            // Lts_Km
            // 
            this.Lts_Km.Caption = "Lts/Km";
            this.Lts_Km.FieldName = "Lts_Km";
            this.Lts_Km.Name = "Lts_Km";
            // 
            // Id_Huerta
            // 
            this.Id_Huerta.Caption = "Id Huerta";
            this.Id_Huerta.FieldName = "Id_Huerta";
            this.Id_Huerta.Name = "Id_Huerta";
            // 
            // Nombre_Huerta
            // 
            this.Nombre_Huerta.Caption = "Huerta";
            this.Nombre_Huerta.FieldName = "Nombre_Huerta";
            this.Nombre_Huerta.Name = "Nombre_Huerta";
            // 
            // Observaciones
            // 
            this.Observaciones.Caption = "Observaciones";
            this.Observaciones.FieldName = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Visible = true;
            this.Observaciones.VisibleIndex = 6;
            // 
            // EsNacional
            // 
            this.EsNacional.Caption = "Nacional";
            this.EsNacional.FieldName = "EsNacional";
            this.EsNacional.Name = "EsNacional";
            // 
            // Id_ClienteAd
            // 
            this.Id_ClienteAd.Caption = "Id_ClienteAd";
            this.Id_ClienteAd.FieldName = "Id_ClienteAd";
            this.Id_ClienteAd.Name = "Id_ClienteAd";
            // 
            // Nombre_ClienteAd
            // 
            this.Nombre_ClienteAd.Caption = "Nombre_ClienteAd";
            this.Nombre_ClienteAd.FieldName = "Nombre_ClienteAd";
            this.Nombre_ClienteAd.Name = "Nombre_ClienteAd";
            // 
            // Frm_BusqSalidas
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
            this.Name = "Frm_BusqSalidas";
            this.Text = "Frm_BusqSalidas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_BusqSalidas_FormClosed);
            this.Load += new System.EventHandler(this.Frm_BusqSalidas_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn Id_Salida;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Salida;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_Principal;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_Principal;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Operador;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Operador;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Ayudante;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Ayudante;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_Secundario;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_Secundario;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Activo_Adicional;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Activo_Adicional;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Ruta;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Ruta;
        private DevExpress.XtraGrid.Columns.GridColumn Origen;
        private DevExpress.XtraGrid.Columns.GridColumn Destino;
        private DevExpress.XtraGrid.Columns.GridColumn Id_MotivoSalida;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_MotivoSalida;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn km_Inicio;
        private DevExpress.XtraGrid.Columns.GridColumn km_Fin;
        private DevExpress.XtraGrid.Columns.GridColumn Dias_Viaje;
        private DevExpress.XtraGrid.Columns.GridColumn Lts_Km;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn Observaciones;
        private DevExpress.XtraGrid.Columns.GridColumn EsNacional;
        private DevExpress.XtraGrid.Columns.GridColumn Id_ClienteAd;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_ClienteAd;
    }
}