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
    public partial class Frm_Servicios : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }

        public Frm_Servicios()
        {
            InitializeComponent();
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
            column.ColumnName = "Folio";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the Column to the DataColumnCollection.
            Tabla.Columns.Add(column);


            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Nombre_ServicioDetalle";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            Tabla.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Secuencia";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            Tabla.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Costo";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            Tabla.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Piezas";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            Tabla.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Total";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            Tabla.Columns.Add(column);

            gridControl1.DataSource = Tabla;
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

        private void sumarTotal()
        {
            double Total;
            Total = 0;
            for (int x = 0; x < gridView1.RowCount; x++)
            {
                int xRow = gridView1.GetVisibleRowHandle(x);
                Total=Total+Convert.ToDouble(gridView1.GetRowCellValue(xRow, gridView1.Columns["Total"]).ToString());
            }
            textPTotal.Text = Total.ToString();
        }

        private void CargarServiciosDetalle(string Folio)
        {
            CLS_ServiciosDetalle Clase = new CLS_ServiciosDetalle();
            Clase.Folio = Folio;
            Clase.MtdSeleccionarServiciosDetalle();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private void InsertarServicios()
        {
            CLS_Servicios Clase = new CLS_Servicios();
            Clase.Folio = textFolio.Text.Trim();
            Clase.Id_Activo = textActivo.Tag.ToString().Trim();
            Clase.Id_TipoServicio = textTipoServicio.Tag.ToString().Trim();
            Clase.PrecioTotal = textPTotal.Text.Trim();
            Clase.Kilometraje = textKM.Text.Trim();
            DateTime Fecha = Convert.ToDateTime(dtFechaAlta.Text.Trim());
            Clase.FechaServicio = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Proveedor = textProveedor.Tag.ToString().Trim();
            Clase.Id_Factura = textFactura.Text.Trim();
            Clase.Comprador = textComprador.Tag.ToString().Trim();
            Clase.Observaciones = memoObservaciones.Text.Trim();
            Clase.MtdInsertarServicios();
            if (Clase.Exito)
            {

                textFolio.Text = Clase.Datos.Rows[0][0].ToString();
                EliminarServiciosDetalleALL(textFolio.Text);

                for (int x = 0; x < gridView1.RowCount; x++)
                {
                    int xRow = gridView1.GetVisibleRowHandle(x);
                    InsertarServiciosDetalle(textFolio.Text.Trim(), gridView1.GetRowCellValue(xRow, gridView1.Columns["Nombre_ServicioDetalle"]).ToString(), Convert.ToInt32(gridView1.GetRowCellValue(xRow, gridView1.Columns["Secuencia"]).ToString()), Convert.ToDouble(gridView1.GetRowCellValue(xRow, gridView1.Columns["Costo"]).ToString()), Convert.ToDouble(gridView1.GetRowCellValue(xRow, gridView1.Columns["Piezas"]).ToString()), Convert.ToDouble(gridView1.GetRowCellValue(xRow, gridView1.Columns["Total"]).ToString()));
                }
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private Boolean InsertarServiciosDetalle(string Folio, string Nombre_ServicioDetalle, int Secuencia, double Costo, double Piezas, double Total)
        {
            CLS_ServiciosDetalle Clase = new CLS_ServiciosDetalle();
            Clase.Folio = Folio;
            Clase.Nombre_ServicioDetalle = Nombre_ServicioDetalle;
            Clase.Secuencia = Secuencia;
            Clase.Costo = Costo;
            Clase.Piezas = Piezas;
            Clase.Total = Total;
            Clase.MtdInsertarServiciosDetalle();
            if (Clase.Exito)
            {
                return true;
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
                return false;
            }
        }

        private void EliminarServicios()
        {
            CLS_Servicios Clase = new CLS_Servicios();
            Clase.Folio = textFolio.Text.Trim();
            Clase.MtdEliminarServicios();
            if (Clase.Exito)
            {
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
                LimpiarDetalle();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private Boolean EliminarServiciosDetalleALL(string Folio)
        {
            CLS_ServiciosDetalle Clase = new CLS_ServiciosDetalle();
            Clase.Folio = textFolio.Text.Trim();
            Clase.MtdEliminarServiciosDetalleALL();
            if (Clase.Exito)
            {
                return true;
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
                return false;
            }
        }

        private void LimpiarCampos()
        {
            textFolio.Text = "";
            textServicio.Text = "";
            textActivo.Text = "";
            textProveedor.Text = "";
            textFactura.Text = "";
            textKM.Text = "";
            textPTotal.Text = "0";
            textTipoServicio.Text = "";
            textComprador.Text = "";
            memoObservaciones.Text = "";
            dtFechaAlta.EditValue = DateTime.Now;
            iniciarTags();
            gridControl1.DataSource = null;
            CargarTabla();
        }

        private void iniciarTags()
        {
            textActivo.Tag = "";
            textProveedor.Tag = "";
            textComprador.Tag = "";
            textTipoServicio.Tag = "";
        }

        private void LimpiarDetalle()
        {
            textServicio.Text = "";
            textCosto.Text = "";
            textCantidad.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Servicios_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarTabla();
            iniciarTags();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textServicio.Focus();
            if (textActivo.Tag.ToString().Trim().Length > 0)
            {
                if (textTipoServicio.Tag.ToString().Trim().Length > 0)
                {
                    if (dtFechaAlta.EditValue!=null)
                    {
                        InsertarServicios();
                    }
                    else
                    {
                        XtraMessageBox.Show("Es necesario esecificar la Fecha del servicio.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Es necesario esecificar el Tipo de servicio.");
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario esecificar el activo al que se le aplicara el servicio.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textFolio.Text.Trim().Length > 0)
            {
                EliminarServicios();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un servicio previamente guardado.");
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDetalles();
            LimpiarDetalle();
            reorganizaSec();
            textServicio.Focus();
            sumarTotal();
        }

        private void AgregarDetalles()
        {
            gridView1.AddNewRow();
            int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
            if (gridView1.IsNewItemRow(rowHandle))
            {
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Folio"], "");
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Nombre_ServicioDetalle"], textServicio.Text.Trim());
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Secuencia"], "");
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Costo"], Convert.ToDouble(textCosto.Text));
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Piezas"], Convert.ToDouble(textCantidad.Text));
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Total"], Convert.ToDouble(Convert.ToDouble(textCosto.Text) * Convert.ToDouble(textCantidad.Text)));

            }
        }

        private void reorganizaSec()
        {
            for (int x = 0; x < gridView1.RowCount; x++)
            {
                int xRow = gridView1.GetVisibleRowHandle(x);
                gridView1.SetRowCellValue(xRow, gridView1.Columns["Secuencia"],  x + 1);

            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                try
                {
                    DialogResult = XtraMessageBox.Show("¿Esta seguro de que desea eliminar el detalle seleccionado?", "Elimnar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (DialogResult == DialogResult.Yes)
                    {
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        reorganizaSec();
                        sumarTotal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBusqActivo_Click(object sender, EventArgs e)
        {
            Frm_Activos Clase = new Frm_Activos();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textActivo.Tag = Clase.IdActivo;
            textActivo.Text = Clase.Activo;
        }

        private void btnBusqTipo_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Servicio Clase = new Frm_Tipo_Servicio();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textTipoServicio.Tag = Clase.IdTipoServicio;
            textTipoServicio.Text = Clase.TipoServicio;
        }

        private void btnBusqProveedor_Click(object sender, EventArgs e)
        {
            Frm_Proveedores Clase = new Frm_Proveedores();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textProveedor.Tag = Clase.IdProveedor;
            textProveedor.Text = Clase.Proveedor;
        }

        private void btnBusqComprador_Click(object sender, EventArgs e)
        {
            Frm_Empleados Clase = new Frm_Empleados();
            Clase.PaSel = true;
            Clase.ShowDialog();
            textComprador.Tag = Clase.vId_Empleado;
            textComprador.Text = Clase.vNombre_Empleado;
        }

        private void barLargeButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Servicios_Buscar frm = new Frm_Servicios_Buscar();
           
            LimpiarCampos();

            frm.ShowDialog();

            textFolio.Text = frm.vFolio;
            textActivo.Tag = frm.vId_Activo;
            textActivo.Text = frm.vNombre_Interno;
            textTipoServicio.Tag = frm.vId_TipoServicio;
            textTipoServicio.Text = frm.vNombre_TipoServicio;
            textPTotal.Text = frm.vPrecioTotal.ToString();
            textKM.Text = frm.vKilometraje.ToString();
            dtFechaAlta.EditValue = Convert.ToDateTime(frm.vFechaServicio);
            textProveedor.Tag = frm.vId_Proveedor;
            textProveedor.Text = frm.vNombre_Proveedor;
            textFactura.Text = frm.vId_Factura;
            textComprador.Tag = frm.vComprador;
            textComprador.Text = frm.vNombre_Empleado;
            memoObservaciones.Text = frm.vObservaciones;
            CargarServiciosDetalle(frm.vFolio);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            

            double tCosto;
            double tPiezas;
                
            if(e.Column.Caption == "Costo U" || e.Column.Caption == "Piezas")
            {
                for (int x = 0; x < gridView1.RowCount; x++)
                {
                    int xRow = gridView1.GetVisibleRowHandle(x);
                    DataRow row = this.gridView1.GetDataRow(xRow);
                    tCosto = Convert.ToDouble(row["Costo"].ToString());
                    tPiezas = Convert.ToDouble(row["Piezas"].ToString());

                    gridView1.SetRowCellValue(xRow, gridView1.Columns["Total"], tCosto * tPiezas);
                }

            }
            sumarTotal();
        }
    }
}