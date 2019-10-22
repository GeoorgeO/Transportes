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
    public partial class Frm_Tipo_Empleados : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }

        public string IdTipoEmpleado { get; set; }
        public string TipoEmpleado { get; set; }

       

        public Frm_Tipo_Empleados(Boolean BPasel)
        {
            this.PaSel = BPasel;
            InitializeComponent();
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
            SeleccionarTipoActivo();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarTipoEmpleado();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al tipo de activo.");
            }
        }
        private void InsertarTipoEmpleado()
        {
            CLS_Tipo_Empleado TipoActivo = new CLS_Tipo_Empleado();
            TipoActivo.Id_Tipo_Empleado = textId.Text.Trim();
            TipoActivo.Nombre_Tipo_Empleado = textNombre.Text.Trim();
            TipoActivo.MtdInsertarTipoEmpleado();
            if (TipoActivo.Exito)
            {

                SeleccionarTipoActivo();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(TipoActivo.Mensaje);
            }
        }
        private void SeleccionarTipoActivo()
        {
            gridControl1.DataSource = null;
            CLS_Tipo_Empleado TipoActivo = new CLS_Tipo_Empleado();

            TipoActivo.MtdSeleccionarTipoEmpleado();
            if (TipoActivo.Exito)
            {
                gridControl1.DataSource = TipoActivo.Datos;
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarTipoActivo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un tipo de empleado.");
            }
        }
        private void EliminarTipoActivo()
        {
            CLS_Tipo_Empleado TipoActivo = new CLS_Tipo_Empleado();
            TipoActivo.Id_Tipo_Empleado = textId.Text.Trim();
            TipoActivo.MtdEliminarTipoEmpleado();
            if (TipoActivo.Exito)
            {
                SeleccionarTipoActivo();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(TipoActivo.Mensaje);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Tipo_Empleados_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            CargarTiposActivos();
        }
        private void CargarTiposActivos()
        {
            gridControl1.DataSource = null;
            CLS_Tipo_Empleado TipoEmpleado = new CLS_Tipo_Empleado();

            TipoEmpleado.MtdSeleccionarTipoEmpleado();
            if (TipoEmpleado.Exito)
            {
                gridControl1.DataSource = TipoEmpleado.Datos;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_Tipo_Empleado"].ToString();
                    textNombre.Text = row["Nombre_Tipo_Empleado"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdTipoEmpleado = textId.Text.Trim();
            TipoEmpleado = textNombre.Text.Trim();
            this.Close();
        }
    }
}