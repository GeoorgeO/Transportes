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
using CapaDeDatos;

namespace TransportBusiness
{
    public partial class Frm_Rutas_Buscar : DevExpress.XtraEditors.XtraForm
    {
        public string Id_Rutas { get; set; }
        public string Nombre_Ruta  { get; set; }
        public Frm_Rutas_Buscar()
        {
            InitializeComponent();
        }

        private void Frm_Rutas_Buscar_Shown(object sender, EventArgs e)
        {
            CLS_Rutas sel = new CLS_Rutas();
            sel.MtdSeleccionarRutas();
            if(sel.Exito)
            {
                dtgRutas.DataSource = sel.Datos;
            }
            else
            {
                XtraMessageBox.Show(sel.Mensaje);
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dtgRutas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    Id_Rutas = row["Id_Rutas"].ToString();
                    Nombre_Ruta = row["Nombre_Ruta"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}