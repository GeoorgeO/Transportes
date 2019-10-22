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

namespace TransportBusiness.Formularios.Catalogos.Tipos
{
    public partial class Frm_Tipo_Domicilio : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Tipo_Domicilio()
        {
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
            SeleccionarTipoDomicilio();
        }
        private void SeleccionarTipoDomicilio()
        {
            gridControl1.DataSource = null;
            CLS_Tipo_Domicilio TipoDomicilio = new CLS_Tipo_Domicilio();

            TipoDomicilio.MtdSeleccionarTiposDomicilios();
            if (TipoDomicilio.Exito)
            {
                gridControl1.DataSource = TipoDomicilio.Datos;
            }
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
    }
}