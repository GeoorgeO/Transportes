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
    public partial class Frm_Entradas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Entradas()
        {
            InitializeComponent();
        }

        private void CargarEntradas()
        {
            gridControl1.DataSource = null;
            CLS_Entradas Clase = new CLS_Entradas();


            Clase.MtdSeleccionarEntradas();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private string DosCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }

        private void InsertarEntradas()
        {
            CLS_Entradas Clase = new CLS_Entradas();
            Clase.Id_Entrada = textEntrada.Text.Trim();
            Clase.Id_Salida = textSalida.Text.Trim();
            DateTime Fecha = Convert.ToDateTime(dtFechaEntrada.Text.Trim());
      
            Clase.Fecha_Entrada = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());

            Clase.Id_Activo_P = textActivoPrincipal.Tag.ToString();
            Clase.Id_Activo_1 = textActivoSec.Tag.ToString();
            Clase.Id_Activo_2 = textActivoAdicional.Tag.ToString();
            Clase.EnRuta = "0";
            Clase.MtdInsertarEntradas();
            if (Clase.Exito)
            {
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
                CargarEntradas();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textEntrada.Text = "";
            textSalida.Text = "";
            textActivoPrincipal.Text = "";
            textActivoPrincipal.Tag = "";
            textActivoSec.Text = "";
            textActivoSec.Tag = "";
            textActivoAdicional.Text = "";
            textActivoAdicional.Tag = "";
            dtFechaEntrada.EditValue = DateTime.Now;
            btnBusqSalida.Enabled = true;
            dtFechaEntrada.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnBusqSalida_Click(object sender, EventArgs e)
        {
            Frm_BusqEntradas frm = new Frm_BusqEntradas();
            frm.ShowDialog();
            textEntrada.Text = frm.vId_Entrada;
            textSalida.Text = frm.vId_Salida;
            textActivoPrincipal.Tag = frm.vId_Activo_P;
            textActivoPrincipal.Text = frm.vNombre_Activo_P;
            textActivoSec.Tag = frm.vId_Activo_1;
            textActivoSec.Text = frm.vNombre_Activo_1;
            textActivoAdicional.Tag = frm.vId_Activo_2;
            textActivoAdicional.Text = frm.vNombre_Activo_2;
            if (frm.vFecha_Entrada.Equals("")) {

            }else
            {
                dtFechaEntrada.EditValue = Convert.ToDateTime(frm.vFecha_Entrada);
            } 
        }

        private void btnBusqSalida_Click_1(object sender, EventArgs e)
        {
            Frm_BusqSalidas frm = new Frm_BusqSalidas();
            frm.filtro = 1;
            frm.ShowDialog();
            textSalida.Text = frm.vId_Salida;
            textActivoPrincipal.Text = frm.vNombre_Activo_Principal;
            textActivoPrincipal.Tag = frm.vId_Activo_Principal;
            textActivoSec.Text = frm.vNombre_Activo_Secundario;
            textActivoSec.Tag = frm.vId_Activo_Secundario;
            textActivoAdicional.Text = frm.vNombre_Activo_Adicional;
            textActivoAdicional.Tag = frm.vId_Activo_Adicional;
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Entradas_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarEntradas();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = XtraMessageBox.Show("¿Esta Seguro que deseas guardar esos datos?, Una vez guardados no se podran modificar.", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult == DialogResult.No)
            {

            }else
            {
                if (textSalida.Text.Trim().Length > 0)
                {
                    InsertarEntradas();
                }
                else
                {
                    XtraMessageBox.Show("Falta seleccionar una salida.");
                    textSalida.Focus();
                }
            }
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textEntrada.Text = row["Id_Entrada"].ToString();
                    textSalida.Text = row["Id_Salida"].ToString();
                    dtFechaEntrada.EditValue = Convert.ToDateTime(row["Fecha_Entrada"]);
                    textActivoPrincipal.Tag= row["Id_Activo_P"].ToString();
                    textActivoPrincipal.Text = row["Nombre_Activo_P"].ToString();
                    textActivoSec.Tag = row["Id_Activo_1"].ToString();
                    textActivoSec.Text = row["Nombre_Activo_1"].ToString();
                    textActivoAdicional.Tag = row["Id_Activo_2"].ToString();
                    textActivoAdicional.Text = row["Nombre_Activo_2"].ToString();

                    btnBusqSalida.Enabled = false;
                    dtFechaEntrada.Enabled = false;
                    btnGuardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }
    }
}