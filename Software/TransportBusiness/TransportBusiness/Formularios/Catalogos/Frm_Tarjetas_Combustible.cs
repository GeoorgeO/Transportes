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
    public partial class Frm_Tarjetas_Combustible : DevExpress.XtraEditors.XtraForm
    {

        public Boolean PaSel { get; set; }

        public Frm_Tarjetas_Combustible()
        {
            InitializeComponent();
        }

        private void CargarTarjeta()
        {
            gridControl1.DataSource = null;
            CLS_Tarjetas_Combustible Clase = new CLS_Tarjetas_Combustible();

            Clase.MtdSeleccionarTarjetas_Combustible();
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

        private void InsertarTarjeta()
        {
            CLS_Tarjetas_Combustible Clase = new CLS_Tarjetas_Combustible();
            Clase.Id_Tarjeta_Combustible = textFolio.Text.Trim();
            Clase.Id_Empresa = textEmpresa.Tag.ToString().Trim();
            Clase.Monto_Min = Convert.ToDecimal(textMmin.Text);
            Clase.Monto_Max = Convert.ToDecimal(textMmax.Text);
            DateTime Fecha = Convert.ToDateTime(dtFechaVigencia.Text.Trim());
            Clase.Vigencia = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.MtdInsertarTarjetas_Combustible();
            if (Clase.Exito)
            {

                CargarTarjeta();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarTarjeta()
        {
            CLS_Tarjetas_Combustible Clase = new CLS_Tarjetas_Combustible();
            Clase.Id_Tarjeta_Combustible = textFolio.Text.Trim();
            Clase.MtdEliminarTarjetas_Combustible();
            if (Clase.Exito)
            {
                CargarTarjeta();
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
            textFolio.Text = "";
            textEmpresa.Tag = "";
            textEmpresa.Text = "";
            textMmin.Text = "";
            textMmax.Text = "";
            textFolio.Enabled = true;
        }

        private void btnBusqProveedor_Click(object sender, EventArgs e)
        {
            Frm_Empresas Clase = new Frm_Empresas();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textEmpresa.Tag = Clase.vId_Empresa;
            textEmpresa.Text = Clase.vNombre_Empresa;
        }

        private void Frm_Tarjetas_Combustible_Load(object sender, EventArgs e)
        {
            dtFechaVigencia.EditValue = DateTime.Now;
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarTarjeta();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textFolio.Text = row["Id_Tarjeta_Combustible"].ToString();
                    dtFechaVigencia.EditValue = Convert.ToDateTime(row["Vigencia"]);
                    textEmpresa.Tag = row["Id_Empresa"].ToString();
                    textEmpresa.Text = row["Nombre_Empresa"].ToString();
                    textMmin.Text = row["Monto_Min"].ToString();
                    textMmax.Text = row["Monto_Max"].ToString();
                    textFolio.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textFolio.Text.ToString().Trim().Length > 0)
            {
                if (textEmpresa.Tag.ToString().Trim().Length > 0)
                {
                    InsertarTarjeta();
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
            if (textFolio.Text.ToString().Trim().Length > 0)
            {
                EliminarTarjeta();
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