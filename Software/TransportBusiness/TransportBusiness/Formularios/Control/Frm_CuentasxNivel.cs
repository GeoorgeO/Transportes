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
    public partial class Frm_CuentasxNivel : DevExpress.XtraEditors.XtraForm
    {

        public string vId_cuenta { get; set; }
        public string vId_cuenta_exclusa { get; set; }
        public string vNombre_cuenta { get; set; }
       
        public int vActiva { get; set; }

        public Frm_CuentasxNivel()
        {
            InitializeComponent();
        }

        private void Frm_CuentasxNivel_Load(object sender, EventArgs e)
        {
            CLS_Cuentas_contables sel = new CLS_Cuentas_contables();
            sel.Id_cuenta = vId_cuenta_exclusa;
            sel.MtdSeleccionarPadre();
            if (sel.Exito)
            {
                dtgRutas.DataSource = sel.Datos;
            }
            else
            {
                XtraMessageBox.Show(sel.Mensaje);
            }

            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    vId_cuenta = row["Id_cuenta"].ToString();
                    vNombre_cuenta = row["Nombre_cuenta"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_cuenta != null)
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se selecciono ningun dato.");
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vId_cuenta = "";
         
            vNombre_cuenta = "";
           
            vActiva = 1;
            this.Close();
        }

        private void dtgRutas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    vId_cuenta = row["Id_cuenta"].ToString();
                    vNombre_cuenta = row["Nombre_cuenta"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}