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
    public partial class Frm_Empresas : DevExpress.XtraEditors.XtraForm
    {
        public string vId_Empresa { get; set; }
        public string vNombre_Empresa { get; set; }
        public Frm_Empresas()
        {
            InitializeComponent();
        }

        private void CargarEmpresa()
        {
            gridControl1.DataSource = null;
            CLS_Empresa Empresa = new CLS_Empresa();

            Empresa.MtdSeleccionarEmpresa();
            if (Empresa.Exito)
            {
                gridControl1.DataSource = Empresa.Datos;
            }
        }



        private void InsertarEmpresa()
        {
            CLS_Empresa Empresa = new CLS_Empresa();
            Empresa.Id_Empresa = textId.Text.Trim();
            Empresa.Nombre_Empresa = textNombre.Text.Trim();
            Empresa.MtdInsertarEmpresa();
            if (Empresa.Exito)
            {

                CargarEmpresa();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Empresa.Mensaje);
            }
        }

        private void EliminarEmpresa()
        {
            CLS_Empresa Empresa = new CLS_Empresa();
            Empresa.Id_Empresa = textId.Text.Trim();
            Empresa.MtdEliminarEmpresa();
            if (Empresa.Exito)
            {
                CargarEmpresa();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Empresa.Mensaje);
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
                    textId.Text = row["Id_Empresa"].ToString();
                    textNombre.Text = row["Nombre_Empresa"].ToString();


                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Empresas_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {


                InsertarEmpresa();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre a la empresa.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarEmpresa();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una empresa.");
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
                vId_Empresa = textId.Text;
                vNombre_Empresa = textNombre.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No ha seleccionado una empresa");
            }
        }
    }
}