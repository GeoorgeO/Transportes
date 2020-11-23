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
    public partial class Frm_Tipo_Cuenta : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Tipo_Cuenta()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string vId_Tipo_Cuenta { get; set; }
        public string vNombre_Tipo_Cuenta { get; set; }

        private void CargarTiposCuentas()
        {
            gridControl1.DataSource = null;
            CLS_Tipo_Cuenta TipoActivo = new CLS_Tipo_Cuenta();

            TipoActivo.MtdSeleccionarTiposCuentas();
            if (TipoActivo.Exito)
            {
                gridControl1.DataSource = TipoActivo.Datos;
            }
        }



        private void InsertarTiposCuentas()
        {
            CLS_Tipo_Cuenta Clase = new CLS_Tipo_Cuenta();
            Clase.Id_tipocuenta = textId.Text.Trim();
            Clase.Nombre_tipocuenta = textNombre.Text.Trim();
            Clase.MtdInsertarTiposCuentas();
            if (Clase.Exito)
            {

                CargarTiposCuentas();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarTiposCuentas()
        {
            CLS_Tipo_Cuenta Clase = new CLS_Tipo_Cuenta();
            Clase.Id_tipocuenta = textId.Text.Trim();
            Clase.MtdEliminarTiposCuentas();
            if (Clase.Exito)
            {
                CargarTiposCuentas();
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

        private void Frm_Tipo_Cuenta_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarTiposCuentas();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_tipocuenta"].ToString();
                    textNombre.Text = row["Nombre_tipocuenta"].ToString();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarTiposCuentas();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al tipo de cuenta.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarTiposCuentas();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un tipo de cuenta.");
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
            if (textId.Text != string.Empty && textNombre.Text != string.Empty)
            {
                vId_Tipo_Cuenta = textId.Text;
                vNombre_Tipo_Cuenta = textNombre.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado tipo de activo");
            }
        }
    }
}