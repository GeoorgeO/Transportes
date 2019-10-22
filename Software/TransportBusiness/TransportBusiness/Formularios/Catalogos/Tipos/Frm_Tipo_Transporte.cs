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
    public partial class Frm_Tipo_Transporte : DevExpress.XtraEditors.XtraForm
    {
        public string vId_Tipo_Transporte { get; set; }
        public string vNombre_Tipo_Transporte { get; set; }
        public Frm_Tipo_Transporte()
        {
            InitializeComponent();
        }

        private void CargarTiposTransportes()
        {
            gridControl1.DataSource = null;
            CLS_Tipo_Transporte TipoTransporte = new CLS_Tipo_Transporte();

            TipoTransporte.MtdSeleccionarTipoTransporte();
            if (TipoTransporte.Exito)
            {
                gridControl1.DataSource = TipoTransporte.Datos;
            }
        }



        private void InsertarTipoTransporte()
        {
            CLS_Tipo_Transporte TipoTransporte = new CLS_Tipo_Transporte();
            TipoTransporte.Id_Tipo_Transporte = textId.Text.Trim();
            TipoTransporte.Nombre_Tipo_Transporte = textNombre.Text.Trim();
            TipoTransporte.MtdInsertarTipoTransporte();
            if (TipoTransporte.Exito)
            {

                CargarTiposTransportes();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(TipoTransporte.Mensaje);
            }
        }

        private void EliminarTipoTransporte()
        {
            CLS_Tipo_Transporte TipoTransporte = new CLS_Tipo_Transporte();
            TipoTransporte.Id_Tipo_Transporte = textId.Text.Trim();
            TipoTransporte.MtdEliminarTipoTransporte();
            if (TipoTransporte.Exito)
            {
                CargarTiposTransportes();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(TipoTransporte.Mensaje);
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
                    textId.Text = row["Id_Tipo_Transporte"].ToString();
                    textNombre.Text = row["Nombre_Tipo_Transporte"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Tipo_Transporte_Load(object sender, EventArgs e)
        {
            CargarTiposTransportes();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {


                InsertarTipoTransporte();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al tipo de transporte.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarTipoTransporte();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un tipo de transporte.");
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
                vId_Tipo_Transporte = textId.Text;
                vNombre_Tipo_Transporte = textNombre.Text;
                this.Close();
            }
        }
    }
}