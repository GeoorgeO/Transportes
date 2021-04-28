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

namespace TransportBusiness.Formularios.Reportes
{
    public partial class Frm_Rpt_SalidasGeneral : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Rpt_SalidasGeneral()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_SalidasGeneral_Load(object sender, EventArgs e)
        {

        }

        private void CargarAños()
        {
            comboEmpresas.Properties.Items.Clear();
            comboEmpresas.EditValue = null;



            for (int i = 2019; i <= DateTime.Today.Year; i++)
                comboAnio.Properties.Items.Add(i);
                }
            
        }
    }
}