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
    public partial class Frm_Asigna_Tarjeta_IAVE : DevExpress.XtraEditors.XtraForm
    {
        public string IdActivo { get; set; }
        public string Activo { get; set; }
        string TarjetaSelect = "";

        public Frm_Asigna_Tarjeta_IAVE()
        {
            InitializeComponent();
        }

        private void CargarAsignaIAVE()
        {
            gridControl1.DataSource = null;
            CLS_Activos_IAVES Clase = new CLS_Activos_IAVES();
            Clase.Id_Activo = IdActivo;
            Clase.MtdSeleccionarActivos_IAVES();
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

        private void InsertarAsignaIAVE()
        {
            CLS_Activos_IAVES Clase = new CLS_Activos_IAVES();
            if (TarjetaSelect.Length>0)
            {
                Clase.IAVEold = TarjetaSelect;
            }else
            {
                Clase.IAVEold = textIAVE.Text.Trim();
            }
            Clase.IAVE = textIAVE.Text.Trim();
            Clase.Id_Activo = IdActivo;
           
            Clase.MtdInsertarActivos_IAVES();
            if (Clase.Exito)
            {

                CargarAsignaIAVE();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarAsignaIAVE()
        {
            CLS_Activos_IAVES Clase = new CLS_Activos_IAVES();
            Clase.IAVE = textIAVE.Text.Trim();
            Clase.Id_Activo = IdActivo;
            Clase.MtdEliminarActivos_IAVES();
            if (Clase.Exito)
            {
                CargarAsignaIAVE();
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
            textIAVE.Text = "";
            TarjetaSelect = "";
        }

        private void Frm_Asigna_Tarjeta_IAVE_Load(object sender, EventArgs e)
        {
            
            textIdActivo.Text= IdActivo ;
            textActivo.Text= Activo ;
            CargarAsignaIAVE();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textIdActivo.Text = row["Id_Activo"].ToString();
                    textIAVE.Text = row["IAVE"].ToString();
                    textActivo.Text = row["Nombre_Interno"].ToString();
                    TarjetaSelect= row["IAVE"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textIAVE.Text.ToString().Trim().Length > 0)
            {
                if (textIdActivo.Text.Trim().Length > 0)
                {
                    InsertarAsignaIAVE();
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
            if (TarjetaSelect.Length>0)
            {
                EliminarAsignaIAVE();
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

        private void btnBusqIAVE_Click(object sender, EventArgs e)
        {
            Frm_Tarjetas_IAVE Clase = new Frm_Tarjetas_IAVE();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textIAVE.Text = Clase.vIAVE;
            
        }
    }
}