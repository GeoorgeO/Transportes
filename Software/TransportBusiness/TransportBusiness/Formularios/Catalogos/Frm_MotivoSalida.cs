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
    public partial class Frm_MotivoSalida : DevExpress.XtraEditors.XtraForm
    {

        public Boolean PaSel { get; set; }

        public Frm_MotivoSalida()
        {
            InitializeComponent();
        }

        public string IdMotivoSalida { get; set; }
        public string MotivoSalida { get; set; }

        private void CargarMotivoSalida()
        {
            gridControl1.DataSource = null;
            CLS_MotivoSalidas Clase = new CLS_MotivoSalidas();

            Clase.MtdSeleccionarMotivoSalida();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private void InsertarMotivoSalida()
        {
            CLS_MotivoSalidas Clase = new CLS_MotivoSalidas();

            Clase.Id_MotivoSalida = textId.Text.Trim();
            Clase.Nombre_MotivoSalida = textNombre.Text.Trim();

            Clase.MtdInsertarMotivoSalida();

            if (Clase.Exito)
            {
                CargarMotivoSalida();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarMotivoSalida()
        {
            CLS_MotivoSalidas Clase = new CLS_MotivoSalidas();
            Clase.Id_MotivoSalida = textId.Text.Trim();
            Clase.MtdEliminarMotivoSalida();
            if (Clase.Exito)
            {
                CargarMotivoSalida();
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
                    textId.Text = row["Id_MotivoSalida"].ToString();
                    textNombre.Text = row["Nombre_MotivoSalida"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_MotivoSalida_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarMotivoSalida();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {


                InsertarMotivoSalida();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al Motivo de Salida.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0)
            {
                EliminarMotivoSalida();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Motivo de Salida.");
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
            IdMotivoSalida = textId.Text.Trim();
            MotivoSalida = textNombre.Text.Trim();
            this.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                IdMotivoSalida = textId.Text.Trim();
                MotivoSalida = textNombre.Text.Trim();
                this.Close();
            }
        }
    }
}