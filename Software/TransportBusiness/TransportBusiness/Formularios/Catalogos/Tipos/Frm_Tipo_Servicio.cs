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
    public partial class Frm_Tipo_Servicio : DevExpress.XtraEditors.XtraForm
    {
        public string IdTipoServicio { get; set; }
        public string TipoServicio { get; set; }
        public Boolean PaSel { get; set; }

        public Frm_Tipo_Servicio()
        {
            InitializeComponent();
        }

        private void CargarTiposServicio()
        {
            gridControl1.DataSource = null;
            CLS_TiposServicio Clase = new CLS_TiposServicio();

            Clase.MtdSeleccionarTiposServicio();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private void InsertarTiposServicio()
        {
            CLS_TiposServicio Clase = new CLS_TiposServicio();
            Clase.Id_TipoServicio = textId.Text.Trim();
            Clase.Nombre_TipoServicio = textNombre.Text.Trim();
            Clase.Abreviatura = textAlias.Text.Trim();
            Clase.MtdInsertarTiposServicio();
            if (Clase.Exito)
            {

                CargarTiposServicio();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarTiposServicio()
        {
            CLS_TiposServicio Clase = new CLS_TiposServicio();
            Clase.Id_TipoServicio = textId.Text.Trim();
            Clase.MtdEliminarTiposServicio();
            if (Clase.Exito)
            {
                CargarTiposServicio();
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
            textNombre.Text = "";
            textAlias.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_TipoServicio"].ToString();
                    textNombre.Text = row["Nombre_TipoServicio"].ToString();
                    textAlias.Text = row["Abreviatura"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Tipo_Servicio_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarTiposServicio();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarTiposServicio();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al tipo de servicio.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 )
            {
                EliminarTiposServicio();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un tipo de servicio.");
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

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdTipoServicio = textId.Text.Trim();
            TipoServicio = textNombre.Text.Trim();
            this.Close();
        }
    }
}