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
    public partial class Frm_BusqAyudante : DevExpress.XtraEditors.XtraForm
    {
        public string IdEmpleado { get; set; }
        public string Empleado { get; set; }

        public Frm_BusqAyudante()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IdEmpleado != null)
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
            IdEmpleado = "";
            Empleado = "";
            this.Close();
        }

        private void dtgRutas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    IdEmpleado = row["Id_Empleado"].ToString();
                    Empleado = row["Nombre_Empleado"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_BusqAyudante_Load(object sender, EventArgs e)
        {
            CLS_Empleado sel = new CLS_Empleado();
            sel.MtdSeleccionarEmpleadoAsistente();
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
                    IdEmpleado = row["Id_Empleado"].ToString();
                    Empleado = row["Nombre_Empleado"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void dtgRutas_DoubleClick(object sender, EventArgs e)
        {
            if (IdEmpleado != null)
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se selecciono ningun dato.");
            }
        }
    }
}