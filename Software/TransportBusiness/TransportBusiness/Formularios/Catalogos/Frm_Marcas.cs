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
    public partial class Frm_Marcas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Marcas()
        {
            InitializeComponent();
        }

        private void CargarMarcas()
        {
            gridControl1.DataSource = null;
            CLS_Marcas Marcas = new CLS_Marcas();

            Marcas.MtdSeleccionarMarcas();
            if (Marcas.Exito)
            {
                gridControl1.DataSource = Marcas.Datos;
            }
        }



        private void InsertarMarcas()
        {
            CLS_Marcas Marcas = new CLS_Marcas();
            Marcas.Id_Marca = textId.Text.Trim();
            Marcas.Nombre_Marca = textNombre.Text.Trim();
            Marcas.MtdInsertarMarcas();
            if (Marcas.Exito)
            {

                CargarMarcas();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Marcas.Mensaje);
            }
        }

        private void EliminarMarcas()
        {
            CLS_Marcas Marcas = new CLS_Marcas();
            Marcas.Id_Marca = textId.Text.Trim();
            Marcas.MtdEliminarMarcas();
            if (Marcas.Exito)
            {
                CargarMarcas();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Marcas.Mensaje);
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
                    textId.Text = row["Id_Marca"].ToString();
                    textNombre.Text = row["Nombre_Marca"].ToString();


                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Marcas_Load(object sender, EventArgs e)
        {
            CargarMarcas();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {


                InsertarMarcas();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar una marca.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarMarcas();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una marca.");
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