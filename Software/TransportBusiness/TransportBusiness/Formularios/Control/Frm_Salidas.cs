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
    public partial class Frm_Salidas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Salidas()
        {
            InitializeComponent();
        }

        private void textFolio_EditValueChanged(object sender, EventArgs e)
        {
            if (textFolio.Text.Trim().Length > 0)
            {
                xtraTabControl1.Enabled = true;
            }else
            {
                xtraTabControl1.Enabled = false;
            }
        }

        private void Frm_Salidas_Load(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            textFolio.Text = "";
        }

        private void btnBusqAyudante_Click(object sender, EventArgs e)
        {
            Frm_BusqAyudante frm = new Frm_BusqAyudante();
            frm.ShowDialog();
            textAyudante.Tag = frm.IdEmpleado;
            textAyudante.Text = frm.Empleado;
        }

        private void btnBusqRuta_Click(object sender, EventArgs e)
        {
            Frm_Rutas_Buscar frm = new Frm_Rutas_Buscar();
            
            frm.ShowDialog();
            textRuta.Tag = frm.Id_Rutas;
            textRuta.Text = frm.Nombre_Ruta;
            textOrigen.Text = frm.vOrigen;
            textDestino.Text = frm.vDestino;
        }

        private void btnBusqClientes_Click(object sender, EventArgs e)
        {
            Frm_Clientes frm = new Frm_Clientes();
            frm.PaSel = true;
            frm.ShowDialog();
            textCliente.Tag = frm.IdCliente;
            textCliente.Text = frm.Cliente;
        }
    }
}