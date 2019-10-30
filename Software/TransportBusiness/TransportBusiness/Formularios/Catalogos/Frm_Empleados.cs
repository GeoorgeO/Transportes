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

        private static Frm_Empleados m_FormDefInstance;
        public static Frm_Empleados DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Empleados();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public string vId_Empleado { get; set; }
        public string vNombre_Empleado { get; set; }

        const string idTipoPersona = "0001";

        public Boolean PaSel { get; set; }

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

        private void CargarDomicilio()
        {
            gridControl2.DataSource = null;
            CLS_Domicilios Domicilio = new CLS_Domicilios();
            Domicilio.Id_Empleado = textIdEmpleado.Text.Trim();
            Domicilio.id_TipoPersona = idTipoPersona;
            Domicilio.MtdSeleccionarDomicilio();
            if (Domicilio.Exito)
            {
                gridControl2.DataSource = Domicilio.Datos;
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

        private void InsertarDomicilio()
        {
            CLS_Domicilios Domicilio = new CLS_Domicilios();
            Domicilio.Id_Domicilio = textIdDomicilio.Text.Trim();
            Domicilio.Calle = textCalle.Text.Trim();
            Domicilio.NoInterior = textNoInterior.Text.Trim();
            Domicilio.NoExterior = textNoExterior.Text.Trim();
            Domicilio.Colonia = textColonia.Text.Trim();
            Domicilio.Codigo_Postal = textCodigoPostal.Text.Trim();
            Domicilio.Id_Estado = textEstado.Tag.ToString().Trim();
            Domicilio.Id_TipoDomicilio = textTipoDomicilio.Tag.ToString().Trim();
            Domicilio.Id_Empleado = textIdEmpleado.Text.Trim();
            Domicilio.id_TipoPersona = idTipoPersona;
            Domicilio.MtdInsertarDomicilio();
            if (Domicilio.Exito)
            {

                CargarDomicilio();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCamposDomicilio();
            }
            else
            {
                XtraMessageBox.Show(Domicilio.Mensaje);
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

        private void EliminarDomicilio()
        {
            CLS_Domicilios Domicilio = new CLS_Domicilios();
            Domicilio.Id_Domicilio = textIdDomicilio.Text.Trim();
            Domicilio.MtdEliminarDomicilio();
            if (Domicilio.Exito)
            {
                CargarDomicilio();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Domicilio.Mensaje);
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

        private void LimpiarCamposDomicilio()
        {
            textIdDomicilio.Text = "";
            textCalle.Text = "";
            textNoInterior.Text = "";
            textNoExterior.Text = "";
            textEstado.Tag = "";
            textEstado.Text = "";
            textCodigoPostal.Text = "";
            textColonia.Text = "";
            textTipoDomicilio.Tag = "";
            textTipoDomicilio.Text = "";
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

            CargarDomicilio();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
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
            else
            {
                if (textCalle.Text.ToString().Trim().Length > 0)
                {
                    if (textNoExterior.Text.ToString().Trim().Length > 0)
                    {

                        InsertarDomicilio();
                    }
                    else
                    {
                        XtraMessageBox.Show("Es necesario agregar un numero exterior.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Agregar una calle.");
                }
            }

           
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                if (textIdEmpleado.Text.Trim().Length > 0)
                {
                    EliminarEmpleado();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar un Empleado.");
                }
            }
            else
            {
                if (textIdDomicilio.Text.Trim().Length > 0)
                {
                    EliminarDomicilio();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar un Domicilio.");
                }
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                LimpiarCampos();
                LimpiarCamposDomicilio();
            }
            else
            {
                LimpiarCamposDomicilio();
            }

           
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarEmpleado();
            CargarDomicilio();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Empleados TipoEmpleado = new Frm_Tipo_Empleados();
            TipoEmpleado.PaSel = true;
            TipoEmpleado.ShowDialog();

            textTipoEmpleado.Tag = TipoEmpleado.IdTipoEmpleado;
            textTipoEmpleado.Text = TipoEmpleado.TipoEmpleado;
        }

        private void btnbusqlicencia_Click(object sender, EventArgs e)
        {
            Frm_Licencias Licencia = new Frm_Licencias();
            Licencia.PaSel = true;
            Licencia.ShowDialog();

            textLicencia.Tag = Licencia.IdLicencia;
            textLicencia.Text = Licencia.Licencia;
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(textIdEmpleado.Text!=string.Empty && textEmpleado.Text!=string.Empty)
            {
                vId_Empleado = textIdEmpleado.Text;
                vNombre_Empleado = textEmpleado.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado un empleado");
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    DataRow row = this.gridView2.GetDataRow(i);
                    textIdDomicilio.Text = row["Id_Domicilio"].ToString();
                    textCalle.Text = row["Calle"].ToString();
                    textNoInterior.Text = row["NoInterior"].ToString();
                    textNoExterior.Text = row["NoExterior"].ToString();
                    textCodigoPostal.Text = row["Codigo_Postal"].ToString();
                    textColonia.Text = row["Colonia"].ToString();
                    textEstado.Tag = row["Id_Estado"].ToString();
                    textEstado.Text = row["Nombre_Estado"].ToString();
                    textTipoDomicilio.Tag = row["Id_TipoDomicilio"].ToString();
                    textTipoDomicilio.Text = row["Nombre_TipoDomicilio"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnBusqEstado_Click(object sender, EventArgs e)
        {
            Frm_Estado Estado = new Frm_Estado(true);

            Estado.ShowDialog();

            textEstado.Tag = Estado.IdEstado;
            textEstado.Text = Estado.Estado;
        }

        private void btnBusqTipoDomicilio_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Domicilio tipoDomicilio = new Frm_Tipo_Domicilio();
            tipoDomicilio.PaSel = true;
            tipoDomicilio.ShowDialog();

            textTipoDomicilio.Tag = tipoDomicilio.IdTipoDomicilio;
            textTipoDomicilio.Text = tipoDomicilio.TipoDomicilio;
        }
    }
}