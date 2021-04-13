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
    public partial class Frm_BusqSalidas : DevExpress.XtraEditors.XtraForm
    {

        public string vId_Salida { get; set; }
        public string vFecha_Salida { get; set; }
        public string vId_Activo_Principal { get; set; }
        public string vNombre_Activo_Principal { get; set; }
        public string vId_Operador { get; set; }
        public string vNombre_Operador { get; set; }
        public string vId_Ayudante { get; set; }
        public string vNombre_Ayudante { get; set; }
        public string vId_Activo_Secundario { get; set; }
        public string vNombre_Activo_Secundario { get; set; }
        public string vId_Activo_Adicional { get; set; }
        public string vNombre_Activo_Adicional { get; set; }
        public string vId_Ruta { get; set; }
        public string vNombre_Ruta { get; set; }
        public string vOrigen { get; set; }
        public string vDestino { get; set; }
        public string vId_MotivoSalida { get; set; }
        public string vNombre_MotivoSalida { get; set; }
        public string vId_Cliente { get; set; }
        public string vNombre_Cliente { get; set; }
        public decimal vkm_Inicio { get; set; }
        public decimal vkm_Fin { get; set; }
        public decimal vDias_Viaje { get; set; }
        public decimal vLts_Km { get; set; }
        public string vId_Huerta { get; set; }
        public string vNombre_Huerta { get; set; }
        public string vObservaciones { get; set; }

        public int filtro { get; set; }

        public Frm_BusqSalidas()
        {
            InitializeComponent();
        }

        private void Frm_BusqSalidas_Load(object sender, EventArgs e)
        {
            CLS_Salidas sel = new CLS_Salidas();
            sel.filtro = filtro;
            sel.MtdSeleccionarSalida();
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
                    vId_Salida = row["Id_Salida"].ToString();
                    vFecha_Salida = row["Fecha_Salida"].ToString();
                    vId_Activo_Principal = row["Id_Activo_Principal"].ToString();
                    vNombre_Activo_Principal = row["Nombre_Activo_Principal"].ToString();
                    vId_Operador = row["Id_Operador"].ToString();
                    vNombre_Operador = row["Nombre_Operador"].ToString();
                    vId_Ayudante = row["Id_Ayudante"].ToString();
                    vNombre_Ayudante = row["Nombre_Ayudante"].ToString();
                    vId_Activo_Secundario = row["Id_Activo_Secundario"].ToString();
                    vNombre_Activo_Secundario = row["Nombre_Activo_Secundario"].ToString();
                    vId_Activo_Adicional = row["Id_Activo_Adicional"].ToString();
                    vNombre_Activo_Adicional = row["Nombre_Activo_Adicional"].ToString();
                    vId_Ruta = row["Id_Ruta"].ToString();
                    vNombre_Ruta = row["Nombre_Ruta"].ToString();
                    vOrigen = row["Origen"].ToString();
                    vDestino = row["Destino"].ToString();
                    vId_MotivoSalida = row["Id_MotivoSalida"].ToString();
                    vNombre_MotivoSalida = row["Nombre_MotivoSalida"].ToString();
                    vId_Cliente = row["Id_Cliente"].ToString();
                    vNombre_Cliente = row["Nombre_Cliente"].ToString();
                    vkm_Inicio = Convert.ToDecimal(row["km_Inicio"]);
                    vkm_Fin = Convert.ToDecimal(row["km_Fin"]);
                    vDias_Viaje = Convert.ToDecimal(row["Dias_Viaje"]);
                    vLts_Km = Convert.ToDecimal(row["Lts_Km"]);
                    vId_Huerta = row["Id_Huerta"].ToString();
                    vNombre_Huerta = row["Nombre_Huerta"].ToString();
                    vObservaciones = row["Observaciones"].ToString();
                    
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
            vId_Salida = "";
            vFecha_Salida = "";
            vId_Activo_Principal = "";
            vNombre_Activo_Principal = "";
            vId_Operador = "";
            vNombre_Operador = "";
            vId_Ayudante = "";
            vNombre_Ayudante = "";
            vId_Activo_Secundario = "";
            vNombre_Activo_Secundario = "";
            vId_Activo_Adicional = "";
            vNombre_Activo_Adicional = "";
            vId_Ruta = "";
            vNombre_Ruta = "";
            vOrigen = "";
            vDestino = "";
            vId_MotivoSalida = "";
            vNombre_MotivoSalida = "";
            vId_Cliente = "";
            vNombre_Cliente = "";
            vkm_Inicio = 0;
            vkm_Fin = 0;
            vDias_Viaje = 0;
            vLts_Km = 0;
            vId_Huerta = "";
            vNombre_Huerta = "";
            vObservaciones = "";
            this.Close();
        }

        private void dtgRutas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRutas.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutas.GetDataRow(i);
                    vId_Salida = row["Id_Salida"].ToString();
                    vFecha_Salida = row["Fecha_Salida"].ToString();
                    vId_Activo_Principal = row["Id_Activo_Principal"].ToString();
                    vNombre_Activo_Principal = row["Nombre_Activo_Principal"].ToString();
                    vId_Operador = row["Id_Operador"].ToString();
                    vNombre_Operador = row["Nombre_Operador"].ToString();
                    vId_Ayudante = row["Id_Ayudante"].ToString();
                    vNombre_Ayudante = row["Nombre_Ayudante"].ToString();
                    vId_Activo_Secundario = row["Id_Activo_Secundario"].ToString();
                    vNombre_Activo_Secundario = row["Nombre_Activo_Secundario"].ToString();
                    vId_Activo_Adicional = row["Id_Activo_Adicional"].ToString();
                    vNombre_Activo_Adicional = row["Nombre_Activo_Adicional"].ToString();
                    vId_Ruta = row["Id_Ruta"].ToString();
                    vNombre_Ruta = row["Nombre_Ruta"].ToString();
                    vOrigen = row["Origen"].ToString();
                    vDestino = row["Destino"].ToString();
                    vId_MotivoSalida = row["Id_MotivoSalida"].ToString();
                    vNombre_MotivoSalida = row["Nombre_MotivoSalida"].ToString();
                    vId_Cliente = row["Id_Cliente"].ToString();
                    vNombre_Cliente = row["Nombre_Cliente"].ToString();
                    vkm_Inicio = Convert.ToDecimal(row["km_Inicio"]);
                    vkm_Fin = Convert.ToDecimal(row["km_Fin"]);
                    vDias_Viaje = Convert.ToDecimal(row["Dias_Viaje"]);
                    vLts_Km = Convert.ToDecimal(row["Lts_Km"]);
                    vId_Huerta = row["Id_Huerta"].ToString();
                    vNombre_Huerta = row["Nombre_Huerta"].ToString();
                    vObservaciones = row["Observaciones"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_BusqSalidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (vId_Salida.Length <= 0)
            {
                vId_Salida = "";
                vFecha_Salida = "";
                vId_Activo_Principal = "";
                vNombre_Activo_Principal = "";
                vId_Operador = "";
                vNombre_Operador = "";
                vId_Ayudante = "";
                vNombre_Ayudante = "";
                vId_Activo_Secundario = "";
                vNombre_Activo_Secundario = "";
                vId_Activo_Adicional = "";
                vNombre_Activo_Adicional = "";
                vId_Ruta = "";
                vNombre_Ruta = "";
                vOrigen = "";
                vDestino = "";
                vId_MotivoSalida = "";
                vNombre_MotivoSalida = "";
                vId_Cliente = "";
                vNombre_Cliente = "";
                vkm_Inicio = 0;
                vkm_Fin = 0;
                vDias_Viaje = 0;
                vLts_Km = 0;
                vId_Huerta = "";
                vNombre_Huerta = "";
                vObservaciones = "";
            }
            
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