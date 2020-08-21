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
    public partial class Frm_TipoCambio : DevExpress.XtraEditors.XtraForm
    {
        public Frm_TipoCambio()
        {
            InitializeComponent();
        }

        private void CargarTipoCambio()
        {
            gridControl1.DataSource = null;
            CLS_TipoCambio Clase = new CLS_TipoCambio();

            Clase.MtdSeleccionarTipoCambio();
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

        private void InsertarTipoCambio()
        {
            CLS_TipoCambio Clase = new CLS_TipoCambio();
            DateTime Fecha;
            Fecha = Convert.ToDateTime(dateFecha.Text.Trim());
            Clase.Fecha = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Tipo_Cambio = Convert.ToDecimal(textTC.Text);
            
            Clase.MtdInsertarTipoCambio();
            if (Clase.Exito)
            {

                CargarTipoCambio();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarTipoCambio()
        {
            CLS_TipoCambio Clase = new CLS_TipoCambio();
            DateTime Fecha;
            Fecha = Convert.ToDateTime(dateFecha.Text.Trim());
            Clase.Fecha = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.MtdEliminarTipoCambio();
            if (Clase.Exito)
            {
                CargarTipoCambio();
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
            dateFecha.EditValue=DateTime.Now;
            textTC.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    dateFecha.EditValue = Convert.ToDateTime(row["Fecha"]);
                    textTC.Text = row["Tipo_Cambio"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_TipoCambio_Load(object sender, EventArgs e)
        {
            CargarTipoCambio();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textTC.Text.ToString().Trim().Length > 0)
            {
                InsertarTipoCambio();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del pais.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                EliminarTipoCambio();
           
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