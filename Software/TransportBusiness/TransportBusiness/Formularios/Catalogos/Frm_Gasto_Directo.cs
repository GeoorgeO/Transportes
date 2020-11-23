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
    public partial class Frm_Gasto_Directo : DevExpress.XtraEditors.XtraForm
    {
        public string vid_GastoDirecto { get; set; }
        public string vNombre_GastoDirecto { get; set; }

        public Boolean PaSel { get; set; }

        public Frm_Gasto_Directo()
        {
            InitializeComponent();
        }

        private void CargarGastosDirectos()
        {
            gridControl1.DataSource = null;
            CLS_GastosDirectos GastosDirectos = new CLS_GastosDirectos();

            GastosDirectos.MtdSeleccionarGastosDirectos();
            if (GastosDirectos.Exito)
            {
                gridControl1.DataSource = GastosDirectos.Datos;
            }
        }



        private void InsertarGastosDirectos()
        {
            CLS_GastosDirectos GastosDirectos = new CLS_GastosDirectos();
            GastosDirectos.Id_GastoDirecto = textId.Text.Trim();
            GastosDirectos.Nombre_GastoDirecto = textNombre.Text.Trim();
            GastosDirectos.MtdInsertarGastosDirectos();
            if (GastosDirectos.Exito)
            {

                CargarGastosDirectos();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(GastosDirectos.Mensaje);
            }
        }

        private void EliminarGastosDirectos()
        {
            CLS_GastosDirectos GastosDirectos = new CLS_GastosDirectos();
            GastosDirectos.Id_GastoDirecto = textId.Text.Trim();
            GastosDirectos.MtdEliminarGastosDirectos();
            if (GastosDirectos.Exito)
            {
                CargarGastosDirectos();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(GastosDirectos.Mensaje);
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
                    textId.Text = row["Id_GastoDirecto"].ToString();
                    textNombre.Text = row["Nombre_GastoDirecto"].ToString();


                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Marcas_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarGastosDirectos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarGastosDirectos();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar una GastoDirecto.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarGastosDirectos();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una GastoDirecto.");
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
            if(textId.Text!=string.Empty && textNombre.Text!=string.Empty)
            {
                vid_GastoDirecto = textId.Text;
                vNombre_GastoDirecto = textNombre.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado una GastoDirecto");
            }
        }
    }
}