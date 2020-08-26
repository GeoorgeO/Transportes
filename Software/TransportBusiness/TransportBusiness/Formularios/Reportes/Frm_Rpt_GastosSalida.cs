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
    public partial class Frm_Rpt_GastosSalida : DevExpress.XtraEditors.XtraForm
    {

        private static Frm_Rpt_GastosSalida m_FormDefInstance;
        public static Frm_Rpt_GastosSalida DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Rpt_GastosSalida();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        public Frm_Rpt_GastosSalida()
        {
            InitializeComponent();
        }

        private void CargarGastos()
        {
            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
            CLS_GastosSalidas Clase = new CLS_GastosSalidas();
            Clase.Parametro = radioParametro.EditValue.ToString();
            DateTime Fecha=Convert.ToDateTime(dateDel.Text.Trim());
            Clase.F_Del = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Fecha = Convert.ToDateTime(dateAl.Text.Trim());
            Clase.F_Al = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Activo = textActivo.Text;
            Clase.MtdSeleccionarGastos();
            if (Clase.Exito)
            {
                gridControl2.DataSource = Clase.Datos;
            }
        }

        private void CargarGastosDet(string activo)
        {
            gridControl1.DataSource = null;
            CLS_GastosSalidas Clase = new CLS_GastosSalidas();
            if (radioParametro.EditValue.ToString().Equals("F"))
            {
                Clase.Parametro = "2";
            }
            else
            {
                Clase.Parametro = radioParametro.EditValue.ToString();
            }
           
            DateTime Fecha = Convert.ToDateTime(dateDel.Text.Trim());
            Clase.F_Del = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Fecha = Convert.ToDateTime(dateAl.Text.Trim());
            Clase.F_Al = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Activo = activo;
            Clase.MtdSeleccionarGastosDet();
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

        private void Frm_Rpt_GastosSalida_Load(object sender, EventArgs e)
        {
            radioParametro.EditValue = 'F';
            radioMoneda.EditValue = "P";
            dateDel.EditValue =  DateTime.Today.AddDays(-7);
            dateAl.EditValue = DateTime.Today;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGastos();
        }

        

        private void radioParametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioParametro.EditValue.Equals( 'F'))
            {
                textActivo.Enabled = false;
                btnbuscar.Enabled = false;
                textActivo.Text = "";
                dateAl.Enabled = true;
                dateDel.Enabled = true;
            }
            if (radioParametro.EditValue.Equals('A'))
            {
                textActivo.Enabled = true;
                btnbuscar.Enabled = true;
                textActivo.Text = "";
                dateAl.Enabled = false;
                dateDel.Enabled = false;
            }
            if (radioParametro.EditValue.Equals('2'))
            {
                dateAl.Enabled = true;
                dateDel.Enabled = true;
                textActivo.Enabled = true;
                btnbuscar.Enabled = true;
                textActivo.Text = "";
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    DataRow row = this.gridView2.GetDataRow(i);
                    CargarGastosDet( row["Id_Activo"].ToString());
                  
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioMoneda.EditValue.Equals("P"))
            {
                Monto_Factura_P.Visible = true;
                Monto_Factura_D.Visible = false;

                Transfe_P.Visible = true;
                Transfe_D.Visible = false;

                Caseta_P.Visible = true;
                Caseta_D.Visible = false;

                PFP_P.Visible = true;
                PFP_D.Visible = false;

                tReten1_P.Visible = true;
                tReten1_D.Visible = false;

                Pension_P.Visible = true;
                Pension_D.Visible = false;

                Lavada_P.Visible = true;
                Lavada_D.Visible = false;

                Thermo_P.Visible = true;
                Thermo_D.Visible = false;

                Otros_P.Visible = true;
                Otros_D.Visible = false;
            }
            else
            {
                Monto_Factura_D.Visible = true;
                Monto_Factura_P.Visible = false;

                Transfe_D.Visible = true;
                Transfe_P.Visible = false;

                Caseta_D.Visible = true;
                Caseta_P.Visible = false;

                PFP_D.Visible = true;
                PFP_P.Visible = false;

                tReten1_D.Visible = true;
                tReten1_P.Visible = false;

                Pension_D.Visible = true;
                Pension_P.Visible = false;

                Lavada_D.Visible = true;
                Lavada_P.Visible = false;

                Thermo_D.Visible = true;
                Thermo_P.Visible = false;

                Otros_D.Visible = true;
                Otros_P.Visible = false;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Frm_Activos frm = new Frm_Activos();
            frm.PaSel = true;
            frm.ShowDialog();

            textActivo.Text = frm.IdActivo;
            textActivo.Tag = frm.Activo;
        }

        private void btnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new System.IO.FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (System.IO.File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}