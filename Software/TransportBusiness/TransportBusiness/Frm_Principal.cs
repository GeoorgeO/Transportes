using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaDeDatos;
using DevExpress.XtraEditors;

namespace TransportBusiness
{
    public partial class Frm_Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string UsuariosLogin { get; set; }
        public string UsuariosClase { get; set; }

        List<string> Lista = new List<string>();

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void CargarAccesos()
        {
            CLS_Perfiles_Pantallas Clase = new CLS_Perfiles_Pantallas();
            Clase.Id_Perfil = UsuariosClase;
            Clase.MtdSeleccionarAccesosPermisos();
            if (Clase.Exito)
            {

               for(int x=0; x<Clase.Datos.Rows.Count; x++)
                {
                    Lista.Add(Clase.Datos.Rows[x][0].ToString());
                }
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private Boolean TieneAcceso(String valor)
        {
            foreach (string x in Lista)
            {
                if (x== valor)
                {
                    return true;
                }
               
            }
            return false;
        }

        


        private void btnVeiculos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("001"))
            {
                Frm_Activos.DefInstance.MdiParent = this;
                Frm_Activos.DefInstance.Show();
            }else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [001]");
            }
           
        }

        private void btnPersonal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("002"))
            {
                Frm_Empleados.DefInstance.MdiParent = this;
                Frm_Empleados.DefInstance.Show();
            }else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [002]");
            }

        }

        private void btnAseguradora_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("015"))
            {
                Frm_Aseguradoras.DefInstance.MdiParent = this;
                Frm_Aseguradoras.DefInstance.PaSel = false;
                Frm_Aseguradoras.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [015]");
            }
        }

        private void btnTipoActivos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("018"))
            {
                Frm_Tipo_Activo Frm = new Frm_Tipo_Activo();
                Frm.PaSel = false;
                Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [018]");
            }
        }

        private void btnTipoDomicilio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("019"))
            {
                Frm_Tipo_Domicilio Frm = new Frm_Tipo_Domicilio();
                Frm.PaSel = false;
                Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [019]");
            }
        }

        private void btnTipoLicencia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("020"))
            {
                Frm_Tipo_Licencia Frm = new Frm_Tipo_Licencia();
                Frm.PaSel = false;
                Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [020]");
            }
        }

        private void btnTipoPlaca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("021"))
            {
                Frm_Tipo_Placa Frm = new Frm_Tipo_Placa();
                Frm.PaSel = false;
                Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [021]");
            }
        }

        private void btnTipoTransporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("022"))
            {
                Frm_Tipo_Transporte Frm = new Frm_Tipo_Transporte();
                Frm.PaSel = false;
                Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [022]");
            }
        }

        private void btnTipoPersona_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("023"))
            {
                Frm_Tipo_Empleados Frm = new Frm_Tipo_Empleados();
                Frm.PaSel = false;
             Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [023]");
            }
        }

        private void btnAgente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("016"))
            {
                Frm_Agente_Empresa_Aseguradora.DefInstance.MdiParent = this;
                Frm_Agente_Empresa_Aseguradora.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [016]");
            }
        }

        private void btnBroker_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("017"))
            {
                Frm_Broker_Empresa_Aseguradora.DefInstance.MdiParent = this;
                Frm_Broker_Empresa_Aseguradora.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [017]");
            }
        }

        private void btnCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("013"))
            {
                Frm_Clientes.DefInstance.MdiParent = this;
                Frm_Clientes.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [013]");
            }
        }

        private void btnEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("014"))
            {
                Frm_Empresas.DefInstance.MdiParent = this;
                Frm_Empresas.DefInstance.PaSel = false;
                Frm_Empresas.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [014]");
            }

        }

        private void btnEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("009"))
            {
                Frm_Estado.DefInstance.MdiParent = this;
                Frm_Estado.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [009]");
            }
        }

        private void btnPais_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("010"))
            {
                Frm_Pais Frm = new Frm_Pais(false);
            Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [010]");
            }
        }

        private void btnMarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("007"))
            {
                Frm_Marcas Frm = new Frm_Marcas();
                Frm.PaSel = false;
                Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [007]");
            }
           
        }

        private void btnLicencias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("008"))
            {
                Frm_Licencias Frm = new Frm_Licencias();
                 Frm.PaSel = false;
                Frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [008]");
            }
        }

        private void btnProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("012"))
            {
                Frm_Proveedores.DefInstance.MdiParent = this;
                Frm_Proveedores.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [012]");
            }
        }

        private void btnPantallas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("028"))
            {
                Frm_Pantallas Pantalla = new Frm_Pantallas();
                Pantalla.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [028]");
            }
        }

        private void btnPerfiles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Perfiles Perfiles = new Frm_Perfiles();
            Perfiles.ShowDialog();
        }

        private void btnUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("029"))
            {
                Frm_Usuarios Usuarios = new Frm_Usuarios();
                Usuarios.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [029]");
            }
        }

        private void btnPermisos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Permisos Permisos = new Frm_Permisos();
            Permisos.ShowDialog();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            CargarAccesos();
        }

        private void btnHerramienta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("003"))
            {
                
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [003]");
            }
        }

        private void btnRutas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("004"))
            {

            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [004]");
            }
        }

        private void btnInfracciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("005"))
            {

            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [005]");
            }
        }

        private void btnCombustible_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("006"))
            {
                Frm_Combustible.DefInstance.MdiParent = this;
                Frm_Combustible.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [006]");
            }
        }

        private void btnGastosIndirectos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("011"))
            {

            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [011]");
            }
        }

        private void btnSalidas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("024"))
            {

            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [024]");
            }
        }

        private void btnEntradas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("025"))
            {

            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [025]");
            }
        }

        private void btnMantenimientos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("026"))
            {

            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [026]");
            }
        }

        private void btnAsignacionHerramienta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("027"))
            {

            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [027]");
            }
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = XtraMessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            MSRegistro RegIn = new MSRegistro();
            RegIn.SaveSetting("ConexionSQL", "Sking", SkinForm.LookAndFeel.SkinName);
        }
    }
}
