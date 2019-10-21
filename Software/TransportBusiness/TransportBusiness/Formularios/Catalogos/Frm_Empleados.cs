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
    public partial class Frm_Empleados : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Empleados()
        {
            InitializeComponent();
        }

        private void CargarEmpleado()
        {
            gridControl1.DataSource = null;
            CLS_Empleado Empleado = new CLS_Empleado();

            Empleado.MtdSeleccionarEmpleado();
            if (Empleado.Exito)
            {
                gridControl1.DataSource = Empleado.Datos;
            }
        }



        private void InsertarEmpleado()
        {
            CLS_Empleado Empleado = new CLS_Empleado();
            Empleado.Id_Empleado = textIdEmpleado.Text.Trim();
            Empleado.Id_Tipo_Empleado = textTipoEmpleado.Tag.ToString().Trim();
            Empleado.Nombre_Empleado = textEmpleado.Text.Trim();
            Empleado.Telefono = textTelefono.Text.Trim();
            Empleado.RFC = textRFC.Text.Trim();
            Empleado.CURP = textCURP.Text.Trim();
            Empleado.No_Identificacion = textNoIdentificacion.Text.Trim();
            Empleado.Id_Licencia = textLicencia.Tag.ToString().Trim();
            Empleado.MtdInsertarEmpleado();
            if (Empleado.Exito)
            {

                CargarEmpleado();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Empleado.Mensaje);
            }
        }

        private void EliminarEmpleado()
        {
            CLS_Empleado Empleado = new CLS_Empleado();
            Empleado.Id_Empleado = textIdEmpleado.Text.Trim();
            Empleado.MtdEliminarEmpleado();
            if (Empleado.Exito)
            {
                CargarEmpleado();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Empleado.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textIdEmpleado.Text = "";
            textEmpleado.Text = "";
            textTipoEmpleado.Text = "";
            textNoIdentificacion.Text = "";
            textTelefono.Text = "";
            textRFC.Text = "";
            textCURP.Text = "";
            textLicencia.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textIdEmpleado.Text = row["Id_Empleado"].ToString();
                    textTipoEmpleado.Tag = row["Id_Tipo_Empleado"].ToString();
                    textTipoEmpleado.Text=row["Nombre_Tipo_Empleado"].ToString();
                    textEmpleado.Text=row["Nombre_Empleado"].ToString();
                    textTelefono.Text = row["Telefono"].ToString();
                    textRFC.Text = row["RFC"].ToString();
                    textCURP.Text = row["CURP"].ToString();
                    textNoIdentificacion.Text = row["No_Identificacion"].ToString();
                    textLicencia.Tag = row["Id_Licencia"].ToString();
                    textLicencia.Text = row["No_Licencia"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textEmpleado.Text.ToString().Trim().Length > 0)
            {
                if (textTipoEmpleado.Text.ToString().Trim().Length > 0)
                {

                    InsertarEmpleado();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar un tipo de empleado.");
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre de empleado.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textIdEmpleado.Text.Trim().Length > 0)
            {
                EliminarEmpleado();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Estado.");
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

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleado();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Empleados TipoEmpleado = new Frm_Tipo_Empleados(true);

            TipoEmpleado.ShowDialog();

            textTipoEmpleado.Tag = TipoEmpleado.IdTipoEmpleado;
            textTipoEmpleado.Text = TipoEmpleado.TipoEmpleado;
        }

        private void btnbusqlicencia_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Empleados TipoEmpleado = new Frm_Tipo_Empleados(true);

            TipoEmpleado.ShowDialog();

            textTipoEmpleado.Tag = TipoEmpleado.IdTipoEmpleado;
            textTipoEmpleado.Text = TipoEmpleado.TipoEmpleado;
        }
    }
}