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
    public partial class Frm_Tipo_Licencia : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }
        public Frm_Tipo_Licencia(Boolean BPasel)
        {
            this.PaSel = BPasel;
            InitializeComponent();
            
        }

        public string IdTipoLicencia { get; set; }
        public string TipoLicencia { get; set; }
        

        private void CargarTipoLicencia()
        {
            gridControl1.DataSource = null;
            CLS_Tipo_Licencia TipoLicencia = new CLS_Tipo_Licencia();

            TipoLicencia.MtdSeleccionarTipoLicencia();
            if (TipoLicencia.Exito)
            {
                gridControl1.DataSource = TipoLicencia.Datos;
            }
        }



        private void InsertarTipoLicencia()
        {
            CLS_Tipo_Licencia TipoLicencia = new CLS_Tipo_Licencia();
            TipoLicencia.Id_Tipo_Licencia = textId.Text.Trim();
            TipoLicencia.Nombre_Tipo_Licencia = textNombre.Text.Trim();
            TipoLicencia.MtdInsertarTipoLicencia();
            if (TipoLicencia.Exito)
            {

                CargarTipoLicencia();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(TipoLicencia.Mensaje);
            }
        }

        private void EliminarTipoLicencia()
        {
            CLS_Tipo_Licencia TipoLicencia = new CLS_Tipo_Licencia();
            TipoLicencia.Id_Tipo_Licencia = textId.Text.Trim();
            TipoLicencia.MtdEliminarTipoLicencia();
            if (TipoLicencia.Exito)
            {
                CargarTipoLicencia();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(TipoLicencia.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_Tipo_Licencia"].ToString();
                    textNombre.Text = row["Nombre_Tipo_Licencia"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Tipo_Licencia_Load(object sender, EventArgs e)
        {
            if (PaSel==true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarTipoLicencia();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarTipoLicencia();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar el tipo de licencia.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarTipoLicencia();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una empresa.");
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

        

        private void btnSeleccionar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdTipoLicencia = textId.Text.Trim();
            TipoLicencia = textNombre.Text.Trim();
            this.Close();
        }
    }
}