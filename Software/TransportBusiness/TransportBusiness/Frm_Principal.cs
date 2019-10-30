using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransportBusiness
{
    public partial class Frm_Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string UsuariosLogin { get; set; }
        public char UsuariosClase { get; set; }
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnVeiculos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Activos.DefInstance.MdiParent = this;
            Frm_Activos.DefInstance.Show();
        }

        private void btnPersonal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Empleados.DefInstance.MdiParent = this;
            Frm_Empleados.DefInstance.Show();
        }

        private void btnAseguradora_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Aseguradoras.DefInstance.MdiParent = this;
            Frm_Aseguradoras.DefInstance.PaSel = false;
            Frm_Aseguradoras.DefInstance.Show();
        }

        private void btnTipoActivos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Tipo_Activo Frm = new Frm_Tipo_Activo();
            Frm.PaSel = false;
            Frm.ShowDialog();
        }

        private void btnTipoDomicilio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Tipo_Domicilio Frm = new Frm_Tipo_Domicilio();
            Frm.PaSel = false;
            Frm.ShowDialog();
        }

        private void btnTipoLicencia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Tipo_Licencia Frm = new Frm_Tipo_Licencia();
            Frm.PaSel = false;
            Frm.ShowDialog();
        }

        private void btnTipoPlaca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Tipo_Placa Frm = new Frm_Tipo_Placa();
            Frm.PaSel = false;
            Frm.ShowDialog();
        }

        private void btnTipoTransporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Tipo_Transporte Frm = new Frm_Tipo_Transporte();
            Frm.PaSel = false;
            Frm.ShowDialog();
        }

        private void btnTipoPersona_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Tipo_Empleados Frm = new Frm_Tipo_Empleados();
            Frm.PaSel = false;
            Frm.ShowDialog();
        }

        private void btnAgente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Agente_Empresa_Aseguradora.DefInstance.MdiParent = this;
            Frm_Agente_Empresa_Aseguradora.DefInstance.Show();
        }

        private void btnBroker_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Broker_Empresa_Aseguradora.DefInstance.MdiParent = this;
            Frm_Broker_Empresa_Aseguradora.DefInstance.Show();
        }

        private void btnCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Clientes.DefInstance.MdiParent = this;
            Frm_Clientes.DefInstance.Show();
        }

        private void btnEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Empresas.DefInstance.MdiParent = this;
            Frm_Empresas.DefInstance.PaSel = false;
            Frm_Empresas.DefInstance.Show();

        }

        private void btnEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Estado.DefInstance.MdiParent = this;
            Frm_Estado.DefInstance.Show();
        }

        private void btnPais_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Pais Frm = new Frm_Pais(false);
            Frm.ShowDialog();
        }

        private void btnMarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Marcas Frm = new Frm_Marcas();
            Frm.PaSel = false;
            Frm.ShowDialog();
        }

        private void btnLicencias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Licencias Frm = new Frm_Licencias();
            Frm.PaSel = false;
            Frm.ShowDialog();
        }

        private void btnProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Proveedores.DefInstance.MdiParent = this;
            Frm_Proveedores.DefInstance.Show();
        }
    }
}
