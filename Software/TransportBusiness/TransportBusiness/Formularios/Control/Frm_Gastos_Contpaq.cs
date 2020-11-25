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
    public partial class Frm_Gastos_Contpaq : DevExpress.XtraEditors.XtraForm
    {
        public string vTipoCambio { get; set; }
        private static Frm_Gastos_Contpaq m_FormDefInstance;
        public static Frm_Gastos_Contpaq DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Gastos_Contpaq();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
       
        public Frm_Gastos_Contpaq()
        {
            InitializeComponent();
        }

        private void Frm_Gastos_Contpaq_Shown(object sender, EventArgs e)
        {
            dateInicio.DateTime = DateTime.Now;
            dateFin.DateTime = DateTime.Now;
            dtgValGastos.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValGastos.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValGastos.OptionsSelection.MultiSelect = true;
            dtgValGastos.OptionsView.ShowGroupPanel = false;
            ColImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            ColImporte.DisplayFormat.FormatString = "$ #,###,###0.00";
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime date1 = dateInicio.DateTime;
            DateTime date2 = dateFin.DateTime;
            int result = DateTime.Compare(date1, date2);
            if(result<=0)
            {
                string vFechaInicio = date1.Year.ToString() + DosCero(date1.Month.ToString()) + DosCero(date1.Day.ToString());
                string vFechaFin = date2.Year.ToString() + DosCero(date2.Month.ToString()) + DosCero(date2.Day.ToString());
                CLS_Gastos_Contpaq gs = new CLS_Gastos_Contpaq();
                gs.FechaInicio = vFechaInicio;
                gs.FechaFin = vFechaFin;
                gs.MtdSeleccionarGastos();
                if(gs.Exito)
                {
                    if(gs.Datos.Rows.Count>0)
                    {
                        dtgGastos.DataSource = gs.Datos;
                    }
                    else
                    {
                        XtraMessageBox.Show("No existen datos en este rango de fechas");
                    }
                }
                else
                {
                    XtraMessageBox.Show(gs.Mensaje);
                }

            }
            else
            {
                XtraMessageBox.Show("La fecha inicio no debe ser mayor a la fecha final");
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

        private void btnImportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dtgValGastos.RowCount>0)
            {
                pgBar.Properties.Minimum = 0;
                pgBar.Properties.Maximum = dtgValGastos.RowCount;
                pgBar.Position = 0;
                for (int i = 0; i < dtgValGastos.RowCount; i++)
                {
                    pgBar.Position = i + 1;
                    Application.DoEvents();
                    int xRow = dtgValGastos.GetVisibleRowHandle(i);
                    DateTime vFecha = Convert.ToDateTime(dtgValGastos.GetRowCellValue(xRow, "Fecha").ToString());
                    
                    if (!ExisteTipoCambio(vFecha))
                    {
                        XtraMessageBox.Show("Falta de capturar el tipo de cambio de la fecha " + vFecha.ToString());
                    }
                    else
                    {
                        CLS_Gastos insdetped = new CLS_Gastos();
                        insdetped.Fecha_Gasto = vFecha.Year.ToString() + DosCero(vFecha.Month.ToString()) + DosCero(vFecha.Day.ToString());
                        insdetped.Tipo_Cambio = Convert.ToDecimal(vTipoCambio);
                        insdetped.Importe = Convert.ToDecimal(dtgValGastos.GetRowCellValue(xRow, "Importe").ToString());
                        insdetped.Factura = string.Empty;
                        insdetped.Concepto = dtgValGastos.GetRowCellValue(xRow, "Concepto").ToString();
                        string vCuenta = dtgValGastos.GetRowCellValue(xRow, "Codigo").ToString();
                        vCuenta = vCuenta.Substring(0, 4) + "-" + vCuenta.Substring(4, 2) + "-" + vCuenta.Substring(6, 2) + "-" + vCuenta.Substring(8, 5);
                        insdetped.Id_Cuenta = vCuenta;
                        insdetped.Referencia = dtgValGastos.GetRowCellValue(xRow, "Referencia").ToString();
                        insdetped.Poliza =Convert.ToInt32(dtgValGastos.GetRowCellValue(xRow, "Poliza").ToString());
                        insdetped.Moneda = dtgValGastos.GetRowCellValue(xRow, "TextoFinal").ToString();
                        insdetped.TipoPoliza = dtgValGastos.GetRowCellValue(xRow, "Nombre").ToString();
                        insdetped.MtdInsertarGastos();
                        if (!insdetped.Exito)
                        {
                            XtraMessageBox.Show(insdetped.Mensaje, "Error al guardar el Registro");
                        }
                    }
                }
                XtraMessageBox.Show("Se han importado los datos con exito");
                pgBar.Position = 0;
            }
            else
            {
                XtraMessageBox.Show("No existen datos para importar");
            }
        }

        private Boolean ExisteTipoCambio(DateTime vFecha)
        {
            DateTime Fcha;
            Boolean Valor = false;
            CLS_Gastos Clase = new CLS_Gastos();
            
            Clase.Fecha_Gasto = vFecha.Year.ToString() + DosCero(vFecha.Month.ToString()) + DosCero(vFecha.Day.ToString());
            Clase.MtdSeleccionarTCxFecha();
            if (Clase.Exito)
            {
                if (Clase.Datos.Rows.Count > 0)
                {
                    vTipoCambio = Clase.Datos.Rows[0]["Tipo_Cambio"].ToString();
                    Valor = true;
                }
                else
                {
                    vTipoCambio = "0";
                }

            }
            return Valor;
        }
    }
}