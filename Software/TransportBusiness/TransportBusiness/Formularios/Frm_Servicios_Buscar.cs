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
    public partial class Frm_Servicios_Buscar : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Servicios_Buscar()
        {
            InitializeComponent();
        }

        public string vFolio { get; set; }
        public double vKilometraje { get; set; }
        public string vId_TipoServicio { get; set; }
        public string vNombre_TipoServicio { get; set; }
        public double vPrecioTotal { get; set; }
        public string vId_Activo { get; set; }
        public string vNombre_Interno { get; set; }
        public string vFechaServicio { get; set; }
        public string vId_Proveedor { get; set; }
        public string vNombre_Proveedor { get; set; }
        public string vId_Factura { get; set; }
        public string vComprador { get; set; }
        public string vNombre_Empleado { get; set; }
        public string vObservaciones { get; set; }

        private void dtgRutas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    vFolio = row["Folio"].ToString();
                    vKilometraje = Convert.ToDouble(row["Kilometraje"].ToString());
                    vId_TipoServicio = row["Id_TipoServicio"].ToString();
                    vNombre_TipoServicio = row["Nombre_TipoServicio"].ToString();
                    vPrecioTotal = Convert.ToDouble(row["PrecioTotal"].ToString());
                    vId_Activo = row["Id_Activo"].ToString();
                    vNombre_Interno = row["Nombre_Interno"].ToString();
                    vFechaServicio = row["FechaServicio"].ToString();
                    vId_Proveedor = row["Id_Proveedor"].ToString();
                    vNombre_Proveedor = row["Nombre_Proveedor"].ToString();
                    vId_Factura = row["Id_Factura"].ToString();
                    vComprador = row["Comprador"].ToString();
                    vNombre_Empleado = row["Nombre_Empleado"].ToString();
                    vObservaciones = row["Observaciones"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Servicios_Buscar_Load(object sender, EventArgs e)
        {
            CLS_Servicios sel = new CLS_Servicios();
            sel.MtdSeleccionarServicios();
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
                    vFolio = row["Folio"].ToString();
                    vKilometraje = Convert.ToDouble(row["Kilometraje"].ToString());
                    vId_TipoServicio = row["Id_TipoServicio"].ToString();
                    vNombre_TipoServicio = row["Nombre_TipoServicio"].ToString();
                    vPrecioTotal = Convert.ToDouble(row["PrecioTotal"].ToString());
                    vId_Activo = row["Id_Activo"].ToString();
                    vNombre_Interno = row["Nombre_Interno"].ToString();
                    vFechaServicio = row["FechaServicio"].ToString();
                    vId_Proveedor = row["Id_Proveedor"].ToString();
                    vNombre_Proveedor = row["Nombre_Proveedor"].ToString();
                    vId_Factura = row["Id_Factura"].ToString();
                    vComprador = row["Comprador"].ToString();
                    vNombre_Empleado = row["Nombre_Empleado"].ToString();
                    vObservaciones = row["Observaciones"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vFolio = String.Empty;
            vKilometraje = 0;
            vId_TipoServicio = "";
            vNombre_TipoServicio = "";
            vPrecioTotal = 0;
            vId_Activo ="";
            vNombre_Interno = "";
            vFechaServicio = DateTime.Now.ToString();
            vId_Proveedor = "";
            vNombre_Proveedor = "";
            vId_Factura = "";
            vComprador = "";
            vNombre_Empleado = "";
            vObservaciones = "";
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vFolio!=null )
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