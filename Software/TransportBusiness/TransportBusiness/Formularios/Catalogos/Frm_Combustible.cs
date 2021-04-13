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
    public partial class Frm_Combustible : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }

        private static Frm_Combustible m_FormDefInstance;
        public static Frm_Combustible DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Combustible();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        public Frm_Combustible()
        {
            InitializeComponent();
        }

        private void CargarCarga_Combustible()
        {
            gridControl1.DataSource = null;
            CLS_Carga_Combustible Clase = new CLS_Carga_Combustible();

            Clase.MtdSeleccionarCarga_Combustible();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private string DosCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }

        private void InsertarCarga_Combustible()
        {
            CLS_Carga_Combustible Clase = new CLS_Carga_Combustible();
            Clase.Folio = textFolio.Text.Trim();
            DateTime Fecha;
            Fecha = Convert.ToDateTime(dtFechaAlta.Text.Trim());
            Clase.FechaCarga = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Kilometraje = Convert.ToDouble(textKM.Text);
            Clase.Litros = Convert.ToDouble(textLT.Text);
            Clase.PrecioLitro= Convert.ToDouble(textPrecio.Text);
            Clase.PrecioTotal= Convert.ToDouble(textTotal.Text);
            Clase.Id_Activo = textActivo.Tag.ToString();
            Clase.Id_Proveedor = textProveedor.Tag.ToString();
            Clase.Id_Factura = textFactura.Text.ToString();
            Clase.Comprador = textComprador.Tag.ToString();
            Clase.Observaciones = memoObservaciones.Text.ToString();
            Clase.MtdInsertarCarga_Combustible();
            if (Clase.Exito)
            {

                CargarCarga_Combustible();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarCarga_Combustible()
        {
            CLS_Carga_Combustible Clase = new CLS_Carga_Combustible();
            Clase.Folio = textFolio.Text.Trim();
            Clase.MtdEliminarCarga_Combustible();
            if (Clase.Exito)
            {
                CargarCarga_Combustible();
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
            textFolio.Text = "";
            textKM.Text = "0";
            textLT.Text = "0";
            textPrecio.Text = "0";
            textTotal.Text = "0";
            textComprador.Text = "";
            textFactura.Text = "";
            textProveedor.Text = "";
            textActivo.Text = "";
            memoObservaciones.Text = "";
            iniciarTags();
            dtFechaAlta.EditValue = DateTime.Now;
        }

        private void iniciarTags()
        {
            textActivo.Tag = "";
            textProveedor.Tag = "";
            textComprador.Tag = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textFolio.Text = row["Folio"].ToString();
                    textKM.Text = row["Kilometraje"].ToString();
                    textLT.Text = row["Litros"].ToString();
                    textPrecio.Text = row["PrecioLitro"].ToString();
                    textTotal.Text = row["PrecioTotal"].ToString();
                    textComprador.Tag = row["Comprador"].ToString();
                    textComprador.Text = row["Nombre_Empleado"].ToString();
                    textFactura.Text = row["Id_Factura"].ToString();
                    textProveedor.Tag = row["Id_Proveedor"].ToString();
                    textProveedor.Text = row["Nombre_Proveedor"].ToString();
                    textActivo.Tag = row["Id_Activo"].ToString();
                    textActivo.Text = row["Nombre_Interno"].ToString();
                    memoObservaciones.Text = row["Observaciones"].ToString();
                    dtFechaAlta.EditValue= row["FechaCarga"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Combustible_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarCarga_Combustible();
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtFechaAlta.EditValue!=null)
            {
                if (textActivo.Tag.ToString().Trim().Length > 0)
                {
                    InsertarCarga_Combustible();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar un activo.");
                }
               
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una fecha de carga.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textFolio.Text.ToString().Trim().Length > 0)
            {
                EliminarCarga_Combustible();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una carga de el detalle.");
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

        private void btnbusqActivo_Click(object sender, EventArgs e)
        {
            Frm_Activos Clase = new Frm_Activos();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textActivo.Tag = Clase.IdActivo;
            textActivo.Text = Clase.Activo;
        }

        private void btnbusqProveedor_Click(object sender, EventArgs e)
        {
            Frm_Proveedores Clase = new Frm_Proveedores();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textProveedor.Tag = Clase.IdProveedor;
            textProveedor.Text = Clase.Proveedor;
        }

        private void btnbusqComprador_Click(object sender, EventArgs e)
        {
            Frm_Empleados Clase = new Frm_Empleados();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textComprador.Tag = Clase.vId_Empleado;
            textComprador.Text = Clase.vNombre_Empleado;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}