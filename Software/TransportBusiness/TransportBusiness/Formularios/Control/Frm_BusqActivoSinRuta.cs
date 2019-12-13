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
    public partial class Frm_BusqActivoSinRuta : DevExpress.XtraEditors.XtraForm
    {

        public string IdActivo { get; set; }
        public string Activo { get; set; }
        public string IdOPerador { get; set; }
        public string Operador { get; set; }

        public Frm_BusqActivoSinRuta()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdActivo = "";
            Activo = "";
            IdOPerador = "";
            Operador = "";
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IdActivo != null)
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se selecciono ningun dato.");
            }
        }

        private void dtgRutas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    IdActivo = row["Id_Activo"].ToString();
                    Activo = row["Nombre_Interno"].ToString();
                    IdOPerador = row["Id_Empleado"].ToString();
                    Operador = row["Nombre_Empleado"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_BusqActivoSinRuta_Load(object sender, EventArgs e)
        {
            CLS_Activos sel = new CLS_Activos();
            sel.MtdSeleccionarActivosSinRuta();
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
                    IdActivo = row["Id_Activo"].ToString();
                    Activo = row["Nombre_Interno"].ToString();
                    IdOPerador = row["Id_Empleado"].ToString();
                    Operador = row["Nombre_Empleado"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}