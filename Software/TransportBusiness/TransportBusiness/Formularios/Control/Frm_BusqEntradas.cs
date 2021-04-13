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
    public partial class Frm_BusqEntradas : DevExpress.XtraEditors.XtraForm
    {

        public string vId_Entrada { get; set; }
        public string vId_Salida { get; set; }
        public string vFecha_Entrada { get; set; }
        public string vFecha_Cruce { get; set; }
        public string vId_Activo_P { get; set; }
        public string vNombre_Activo_P { get; set; }
        public string vId_Activo_1 { get; set; }
        public string vNombre_Activo_1 { get; set; }
        public string vId_Activo_2 { get; set; }
        public string vNombre_Activo_2 { get; set; }


        public Frm_BusqEntradas()
        {
            InitializeComponent();
        }

        private void Frm_BusqEntradas_Load(object sender, EventArgs e)
        {
            CLS_Entradas sel = new CLS_Entradas();
            sel.MtdSeleccionarEntradas();
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
                    vId_Entrada = row["Id_Entrada"].ToString();
                    vId_Salida = row["Id_Salida"].ToString();
                    vFecha_Entrada = row["Fecha_Entrada"].ToString();
                    vFecha_Cruce = row["Fecha_Cruce"].ToString();
                    vId_Activo_P = row["Id_Activo_P"].ToString();
                    vNombre_Activo_P = row["Nombre_Activo_P"].ToString();
                    vId_Activo_1 = row["Id_Activo_1"].ToString();
                    vNombre_Activo_1 = row["Nombre_Activo_1"].ToString();
                    vId_Activo_2 = row["Id_Activo_2"].ToString();
                    vNombre_Activo_2 = row["Nombre_Activo_2"].ToString();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_Salida != null)
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
            vId_Entrada ="";
            vId_Salida = "";
            vFecha_Entrada = "";
            vFecha_Cruce = "";
            vId_Activo_P = "";
            vNombre_Activo_P = "";
            vId_Activo_1 = "";
            vNombre_Activo_1 = "";
            vId_Activo_2 = "";
            vNombre_Activo_2 = "";
            this.Close();
        }

        private void dtgRutas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    vId_Entrada = row["Id_Entrada"].ToString();
                    vId_Salida = row["Id_Salida"].ToString();
                    vFecha_Entrada = row["Fecha_Entrada"].ToString();
                    vFecha_Cruce = row["Fecha_Cruce"].ToString();
                    vId_Activo_P = row["Id_Activo_P"].ToString();
                    vNombre_Activo_P = row["Nombre_Activo_P"].ToString();
                    vId_Activo_1 = row["Id_Activo_1"].ToString();
                    vNombre_Activo_1 = row["Nombre_Activo_1"].ToString();
                    vId_Activo_2 = row["Id_Activo_2"].ToString();
                    vNombre_Activo_2 = row["Nombre_Activo_2"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_BusqEntradas_FormClosed(object sender, FormClosedEventArgs e)
        {
            vId_Entrada = "";
            vId_Salida = "";
            vFecha_Entrada = "";
            vFecha_Cruce = "";
            vId_Activo_P = "";
            vNombre_Activo_P = "";
            vId_Activo_1 = "";
            vNombre_Activo_1 = "";
            vId_Activo_2 = "";
            vNombre_Activo_2 = "";
        }

        private void dtgRutas_DoubleClick(object sender, EventArgs e)
        {
            if (vId_Salida != null)
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