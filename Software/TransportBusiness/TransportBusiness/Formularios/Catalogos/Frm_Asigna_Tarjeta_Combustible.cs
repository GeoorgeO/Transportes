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
    public partial class Frm_Asigna_Tarjeta_Combustible : DevExpress.XtraEditors.XtraForm
    {
        public string IdActivo { get; set; }
        public string Activo { get; set; }
        string TarjetaSelect = "";

        public Frm_Asigna_Tarjeta_Combustible()
        {
            InitializeComponent();
        }

        private void CargarAsignaTCombustible()
        {
            gridControl1.DataSource = null;
            CLS_Activos_TCombustible Clase = new CLS_Activos_TCombustible();
            Clase.Id_Activo = IdActivo;
            Clase.MtdSeleccionarActivos_TCombustible();
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

        private void InsertarAsignaTCombustible()
        {
            CLS_Activos_TCombustible Clase = new CLS_Activos_TCombustible();
            if (TarjetaSelect.Length > 0)
            {
                Clase.Id_Tarjeta_Combustibleold = TarjetaSelect;
            }
            else
            {
                Clase.Id_Tarjeta_Combustibleold = textTCombustible.Text.Trim();
            }
            Clase.Id_Tarjeta_Combustible = textTCombustible.Text.Trim();
            Clase.Id_Activo = IdActivo;

            Clase.MtdInsertarActivos_TCombustible();
            if (Clase.Exito)
            {

                CargarAsignaTCombustible();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarAsignaTCombustible()
        {
            CLS_Activos_TCombustible Clase = new CLS_Activos_TCombustible();
            Clase.Id_Tarjeta_Combustible = textTCombustible.Text.Trim();
            Clase.Id_Activo = IdActivo;
            Clase.MtdEliminarActivos_TCombustible();
            if (Clase.Exito)
            {
                CargarAsignaTCombustible();
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
            textTCombustible.Text = "";
            TarjetaSelect = "";
        }

        private void Frm_Asigna_Tarjeta_Combustible_Load(object sender, EventArgs e)
        {
            textIdActivo.Text = IdActivo;
            textActivo.Text = Activo;
            CargarAsignaTCombustible();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textIdActivo.Text = row["Id_Activo"].ToString();
                    textTCombustible.Text = row["Id_Tarjeta_Combustible"].ToString();
                    textActivo.Text = row["Nombre_Interno"].ToString();
                    TarjetaSelect = row["Id_Tarjeta_Combustible"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textTCombustible.Text.ToString().Trim().Length > 0)
            {
                if (textIdActivo.Text.Trim().Length > 0)
                {
                    InsertarAsignaTCombustible();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un problema para identificar el Activo.");

                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una IAVE.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TarjetaSelect.Length > 0)
            {
                EliminarAsignaTCombustible();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un elemento de la lista.");
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

        private void btnBusqTarjeta_Click(object sender, EventArgs e)
        {
            Frm_Tarjetas_Combustible Clase = new Frm_Tarjetas_Combustible();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textTCombustible.Text = Clase.vTCombustible;
        }
    }
}