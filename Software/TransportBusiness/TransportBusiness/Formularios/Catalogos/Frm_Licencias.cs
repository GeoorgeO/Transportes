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
    public partial class Frm_Licencias : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Licencias()
        {
            InitializeComponent();
        }

        public string IdTipoLicencia { get; set; }
        public string TipoLicencia { get; set; }

        private void CargarLicencias()
        {
            gridControl1.DataSource = null;
            CLS_Licencia Licencia = new CLS_Licencia();

            Licencia.MtdSeleccionarLicencia();
            if (Licencia.Exito)
            {
                gridControl1.DataSource = Licencia.Datos;
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


        private void InsertarLicencia()
        {
            CLS_Licencia Licencia = new CLS_Licencia();
            Licencia.Id_Licencia = textId.Text.Trim();
            Licencia.Id_Tipo_Licencia = textIdTipo.Text.Trim();
            DateTime Fecha = Convert.ToDateTime(deVigencia.Text.Trim());
            
            Licencia.Vigencia = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Licencia.No_Licencia = textNoLic.Text.Trim();   
            Licencia.MtdInsertarLicencia();
            if (Licencia.Exito)
            {

                CargarLicencias();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Licencia.Mensaje);
            }
        }

        private void EliminarLicencia()
        {
            CLS_Licencia Licencia = new CLS_Licencia();
            Licencia.Id_Licencia = textId.Text.Trim();
            Licencia.MtdEliminarLicencia();
            if (Licencia.Exito)
            {
                CargarLicencias();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Licencia.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textIdTipo.Text="";
            textNoLic.Text = "";
            textTipo.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_Licencia"].ToString();
                    textIdTipo.Text = row["Id_Tipo_Licencia"].ToString();
                    textTipo.Text= row["Nombre_Tipo_Licencia"].ToString();
                    deVigencia.Text= row["Vigencia"].ToString();
                    textNoLic.Text= row["No_Licencia"].ToString();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Licencias_Load(object sender, EventArgs e)
        {
            CargarLicencias();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNoLic.Text.ToString().Trim().Length > 0)
            {
                if (textTipo.Text.ToString().Trim().Length > 0)
                {
                    if (deVigencia.Text.ToString().Trim().Length > 0)
                    {


                        InsertarLicencia();
                    }
                    else
                    {
                        XtraMessageBox.Show("Es necesario Agregar la vigencia.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar un tipo de licencia.");
                }
            }
            
            else
            {
                XtraMessageBox.Show("Es necesario Agregar el numero de licencia.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 )
            {
                EliminarLicencia();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una licencia.");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Licencia TipLic = new Frm_Tipo_Licencia(true);
            
            TipLic.ShowDialog();

            textIdTipo.Text = TipLic.IdTipoLicencia;
            textTipo.Text= TipLic.TipoLicencia;
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