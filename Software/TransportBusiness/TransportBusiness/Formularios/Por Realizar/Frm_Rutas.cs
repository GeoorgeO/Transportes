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
        private void MakeTablaPedidos()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column;
            table.Reset();

            // DataRow row;
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Id_Rutas";
            column.AutoIncrement = false;
            column.Caption = "Id_Rutas";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Secuencia";
            column.AutoIncrement = false;
            column.Caption = "Secuencia";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Nombre_Rutas_Detalle";
            column.AutoIncrement = false;
            column.Caption = "Nombre_Rutas_Detalle";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgRutasDetalles.DataSource = table;
        }

        private void CargarDetalles()
        {
            dtgRutasDetalles.DataSource = null;
            CLS_Rutas_Detalle RutasDetalle = new CLS_Rutas_Detalle();
            RutasDetalle.Id_Rutas = textIdRuta.Text.Trim();
            RutasDetalle.MtdSeleccionarRutasDetalle();
            if (RutasDetalle.Exito)
            {
                dtgRutasDetalles.DataSource = RutasDetalle.Datos;
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

                //CargarRutas();
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
            RutasDetalle.Id_Rutas = textIdRuta.Text.Trim();
            RutasDetalle.Nombre_Rutas_Detalle = textRutaDetalle.Text.Trim();
            RutasDetalle.Secuencia =("000"+ (dtgValRutasDetalles.DataRowCount+1).ToString()).Substring(("000"+ (dtgValRutasDetalles.DataRowCount + 1).ToString()).Length - 3) ;
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
                //CargarRutas();
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
            RutasDetalle.Id_Rutas = textIdRuta.Text.Trim();
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
                //CargarRutas();

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
            textIdRuta.Text = "";
            textRutaDetalle.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    foreach (int i in this.gridView1.GetSelectedRows())
            //    {
            //        DataRow row = this.gridView1.GetDataRow(i);
            //        textIdRuta.Text = row["Id_Rutas"].ToString();
            //        textIdRutaDetalle.Text = row["Id_Rutas"].ToString();
            //        textRuta.Text = row["Nombre_Ruta"].ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message);
            //}

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
                if (textIdRuta.Text.Trim().Length > 0 && textRutaDetalle.Tag.ToString().Trim().Length>0)
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
            MakeTablaPedidos();
            //CargarRutas();
            CargarDetalles();
            iniciarTags();
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Rutas_Buscar frm = new Frm_Rutas_Buscar();
            frm.Id_Rutas = string.Empty;
            frm.Nombre_Ruta = string.Empty;
            frm.ShowDialog();
            textIdRuta.Text = frm.Id_Rutas;
            textRuta.Text = frm.Nombre_Ruta;
        }
    }
}