using System;

using System.Data;

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

        //GridControlCheckMarksSelection gridCheckMarksPalets;
        //string CadenaCodigos = null;
        //StringBuilder sb = new StringBuilder();

        public Frm_Rpt_GastosSalida()
        {
            InitializeComponent();
        }

        private void CargarGastos()
        {
            CLS_Gastos_Contpaq gs = new CLS_Gastos_Contpaq();
            gs.MtdSeleccionarCtasNoConsidera();
            string Cadena = String.Empty;
            if (gs.Exito)
            {
                for (int i = 0; i < gs.Datos.Rows.Count; i++)
                {

                    string s = gs.Datos.Rows[i]["Id_cuenta"].ToString(); ;

                    if (i == 0)
                    {
                        Cadena = s;
                    }
                    else
                    {
                        Cadena = Cadena + "," + s;
                    }

                }
            }

         

            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
            CLS_GastosSalidas Clase = new CLS_GastosSalidas();
            Clase.Parametro = radioParametro.EditValue.ToString();
            DateTime Fecha=Convert.ToDateTime(dateDel.Text.Trim());
            Clase.F_Del = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Fecha = Convert.ToDateTime(dateAl.Text.Trim());
            Clase.F_Al = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Activo = textActivo.Text;
            Clase.Cuentas = Cadena;
            if (checkEmpresas.Checked)
            {
                Clase.Id_Empresa = "";
            }
            else
            {
                Clase.Id_Empresa =  comboEmpresas.EditValue.ToString().Substring(0,4);
            }
           
            Clase.MtdSeleccionarGastos();
            if (Clase.Exito)
            {
                gridControl2.DataSource = Clase.Datos;
            }
        }

        private void CargarGastosCuentas()
        {
            gridControl3.DataSource = null;


            CLS_Gastos_Contpaq gs = new CLS_Gastos_Contpaq();
            gs.MtdSeleccionarCtasNoConsidera();
            string Cadena = String.Empty;
            if (gs.Exito)
            {
                for (int i = 0; i < gs.Datos.Rows.Count; i++)
                {

                    string s = gs.Datos.Rows[i]["Id_cuenta"].ToString(); ;

                    if (i == 0)
                    {
                        Cadena = s;
                    }
                    else
                    {
                        Cadena = Cadena + "," + s;
                    }

                }
            }

            CLS_GastosSalidas Clase = new CLS_GastosSalidas();
            
            DateTime Fecha = Convert.ToDateTime(dateDel.Text.Trim());
            Clase.F_Del = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Fecha = Convert.ToDateTime(dateAl.Text.Trim());
            Clase.F_Al = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            if (checkEmpresas.Checked)
            {
                Clase.Id_Empresa = "";
            }
            else
            {
                Clase.Id_Empresa = comboEmpresas.EditValue.ToString().Substring(0, 4);
            }
            Clase.Cuentas = Cadena;
            Clase.MtdSeleccionarGastosCuentas();
            if (Clase.Exito)
            {
                gridControl3.DataSource = Clase.Datos;
            }
        }

        private void CargarEmpresas()
        {
            comboEmpresas.Properties.Items.Clear();
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
                comboEmpresas.SelectedIndex=0;
            }
        }

        private void CargarGastosDet(string activo)
        {
            gridControl1.DataSource = null;


            CLS_Gastos_Contpaq gs = new CLS_Gastos_Contpaq();
            gs.MtdSeleccionarCtasNoConsidera();
            string Cadena = String.Empty;
            if (gs.Exito)
            {
                for (int i = 0; i < gs.Datos.Rows.Count; i++)
                {

                    string s = gs.Datos.Rows[i]["Id_cuenta"].ToString(); ;

                    if (i == 0)
                    {
                        Cadena = s;
                    }
                    else
                    {
                        Cadena = Cadena + "," + s;
                    }

                }
            }


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
       
            if (checkEmpresas.Checked)
            {
                Clase.Id_Empresa = "";
            }
            else
            {
                Clase.Id_Empresa = comboEmpresas.EditValue.ToString().Substring(0, 4);
            }
            Clase.Cuentas = Cadena;
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

            //GridMultiplePalets();
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


       

        //private void GridMultiplePalets()
        //{
        //    gridCheckMarksPalets = new GridControlCheckMarksSelection(gridView2);
        //    gridCheckMarksPalets.SelectionChanged += gridCheckMarksAcuerdos_SelectionChanged;
        //}
        //void gridCheckMarksAcuerdos_SelectionChanged(object sender, EventArgs e)
        //{
        //    CadenaCodigos = string.Empty;
        //    if (ActiveControl is DevExpress.XtraGrid.GridControl)
        //    {

        //        foreach (DataRowView rv in (sender as GridControlCheckMarksSelection).selection)
        //        {
        //            if (sb.ToString().Length > 0) { sb.Append(", "); }
        //            sb.AppendFormat("{0}", rv["Id_Activo"]);

        //            if (CadenaCodigos != string.Empty)
        //            {
        //                CadenaCodigos = string.Format("{0},{1}", CadenaCodigos, rv["Id_Activo"]);
        //            }
        //            else
        //            {
        //                CadenaCodigos = rv["Id_Activo"].ToString();
        //            }
        //        }
        //    }
        //    if (CadenaCodigos == string.Empty)
        //    {
        //        btnExportar.Enabled = false;
        //    }
        //    else
        //    {
        //        btnExportar.Enabled = true;
        //    }
        //    CargarGastosDet(CadenaCodigos);

        //}

        private void gridControl2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string Tactivos="";
            //    //foreach (int i in this.gridView2.GetSelectedRows())
            //    //{
            //    //    DataRow row = this.gridView2.GetDataRow(i);
            //    //    CargarGastosDet( row["Id_Activo"].ToString());

            //    //}

            //    System.Collections.ArrayList rows = new System.Collections.ArrayList();

            //    // Add the selected rows to the list.
            //    Int32[] selectedRowHandles = gridView2.GetSelectedRows();
            //    for (int i = 0; i < selectedRowHandles.Length; i++)
            //    {
            //        int selectedRowHandle = selectedRowHandles[i];
            //        if (selectedRowHandle >= 0)
            //            rows.Add(gridView2.GetDataRow(selectedRowHandle));
            //    }
            //    try
            //    {
            //        gridView2.BeginUpdate();
            //        for (int i = 0; i < rows.Count; i++)
            //        {
            //            DataRow row = rows[i] as DataRow;
            //            if (Tactivos.Length > 0)
            //            {
            //                Tactivos = Tactivos+ "," + row[0].ToString() ;
            //            }
            //            else
            //            {
            //                Tactivos = row[0].ToString() ;
            //            }
                        
            //            // Change the field value.
            //            //row["Discontinued"] = true;
            //        }
            //    }
            //    finally
            //    {
            //        gridView2.EndUpdate();
            //    }
            //    CargarGastosDet(Tactivos);

            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message);
            //}
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioMoneda.EditValue.Equals("P"))
            {
                Nombre_InternoG.VisibleIndex = 1;
                Nombre_Empresa.VisibleIndex = 2;

                Monto_Factura_DG.Visible = false;
                Monto_Factura_DG.VisibleIndex = -1;
                Gasto_Total_DG.Visible = false;
                Gasto_Total_DG.VisibleIndex = -1;
                Utilidad_Total_DG.Visible = false;
                Utilidad_Total_DG.VisibleIndex = -1;
                GastoIndirecto_D.Visible = false;
                GastoIndirecto_D.VisibleIndex = -1;
                Monto_Viaje_DG.Visible = false;
                Monto_Viaje_DG.VisibleIndex = -1;
                Rendimiento_Total_DG.Visible = false;
                Rendimiento_Total_DG.VisibleIndex = -1;

                Monto_Factura_PG.Visible = true;
                Monto_Factura_PG.VisibleIndex = 4;
                Gasto_Total_PG.Visible = true;
                Gasto_Total_PG.VisibleIndex = 5;
                GastoIndirecto_P.Visible = true;
                GastoIndirecto_P.VisibleIndex = 6;
                Utilidad_Total_PG.Visible = true;
                Utilidad_Total_PG.VisibleIndex = 7;
                Monto_Viaje_PG.Visible = true;
                Monto_Viaje_PG.VisibleIndex = 8;
                Rendimiento_Total_PG.Visible = true;
                Rendimiento_Total_PG.VisibleIndex = 9;



                Fecha_Salida.VisibleIndex = 1;
                Nombre_Interno.VisibleIndex = 2;
                Operador.VisibleIndex = 3;
                Origen.VisibleIndex = 4;
                Destino.VisibleIndex = 5;
                Nombre_Cliente.VisibleIndex = 6;

                Monto_Factura_D.Visible = false;
                Monto_Factura_D.VisibleIndex = -1;
                Diesel_D.Visible = false;
                Diesel_D.VisibleIndex = -1;
                Transfe_D.Visible = false;
                Transfe_D.VisibleIndex = -1;
                Caseta_D.Visible = false;
                Caseta_D.VisibleIndex = -1;
                PFP_D.Visible = false;
                PFP_D.VisibleIndex = -1;
                tReten1_D.Visible = false;
                tReten1_D.VisibleIndex = -1;
                Pension_D.Visible = false;
                Pension_D.VisibleIndex = -1;
                Lavada_D.Visible = false;
                Lavada_D.VisibleIndex = -1;
                Thermo_D.Visible = false;
                Thermo_D.VisibleIndex = -1;
               
                Comision_Chofer_D.Visible = false;
                Comision_Chofer_D.VisibleIndex = -1;
                Otros_D.Visible = false;
                Otros_D.VisibleIndex = -1;
                Gasto_Total_D.Visible = false;
                Gasto_Total_D.VisibleIndex = -1;
                PGastoIndirecto_D.Visible = false;
                PGastoIndirecto_D.VisibleIndex = -1;
                Ganancias_Total_D.Visible = false;
                Ganancias_Total_D.VisibleIndex = -1;
                Monto_Viaje_D.Visible = false;
                Monto_Viaje_D.VisibleIndex = -1;
                Rendimiento_Total_D.Visible = false;
                Rendimiento_Total_D.VisibleIndex = -1;

                Monto_Factura_P.Visible = true;
                Monto_Factura_P.VisibleIndex = 8;
                Diesel_P.Visible = true;
                Diesel_P.VisibleIndex = 9;
                Transfe_P.Visible = true;
                Transfe_P.VisibleIndex = 10;
                Caseta_P.Visible = true;
                Caseta_P.VisibleIndex = 11;
                PFP_P.Visible = true;
                PFP_P.VisibleIndex = 12;
                tReten1_P.Visible = true;
                tReten1_P.VisibleIndex = 12;
                Pension_P.Visible = true;
                Pension_P.VisibleIndex = 13;
                Lavada_P.Visible = true;
                Lavada_P.VisibleIndex = 14;
                Thermo_P.Visible = true;
                Thermo_P.VisibleIndex = 15;
               
                Comision_Chofer_P.Visible = true;
                Comision_Chofer_P.VisibleIndex = 16;
                Otros_P.Visible = true;
                Otros_P.VisibleIndex = 17;
                Gasto_Total_P.Visible = true;
                Gasto_Total_P.VisibleIndex = 18;
                PGastoIndirecto_P.Visible = true;
                PGastoIndirecto_P.VisibleIndex = 19;
                Ganancias_Total_P.Visible = true;
                Ganancias_Total_P.VisibleIndex = 20;
                Monto_Viaje_P.Visible = true;
                Monto_Viaje_P.VisibleIndex = 21;
                Rendimiento_Total_P.Visible = true;
                Rendimiento_Total_P.VisibleIndex = 22;

            }
            else
            {
                Nombre_InternoG.VisibleIndex = 1;
                Nombre_Empresa.VisibleIndex = 2;

                Monto_Factura_PG.Visible = false;
                Monto_Factura_PG.VisibleIndex = -1;
                Gasto_Total_PG.Visible = false;
                Gasto_Total_PG.VisibleIndex = -1;
                Utilidad_Total_PG.Visible = false;
                Utilidad_Total_PG.VisibleIndex = -1;
                GastoIndirecto_P.Visible = false;
                GastoIndirecto_P.VisibleIndex = -1;
                Monto_Viaje_PG.Visible = false;
                Monto_Viaje_PG.VisibleIndex = -1;
                Rendimiento_Total_PG.Visible = false;
                Rendimiento_Total_PG.VisibleIndex = -1;

                Monto_Factura_DG.Visible = true;
                Monto_Factura_DG.VisibleIndex = 4;
                Gasto_Total_DG.Visible = true;
                Gasto_Total_DG.VisibleIndex = 5;
                GastoIndirecto_D.Visible = true;
                GastoIndirecto_D.VisibleIndex = 6;
                Utilidad_Total_DG.Visible = true;
                Utilidad_Total_DG.VisibleIndex = 7;
                Monto_Viaje_DG.Visible = true;
                Monto_Viaje_DG.VisibleIndex = 8;
                Rendimiento_Total_DG.Visible = true;
                Rendimiento_Total_DG.VisibleIndex = 9;


                Fecha_Salida.VisibleIndex = 1;
                Nombre_Interno.VisibleIndex = 2;
                Operador.VisibleIndex = 3;
                Origen.VisibleIndex = 4;
                Destino.VisibleIndex = 5;
                Nombre_Cliente.VisibleIndex = 6;

                Monto_Factura_P.Visible = false;
                Monto_Factura_P.VisibleIndex = -1;
                Diesel_P.Visible = false;
                Diesel_P.VisibleIndex = -1;
                Transfe_P.Visible = false;
                Transfe_P.VisibleIndex = -1;
                Caseta_P.Visible = false;
                Caseta_P.VisibleIndex = -1;
                PFP_P.Visible = false;
                PFP_P.VisibleIndex = -1;
                tReten1_P.Visible = false;
                tReten1_P.VisibleIndex = -1;
                Pension_P.Visible = false;
                Pension_P.VisibleIndex = -1;
                Lavada_P.Visible = false;
                Lavada_P.VisibleIndex = -1;
                Thermo_P.Visible = false;
                Thermo_P.VisibleIndex = -1;
                
                Comision_Chofer_P.Visible = false;
                Comision_Chofer_P.VisibleIndex = -1;
                Otros_P.Visible = false;
                Otros_P.VisibleIndex = -1;
                Gasto_Total_P.Visible = false;
                Gasto_Total_P.VisibleIndex = -1;
                PGastoIndirecto_P.Visible = false;
                PGastoIndirecto_P.VisibleIndex = -1;
                Ganancias_Total_P.Visible = false;
                Ganancias_Total_P.VisibleIndex = -1;
                Monto_Viaje_P.Visible = false;
                Monto_Viaje_P.VisibleIndex = -1;
                Rendimiento_Total_P.Visible = false;
                Rendimiento_Total_P.VisibleIndex = -1;

                Monto_Factura_D.Visible = true;
                Monto_Factura_D.VisibleIndex = 8;
                Diesel_D.Visible = true;
                Diesel_D.VisibleIndex = 9;
                Transfe_D.Visible = true;
                Transfe_D.VisibleIndex = 10;
                Caseta_D.Visible = true;
                Caseta_D.VisibleIndex = 11;
                PFP_D.Visible = true;
                PFP_D.VisibleIndex = 12;
                tReten1_D.Visible = true;
                tReten1_D.VisibleIndex = 12;
                Pension_D.Visible = true;
                Pension_D.VisibleIndex = 13;
                Lavada_D.Visible = true;
                Lavada_D.VisibleIndex = 14;
                Thermo_D.Visible = true;
                Thermo_D.VisibleIndex = 15;
                
                Comision_Chofer_D.Visible = true;
                Comision_Chofer_D.VisibleIndex = 16;
                Otros_D.Visible = true;
                Otros_D.VisibleIndex = 17;
                Gasto_Total_D.Visible = true;
                Gasto_Total_D.VisibleIndex = 18;
                PGastoIndirecto_D.Visible = true;
                PGastoIndirecto_D.VisibleIndex = 19;
                Ganancias_Total_D.Visible = true;
                Ganancias_Total_D.VisibleIndex = 20;
                Monto_Viaje_D.Visible = true;
                Monto_Viaje_D.VisibleIndex = 21;
                Rendimiento_Total_D.Visible = true;
                Rendimiento_Total_D.VisibleIndex = 22;
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

        private void btnImpimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Rpt_GastosSalida_Preview clase = new Frm_Rpt_GastosSalida_Preview();
            clase.ShowDialog();
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                string Tactivos = "";
                //foreach (int i in this.gridView2.GetSelectedRows())
                //{
                //    DataRow row = this.gridView2.GetDataRow(i);
                //    CargarGastosDet( row["Id_Activo"].ToString());

                //}

                System.Collections.ArrayList rows = new System.Collections.ArrayList();

                // Add the selected rows to the list.
                Int32[] selectedRowHandles = gridView2.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                        rows.Add(gridView2.GetDataRow(selectedRowHandle));
                }
                try
                {
                    gridView2.BeginUpdate();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i] as DataRow;
                        if (Tactivos.Length > 0)
                        {
                            Tactivos = Tactivos + "," + row[0].ToString();
                        }
                        else
                        {
                            Tactivos = row[0].ToString();
                        }

                        // Change the field value.
                        //row["Discontinued"] = true;
                    }
                }
                finally
                {
                    gridView2.EndUpdate();
                }
                CargarGastosDet(Tactivos);
                CargarGastosCuentas();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void checkEmpresas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEmpresas.Checked)
            {
                comboEmpresas.Enabled = false;
            }else
            {
                comboEmpresas.Enabled = true;
                CargarEmpresas();
            }
        }
    }
}