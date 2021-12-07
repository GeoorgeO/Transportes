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
    public partial class Frm_RelacionaSalida : DevExpress.XtraEditors.XtraForm
    {
        public Frm_RelacionaSalida()
        {
            InitializeComponent();
        }

        public DateTime Fecha { get; set; }
        public String IdActivo { get; set; }
        public String IdSalida { get; set; }

        private void Frm_RelacionaSalida_Load(object sender, EventArgs e)
        {
            CargarSalidas();
            IdSalida = "";
        }

        private void CargarSalidas()
        {  
            gridControl1.DataSource = null;
            CLS_Carga_Combustible Clase = new CLS_Carga_Combustible();
            
            Clase.FechaCarga = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Activo = IdActivo;
            Clase.MtdSeleccionarCombustibleSalida();
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

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    IdSalida = row["Id_Salida"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }

}