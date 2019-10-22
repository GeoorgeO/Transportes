using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TransportBusiness
{
    public partial class Frm_Activos : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Activos()
        {
            InitializeComponent();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            Frm_Marcas frm = new Frm_Marcas();
            frm.ShowDialog();

            txtMarca.Text = frm.vNombre_Marca;
            txtMarca.Tag = frm.vid_Marca;
        }

        private void btnTipoTransporte_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Transporte frm = new Frm_Tipo_Transporte();
            frm.ShowDialog();

            txtTipoTransporte.Text = frm.vNombre_Tipo_Transporte;
            txtTipoTransporte.Tag = frm.vId_Tipo_Transporte;
        }

        private void btnTipoActivo_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Activo frm = new Frm_Tipo_Activo();
            frm.ShowDialog();

            txtTipoActivo.Text = frm.vNombre_Tipo_Activo;
            txtTipoActivo.Tag = frm.vId_Tipo_Activo;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Frm_Empresas frm = new Frm_Empresas();
            frm.ShowDialog();

            txtEmpresa.Text = frm.vNombre_Empresa;
            txtEmpresa.Tag = frm.vId_Empresa;
        }

        private void btnTipoPlaca_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Placa frm = new Frm_Tipo_Placa();
            frm.ShowDialog();

            txtTipoPlaca.Text = frm.vNombre_Tipo_Placa;
            txtTipoPlaca.Tag = frm.vId_Tipo_Placa;
        }
    }
}