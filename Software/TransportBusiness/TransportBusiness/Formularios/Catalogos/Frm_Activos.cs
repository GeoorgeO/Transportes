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

        }
    }
}