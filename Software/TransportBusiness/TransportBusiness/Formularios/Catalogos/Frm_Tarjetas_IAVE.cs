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
    public partial class Frm_Tarjetas_IAVE : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Tarjetas_IAVE()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        private void CargarIAVE()
        {
            gridControl1.DataSource = null;
            CLS_Tarjetas_IAVE Clase = new CLS_Tarjetas_IAVE();

            Clase.MtdSeleccionarTarjetas_IAVE();
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

        private void InsertarIAVE()
        {
            CLS_Tarjetas_IAVE Clase = new CLS_Tarjetas_IAVE();
            Clase.IAVE = textIAVE.Text.Trim();
            Clase.Id_Empresa = textEmpresa.Tag.ToString().Trim();
            Clase.Monto_Min = Convert.ToDecimal(textMmin.Text);
            Clase.Monto_Max = Convert.ToDecimal(textMmax.Text);
            DateTime Fecha = Convert.ToDateTime(dtFechaAlta.Text.Trim());
            Clase.Vigencia = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.MtdInsertarTarjetas_IAVE();
            if (Clase.Exito)
            {

                CargarIAVE();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarIAVE()
        {
            CLS_Tarjetas_IAVE Clase = new CLS_Tarjetas_IAVE();
            Clase.IAVE = textIAVE.Text.Trim();
            Clase.MtdEliminarTarjetas_IAVE();
            if (Clase.Exito)
            {
                CargarIAVE();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textIAVE.Text = "";
            textEmpresa.Tag = "";
            textEmpresa.Text = "";
            textMmin.Text = "";
            textMmax.Text = "";
            textIAVE.Enabled = true;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Frm_Empresas Clase = new Frm_Empresas();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textEmpresa.Tag = Clase.vId_Empresa;
            textEmpresa.Text = Clase.vNombre_Empresa;
        }

        private void Frm_Tarjetas_IAVE_Load(object sender, EventArgs e)
        {
            dtFechaAlta.EditValue = DateTime.Now;
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarIAVE();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textIAVE.Text = row["IAVE"].ToString();
                    dtFechaAlta.EditValue = Convert.ToDateTime(row["Vigencia"]);
                    textEmpresa.Tag= row["Id_Empresa"].ToString();
                    textEmpresa.Text = row["Nombre_Empresa"].ToString();
                    textMmin.Text = row["Monto_Min"].ToString();
                    textMmax.Text = row["Monto_Max"].ToString();
                    textIAVE.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textIAVE.Text.ToString().Trim().Length > 0)
            {
                if (textEmpresa.Tag.ToString().Trim().Length > 0)
                {
                    InsertarIAVE();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Seleccionar la empresa.");
                    textEmpresa.Focus();
                }  
            }
            else
            {
                XtraMessageBox.Show("Es necesario teclear el folio de la tarjeta.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textIAVE.Text.ToString().Trim().Length > 0)
            {
                EliminarIAVE();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un elemento de la lista.");
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}