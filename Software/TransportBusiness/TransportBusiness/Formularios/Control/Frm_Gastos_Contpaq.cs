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
    }
}