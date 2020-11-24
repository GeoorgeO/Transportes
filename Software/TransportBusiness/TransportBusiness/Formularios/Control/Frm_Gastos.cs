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
    public partial class Frm_Gastos : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Gastos()
        {
            InitializeComponent();
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

        private void CargarGastos()
        {
            DateTime Fcha;
            gridControl1.DataSource = null;
            CLS_Gastos Clase = new CLS_Gastos();
            Fcha = Convert.ToDateTime(dateFecha.EditValue);
        
            Clase.Fecha_Gasto= Fcha.Year.ToString() + DosCero(Fcha.Month.ToString()) + DosCero(Fcha.Day.ToString());
            Clase.MtdSeleccionarGastos();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private void CargarTC()
        {
            DateTime Fcha;
           
            CLS_Gastos Clase = new CLS_Gastos();
            Fcha = Convert.ToDateTime(dateFecha.EditValue);

            Clase.Fecha_Gasto = Fcha.Year.ToString() + DosCero(Fcha.Month.ToString()) + DosCero(Fcha.Day.ToString());
            Clase.MtdSeleccionarTCxFecha();
            if (Clase.Exito)
            {
                if (Clase.Datos.Rows.Count > 0)
                {
                    textTC.Text = Clase.Datos.Rows[0]["Tipo_Cambio"].ToString();
                }else
                {
                    textTC.Text = "0";
                }
                
            }
        }

        private Boolean CargarId()
        {
            DateTime Fcha;
           
            CLS_Gastos Clase = new CLS_Gastos();
            Fcha = Convert.ToDateTime(dateFecha.EditValue);

            Clase.Fecha_Gasto = Fcha.Year.ToString() + DosCero(Fcha.Month.ToString()) + DosCero(Fcha.Day.ToString());
            Clase.MtdSeleccionarIdGasto();
            if (Clase.Exito)
            {
                if (Clase.Datos.Rows.Count > 0)
                {
                   textId.Text = Fcha.Year.ToString().Substring(2, 2) + DosCero(Fcha.Month.ToString()) + DosCero(Fcha.Day.ToString()) + Clase.Datos.Rows[0][0].ToString();
                    return true;
                }
            }
            return false;
        }

        private void InsertarGastos()
        {
            CLS_Gastos Clase = new CLS_Gastos();
            DateTime Fcha;
            Clase.Id_Gasto = textId.Text.Trim();
            Clase.Id_GastoIndirecto = textGastosIndirectos.Tag.ToString().Trim();
            Clase.Importe=Convert.ToDecimal( textImporte.Text );
            Clase.Tipo_Cambio=Convert.ToDecimal(textTC.Text);
            Fcha = Convert.ToDateTime(dateFecha.EditValue);
            Clase.Fecha_Gasto= Fcha.Year.ToString() + DosCero(Fcha.Month.ToString()) + DosCero(Fcha.Day.ToString());
            Clase.Concepto = textConcepto.Text;
            Clase.Factura = textFactura.Text;
            Clase.Id_Cuenta = textCtas.Tag.ToString();
            Clase.MtdInsertarGastos();

            if (Clase.Exito)
            {
                CargarGastos();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarGastos()
        {
            CLS_Gastos Clase = new CLS_Gastos();
            Clase.Id_Gasto = textId.Text.Trim();
            Clase.MtdEliminarGastos();
            if (Clase.Exito)
            {
                CargarGastos();
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
            textId.Text = "";
            textGastosIndirectos.Text = "";
            textGastosIndirectos.Tag = "";
            textImporte.Text = "0";
            textFactura.Text = "";
            textConcepto.Text = "";
            textCtas.Tag = "";
            textCtas.Text = "";
        }

        private void Frm_Gastos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            dateFecha.EditValue = DateTime.Today;
            
            CargarGastos();
            CargarTC();
        }

        private void btnGastosIndirectos_Click(object sender, EventArgs e)
        {
            Frm_Gasto_Indirecto Clase = new Frm_Gasto_Indirecto();
            Clase.PaSel = true;
            Clase.ShowDialog();
            if (Clase.vid_GastoIndirecto != null)
            {
                textGastosIndirectos.Text = Clase.vNombre_GastoIndirecto;
                textGastosIndirectos.Tag = Clase.vid_GastoIndirecto;
            }
        }

        private void dateFecha_EditValueChanged(object sender, EventArgs e)
        {
            CargarGastos();
            CargarTC();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CargarId())
            {
                if (textId.Text.ToString().Trim().Length > 0)
                {
                    InsertarGastos();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Agregar un nombre de un cultivo.");
                }
            }

        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0)
            {
                EliminarGastos();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un cultivo.");
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

        private void btnCtas_Click(object sender, EventArgs e)
        {
            Frm_Cuentas_Contables Clase = new Frm_Cuentas_Contables();
            Clase.PaSel = true;
            Clase.ShowDialog();
            if (Clase.vId_Cuenta != null)
            {
                textCtas.Text = Clase.vNombre_Cuenta;
                textCtas.Tag = Clase.vId_Cuenta;
            }
        }
    }
}