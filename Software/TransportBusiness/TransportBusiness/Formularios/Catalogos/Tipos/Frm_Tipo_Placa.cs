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
    public partial class Frm_Tipo_Placa : DevExpress.XtraEditors.XtraForm
    {
        public string vId_Tipo_Placa { get; set; }
        public string vNombre_Tipo_Placa { get; set; }

        public Boolean PaSel { get; set; }

        public Frm_Tipo_Placa(Boolean BPasel)
        {
            this.PaSel = BPasel;
            InitializeComponent();
        }

        private void CargarTiposPlacas()
        {
            gridControl1.DataSource = null;
            CLS_Tipo_Placa TipoPlaca = new CLS_Tipo_Placa();

            TipoPlaca.MtdSeleccionarTiposPlacas();
            if (TipoPlaca.Exito)
            {
                gridControl1.DataSource = TipoPlaca.Datos;
            }
        }

       

        private void InsertarTipoPlaca()
        {
            CLS_Tipo_Placa TipoPlaca = new CLS_Tipo_Placa();
            TipoPlaca.Id_Tipo_Placa = textId.Text.Trim();
            TipoPlaca.Nombre_Tipo_Placa = textNombre.Text.Trim();
            TipoPlaca.MtdInsertarTipoPlaca();
            if (TipoPlaca.Exito)
            {

                CargarTiposPlacas();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(TipoPlaca.Mensaje);
            }
        }

        private void EliminarTipoPlaca()
        {
            CLS_Tipo_Placa TipoPlaca = new CLS_Tipo_Placa();
            TipoPlaca.Id_Tipo_Placa = textId.Text.Trim();
            TipoPlaca.MtdEliminarTipoPlaca();
            if (TipoPlaca.Exito)
            {
                CargarTiposPlacas();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(TipoPlaca.Mensaje);
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
                    textId.Text = row["Id_Tipo_Placa"].ToString();
                    textNombre.Text = row["Nombre_Tipo_Placa"].ToString();


                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Tipo_Placa_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarTiposPlacas();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                

                InsertarTipoPlaca();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al tipo de placa.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarTipoPlaca();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un tipo de placa.");
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
                vId_Tipo_Placa = textId.Text;
                vNombre_Tipo_Placa = textNombre.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado tipo de placa");
            }
        }
    }
}