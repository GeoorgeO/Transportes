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
    public partial class Frm_BusqHuertasNew : DevExpress.XtraEditors.XtraForm
    {
        public Frm_BusqHuertasNew()
        {
            InitializeComponent();
        }

        public string vId_Huerta { get; set; }
        public string vNombre_Huerta { get; set; }
        public string vRegistro_Huerta { get; set; }
        public string vId_Duenio { get; set; }
        public string vNombre_Duenio { get; set; }
        public string vId_Estado { get; set; }
        public string vNombre_Estado { get; set; }
        public string vId_Ciudad { get; set; }
        public string vNombre_Ciudad { get; set; }
        public string vId_Calidad { get; set; }
        public string vNombre_Calidad { get; set; }
        public string vId_Cultivo { get; set; }
        public string vNombre_Cultivo { get; set; }
        public string vzona_Huerta { get; set; }
        public string vbanda_Huerta { get; set; }
        public string veste_Huerta { get; set; }
        public string vnorte_Huerta { get; set; }
        public string vasnm_Huerta { get; set; }
        public string vlatitud_Huerta { get; set; }
        public string vlongitud_Huerta { get; set; }
        public string vActiva_Huerta { get; set; }

        private void Frm_BusqHuertasNew_Load(object sender, EventArgs e)
        {
            CLS_Huerta sel = new CLS_Huerta();
           
            sel.MtdSeleccionarHuertaNew();
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
                    vId_Huerta = row["Id_Huerta"].ToString();
                    vNombre_Huerta = row["Nombre_Huerta"].ToString();
                    vRegistro_Huerta = row["Registro_Huerta"].ToString();
                    vId_Duenio = row["Id_Duenio"].ToString();
                    vNombre_Duenio = row["Nombre_Duenio"].ToString();
                    vId_Estado = row["Id_Estado"].ToString();
                    vNombre_Estado = row["Nombre_Estado"].ToString();
                    vId_Ciudad = row["Id_Ciudad"].ToString();
                    vNombre_Ciudad = row["Nombre_Ciudad"].ToString();
                    vId_Calidad = row["Id_Calidad"].ToString();
                    vNombre_Calidad = row["Nombre_Calidad"].ToString();
                    vId_Cultivo = row["Id_Cultivo"].ToString();
                    vNombre_Cultivo = row["Nombre_Cultivo"].ToString();
                    vzona_Huerta = row["zona_Huerta"].ToString();
                    vbanda_Huerta = row["banda_Huerta"].ToString();
                    veste_Huerta = row["este_Huerta"].ToString();
                    vnorte_Huerta = row["norte_Huerta"].ToString();
                    vasnm_Huerta = row["asnm_Huerta"].ToString();
                    vlatitud_Huerta = row["latitud_Huerta"].ToString();
                    vlongitud_Huerta = row["longitud_Huerta"].ToString();
                    vActiva_Huerta = row["Activa_Huerta"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void dtgRutas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    vId_Huerta = row["Id_Huerta"].ToString();
                    vNombre_Huerta = row["Nombre_Huerta"].ToString();
                    vRegistro_Huerta = row["Registro_Huerta"].ToString();
                    vId_Duenio = row["Id_Duenio"].ToString();
                    vNombre_Duenio = row["Nombre_Duenio"].ToString();
                    vId_Estado = row["Id_Estado"].ToString();
                    vNombre_Estado = row["Nombre_Estado"].ToString();
                    vId_Ciudad = row["Id_Ciudad"].ToString();
                    vNombre_Ciudad = row["Nombre_Ciudad"].ToString();
                    vId_Calidad = row["Id_Calidad"].ToString();
                    vNombre_Calidad = row["Nombre_Calidad"].ToString();
                    vId_Cultivo = row["Id_Cultivo"].ToString();
                    vNombre_Cultivo = row["Nombre_Cultivo"].ToString();
                    vzona_Huerta = row["zona_Huerta"].ToString();
                    vbanda_Huerta = row["banda_Huerta"].ToString();
                    veste_Huerta = row["este_Huerta"].ToString();
                    vnorte_Huerta = row["norte_Huerta"].ToString();
                    vasnm_Huerta = row["asnm_Huerta"].ToString();
                    vlatitud_Huerta = row["latitud_Huerta"].ToString();
                    vlongitud_Huerta = row["longitud_Huerta"].ToString();
                    vActiva_Huerta = row["Activa_Huerta"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vId_Huerta = "";
            vNombre_Huerta = "";
            vRegistro_Huerta = "";
            vId_Duenio = "";
            vNombre_Duenio = "";
            vId_Estado = "";
            vNombre_Estado = "";
            vId_Ciudad = "";
            vNombre_Ciudad = "";
            vId_Calidad = "";
            vNombre_Calidad = "";
            vId_Cultivo = "";
            vNombre_Cultivo = "";
            vzona_Huerta = "";
            vbanda_Huerta = "";
            veste_Huerta = "";
            vnorte_Huerta = "";
            vasnm_Huerta = "";
            vlatitud_Huerta = "";
            vlongitud_Huerta = "";
            vActiva_Huerta = "";

            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_Huerta != null)
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