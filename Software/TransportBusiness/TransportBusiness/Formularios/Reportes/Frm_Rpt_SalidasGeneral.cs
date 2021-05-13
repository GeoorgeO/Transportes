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
    public partial class Frm_Rpt_SalidasGeneral : DevExpress.XtraEditors.XtraForm
    {


        private static Frm_Rpt_SalidasGeneral m_FormDefInstance;
        public static Frm_Rpt_SalidasGeneral DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Rpt_SalidasGeneral();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Frm_Rpt_SalidasGeneral()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_SalidasGeneral_Load(object sender, EventArgs e)
        {
            CargarAños();
            CargarEmpresas();

        }

        private void CargarAños()
        {
            comboEmpresas.Properties.Items.Clear();
            comboEmpresas.EditValue = null;



            for (int i = 2019; i <= DateTime.Today.Year; i++) { 
                comboAnio.Properties.Items.Add(i);
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
                comboEmpresas.SelectedIndex = 0;
            }
        }

        private void CargarGridNsalidasxMes()
        {
            


            CLS_Rpt_SalidasG Clase = new CLS_Rpt_SalidasG();
            Clase.Anio = comboAnio.EditValue.ToString();
            if (checkEmpresas.Checked)
            {
                Clase.Id_Empresa = "";
            }
            else
            {
                Clase.Id_Empresa = comboEmpresas.EditValue.ToString().Substring(0, 4);
            }
            Clase.MtdNSalidasxMes();
            if (Clase.Exito)
            {
                
             gridControl2.DataSource = Clase.Datos;
                
            }
            
        }

        private void CargarGridGastosDirectosxMes()
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

            CLS_Rpt_SalidasG Clase = new CLS_Rpt_SalidasG();
            Clase.Anio = comboAnio.EditValue.ToString();
            if (checkEmpresas.Checked)
            {
                Clase.Id_Empresa = "";
            }
            else
            {
                Clase.Id_Empresa = comboEmpresas.EditValue.ToString().Substring(0, 4);
            }
            
            Clase.Moneda = radioMoneda.EditValue.ToString();
            Clase.Cuentas = Cadena;
           
            Clase.MtdGastosDirectosxMes();
            if (Clase.Exito)
            {

                gridControl1.DataSource = Clase.Datos;

            }

        }

        private void CargarGridGastosIndirectosxMes()
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

            CLS_Rpt_SalidasG Clase = new CLS_Rpt_SalidasG();
            Clase.Anio = comboAnio.EditValue.ToString();
            if (checkEmpresas.Checked)
            {
                Clase.Id_Empresa = "";
            }
            else
            {
                Clase.Id_Empresa = comboEmpresas.EditValue.ToString().Substring(0, 4);
            }

            Clase.Moneda = radioMoneda.EditValue.ToString();
            Clase.Cuentas = Cadena;

            Clase.MtdGastosIndirectosxMes();
            if (Clase.Exito)
            {

                gridControl3.DataSource = Clase.Datos;

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGridNsalidasxMes();
            CargarGridGastosDirectosxMes();
            CargarGridGastosIndirectosxMes();
        }

        private void checkEmpresas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEmpresas.Checked)
            {
                comboEmpresas.Enabled = false;
            }
            else
            {
                comboEmpresas.Enabled = true;
                CargarEmpresas();
            }
        }
    }
}