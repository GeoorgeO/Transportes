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

namespace TransportBusiness.Formularios.Catalogos
{
    public partial class Frm_Tarjetas_IAVE : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Tarjetas_IAVE()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Frm_Proveedores Clase = new Frm_Proveedores();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textProveedor.Tag = Clase.IdProveedor;
            textProveedor.Text = Clase.Proveedor;
        }
    }
}