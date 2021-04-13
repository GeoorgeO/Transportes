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
    public partial class Frm_ServiciosCatalogo : DevExpress.XtraEditors.XtraForm
    {
        public string IdServicio { get; set; }
        public string Servicio { get; set; }
        public Boolean PaSel { get; set; }

        public Frm_ServiciosCatalogo()
        {
            InitializeComponent();
        }

        private void CargarServicio()
        {
            gridControl1.DataSource = null;
            CLS_ServiciosCatalogo Clase = new CLS_ServiciosCatalogo();

            Clase.MtdSeleccionarServicio();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }



        private void InsertarServicio()
        {
            CLS_ServiciosCatalogo Clase = new CLS_ServiciosCatalogo();
            Clase.Id_Servicio = textId.Text.Trim();
            Clase.Nombre_Servicio = textNombre.Text.Trim();
            Clase.MtdInsertarServicio();
            if (Clase.Exito)
            {

                CargarServicio();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarServicio()
        {
            CLS_ServiciosCatalogo Clase = new CLS_ServiciosCatalogo();
            Clase.Id_Servicio = textId.Text.Trim();
            Clase.MtdEliminarServicio();
            if (Clase.Exito)
            {
                CargarServicio();
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
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_Servicio"].ToString();
                    textNombre.Text = row["Nombre_Servicio"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_ServiciosCatalogo_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarServicio();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {


                InsertarServicio();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar la descripción del servicio de forma breve.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarServicio();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un servicio.");
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
            IdServicio = textId.Text.Trim();
            Servicio = textNombre.Text.Trim();
            this.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                IdServicio = textId.Text.Trim();
                Servicio = textNombre.Text.Trim();
                this.Close();
            }
        }
    }
}