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

        private static Frm_Rutas m_FormDefInstance;
        public static Frm_Rutas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Rutas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void CargarTabla()
        {
            DataTable Tabla = new DataTable("Tabla");
            DataColumn column;
            Tabla.Reset();
            // Create new DataColumn, set DataType, 
            // ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Id_Rutas";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the Column to the DataColumnCollection.
            Tabla.Columns.Add(column);


            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Nombre_Rutas_Detalle";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            Tabla.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Secuencia";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            Tabla.Columns.Add(column);

            dtgRutasDetalles.DataSource=Tabla;
        }
        private void AgregarDetalles()
        {
            dtgValRutasDetalles.AddNewRow();
            int rowHandle = dtgValRutasDetalles.GetRowHandle(dtgValRutasDetalles.DataRowCount);
            if (dtgValRutasDetalles.IsNewItemRow(rowHandle))
            {
                dtgValRutasDetalles.SetRowCellValue(rowHandle, dtgValRutasDetalles.Columns["Id_Rutas"], "");
                dtgValRutasDetalles.SetRowCellValue(rowHandle, dtgValRutasDetalles.Columns["Nombre_Rutas_Detalle"], textRutaDetalle.Text.Trim());
                dtgValRutasDetalles.SetRowCellValue(rowHandle, dtgValRutasDetalles.Columns["Secuencia"], "");

            }
        }

        private void CargarDetalles()
        {
           
            
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
            Rutas.Kilometros = Convert.ToDouble(textKM.Text);
            Rutas.Origen = textOrigen.Text.Trim();
            Rutas.Destino = textDestino.Text.Trim();

            Rutas.MtdInsertarRutas();
            if (Rutas.Exito)
            {
                textIdRuta.Text= Rutas.Datos.Rows[0][0].ToString();
                 EliminarDetalleAll();

                for (int x=0; x < dtgValRutasDetalles.RowCount; x++)
                {
                    int xRow = dtgValRutasDetalles.GetVisibleRowHandle(x);
                    InsertarDetalles(textIdRuta.Text.Trim(), dtgValRutasDetalles.GetRowCellValue(xRow, dtgValRutasDetalles.Columns["Nombre_Rutas_Detalle"]).ToString(), dtgValRutasDetalles.GetRowCellValue(xRow, dtgValRutasDetalles.Columns["Secuencia"]).ToString());
                }
                


            }
            else
            {
                XtraMessageBox.Show(Rutas.Mensaje);
            }
        }

        private void EliminarDetalleAll( )
        {
            CLS_Rutas_Detalle Rutas = new CLS_Rutas_Detalle();
            Rutas.Id_Rutas = textIdRuta.Text.Trim();
            Rutas.MtdEliminarRutasDetalleALL();
            if (Rutas.Exito)
            {

                //CargarRutas();
                //XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                //LimpiarCampos();
                //LimpiarCamposDetalle();
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

        private void InsertarDetalles(string Id,string nombre,string secuencia)
        {
            CLS_Rutas_Detalle RutasDetalle = new CLS_Rutas_Detalle();
            RutasDetalle.Id_Rutas = Id;
            RutasDetalle.Nombre_Rutas_Detalle = nombre;
            RutasDetalle.Secuencia = secuencia;
            RutasDetalle.MtdInsertarRutasDetalle();
            if (RutasDetalle.Exito)
            {
                //AgregarDetalles();
                //XtraMessageBox.Show("Se ha Insertado el registro con exito");
               // LimpiarCamposDetalle();
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

            try
            {
                foreach (int i in this.dtgValRutasDetalles.GetSelectedRows())
                {
                    DataRow row = this.dtgValRutasDetalles.GetDataRow(i);
                    RutasDetalle.Id_Rutas = row["Id_Rutas"].ToString();
                    RutasDetalle.Secuencia = row["Secuencia"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            
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

        

        private void LimpiarCampos()
        {
            textIdRuta.Text = "";
            textRuta.Text = "";
            textKM.Text = "0";
            textOrigen.Text = "";
            textDestino.Text = "";
            dtgRutasDetalles.DataSource = null;
            CargarTabla();

        }

        private void LimpiarCamposDetalle()
        {
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
                    LimpiarCampos();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Agregar un nombre a la ruta.");
                }
            }
           
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textIdRuta.Text.Trim().Length > 0)
            {
                DialogResult = XtraMessageBox.Show("¿Estas seguro que deseas eliminar el detalle seleccionado?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult == DialogResult.Yes)
            {
               
                    EliminarRutas();
                
            }

            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una ruta.");
            }

        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                LimpiarCampos();
                LimpiarCamposDetalle();
                
          
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Rutas_Load(object sender, EventArgs e)
        {
            iniciarTags();
            CargarTabla();
        }

        private void reorganizaSec()
        {
            for (int x = 0; x < dtgValRutasDetalles.RowCount; x++)
            {
                int xRow = dtgValRutasDetalles.GetVisibleRowHandle(x);
                dtgValRutasDetalles.SetRowCellValue(xRow, dtgValRutasDetalles.Columns["Secuencia"], string.Format("{0:000}", x + 1));
               
            }
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Rutas_Buscar frm = new Frm_Rutas_Buscar();
            frm.Id_Rutas = string.Empty;
            frm.Nombre_Ruta = string.Empty;
            LimpiarCampos();

            frm.ShowDialog();
           
            textIdRuta.Text = frm.Id_Rutas;
            textRuta.Text = frm.Nombre_Ruta;
            textKM.Text = frm.vKilometros.ToString();
            textOrigen.Text = frm.vOrigen;
            textDestino.Text = frm.vDestino;
            CargarDetalles();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
                AgregarDetalles();
               // InsertarRutas(true);
                LimpiarCamposDetalle();
                reorganizaSec();
                 textRutaDetalle.Focus();
        }

        private void dtgRutasDetalles_DoubleClick(object sender, EventArgs e)
        {
            if (dtgValRutasDetalles.RowCount > 0)
            {
                try
                {
                    DialogResult = XtraMessageBox.Show("¿Esta seguro de que desea eliminar el detalle seleccionado?", "Elimnar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (DialogResult == DialogResult.Yes)
                    {
                        dtgValRutasDetalles.DeleteRow(dtgValRutasDetalles.FocusedRowHandle);
                        reorganizaSec();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtgRutasDetalles_Click(object sender, EventArgs e)
        {

        }
    }
}