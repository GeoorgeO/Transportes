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
    public partial class Frm_Cuentas_Contables : DevExpress.XtraEditors.XtraForm
    {

        private static Frm_Cuentas_Contables m_FormDefInstance;
        public static Frm_Cuentas_Contables DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Cuentas_Contables();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Boolean PaSel { get; set; }

        public string vId_Cuenta { get; set; }
        public string vNombre_Cuenta { get; set; }

        public Frm_Cuentas_Contables()
        {
            InitializeComponent();
        }

        private void CargarCuentas()
        {
            gridControl1.DataSource = null;
            CLS_Cuentas_contables TipoActivo = new CLS_Cuentas_contables();
            TipoActivo.Activa = 1;
            TipoActivo.MtdSeleccionarCtas();
            if (TipoActivo.Exito)
            {
                gridControl1.DataSource = TipoActivo.Datos;
            }
        }



        private void InsertarCuentas()
        {
            CLS_Cuentas_contables Clase = new CLS_Cuentas_contables();
            Clase.Id_cuenta = textId.Text.Trim();
            Clase.Id_cuenta_padre = textCtasPadre.Tag.ToString();
            Clase.Id_tipocuenta = textTipoCta.Tag.ToString();
            Clase.Nombre_cuenta = textNombre.Text.Trim();
            if (cbNaturaleza.Text.Equals("Deudora"))
            {
                Clase.Naturaleza = "D";
            }else
            {
                Clase.Naturaleza = "A";
            }
            if (checkActiva.Checked)
            {
                Clase.Activa = 0;
            }else
            {
                Clase.Activa = 1;
            }
            

            

            Clase.MtdInsertarCtas();
            if (Clase.Exito)
            {

                CargarCuentas();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarCuentas()
        {
            CLS_Tipo_Cuenta Clase = new CLS_Tipo_Cuenta();
            Clase.Id_tipocuenta = textId.Text.Trim();
            Clase.MtdEliminarTiposCuentas();
            if (Clase.Exito)
            {
                CargarCuentas();
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
            textCtasPadre.Tag = "";
            textCtasPadre.Text = "";
            textTipoCta.Tag = "";
            textTipoCta.Text = "";
            cbNaturaleza.Text = "Deudora";
        }

        private void btnTipoCta_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Cuenta clase = new Frm_Tipo_Cuenta();
            clase.PaSel = true;
            clase.ShowDialog();
            if (clase.vId_Tipo_Cuenta !=null)
            {
                textTipoCta.Text = clase.vNombre_Tipo_Cuenta;
                textTipoCta.Tag = clase.vId_Tipo_Cuenta;
            }
        }

        private void btnCtasPadre_Click(object sender, EventArgs e)
        {
            Frm_CuentasxNivel clase = new Frm_CuentasxNivel();
            clase.vId_cuenta_exclusa = textId.Text;
            clase.ShowDialog();
            if (clase.vId_cuenta != null)
            {
                textCtasPadre.Text = clase.vNombre_cuenta;
                textCtasPadre.Tag = clase.vId_cuenta;
            }
        }

        private void Frm_Cuentas_Contables_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarCuentas();
            LimpiarCampos();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_cuenta"].ToString();
                    textNombre.Text = row["Nombre_cuenta"].ToString();
                    textTipoCta.Text= row["Nombre_tipocuenta"].ToString();
                    textTipoCta.Tag = row["Id_tipocuenta"].ToString();
                    if (row["Naturaleza"].ToString().Equals("D"))
                    {
                        cbNaturaleza.Text = "Deudora";
                    }else
                    {
                        cbNaturaleza.Text = "Acreedora";
                    }
                    textCtasPadre.Text= row["Nombre_Padre"].ToString();
                    textCtasPadre.Tag = row["Id_cuenta_padre"].ToString();
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
                InsertarCuentas();
                ActualizaNivel();
               
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al tipo de cuenta.");
            }
        }

        private void ActualizaNivel()
        {
            CLS_Cuentas_contables clase = new CLS_Cuentas_contables();
            clase.MtdUpdateCtasNivel();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarCuentas();
                ActualizaNivel();
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
                vId_Cuenta = textId.Text;
                vNombre_Cuenta = textNombre.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado tipo de activo");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                vId_Cuenta = textId.Text;
                vNombre_Cuenta = textNombre.Text;
                this.Close();
            }
        }
    }
}