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
    public partial class Frm_Tipo_Activo : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Tipo_Activo()
        {
            InitializeComponent();
        }


        private void CargarTiposActivos()
        {
            CLS_Tipo_Activo TipoActivo = new CLS_Tipo_Activo();
            
            TipoActivo.MtdSeleccionarTiposActivos();
            if (TipoActivo.Exito)
            {
                gridControl1.DataSource = TipoActivo.Datos;
            }
        }

        private void SeleccionarTipoActivo()
        {
           gridControl1.DataSource = null;
           CLS_Tipo_Activo TipoActivo = new CLS_Tipo_Activo();

            TipoActivo.MtdSeleccionarTiposActivos();
            if (TipoActivo.Exito)
            {
                gridControl1.DataSource = TipoActivo.Datos;
            }
        }

        private void InsertarTipoActivo()
        {
            CLS_Tipo_Activo TipoActivo = new CLS_Tipo_Activo();
            TipoActivo.Id_Tipo_Activo = textId.Text.Trim();
            TipoActivo.Nombre_Tipo_Activo = textNombre.Text.Trim();
            TipoActivo.MtdInsertarTipoActivo();
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

        private void EliminarTipoActivo()
        {
            CLS_Tipo_Activo TipoActivo = new CLS_Tipo_Activo();
            TipoActivo.Id_Tipo_Activo = textId.Text.Trim();
            TipoActivo.MtdEliminarTipoActivo();
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
                    textId.Text = row["Id_Tipo_Activo"].ToString();
                    textNombre.Text = row["Nombre_Tipo_Activo"].ToString();
                    
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Tipo_Activo_Load(object sender, EventArgs e)
        {
            SeleccionarTipoActivo();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                if (textId.Text.ToString().Trim().Length==0)
                {
                    textId.Text = "-9";
                }

                InsertarTipoActivo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un departamento y una actividad.");
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
                XtraMessageBox.Show("Es necesario seleccionar un departamento y una actividad.");
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
    }
}