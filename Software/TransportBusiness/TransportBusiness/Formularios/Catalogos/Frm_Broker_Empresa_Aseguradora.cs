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
    public partial class Frm_Broker_Empresa_Aseguradora : DevExpress.XtraEditors.XtraForm
    {

        private static Frm_Broker_Empresa_Aseguradora m_FormDefInstance;
        public static Frm_Broker_Empresa_Aseguradora DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Broker_Empresa_Aseguradora();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        const string idTipoPersona = "0004";

        public Frm_Broker_Empresa_Aseguradora()
        {
            InitializeComponent();
        }

        private void CargarBroker()
        {
            gridControl1.DataSource = null;
            CLS_Broker_Empresa_Aseguradora Broker = new CLS_Broker_Empresa_Aseguradora();

            Broker.MtdSeleccionarBrokerEmpresaAseguradora();
            if (Broker.Exito)
            {
                gridControl1.DataSource = Broker.Datos;
            }
        }

        private void CargarDomicilio()
        {
            gridControl2.DataSource = null;
            CLS_Domicilios Domicilio = new CLS_Domicilios();
            Domicilio.Id_Empleado = textIdBroker.Text.Trim();
            Domicilio.id_TipoPersona = idTipoPersona;
            Domicilio.MtdSeleccionarDomicilio();
            if (Domicilio.Exito)
            {
                gridControl2.DataSource = Domicilio.Datos;
            }
        }

        private void iniciarTags()
        {
            textAseguradora.Tag = "";
            textTipoDomicilio.Tag = "";
            textEstado.Tag = "";
        }

        private void InsertarBroker()
        {
            CLS_Broker_Empresa_Aseguradora Broker = new CLS_Broker_Empresa_Aseguradora();
            Broker.Id_Broker_Empresa_Aseguradora = textIdBroker.Text.Trim();
            Broker.Nombre_Broker_Empresa_Aseguradora = textBroker.Text.Trim();
            Broker.Telefono = textTelefono.Text.Trim();
            Broker.Id_Empresa_Aseguradora = textAseguradora.Tag.ToString().Trim();
            Broker.MtdInsertarBrokerEmpresaAseguradora();
            if (Broker.Exito)
            {

                CargarBroker();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Broker.Mensaje);
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
            Domicilio.Id_Empleado = textIdBroker.Text.Trim();
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

        private void EliminarBroker()
        {
            CLS_Broker_Empresa_Aseguradora Agente = new CLS_Broker_Empresa_Aseguradora();
            Agente.Id_Broker_Empresa_Aseguradora = textIdBroker.Text.Trim();
            Agente.MtdEliminarBrokerEmpresaAseguradora();
            if (Agente.Exito)
            {
                EliminarDomicilioPersona();
                CargarBroker();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Agente.Mensaje);
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
            Domicilio.Id_Empleado = textIdBroker.Text.Trim();
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
            textIdBroker.Text = "";
            textBroker.Text = "";
            textTelefono.Text = "";
            textAseguradora.Text = "";
            textAseguradora.Tag = "";
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
                    textIdBroker.Text = row["Id_Broker_Empresa_Aseguradora"].ToString();
                    textBroker.Text = row["Nombre_Broker_Empresa_Aseguradora"].ToString();
                    textTelefono.Text = row["Telefono"].ToString();
                    textAseguradora.Tag = row["Id_Empresa_Aseguradora"].ToString();
                    textAseguradora.Text = row["Nombre_Empresa_Aseguradora"].ToString();
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
                if (textBroker.Text.ToString().Trim().Length > 0)
                {
                    if (textAseguradora.Text.ToString().Trim().Length > 0)
                    {

                        InsertarBroker();
                    }
                    else
                    {
                        XtraMessageBox.Show("Es necesario seleccionar un broker.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Agregar un nombre al broker.");
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
                if (textIdBroker.Text.Trim().Length > 0)
                {
                    EliminarBroker();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar un broker.");
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

        private void Frm_Broker_Empresa_Aseguradora_Load(object sender, EventArgs e)
        {
            CargarBroker();
            CargarDomicilio();
            iniciarTags();
            LimpiarCampos();
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Frm_Aseguradoras aseguradora = new Frm_Aseguradoras();
            aseguradora.PaSel = true;
            aseguradora.ShowDialog();

            textAseguradora.Tag = aseguradora.idAseguradora;
            textAseguradora.Text = aseguradora.Aseguradora;
        }

        private void btnBusqEstado_Click(object sender, EventArgs e)
        {
            Frm_Estado Estado = new Frm_Estado();
            Estado.PaSel = true;
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

        private void textIdBroker_EditValueChanged(object sender, EventArgs e)
        {
            if (textIdBroker.Text == String.Empty)
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