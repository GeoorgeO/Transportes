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
    public partial class Frm_Gasto_Indirecto : DevExpress.XtraEditors.XtraForm
    {
        public string vid_GastoIndirecto { get; set; }
        public string vNombre_GastoIndirecto { get; set; }

        public Boolean PaSel { get; set; }

        public Frm_Gasto_Indirecto()
        {
            InitializeComponent();
        }

        private void CargarGastosIndirectos()
        {
            gridControl1.DataSource = null;
            CLS_GastosIndirectos GastosIndirectos = new CLS_GastosIndirectos();

            GastosIndirectos.MtdSeleccionarGastosIndirectos();
            if (GastosIndirectos.Exito)
            {
                gridControl1.DataSource = GastosIndirectos.Datos;
            }
        }



        private void InsertarGastosIndirectos()
        {
            CLS_GastosIndirectos GastosIndirectos = new CLS_GastosIndirectos();
            GastosIndirectos.Id_GastoIndirecto = textId.Text.Trim();
            GastosIndirectos.Nombre_GastoIndirecto = textNombre.Text.Trim();
            GastosIndirectos.Id_cuenta = textCtasContables.Tag.ToString();
            GastosIndirectos.MtdInsertarGastosIndirectos();
            if (GastosIndirectos.Exito)
            {

                CargarGastosIndirectos();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(GastosIndirectos.Mensaje);
            }
        }

        private void EliminarGastosIndirectos()
        {
            CLS_GastosIndirectos GastosIndirectos = new CLS_GastosIndirectos();
            GastosIndirectos.Id_GastoIndirecto = textId.Text.Trim();
            GastosIndirectos.MtdEliminarGastosIndirectos();
            if (GastosIndirectos.Exito)
            {
                CargarGastosIndirectos();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(GastosIndirectos.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
            textCtasContables.Tag = "";
            textCtasContables.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_GastoIndirecto"].ToString();
                    textNombre.Text = row["Nombre_GastoIndirecto"].ToString();
                    textCtasContables.Tag = row["Id_cuenta"].ToString();
                    textCtasContables.Text = row["Nombre_cuenta"].ToString();

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
            CargarGastosIndirectos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarGastosIndirectos();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar una GastoIndirecto.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarGastosIndirectos();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una GastoIndirecto.");
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
                vid_GastoIndirecto = textId.Text;
                vNombre_GastoIndirecto = textNombre.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado un Gasto Indirecto");
            }
        }

        private void btnCtasContables_Click(object sender, EventArgs e)
        {
            Frm_Cuentas_Contables clase = new Frm_Cuentas_Contables();
            clase.PaSel = true;
            clase.ShowDialog();
            if (clase.vId_Cuenta != null)
            {
                textCtasContables.Text = clase.vNombre_Cuenta;
                textCtasContables.Tag = clase.vId_Cuenta;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                if (textId.Text != string.Empty && textNombre.Text != string.Empty)
                {
                    vid_GastoIndirecto = textId.Text;
                    vNombre_GastoIndirecto = textNombre.Text;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("No se ha seleccionado un Gasto Indirecto");
                }
            }
        }
    }
}