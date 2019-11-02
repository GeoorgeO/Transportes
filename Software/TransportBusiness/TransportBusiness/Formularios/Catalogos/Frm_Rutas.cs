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
    public partial class Frm_Rutas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Rutas()
        {
            InitializeComponent();
        }

        private void CargarRutas()
        {
            gridControl1.DataSource = null;
            CLS_Rutas Rutas = new CLS_Rutas();

            Rutas.MtdSeleccionarRutas();
            if (Rutas.Exito)
            {
                gridControl1.DataSource = Rutas.Datos;
            }
        }

        private void CargarDetalles()
        {
            gridControl2.DataSource = null;
            CLS_Rutas_Detalle RutasDetalle = new CLS_Rutas_Detalle();
            RutasDetalle.Id_Rutas = textIdRuta.Text.Trim();
            RutasDetalle.MtdSeleccionarRutasDetalle();
            if (RutasDetalle.Exito)
            {
                gridControl2.DataSource = RutasDetalle.Datos;
            }
        }

        private void InsertarRutas()
        {
            CLS_Rutas Rutas = new CLS_Rutas();
            Rutas.Id_Rutas = textIdRuta.Text.Trim();
            Rutas.Nombre_Rutas = textRuta.Text.Trim();
            

            Rutas.MtdInsertarRutas();
            if (Rutas.Exito)
            {

                CargarRutas();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Rutas.Mensaje);
            }
        }
        private void iniciarTags()
        {
            textRutaDetalle.Tag = "";
        }

        private void InsertarDetalles()
        {
            CLS_Rutas_Detalle RutasDetalle = new CLS_Rutas_Detalle();
            RutasDetalle.Id_Rutas = textIdRutaDetalle.Text.Trim();
            RutasDetalle.Nombre_Rutas_Detalle = textRutaDetalle.Text.Trim();
            RutasDetalle.Secuencia =("000"+ (gridView2.DataRowCount+1).ToString()).Substring(("000"+ (gridView2.DataRowCount + 1).ToString()).Length - 3) ;
            RutasDetalle.MtdInsertarRutasDetalle();
            if (RutasDetalle.Exito)
            {
                CargarDetalles();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCamposDetalle();
            }
            else
            {
                XtraMessageBox.Show(RutasDetalle.Mensaje);
            }
        }

        private void EliminarRutas()
        {
            CLS_Rutas Rutas = new CLS_Rutas();
            Rutas.Id_Rutas = textIdRuta.Text.Trim();
            Rutas.MtdEliminarRutas();
            if (Rutas.Exito)
            {
                EliminarRutayDetalles();
                CargarRutas();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
                LimpiarCamposDetalle();
            }
            else
            {
                XtraMessageBox.Show(Rutas.Mensaje);
            }
        }

        private void EliminarDetalle()
        {
            CLS_Rutas_Detalle RutasDetalle = new CLS_Rutas_Detalle();
            RutasDetalle.Id_Rutas = textIdRutaDetalle.Text.Trim();
            RutasDetalle.Secuencia = textRutaDetalle.Tag.ToString();
            RutasDetalle.MtdEliminarRutasDetalle();
            if (RutasDetalle.Exito)
            {
                CargarDetalles();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCamposDetalle();
            }
            else
            {
                XtraMessageBox.Show(RutasDetalle.Mensaje);
            }
        }

        private void EliminarRutayDetalles()
        {
            CLS_Rutas_Detalle RutasDetalle = new CLS_Rutas_Detalle();
            RutasDetalle.Id_Rutas = textIdRuta.Text.Trim();
           
            RutasDetalle.MtdEliminarRutasYDetalle();
            if (RutasDetalle.Exito)
            {
                CargarRutas();

                LimpiarCamposDetalle();
            }
            else
            {
                XtraMessageBox.Show(RutasDetalle.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textIdRuta.Text = "";
            textRuta.Text = "";
        }

        private void LimpiarCamposDetalle()
        {
            textIdRutaDetalle.Text = "";
            textRutaDetalle.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textIdRuta.Text = row["Id_Rutas"].ToString();
                    textIdRutaDetalle.Text = row["Id_Rutas"].ToString();
                    textRuta.Text = row["Nombre_Ruta"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            CargarDetalles();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                if (textRuta.Text.ToString().Trim().Length > 0)
                {
                    InsertarRutas();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Agregar un nombre a la ruta.");
                }
            }
            else
            {
                if (textRutaDetalle.Text.ToString().Trim().Length > 0)
                {
                  

                        InsertarDetalles();
                   
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Agregar un nombre al detalle de la ruta.");
                }
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                if (textIdRuta.Text.Trim().Length > 0)
                {
                    EliminarRutas();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar uns ruta.");
                }
            }
            else
            {
                if (textIdRutaDetalle.Text.Trim().Length > 0 && textRutaDetalle.Tag.ToString().Trim().Length>0)
                {
                    EliminarDetalle();
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
                LimpiarCamposDetalle();
            }
            else
            {
                LimpiarCamposDetalle();
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Rutas_Load(object sender, EventArgs e)
        {
            CargarRutas();
            CargarDetalles();
            iniciarTags();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    DataRow row = this.gridView2.GetDataRow(i);
                    textIdRutaDetalle.Text = row["Id_Rutas"].ToString();
                    textRutaDetalle.Text = row["Nombre_Rutas_Detalle"].ToString();
                    textRutaDetalle.Tag = row["Secuencia"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


    }
}