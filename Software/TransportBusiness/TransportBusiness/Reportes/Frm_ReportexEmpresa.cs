using System;
using System.Data;
using CapaDeDatos;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace TransportBusiness
{
    public partial class Frm_ReportexEmpresa : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_ReportexEmpresa m_FormDefInstance;
        public static Frm_ReportexEmpresa DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_ReportexEmpresa();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Frm_ReportexEmpresa()
        {
            InitializeComponent();
        }

        private void Frm_ReportexEmpresa_Shown(object sender, EventArgs e)
        {
            Limpiar_Campos();
            CargarEmpresas();
            ColIngreso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            ColIngreso.DisplayFormat.FormatString = "$ ###,###0.00";
            ColGasto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            ColGasto.DisplayFormat.FormatString = "$ ###,###0.00";
            ColUtilidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            ColUtilidad.DisplayFormat.FormatString = "$ ###,###0.00";
        }

        private void Limpiar_Campos()
        {
            radioMoneda.EditValue = "P";
            dateDel.EditValue = DateTime.Today.AddDays(-7);
            dateAl.EditValue = DateTime.Today;
            dtgReporte.DataSource = null;
        }
        private void CargarGastos()
        {
            dtgReporte.DataSource = null;
            CLS_GastosSalidas Clase = new CLS_GastosSalidas();
            Clase.Moneda = radioMoneda.EditValue.ToString();
            DateTime Fecha = Convert.ToDateTime(dateDel.Text.Trim());
            Clase.F_Del = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Fecha = Convert.ToDateTime(dateAl.Text.Trim());
            Clase.F_Al = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Empresa = comboEmpresas.EditValue.ToString().Substring(0, 4);
            Clase.MtdSeleccionarGastosEmpresa();
            if (Clase.Exito)
            {
                dtgReporte.DataSource = Clase.Datos;
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
        private void CargarEmpresas()
        {
            comboEmpresas.EditValue = null;

            CLS_Empresa Clase = new CLS_Empresa();
            Clase.MtdSeleccionarEmpresa();
            if (Clase.Exito)
            {
                foreach (DataRow Row in Clase.Datos.Rows)
                {
                    comboEmpresas.Properties.Items.Add(Row["Id_Empresa"] + " - " + Row["Nombre_Empresa"]);
                }
            }
            if (comboEmpresas.Properties.Items.Count > 0)
            {
                comboEmpresas.SelectedIndex = 0;
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpiar_Campos();
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarGastos();
        }
        private void Form1_ConfigureDataConnection(object sender, ConfigureDataConnectionEventArgs e)
        {
            MSRegistro RegOut = new MSRegistro();
            Crypto DesencriptarTexto = new Crypto();

            string valServer = RegOut.GetSetting("ConexionSQL", "Server");
            string valDB = RegOut.GetSetting("ConexionSQL", "DBase");
            string valLogin = RegOut.GetSetting("ConexionSQL", "User");
            string valPass = RegOut.GetSetting("ConexionSQL", "Password");

            if (valServer != string.Empty && valDB != string.Empty && valLogin != string.Empty && valPass != string.Empty)
            {
                valServer = DesencriptarTexto.Desencriptar(valServer);
                valDB = DesencriptarTexto.Desencriptar(valDB);
                valLogin = DesencriptarTexto.Desencriptar(valLogin);
                valPass = DesencriptarTexto.Desencriptar(valPass);
                e.ConnectionParameters = new MsSqlConnectionParameters(valServer, valDB, valLogin, valPass, MsSqlAuthorizationType.SqlServer);
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgValReporte.RowCount>0)
            {
                String Moneda = radioMoneda.EditValue.ToString();
                DateTime Fecha = Convert.ToDateTime(dateDel.Text.Trim());
                String F_Del = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
                Fecha = Convert.ToDateTime(dateAl.Text.Trim());
                String F_Al = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
                String Id_Empresa = comboEmpresas.EditValue.ToString().Substring(0, 4);
                
                rpt_Reporte_Salidas rpt = new rpt_Reporte_Salidas(F_Del,F_Al,Id_Empresa,Moneda);
                ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
                ReportPrintTool print = new ReportPrintTool(rpt);
                rpt.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Falta seleccionar un Pedido");
            }
        }
    }
}