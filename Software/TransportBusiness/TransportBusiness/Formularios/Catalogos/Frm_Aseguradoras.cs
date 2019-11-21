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
    public partial class Frm_Aseguradoras : DevExpress.XtraEditors.XtraForm
    {

        private static Frm_Aseguradoras m_FormDefInstance;
        public static Frm_Aseguradoras DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Aseguradoras();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        const string idTipoPersona = "0003";
        public Boolean PaSel { get; set; }

        public Frm_Aseguradoras()
        {
            InitializeComponent();
        }

        public string idAseguradora { get; set; }
        public string Aseguradora { get; set; }

        private void CargarAseguradora()
        {
            gridControl1.DataSource = null;
            CLS_Empresa_Aseguradora Aseguradora = new CLS_Empresa_Aseguradora();

            Aseguradora.MtdSeleccionarEmpresaAseguradora();
            if (Aseguradora.Exito)
            {
                gridControl1.DataSource = Aseguradora.Datos;
            }
        }

        private void CargarDomicilio()
        {
            gridControl2.DataSource = null;
            CLS_Domicilios Domicilio = new CLS_Domicilios();
            Domicilio.Id_Empleado = textIdAseguradora.Text.Trim();
            Domicilio.id_TipoPersona = idTipoPersona;
            Domicilio.MtdSeleccionarDomicilio();
            if (Domicilio.Exito)
            {
                gridControl2.DataSource = Domicilio.Datos;
            }
        }

        private void InsertarAseguradora()
        {
            CLS_Empresa_Aseguradora Aseguradora = new CLS_Empresa_Aseguradora();
            Aseguradora.Id_Empresa_Aseguradora = textIdAseguradora.Text.Trim();
            Aseguradora.Nombre_Empresa_Aseguradora = textAseguradora.Text.Trim();
            Aseguradora.Telefono = textTelefono.Text.Trim();
            Aseguradora.Telefono_Siniestros = textTelSiniestro.Text.Trim();
            Aseguradora.MtdInsertarEmpresaAseguradora();
            if (Aseguradora.Exito)
            {

                CargarAseguradora();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Aseguradora.Mensaje);
            }
        }

        private void iniciarTags()
        {
            textTipoDomicilio.Tag = "";
            textEstado.Tag = "";
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
            Domicilio.Id_Empleado = textIdAseguradora.Text.Trim();
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

        private void EliminarAseguradora()
        {
            CLS_Empresa_Aseguradora Aseguradora = new CLS_Empresa_Aseguradora();
            Aseguradora.Id_Empresa_Aseguradora = textIdAseguradora.Text.Trim();
            Aseguradora.MtdEliminarEmpresaAseguradora();
            if (Aseguradora.Exito)
            {
                EliminarDomicilioPersona();
                CargarAseguradora();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Aseguradora.Mensaje);
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
                LimpiarCamposDomicilio();
            }
            else
            {
                XtraMessageBox.Show(Domicilio.Mensaje);
            }
        }

        private void EliminarDomicilioPersona()
        {
            CLS_Domicilios Domicilio = new CLS_Domicilios();
            Domicilio.Id_Empleado = textIdAseguradora.Text.Trim();
            Domicilio.id_TipoPersona = idTipoPersona;
            Domicilio.MtdEliminarDomicilioPersona();
            if (Domicilio.Exito)
            {
                CargarDomicilio();

                LimpiarCamposDomicilio();
            }
            else
            {
                XtraMessageBox.Show(Domicilio.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textIdAseguradora.Text = "";
            textAseguradora.Text = "";
            textTelefono.Text = "";
            textTelSiniestro.Text = "";
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
                    textIdAseguradora.Text = row["Id_Empresa_Aseguradora"].ToString();
                    textAseguradora.Text = row["Nombre_Empresa_Aseguradora"].ToString();
                    textTelefono.Text = row["Telefono"].ToString();
                    textTelSiniestro.Text = row["Telefono_Siniestros"].ToString();
                   
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
                if (textAseguradora.Text.ToString().Trim().Length > 0)
                {
                   

                        InsertarAseguradora();
                    
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Agregar un nombre de la aseguradora.");
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
                if (textIdAseguradora.Text.Trim().Length > 0)
                {
                    EliminarAseguradora();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar una empresa aseguradora.");
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

        private void Frm_Aseguradoras_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            CargarAseguradora();
            CargarDomicilio();
            iniciarTags();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    DataRow row = this.gridView2.GetDataRow(i);
                    textIdDomicilio.Text = row["Id_Domicilio"].ToString();
                    textCalle.Tag = row["Calle"].ToString();
                    textNoInterior.Text = row["NoInterior"].ToString();
                    textNoExterior.Text = row["NoExterior"].ToString();
                    textCodigoPostal.Text = row["Codigo_Postal"].ToString();
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

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            idAseguradora = textIdAseguradora.Text;
            Aseguradora = textAseguradora.Text;
            this.Close();
        }

        private void textIdAseguradora_EditValueChanged(object sender, EventArgs e)
        {
            if (textIdAseguradora.Text == String.Empty)
            {
                xtraTabPage2.PageEnabled = false;
            }
            else
            {
                xtraTabPage2.PageEnabled = true;
            }
        }
    }
}