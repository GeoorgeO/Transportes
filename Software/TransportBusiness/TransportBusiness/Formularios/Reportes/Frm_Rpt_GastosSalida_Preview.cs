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
    public partial class Frm_Rpt_GastosSalida_Preview : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Rpt_GastosSalida_Preview()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_GastosSalida_Preview_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}