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
using System.IO;
using CapaDeDatos;

namespace TransportBusiness
{
    public partial class Frm_Salidas : DevExpress.XtraEditors.XtraForm
    {

        string RutaPDF="", NombrePDF="";
        string RutaXML="", NombreXML="";

        string RutaPDFG = "", NombrePDFG = "";
        string RutaXMLG = "", NombreXMLG = "";

        string RutaPDFC = "", NombrePDFC = "";
        string RutaXMLC = "", NombreXMLC = "";
        public static string Id_Usuario { get; set; }

        string OperadorAnterior = "",ActivoAnterior="";

        Boolean editaG = false;

        Byte[] ArchivoPDFGlobal = null;
        Byte[] ArchivoXMLGlobal = null;

        Byte[] ArchivoPDFGlobalG = null;
        Byte[] ArchivoXMLGlobalG = null;

        Byte[] ArchivoPDFGlobalC = null;
        Byte[] ArchivoXMLGlobalC = null;

        private static Frm_Salidas m_FormDefInstance;
        public static Frm_Salidas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Salidas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Frm_Salidas()
        {
            InitializeComponent();
        }

        public void CargarMotivoSalida()
        {
            CLS_MotivoSalidas MotivoSalida = new CLS_MotivoSalidas();
            MotivoSalida.MtdSeleccionarMotivoSalida();
            if (MotivoSalida.Exito)
            {
                cboMotivoSalida.Properties.DisplayMember = "Nombre_MotivoSalida";
                cboMotivoSalida.Properties.ValueMember = "Id_MotivoSalida";
                cboMotivoSalida.Properties.DataSource = MotivoSalida.Datos;
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

        private void InsertarSalidas()
        {
            CLS_Salidas Clase = new CLS_Salidas();

            Clase.Id_Salida = textFolio.Text.Trim();
            DateTime Fecha = Convert.ToDateTime(dtFechaSalida.Text.Trim());
            Clase.Fecha_Salida = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Activo_Principal = textActivoPrincipal.Tag.ToString();
            Clase.Id_Operador = textOperador.Tag.ToString();
            Clase.Id_Ayudante = textAyudante.Tag.ToString();
            Clase.Id_Activo_Secundario = textActivoSec.Tag.ToString();
            Clase.Id_Activo_Adicional = textActivoAdicional.Tag.ToString();
            Clase.Id_Ruta = textRuta.Tag.ToString();
            Clase.Id_MotivoSalida =cboMotivoSalida.EditValue.ToString();
            Clase.Id_Cliente = textCliente.Tag.ToString();
            Clase.km_Inicio = Convert.ToDecimal(textKmIni.Text);
            Clase.km_Fin=Convert.ToDecimal(textKmFin.Text);
            Clase.Dias_Viaje = Convert.ToDecimal(textDiasViaje.Text);
            Clase.Lts_Km = Convert.ToDecimal(textLts.Text);
            Clase.Id_Huerta = textHuerta.Tag.ToString();
            Clase.Observaciones= memoObservaciones.Text.ToString();
            Clase.EnRuta = "1";
            Clase.Usuario = Id_Usuario;
            Clase.MtdInsertarSalidas();

            if (Clase.Exito)
            {
                //CargarCiudad();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                textFolio.Text = Clase.Datos.Rows[0][0].ToString();
                
                    if (OperadorAnterior.Equals(textOperador.Tag.ToString()))
                    {
                        
                    }
                    else
                    {
                        InsertarHistorialOperadores();
                    }
                
                
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void InsertarHistorialOperadores()
        {
            CLS_HistorialOperadores Clase = new CLS_HistorialOperadores();

            Clase.Id_Operador = textOperador.Tag.ToString();
            Clase.Id_Activo = textActivoPrincipal.Tag.ToString();
            Clase.Tipo = "S";
           
            Clase.MtdInsertarHistorialOperadores();

            if (Clase.Exito)
            {
                OperadorAnterior = textOperador.Tag.ToString();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void textFolio_EditValueChanged(object sender, EventArgs e)
        {
            if (textFolio.Text.Trim().Length > 0)
            {
                xtraTabControl1.Enabled = true;
            }else
            {
                xtraTabControl1.Enabled = false;
            }
            limpiarSalidasCruce();
            limpiarSalidasFacturas();
            limpiarSalidasHonorario();
            limpiarSalidasOtrosGastos();
            limpiarSalidasRevisionUnidad();
            limpiarSalidasViaticos();
            limpiarSalidas_diesel();
        }

        private void Frm_Salidas_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            CargarMotivoSalida();
            limpiarSalidas_diesel();
            limpiarSalidasOtrosGastos();
            limpiarSalidasViaticos();
            arcScaleComponent1.MaxValue = 100;
            arcScaleComponent1.MinValue = 0;
            limpiarSalidasRevisionUnidad();
            limpiarSalidasFacturas();
            cboMoneda.Text = "Pesos";
        }

        private void limpiarCampos()
        {
            textFolio.Text = "";
            dtFechaSalida.EditValue = DateTime.Now;
            textActivoPrincipal.Tag = "";
            textActivoPrincipal.Text = "";
            textOperador.Tag = "";
            textOperador.Text = "";
            textAyudante.Tag = "";
            textAyudante.Text = "";
            textActivoSec.Tag = "";
            textActivoSec.Text = "";
            textActivoAdicional.Tag = "";
            textActivoAdicional.Text = "";
            textRuta.Tag = "";
            textRuta.Text = "";
            cboMotivoSalida.EditValue = null;
            textCliente.Tag = "";
            textCliente.Text = "";
            textKmIni.Text = "0";
            textKmFin.Text = "0";
            textDiasViaje.Text = "0";
            textLts.Text = "0";
            textHuerta.Tag = "";
            textHuerta.Text = "";
            memoObservaciones.Text = "";
            textOrigen.Text = "";
            textDestino.Text = "";
            gridDiesel.DataSource = null;
            gridOtrosGastos.DataSource = null;
            gridViaticos.DataSource = null;
            gridHonorario.DataSource = null;
            gridCruce.DataSource = null;
            OperadorAnterior = "";
            ActivoAnterior = "";
            
        }

        private void btnBusqAyudante_Click(object sender, EventArgs e)
        {
            Frm_BusqAyudante frm = new Frm_BusqAyudante();
            frm.ShowDialog();
            textAyudante.Tag = frm.IdEmpleado;
            textAyudante.Text = frm.Empleado;
        }

        private void btnBusqRuta_Click(object sender, EventArgs e)
        {
            Frm_Rutas_Buscar frm = new Frm_Rutas_Buscar();
            frm.ShowDialog();
            textRuta.Tag = frm.Id_Rutas;
            textRuta.Text = frm.Nombre_Ruta;
            textOrigen.Text = frm.vOrigen;
            textDestino.Text = frm.vDestino;
        }

        private void btnBusqClientes_Click(object sender, EventArgs e)
        {
            Frm_Clientes frm = new Frm_Clientes();
            frm.PaSel = true;
            frm.ShowDialog();
            textCliente.Tag = frm.IdCliente;
            textCliente.Text = frm.Cliente;
        }

        private void btnBusqActivoPrincipal_Click(object sender, EventArgs e)
        {
            Frm_BusqActivoSinRuta frm = new Frm_BusqActivoSinRuta();

            frm.ShowDialog();
            textActivoPrincipal.Tag = frm.IdActivo;
            textActivoPrincipal.Text = frm.Activo;
            textOperador.Tag = frm.IdOPerador;
            textOperador.Text = frm.Operador;
            ActivoAnterior= frm.IdActivo;
            OperadorAnterior= frm.IdOPerador;
        }

        private void btnBusqActivoSec_Click(object sender, EventArgs e)
        {
            Frm_BusqActivoSinRuta frm = new Frm_BusqActivoSinRuta();

            frm.ShowDialog();
            textActivoSec.Tag = frm.IdActivo;
            textActivoSec.Text = frm.Activo;
        }

        private void btnBusqActivoAdicional_Click(object sender, EventArgs e)
        {
            Frm_BusqActivoSinRuta frm = new Frm_BusqActivoSinRuta();

            frm.ShowDialog();
            textActivoAdicional.Tag = frm.IdActivo;
            textActivoAdicional.Text = frm.Activo;
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textActivoPrincipal.Text.ToString().Trim().Length > 0)
            {
                if (textRuta.Tag.ToString().Trim().Length > 0)
                {
                    if (cboMotivoSalida.EditValue != null)
                    {
                        if (textCliente.Tag.ToString().Trim().Length >0)
                        {
                           InsertarSalidas();
                        }
                        else
                        {
                            XtraMessageBox.Show("Es necesario seleccionar un cliente");
                        }
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar un motivo de salida");
                }
            }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar una ruta");
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un activo principal");
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            limpiarCampos();
            limpiarSalidasRevisionUnidad();
            limpiarSalidasFacturas();
            limpiarSalidasHonorario();
            limpiarSalidasOtrosGastos();
            limpiarSalidasViaticos();
            limpiarSalidas_diesel();
            limpiarSalidasCruce();
        }

        private void btnBusqSalida_Click(object sender, EventArgs e)
        {
            
            Frm_BusqSalidas frm = new Frm_BusqSalidas();
            frm.filtro = 0;
            frm.ShowDialog();
            textFolio.Text= frm.vId_Salida;
            if (frm.vFecha_Salida.Length > 0)
            {
                dtFechaSalida.EditValue = Convert.ToDateTime(frm.vFecha_Salida);
            }
            textActivoPrincipal.Tag=frm.vId_Activo_Principal;
            ActivoAnterior= frm.vId_Activo_Principal; 
            textActivoPrincipal.Text=frm.vNombre_Activo_Principal;
            textOperador.Tag=frm.vId_Operador;
            OperadorAnterior= frm.vId_Operador;
            textOperador.Text=frm.vNombre_Operador;
            textAyudante.Tag=frm.vId_Ayudante;
            textAyudante.Text=frm.vNombre_Ayudante;
            textActivoSec.Tag=frm.vId_Activo_Secundario;
            textActivoSec.Text=frm.vNombre_Activo_Secundario;
            textActivoAdicional.Tag=frm.vId_Activo_Adicional;
            textActivoAdicional.Text=frm.vNombre_Activo_Adicional;
            textRuta.Tag=frm.vId_Ruta ;
            textRuta.Text=frm.vNombre_Ruta;
            textOrigen.Text=frm.vOrigen;
            textDestino.Text=frm.vDestino;
            cboMotivoSalida.EditValue=frm.vId_MotivoSalida;
            textCliente.Tag=frm.vId_Cliente;
            textCliente.Text=frm.vNombre_Cliente;
            textKmIni.Text = frm.vkm_Inicio.ToString() ;
            textKmFin.Text=frm.vkm_Fin.ToString();
            textDiasViaje.Text=frm.vDias_Viaje.ToString();
            textLts.Text=frm.vLts_Km.ToString();
            textHuerta.Tag=frm.vId_Huerta;
            textHuerta.Text=frm.vNombre_Huerta;
            memoObservaciones.Text=frm.vObservaciones;

            CargarSalidas_Diesel();
            CargarSalidasOtrosGastos();
            CargarSalidasViaticos();
            CargarSalidasRevisionUnidad();
            CargarSalidasHonorario();
            CargarSalidasFacturas();
            CargarSalidasCruces();
            
        }

        private void btnMotivoSalida_Click(object sender, EventArgs e)
        {
            Frm_MotivoSalida frm = new Frm_MotivoSalida();
            frm.ShowDialog();
            CargarMotivoSalida();
        }

        private void InsertarSalidasDiesel()
        {
            CLS_Salidas_Diesel Clase = new CLS_Salidas_Diesel();

            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.Ticket = textTicket.Text.ToString();
            Clase.Importe = Convert.ToDecimal(textImporte.Text);
            Clase.Litros = Convert.ToDecimal(textLitros.Text);
            if (comboMonedaDiesel.Text.Equals("Pesos"))
            {
                Clase.Moneda = "P";
            }
            else
            {
                Clase.Moneda = "D";
            }
            DateTime Fecha;
           
            Fecha = Convert.ToDateTime(dateFechaDiesel.Text.Trim());
            Clase.Fecha_Diesel = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Usuario = Id_Usuario;
            Clase.MtdInsertarSalidas_Diesel();
            if (Clase.Exito)
            {
                CargarSalidas_Diesel();
                limpiarSalidas_diesel();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void CargarSalidas_Diesel()
        {
            dateFechaDiesel.EditValue = dtFechaSalida.EditValue;
            comboMonedaDiesel.Text = "Pesos";
            gridDiesel.DataSource = null;
            CLS_Salidas_Diesel Clase = new CLS_Salidas_Diesel();
            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.MtdSeleccionarSalidas_Diesel();
            if (Clase.Exito)
            {
                gridDiesel.DataSource = Clase.Datos;
            }
        }

        private void limpiarSalidas_diesel()
        {
            textTicket.Text = "";
            textImporte.Text = "0";
            textLitros.Text = "0";
            textTicket.Focus();

            
        }

        private void btnSalidaDiesel_Click(object sender, EventArgs e)
        {
            if (textTicket.Text.ToString().Trim().Length > 0)
            {
                if (Convert.ToDecimal(textImporte.Text)>0)
                {
                    if (recorrerPaNoDuplicaG())
                    {
                        InsertarSalidasDiesel();
                    }
                    else
                    {
                        XtraMessageBox.Show("Folio de ticket ya agregado en la lista. Verifique por favor.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("El importe debe ser mayor que cero.");
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario teclear el numero de ticket.");
            }
        }

        private void EliminarSalidaDiesel(string Salida,string ticket)
        {
            CLS_Salidas_Diesel Clase = new CLS_Salidas_Diesel();
            Clase.Id_Salida = Salida;
            Clase.Ticket = ticket;
            Clase.MtdEliminarSalidas_Diesel();
            if (Clase.Exito)
            {
                CargarSalidas_Diesel();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void gridDiesel_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult = XtraMessageBox.Show("¿Esta seguro de que desea eliminar el detalle seleccionado?", "Elimnar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    foreach (int i in this.gridView2.GetSelectedRows())
                    {
                        DataRow row = this.gridView2.GetDataRow(i);
                        EliminarSalidaDiesel(row["Id_Salida"].ToString().Trim(), row["Ticket"].ToString().Trim());

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnBusqGastos_Click(object sender, EventArgs e)
        {
            Frm_Gasto_Directo frm = new Frm_Gasto_Directo();
            frm.PaSel = true;
            frm.ShowDialog();
            textGastos.Tag = frm.vid_GastoDirecto;
            textGastos.Text = frm.vNombre_GastoDirecto;
        }

        private void InsertarSalidasOtrosGastos()
        {
            CLS_Salidas_OtrosGastos Clase = new CLS_Salidas_OtrosGastos();

            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.Ticket = textTicketG.Text.ToString();
            Clase.Importe = Convert.ToDecimal(textImporteG.Text);
            if (cbMonedaG.Text.Equals("Pesos"))
            {
                Clase.Moneda = "P";
            }
            else
            {
                Clase.Moneda = "D";
            }
            Clase.Id_GastoDirecto = textGastos.Tag.ToString();
            if (checkPagadoOperador.Checked)
            {
                Clase.PagoOperador = "1";
            }
            else
            {
                Clase.PagoOperador = "0";
            }
            Clase.Otros_Gastos = textOtrosGastos.Text.Trim();

            Byte[] ArchivoPDF = null;
            Byte[] ArchivoXML = null;

            FileStream fsPDF = null;
            FileStream fsXML = null;

            Boolean noentroPDF = true, noentroXML = true;

            if (RutaPDFG.Length > 0)
            {
                //txtNombreArchivoPDF.Text = result2;
                //string ar = OpenDialog.FileName;
                fsPDF = new FileStream(RutaPDFG, FileMode.Open, FileAccess.Read);
                //Creamos un array de bytes para almacenar los datos leídos por fs.
                ArchivoPDF = new byte[fsPDF.Length];
                //Y guardamos los datos en el array data
                fsPDF.Read(ArchivoPDF, 0, (int)fsPDF.Length);
            }
            else
            {
                ArchivoPDF = ArchivoPDFGlobalG;
                noentroPDF = false;
            }
            if (RutaXMLG.Length > 0)
            {
                fsXML = new FileStream(RutaXMLG, FileMode.Open);
                //Creamos un array de bytes para almacenar los datos leídos por fs.
                ArchivoXML = new byte[fsXML.Length];
                //Y guardamos los datos en el array data
                fsXML.Read(ArchivoXML, 0, Convert.ToInt32(fsXML.Length));
            }
            else
            {
                ArchivoXML = ArchivoXMLGlobalG;
                noentroXML = false;
            }

            Clase.Id_Salida = textFolio.Text.Trim();
            if (ArchivoPDF != null)
            {
                Clase.FacturaPDF = ArchivoPDF;
            }
            else
            {
                Clase.FacturaPDF = Encoding.UTF8.GetBytes("");
            }
            Clase.FacturaPDFNombre = NombrePDFG;
            if (ArchivoXML != null)
            {
                Clase.FacturaXML = ArchivoXML;
            }
            else
            {
                Clase.FacturaXML = Encoding.UTF8.GetBytes("");
            }

            Clase.FacturaXMLNombre = NombreXMLG;

            DateTime Fecha;
            if (checkFGasto.Checked)
            {
                Clase.Fecha_Factura = String.Empty;
            }
            else
            {
                Fecha = Convert.ToDateTime(dateOtroGasto.Text.Trim());
                Clase.Fecha_Factura = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            }
            Clase.Usuario = Id_Usuario;
            Clase.MtdInsertarSalidas_OtrosGastos();

            if (Clase.Exito)
            {
                CargarSalidasOtrosGastos();
                InsertarSalidasHonorarioPagoOperador();
                limpiarSalidasOtrosGastos();
                editaG = false;
                XtraMessageBox.Show("Se ha Insertado el registro con exito");

            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
            if (noentroXML)
            {
                fsXML.Close();
            }
            if (noentroPDF)
            {
                fsPDF.Close();
            }
        }

        private void CargarSalidasOtrosGastos()
        {
            gridOtrosGastos.DataSource = null;
            CLS_Salidas_OtrosGastos Clase = new CLS_Salidas_OtrosGastos();
            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.MtdSeleccionarSalidas_OtrosGastos();
            if (Clase.Exito)
            {
                gridOtrosGastos.DataSource = Clase.Datos;
            }
            CalculaSaldoOperador();
        }

        private void limpiarSalidasOtrosGastos()
        {
            textTicketG.Text = "";
            textImporteG.Text = "0";
            textTicketG.Focus();
            checkPagadoOperador.Checked = false;
            textGastos.Tag = "";
            textGastos.Text = "";
            textOtrosGastos.Text = "";
            cbMonedaG.Text = "Pesos";
            textNombreArchivoPDF.Text = "";
            textNombreArchivoXML.Text = "";
            RutaPDFG = "";
            RutaXMLG = "";
            NombrePDFG = "";
            NombreXMLG = "";
            ArchivoPDFGlobalG = null;
            ArchivoXMLGlobalG = null;
            textTicketG.Enabled = true;
            checkFGasto.Checked = true;
           
        }

        private void EliminarSalidasOtrosGastos(string Salida, string ticket)
        {
            CLS_Salidas_OtrosGastos Clase = new CLS_Salidas_OtrosGastos();
            Clase.Id_Salida = Salida;
            Clase.Ticket = ticket;
            Clase.MtdEliminarSalidas_OtrosGastos();
            if (Clase.Exito)
            {
                CargarSalidasOtrosGastos();
                InsertarSalidasHonorarioPagoOperador();
                limpiarSalidasOtrosGastos();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarSalidasCruces(string Salida, int Archivo)
        {
            CLS_Salidas_Cruces Clase = new CLS_Salidas_Cruces();
            Clase.Id_Salida = Salida;
            Clase.Id_Archivo = Archivo;
            Clase.MtdDeleteSalidasArchivoPDFXML();
            if (Clase.Exito)
            {
                CargarSalidasCruces();
                limpiarSalidasCruce();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void btnAgregaGastos_Click(object sender, EventArgs e)
        {
            if (textTicketG.Text.ToString().Trim().Length > 0)
            {
                if (Convert.ToDecimal(textImporteG.Text) > 0)
                {
                    if (recorrerPaNoDuplicaG() || editaG==true)
                    {
                        InsertarSalidasOtrosGastos();
                    }else
                    {
                        XtraMessageBox.Show("Folio de ticket ya agregado en la lista. Verifique por favor.");
                    }
                    
                }
                else
                {
                    XtraMessageBox.Show("El importe debe ser mayor que cero.");
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario teclear el numero de ticket.");
            }
        }

        private Boolean recorrerPaNoDuplicaG()
        {
            for (int x = 0; x < gridView3.RowCount; x++)
            {
                int xRow = gridView3.GetVisibleRowHandle(x);

                if (gridView3.GetRowCellValue(xRow, gridView3.Columns["Ticket"]).ToString().Equals(textTicketG.Text.Trim()))
                {
                    return false;
                }

            }
            return true;
        }

        private Boolean recorrerPaNoDuplicaD()
        {
            for (int x = 0; x < gridView2.RowCount; x++)
            {
                int xRow = gridView2.GetVisibleRowHandle(x);

                if (gridView2.GetRowCellValue(xRow, gridView2.Columns["Ticket"]).ToString().Equals(textTicket.Text.Trim()))
                {
                    return false;
                }

            }
            return true;
        }

        private void gridOtrosGastos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult = XtraMessageBox.Show("¿Esta seguro de que desea eliminar el detalle seleccionado?", "Elimnar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    foreach (int i in this.gridView3.GetSelectedRows())
                    {
                        DataRow row = this.gridView3.GetDataRow(i);
                        EliminarSalidasOtrosGastos(row["Id_Salida"].ToString().Trim(), row["Ticket"].ToString().Trim());

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void InsertarSalidasViaticos()
        {
            CLS_Salidas_Viaticos Clase = new CLS_Salidas_Viaticos();

            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.PagadoPor = textPagadoX.Text.ToString();
            Clase.Importe = Convert.ToDecimal(textImporteV.Text);
            DateTime Fecha = Convert.ToDateTime(dateFechaViatico.Text.Trim());
            Clase.FechaPago = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
          
            Clase.MtdInsertarSalidas_Viaticos();

            if (Clase.Exito)
            {
                CargarSalidasViaticos();
                limpiarSalidasViaticos();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");

            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void CargarSalidasViaticos()
        {
            gridViaticos.DataSource = null;
            CLS_Salidas_Viaticos Clase = new CLS_Salidas_Viaticos();
            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.MtdSeleccionarSalidas_Viaticos();
            if (Clase.Exito)
            {
                gridViaticos.DataSource = Clase.Datos;
            }
            CalculaSaldoOperador();
        }

        private void limpiarSalidasViaticos()
        {
            textImporteV.Text = "0";
            textPagadoX.Text = "";
            textPagadoX.Focus();
            dateFechaViatico.EditValue = DateTime.Now;

            
        }

        private void EliminarSalidasViaticos(string Salida, string Id_Viatico)
        {
            CLS_Salidas_Viaticos Clase = new CLS_Salidas_Viaticos();
            Clase.Id_Salida = Salida;
            Clase.Id_Viatico = Id_Viatico;
            Clase.MtdEliminarSalidas_Viaticos();
            if (Clase.Exito)
            {
                CargarSalidasViaticos();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void btnAgregaViatico_Click(object sender, EventArgs e)
        {
            if (textPagadoX.Text.ToString().Trim().Length > 0)
            {
                if (Convert.ToDecimal(textImporteV.Text) > 0)
                {
                    InsertarSalidasViaticos();
                }
                else
                {
                    XtraMessageBox.Show("El importe debe ser mayor que cero.");
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario teclear quien proporciono el pago.");
            }
        }

        private void gridViaticos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult = XtraMessageBox.Show("¿Esta seguro de que desea eliminar el detalle seleccionado?", "Elimnar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    foreach (int i in this.gridView4.GetSelectedRows())
                    {
                        DataRow row = this.gridView4.GetDataRow(i);
                        EliminarSalidasViaticos(row["Id_Salida"].ToString().Trim(), row["Id_Viatico"].ToString().Trim());

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void limpiarSalidasRevisionUnidad()
        {
            checkAceite.Checked = false;
            checkAnticongelante.Checked = false;
            checkCaja.Checked = false;
            checkLicencia.Checked = false;
            checkLimpieza.Checked = false;
            checkLiquidoDireccion.Checked = false;
            checkLuces.Checked = false;
            checkPresionLlantas.Checked = false;
            checkTCirculacion.Checked = false;
            checkTCombustible.Checked = false;
            textCombustible.Text = "0";
            arcScaleComponent1.Value = 0;
        }


        private void InsertarSalidasRevisionUnidad()
        {
            CLS_Salidas_RevisionUnidad Clase = new CLS_Salidas_RevisionUnidad();

            Clase.Id_Salida = textFolio.Text.Trim();
            if (checkAceite.Checked)
            {
                Clase.AceiteMotor = "1";
            }
            else
            {
                Clase.AceiteMotor = "0";
            }
            if (checkLiquidoDireccion.Checked)
            {
                Clase.LiqDireccionHidraulica = "1";
            }
            else
            {
                Clase.LiqDireccionHidraulica = "0";
            }
            if (checkAnticongelante.Checked)
            {
                Clase.Anticongelante = "1";
            }
            else
            {
                Clase.Anticongelante = "0";
            }
            if (checkTCirculacion.Checked)
            {
                Clase.TCirculacion = "1";
            }
            else
            {
                Clase.TCirculacion = "0";
            }
            if (checkTCombustible.Checked)
            {
                Clase.TCombustible = "1";
            }
            else
            {
                Clase.TCombustible = "0";
            }
            if (checkLicencia.Checked)
            {
                Clase.TLicencia = "1";
            }
            else
            {
                Clase.TLicencia = "0";
            }
            if (checkLimpieza.Checked)
            {
                Clase.LimpiezaInterior = "1";
            }
            else
            {
                Clase.LimpiezaInterior = "0";
            }
            if (checkPresionLlantas.Checked)
            {
                Clase.PresionLlantas = "1";
            }
            else
            {
                Clase.PresionLlantas = "0";
            }
            if (checkLuces.Checked)
            {
                Clase.Luces = "1";
            }
            else
            {
                Clase.Luces = "0";
            }
            if (checkCaja.Checked)
            {
                Clase.CajaCampo = "1";
            }
            else
            {
                Clase.CajaCampo = "0";
            }
            
            Clase.Combustible = Convert.ToDecimal(textCombustible.Text);

            Clase.MtdInsertarSalidas_RevisionUnidad();

            if (Clase.Exito)
            {
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void CargarSalidasRevisionUnidad()
        {
            CLS_Salidas_RevisionUnidad Clase = new CLS_Salidas_RevisionUnidad();
            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.MtdSeleccionarSalidas_RevisionUnidad();
            if (Clase.Exito)
            {
                if (Clase.Datos.Rows.Count > 0)
                {

                    checkAceite.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["AceiteMotor"]);
                    checkLiquidoDireccion.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["LiqDireccionHidraulica"]);
                    checkAnticongelante.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["Anticongelante"]);
                    checkTCirculacion.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["TCirculacion"]);
                    checkTCombustible.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["TCombustible"]);
                    checkLicencia.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["TLicencia"]);
                    checkLimpieza.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["LimpiezaInterior"]);
                    checkPresionLlantas.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["PresionLlantas"]);
                    checkLuces.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["Luces"]);
                    checkCaja.Checked = Convert.ToBoolean(Clase.Datos.Rows[0]["CajaCampo"]);
                    textCombustible.Text = Clase.Datos.Rows[0]["Combustible"].ToString();
                }
            }
        }

        private void btnGuardarCheck_Click(object sender, EventArgs e)
        {
            InsertarSalidasRevisionUnidad();
        }

        private void textCombustible_EditValueChanged_1(object sender, EventArgs e)
        {
            arcScaleComponent1.Value = Convert.ToInt32(textCombustible.Text);
        }

        private decimal CalculaPagadoPorOperador()
        {
            decimal TPagoOperador = 0;
            for(int x = 0; x < gridView3.RowCount; x++)
            {
                int xRow = gridView3.GetVisibleRowHandle(x);
                
                if (gridView3.GetRowCellValue(xRow, gridView3.Columns["PagoOperador"]).ToString().Equals("True"))
                {
                    TPagoOperador = TPagoOperador + Convert.ToDecimal(gridView3.GetRowCellValue(xRow, gridView3.Columns["Importe"]));
                }
                
            }
            return TPagoOperador;
        }

        private decimal CalculaViaticos()
        {
            decimal TViaticos = 0;
            for (int x = 0; x < gridView4.RowCount; x++)
            {
                int xRow = gridView4.GetVisibleRowHandle(x);

                
                    TViaticos = TViaticos + Convert.ToDecimal(gridView4.GetRowCellValue(xRow, gridView4.Columns["Importe"]));
                

            }
            return TViaticos;
        }

        private decimal CalculaHonorarios()
        {
            decimal Thonorarios = 0;
            for (int x = 0; x < gridView5.RowCount; x++)
            {
                int xRow = gridView5.GetVisibleRowHandle(x);

                if (gridView5.GetRowCellValue(xRow, gridView5.Columns["Concepto"]).ToString().Equals("HONORARIOS AL OPERADOR"))
                {
                    Thonorarios = Thonorarios + Convert.ToDecimal(gridView5.GetRowCellValue(xRow, gridView5.Columns["Importe"]));
                }

            }
            return Thonorarios;
        }

        private void CalculaSaldoOperador()
        {
            decimal TSaldoOperador = 0;
           
            TSaldoOperador = (CalculaHonorarios() - CalculaViaticos()) + CalculaPagadoPorOperador();

            labelSaldoOperdor.Text = TSaldoOperador.ToString();
        }

        private void InsertarSalidasHonorarioPagoOperador()
        {
            CLS_Salidas_Honorarios Clase = new CLS_Salidas_Honorarios();

            Clase.Id_Salida = textFolio.Text.Trim();
           
            Clase.Importe = CalculaPagadoPorOperador();
            
            Clase.MtdInsertarSalidas_Honorarios_PagoOperador();

            if (Clase.Exito)
            {
                
                CargarSalidasHonorario();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void InsertarSalidasHonorario()
        {
            CLS_Salidas_Honorarios Clase = new CLS_Salidas_Honorarios();

            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.Importe = Convert.ToDecimal(textImporteH.Text);
            DateTime Fecha = Convert.ToDateTime(dtFechaSalida.Text.Trim());
            Clase.Fecha_Honorario = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Usuario = Id_Usuario;
            Clase.MtdInsertarSalidas_Honorarios();

            if (Clase.Exito)
            {
                CargarSalidasHonorario();
                limpiarSalidasHonorario();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");

            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void limpiarSalidasHonorario()
        {
            textImporteH.Text = "0";
            textImporteH.Focus();
            labelSaldoOperdor.Text = "0";

            
        }

        private void CargarSalidasHonorario()
        {
            gridHonorario.DataSource = null;
            CLS_Salidas_Honorarios Clase = new CLS_Salidas_Honorarios();
            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.MtdSeleccionarSalidas_Honorarios();
            if (Clase.Exito)
            {
                gridHonorario.DataSource = Clase.Datos;
            }
            CalculaSaldoOperador();
        }

        private void EliminarSalidasHonorario(string Salida, string Id_Honorario)
        {
            CLS_Salidas_Honorarios Clase = new CLS_Salidas_Honorarios();
            Clase.Id_Salida = Salida;
            Clase.Id_Honorario = Id_Honorario;
            Clase.MtdEliminarSalidas_Honorarios();
            if (Clase.Exito)
            {
                InsertarSalidasHonorarioPagoOperador();
                CargarSalidasViaticos();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void btnAgregaHonorario_Click(object sender, EventArgs e)
        {
            InsertarSalidasHonorarioPagoOperador();
            if (Convert.ToDecimal(textImporteH.Text) > 0)
            {
                InsertarSalidasHonorario();
            }
            else
            {
                XtraMessageBox.Show("El importe debe ser mayor que cero.");
            }
        }

        private void gridHonorario_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Boolean pasaValidacion = false;
                foreach (int i in this.gridView5.GetSelectedRows())
                {
                    DataRow row = this.gridView5.GetDataRow(i);
                    if (row["Concepto"].ToString().Trim().Equals("GASTOS PAGADOS POR OPERADOR"))
                    {
                        XtraMessageBox.Show("No se puede eliminar este concepto");

                    }else
                    {
                        pasaValidacion = true;
                    }

                }
                if (pasaValidacion == true)
                {
                   
                    DialogResult = XtraMessageBox.Show("¿Esta seguro de que desea eliminar el detalle seleccionado?", "Elimnar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (DialogResult == DialogResult.Yes)
                    {
                        foreach (int i in this.gridView5.GetSelectedRows())
                        {
                            DataRow row = this.gridView5.GetDataRow(i);
                            EliminarSalidasHonorario(row["Id_Salida"].ToString().Trim(), row["Id_Honorario"].ToString().Trim());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnBusqHuerta_Click(object sender, EventArgs e)
        {
            Frm_Huertas frm = new Frm_Huertas();
            frm.PaSel = true;
            frm.ShowDialog();
            textHuerta.Tag = frm.IdHuerta;
            textHuerta.Text = frm.Huerta;
        }

        private void btnUpPDF_Click(object sender, EventArgs e)
        {
            OpenDialog.Filter = "Portable Document Format (*.PDF)|*.PDF";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
            OpenDialog.Title = "Cargar Documento PDF";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                var result2="";
                do
                {
                    args.Caption = "Ingrese el nombre del Archivo";
                    args.Prompt = "Descripción";
                    args.DefaultButtonIndex = 0;
                    //args.Showing += Args_Showing;
                    // initialize a DateEdit editor with custom settings 
                    TextEdit editor = new TextEdit();
                    args.Editor = editor;
                    // a default DateEdit value 
                    args.DefaultResponse = "Archivo PDF";
                    // display an Input Box with the custom editor
                    args.Editor = textEdit;
                    result2 = XtraInputBox.Show(args).ToString();
                } while (result2.Length==0 );
               
               
                if (result2 != null)
                {
                    NombrePDF = result2;
                    RutaPDF = OpenDialog.FileName;
                    txtNombreArchivoPDF.Text = result2;
                    //string ar = OpenDialog.FileName;
                    //FileStream fs = new FileStream(ar, FileMode.Open);
                    ////Creamos un array de bytes para almacenar los datos leídos por fs.
                    //Byte[] Archivo = new byte[fs.Length];
                    ////Y guardamos los datos en el array data
                    //fs.Read(Archivo, 0, Convert.ToInt32(fs.Length));
                    //CLS_Activos udp = new CLS_Activos();
                    //udp.Id_Activo = ;
                    //udp.Opcion = 1;
                    //udp.NombreArchivoPDF = txtNombreArchivoPDF.Text;
                    //udp.ArchivoPDF = Archivo;
                    //udp.MtdUpdateActivoArchivoPDF();
                    //if (udp.Exito)
                    //{
                    //    XtraMessageBox.Show("Se a agregado el PDF con Exito");
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show(udp.Mensaje);
                    //}
                }
            }
        }

        private void btnUPXML_Click(object sender, EventArgs e)
        {
            OpenDialog.Filter = "eXtensible Markup Language (*.XML)|*.XML";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); ;
            OpenDialog.Title = "Cargar Documento XML";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                var result2 = "";
                do
                {
                    args.Caption = "Ingrese el nombre del Archivo";
                    args.Prompt = "Descripción";
                    args.DefaultButtonIndex = 0;
                    //args.Showing += Args_Showing;
                    // initialize a DateEdit editor with custom settings 
                    TextEdit editor = new TextEdit();
                    args.Editor = editor;
                    // a default DateEdit value 
                    args.DefaultResponse = "Archivo XML";
                    // display an Input Box with the custom editor
                    args.Editor = textEdit;
                    result2 = XtraInputBox.Show(args).ToString();
                } while (result2.Length == 0);
                if (result2 != null)
                {
                    NombreXML = result2;
                    RutaXML = OpenDialog.FileName;
                    txtNombreArchivoXML.Text = result2;
                    //string ar = OpenDialog.FileName;
                    //FileStream fs = new FileStream(ar, FileMode.Open);
                    ////Creamos un array de bytes para almacenar los datos leídos por fs.
                    //Byte[] Archivo = new byte[fs.Length];
                    ////Y guardamos los datos en el array data
                    //fs.Read(Archivo, 0, Convert.ToInt32(fs.Length));
                    //CLS_Activos udp = new CLS_Activos();
                    //udp.Id_Activo = vId_Activo;
                    //udp.Opcion = 1;
                    //udp.NombreArchivoXML = txtNombreArchivoXML.Text;
                    //udp.ArchivoXML = Archivo;
                    //udp.MtdUpdateActivoArchivoXML();
                    //if (udp.Exito)
                    //{
                    //    XtraMessageBox.Show("Se a agregado el PDF con Exito");
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show(udp.Mensaje);
                    //}
                }else
                {

                }
            }
            
        }

        private void btnAgregarFacturas_Click(object sender, EventArgs e)
        {
            CLS_Salidas_Facturas Clase = new CLS_Salidas_Facturas();

            Byte[] ArchivoPDF=null;
            Byte[] ArchivoXML=null;

            FileStream fsPDF=null;
            FileStream fsXML=null;

            Boolean noentroPDF = true,noentroXML=true;

            if (RutaPDF.Length > 0)
            {
                //txtNombreArchivoPDF.Text = result2;
                //string ar = OpenDialog.FileName;
                fsPDF = new FileStream(RutaPDF, FileMode.Open, FileAccess.Read);
                //Creamos un array de bytes para almacenar los datos leídos por fs.
                ArchivoPDF = new byte[fsPDF.Length];
                //Y guardamos los datos en el array data
                fsPDF.Read(ArchivoPDF, 0, (int)fsPDF.Length);
            }else
            {
                ArchivoPDF =ArchivoPDFGlobal;
                noentroPDF = false;
            }
            if (RutaXML.Length > 0)
            {
                fsXML = new FileStream(RutaXML, FileMode.Open);
                //Creamos un array de bytes para almacenar los datos leídos por fs.
                ArchivoXML = new byte[fsXML.Length];
                //Y guardamos los datos en el array data
                fsXML.Read(ArchivoXML, 0, Convert.ToInt32(fsXML.Length));
            }else
            {
                ArchivoXML = ArchivoXMLGlobal;
                noentroXML = false;
            }

            Clase.Id_Salida = textFolio.Text.Trim();
            if (ArchivoPDF!=null)
            {
                Clase.FacturaPDF = ArchivoPDF;
            }
            else
            {
                Clase.FacturaPDF = Encoding.UTF8.GetBytes("");
            }
            Clase.FacturaPDFNombre = NombrePDF;
            if (ArchivoXML!=null)
            {
                Clase.FacturaXML = ArchivoXML;
            }
            else
            {
                Clase.FacturaXML = Encoding.UTF8.GetBytes("");
            }
            
            Clase.FacturaXMLNombre = NombreXML;
            Clase.Importe = Convert.ToDecimal(textImporteF.Text);
            Clase.Id_Archivo = Convert.ToDecimal(labelIdArchivo.Text);
            if (cboMoneda.Text.Equals("Pesos"))
            {
                Clase.Moneda = "P";
            }else
            {
                Clase.Moneda = "D";
            }

            if (rbDiferidoF.Checked)
            {
                Clase.Diferido = "1";
            }
            else
            {
                Clase.Diferido = "0";
            }

            DateTime Fecha;
           

            if (dateFactura.EditValue == null)
            {
                Clase.Fecha_Factura = String.Empty;
            }else
            {
               Fecha = Convert.ToDateTime(dateFactura.Text.Trim());
               Clase.Fecha_Factura = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            }
            if (dateCobro.EditValue == null)
            {
                Clase.Fecha_Cobro = String.Empty;
            }
            else
            {
                Fecha = Convert.ToDateTime(dateCobro.Text.Trim());
                Clase.Fecha_Cobro = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            }
            if (datePago.EditValue == null)
            {
                Clase.Fecha_Pago = String.Empty;
            }
            else
            {
                Fecha = Convert.ToDateTime(datePago.Text.Trim());
                Clase.Fecha_Pago = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            }
            
                Clase.Importe_Viaje = Convert.ToDecimal(txtImporteViaje.Text);


            Clase.Usuario = Id_Usuario;
            Clase.MtdInsertarSalidasArchivoPDFXML();

            if (Clase.Exito)
            {
                CargarSalidasFacturas();
                limpiarSalidasFacturas();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
            if (noentroXML)
            {
                fsXML.Close();
            }
            if (noentroPDF)
            {
                fsPDF.Close();
            }
            
        }

        private void btnViewPDF_Click(object sender, EventArgs e)
        {
            Frm_ViewPDFSalidas frm = new Frm_ViewPDFSalidas();
            frm.Id_Salida = textFolio.Text.Trim();
            frm.Id_Archivo = Convert.ToDecimal(labelIdArchivo.Text);
            frm.Ventana = "Facturas";
            frm.ShowDialog();
            frm.Dispose();
            System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf");
        }

        private void CargarSalidasFacturas()
        {
            gridFacturas.DataSource = null;
            CLS_Salidas_Facturas Clase = new CLS_Salidas_Facturas();
            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.MtdSeleccionarSalidasArchivoPDFXML();
            if (Clase.Exito)
            {
                gridFacturas.DataSource = Clase.Datos;
            }
        }

        private void CargarSalidasCruces()
        {
            gridCruce.DataSource = null;
            CLS_Salidas_Cruces Clase = new CLS_Salidas_Cruces();
            Clase.Id_Salida = textFolio.Text.Trim();
            Clase.MtdSeleccionarSalidasArchivoPDFXML();
            if (Clase.Exito)
            {
                gridCruce.DataSource = Clase.Datos;
            }
        }

        private void gridFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView6.GetSelectedRows())
                {
                    DataRow row = this.gridView6.GetDataRow(i);
                    
                    txtNombreArchivoPDF.Text = row["FacturaPDFNombre"].ToString();
                    NombrePDF= row["FacturaPDFNombre"].ToString();
                    txtNombreArchivoXML.Text = row["FacturaXMLNombre"].ToString();
                    NombreXML= row["FacturaXMLNombre"].ToString();
                    ArchivoPDFGlobal = (byte[])row["FacturaPDF"];
                    ArchivoXMLGlobal = (byte[])(row["FacturaXML"]);
                    textImporteF.Text= row["Importe"].ToString();
                    labelIdArchivo.Text= row["Id_Archivo"].ToString();
                    if (row["Moneda"].ToString().Equals("P"))
                    {
                        cboMoneda.Text = "Pesos";
                    }else
                    {
                        cboMoneda.Text = "Dólares";
                    }

                    if (row["Diferido"].ToString().Equals("True"))
                    {
                        rbDiferidoF.Checked = true;
                    }
                    else
                    {
                        rbTotalF.Checked = true;
                    }

                    if (row["Fecha_Factura"].ToString() == String.Empty)
                    {

                    }
                    else
                    {
                        dateFactura.EditValue = Convert.ToDateTime(row["Fecha_Factura"]);
                    }
                   
                    if (row["Fecha_Cobro"].ToString() == String.Empty)
                    {

                    }else
                    {
                        dateCobro.EditValue = Convert.ToDateTime(row["Fecha_Cobro"]);
                    }
                        
                    if (row["Fecha_Pago"].ToString()==String.Empty)
                    {

                    }else
                    {
                        datePago.EditValue = Convert.ToDateTime(row["Fecha_Pago"]);
                        checkPagada.Checked = true;
                    }

                    txtImporteViaje.Text = row["Importe_Viaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnViewXML_Click(object sender, EventArgs e)
        {
            Frm_ViewXMLSalidas frm = new Frm_ViewXMLSalidas();
            frm.Id_Salida = textFolio.Text.Trim();
            frm.Id_Archivo=Convert.ToDecimal(labelIdArchivo.Text);
            frm.Ventana = "Facturas";
            frm.ShowDialog();
            frm.Dispose();
            System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewXML.xml");
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Salidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Frm_Salidas_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void gridFacturas_DoubleClick(object sender, EventArgs e)
        {
            limpiarSalidasFacturas();
            try
            {
                DialogResult = XtraMessageBox.Show("¿Esta seguro de que desea eliminar el detalle seleccionado?", "Elimnar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    foreach (int i in this.gridView6.GetSelectedRows())
                    {
                        DataRow row = this.gridView6.GetDataRow(i);
                        EliminarSalidasFacturas(row["Id_Salida"].ToString().Trim(), row["Id_Archivo"].ToString().Trim());

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnBusqOperador_Click(object sender, EventArgs e)
        {
            Frm_Empleados frm = new Frm_Empleados();
            frm.PaSel = true;
            frm.ShowDialog();

            textOperador.Text = frm.vNombre_Empleado;
            textOperador.Tag = frm.vId_Empleado;
        }

        private void btnUpPDFG_Click(object sender, EventArgs e)
        {
            OpenDialog.Filter = "Portable Document Format (*.PDF)|*.PDF";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
            OpenDialog.Title = "Cargar Documento PDF";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                var result2 = "";
                do
                {
                    args.Caption = "Ingrese el nombre del Archivo";
                    args.Prompt = "Descripción";
                    args.DefaultButtonIndex = 0;
                    //args.Showing += Args_Showing;
                    // initialize a DateEdit editor with custom settings 
                    TextEdit editor = new TextEdit();
                    args.Editor = editor;
                    // a default DateEdit value 
                    args.DefaultResponse = "Archivo PDF";
                    // display an Input Box with the custom editor
                    args.Editor = textEdit;
                    result2 = XtraInputBox.Show(args).ToString();
                } while (result2.Length == 0);


                if (result2 != null)
                {
                    NombrePDFG = result2;
                    RutaPDFG = OpenDialog.FileName;
                    textNombreArchivoPDF.Text = result2;
                    //string ar = OpenDialog.FileName;
                    //FileStream fs = new FileStream(ar, FileMode.Open);
                    ////Creamos un array de bytes para almacenar los datos leídos por fs.
                    //Byte[] Archivo = new byte[fs.Length];
                    ////Y guardamos los datos en el array data
                    //fs.Read(Archivo, 0, Convert.ToInt32(fs.Length));
                    //CLS_Activos udp = new CLS_Activos();
                    //udp.Id_Activo = ;
                    //udp.Opcion = 1;
                    //udp.NombreArchivoPDF = txtNombreArchivoPDF.Text;
                    //udp.ArchivoPDF = Archivo;
                    //udp.MtdUpdateActivoArchivoPDF();
                    //if (udp.Exito)
                    //{
                    //    XtraMessageBox.Show("Se a agregado el PDF con Exito");
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show(udp.Mensaje);
                    //}
                }
            }
        }

        private void btnViewPDFG_Click(object sender, EventArgs e)
        {
            Frm_ViewPDFSalidas frm = new Frm_ViewPDFSalidas();
            frm.Id_Salida = textFolio.Text.Trim();
            frm.Ticket = textTicketG.Text.Trim();
            frm.Ventana = "OtrosGastos";
            frm.ShowDialog();
            frm.Dispose();
            System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf");
        }

        private void gridOtrosGastos_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView3.GetSelectedRows())
                {
                    DataRow row = this.gridView3.GetDataRow(i);

                    textNombreArchivoPDF.Text = row["FacturaPDFNombre"].ToString();
                    NombrePDFG = row["FacturaPDFNombre"].ToString();
                    textNombreArchivoXML.Text = row["FacturaXMLNombre"].ToString();
                    NombreXMLG = row["FacturaXMLNombre"].ToString();
                    if (row["FacturaPDF"].ToString().Length>0) { ArchivoPDFGlobalG = (byte[])row["FacturaPDF"]; }
                    if (row["FacturaXML"].ToString().Length > 0) { ArchivoXMLGlobalG = (byte[])(row["FacturaXML"]); }
                    
                    textImporteG.Text = row["Importe"].ToString();
                    textTicketG.Text = row["Ticket"].ToString();
                    textGastos.Tag = row["Id_GastoDirecto"].ToString();
                    textGastos.Text = row["Nombre_GastoDirecto"].ToString();
                    textOtrosGastos.Text = row["Otros_Gastos"].ToString();
                    if (row["Fecha_Factura"].ToString() != String.Empty)
                    {
                        checkFGasto.Checked = false;
                        dateOtroGasto.EditValue = Convert.ToDateTime(row["Fecha_Factura"]);
                        
                    }else
                    {
                        checkFGasto.Checked = true;
                        dateOtroGasto.EditValue = null;
                    }
                    if (row["Moneda"].ToString().Equals("P"))
                    {
                        cbMonedaG.Text = "Pesos";
                    }
                    else
                    {
                        cbMonedaG.Text = "Dólares";
                    }
                    if (row["PagoOperador"].ToString().Equals("True"))
                    {
                        checkPagadoOperador.Checked = true;
                    }else
                    {
                        checkPagadoOperador.Checked = false;
                    }

                    textTicketG.Enabled = false;
                    editaG = true;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnUpPDFC_Click(object sender, EventArgs e)
        {
            OpenDialog.Filter = "Portable Document Format (*.PDF)|*.PDF";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
            OpenDialog.Title = "Cargar Documento PDF";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                var result2 = "";
                do
                {
                    args.Caption = "Ingrese el nombre del Archivo";
                    args.Prompt = "Descripción";
                    args.DefaultButtonIndex = 0;
                    //args.Showing += Args_Showing;
                    // initialize a DateEdit editor with custom settings 
                    TextEdit editor = new TextEdit();
                    args.Editor = editor;
                    // a default DateEdit value 
                    args.DefaultResponse = "Archivo PDF";
                    // display an Input Box with the custom editor
                    args.Editor = textEdit;
                    result2 = XtraInputBox.Show(args).ToString();
                } while (result2.Length == 0);


                if (result2 != null)
                {
                    NombrePDFC = result2;
                    RutaPDFC = OpenDialog.FileName;
                    txtNombreArchivoPDFC.Text = result2;
                    //string ar = OpenDialog.FileName;
                    //FileStream fs = new FileStream(ar, FileMode.Open);
                    ////Creamos un array de bytes para almacenar los datos leídos por fs.
                    //Byte[] Archivo = new byte[fs.Length];
                    ////Y guardamos los datos en el array data
                    //fs.Read(Archivo, 0, Convert.ToInt32(fs.Length));
                    //CLS_Activos udp = new CLS_Activos();
                    //udp.Id_Activo = ;
                    //udp.Opcion = 1;
                    //udp.NombreArchivoPDF = txtNombreArchivoPDF.Text;
                    //udp.ArchivoPDF = Archivo;
                    //udp.MtdUpdateActivoArchivoPDF();
                    //if (udp.Exito)
                    //{
                    //    XtraMessageBox.Show("Se a agregado el PDF con Exito");
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show(udp.Mensaje);
                    //}
                }
            }
        }

        private void btnUpXMLC_Click(object sender, EventArgs e)
        {
            OpenDialog.Filter = "eXtensible Markup Language (*.XML)|*.XML";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
            OpenDialog.Title = "Cargar Documento XML";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                var result2 = "";
                do
                {
                    args.Caption = "Ingrese el nombre del Archivo";
                    args.Prompt = "Descripción";
                    args.DefaultButtonIndex = 0;
                    //args.Showing += Args_Showing;
                    // initialize a DateEdit editor with custom settings 
                    TextEdit editor = new TextEdit();
                    args.Editor = editor;
                    // a default DateEdit value 
                    args.DefaultResponse = "Archivo XML";
                    // display an Input Box with the custom editor
                    args.Editor = textEdit;
                    result2 = XtraInputBox.Show(args).ToString();
                } while (result2.Length == 0);
                if (result2 != null)
                {
                    NombreXMLC = result2;
                    RutaXMLC = OpenDialog.FileName;
                    txtNombreArchivoXMLC.Text = result2;
                    //string ar = OpenDialog.FileName;
                    //FileStream fs = new FileStream(ar, FileMode.Open);
                    ////Creamos un array de bytes para almacenar los datos leídos por fs.
                    //Byte[] Archivo = new byte[fs.Length];
                    ////Y guardamos los datos en el array data
                    //fs.Read(Archivo, 0, Convert.ToInt32(fs.Length));
                    //CLS_Activos udp = new CLS_Activos();
                    //udp.Id_Activo = vId_Activo;
                    //udp.Opcion = 1;
                    //udp.NombreArchivoXML = txtNombreArchivoXML.Text;
                    //udp.ArchivoXML = Archivo;
                    //udp.MtdUpdateActivoArchivoXML();
                    //if (udp.Exito)
                    //{
                    //    XtraMessageBox.Show("Se a agregado el PDF con Exito");
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show(udp.Mensaje);
                    //}
                }
                else
                {

                }
            }
        }

        private void btnViewPDFC_Click(object sender, EventArgs e)
        {
            Frm_ViewPDFSalidas frm = new Frm_ViewPDFSalidas();
            frm.Id_Salida = textFolio.Text.Trim();
            frm.Id_Archivo = Convert.ToInt32(labelId_Archivo.Text.Trim());
            frm.Ventana = "Cruces";
            frm.ShowDialog();
            frm.Dispose();
            System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf");
        }

        private void btnViewXMLC_Click(object sender, EventArgs e)
        {
            Frm_ViewXMLSalidas frm = new Frm_ViewXMLSalidas();
            frm.Id_Salida = textFolio.Text.Trim();
            frm.Id_Archivo = Convert.ToInt32(labelId_Archivo.Text.Trim());
            frm.Ventana = "Cruces";
            frm.ShowDialog();
            frm.Dispose();
            System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewXML.xml");
        }

        private void btnAgregarCruce_Click(object sender, EventArgs e)
        {
            CLS_Salidas_Cruces Clase = new CLS_Salidas_Cruces();

            Byte[] ArchivoPDFC = null;
            Byte[] ArchivoXMLC = null;

            FileStream fsPDF = null;
            FileStream fsXML = null;

            Boolean noentroPDF = true, noentroXML = true;

            if (RutaPDFC.Length > 0)
            {
                //txtNombreArchivoPDF.Text = result2;
                //string ar = OpenDialog.FileName;
                fsPDF = new FileStream(RutaPDFC, FileMode.Open, FileAccess.Read);
                //Creamos un array de bytes para almacenar los datos leídos por fs.
                ArchivoPDFC = new byte[fsPDF.Length];
                //Y guardamos los datos en el array data
                fsPDF.Read(ArchivoPDFC, 0, (int)fsPDF.Length);
            }
            else
            {
                ArchivoPDFC = ArchivoPDFGlobalC;
                noentroPDF = false;
            }
            if (RutaXMLC.Length > 0)
            {
                fsXML = new FileStream(RutaXMLC, FileMode.Open);
                //Creamos un array de bytes para almacenar los datos leídos por fs.
                ArchivoXMLC = new byte[fsXML.Length];
                //Y guardamos los datos en el array data
                fsXML.Read(ArchivoXMLC, 0, Convert.ToInt32(fsXML.Length));
            }
            else
            {
                ArchivoXMLC = ArchivoXMLGlobalC;
                noentroXML = false;
            }

            Clase.Id_Salida = textFolio.Text.Trim();
            if (ArchivoPDFC != null)
            {
                Clase.FacturaPDF = ArchivoPDFC;
            }
            else
            {
                Clase.FacturaPDF = Encoding.UTF8.GetBytes("");
            }
            Clase.FacturaPDFNombre = NombrePDFC;
            if (ArchivoXMLC != null)
            {
                Clase.FacturaXML = ArchivoXMLC;
            }
            else
            {
                Clase.FacturaXML = Encoding.UTF8.GetBytes("");
            }

            Clase.FacturaXMLNombre = NombreXMLC;
            Clase.Importe = Convert.ToDecimal(textImporteC.Text);
            
                DateTime Fecha = Convert.ToDateTime(dateFacturaC.Text.Trim());
            Clase.Fecha_Cruce  = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Archivo = Convert.ToInt32( labelId_Archivo.Text);
            if (cboMonedaC.Text.Equals("Pesos"))
            {
                Clase.Moneda = "P";
            }
            else
            {
                Clase.Moneda = "D";
            }
            if (rbDiferido.Checked)
            {
                Clase.Diferido = "1";
            }
            else
            {
                Clase.Diferido = "0";
            }
            

            Clase.MtdInsertarSalidasArchivoPDFXML();

            if (Clase.Exito)
            {
                CargarSalidasCruces();
                limpiarSalidasCruce();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");

            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
            if (noentroXML)
            {
                fsXML.Close();
            }
            if (noentroPDF)
            {
                fsPDF.Close();
            }
        }

        private void gridCruce_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);

                    txtNombreArchivoPDFC.Text = row["FacturaPDFNombre"].ToString();
                    NombrePDFC = row["FacturaPDFNombre"].ToString();
                    txtNombreArchivoXMLC.Text = row["FacturaXMLNombre"].ToString();
                    NombreXMLC = row["FacturaXMLNombre"].ToString();
                    ArchivoPDFGlobalC = (byte[])row["FacturaPDF"];
                    ArchivoXMLGlobalC = (byte[])(row["FacturaXML"]);
                    textImporteC.Text = row["Importe"].ToString();
                    dateFacturaC.Text = row["Fecha_Cruce"].ToString();
                    labelId_Archivo.Text = row["Id_Archivo"].ToString();
                    if (row["Moneda"].ToString().Equals("P"))
                    {
                        cboMonedaC.Text = "Pesos";
                    }
                    else
                    {
                        cboMonedaC.Text = "Dólares";
                    }
                    if (row["Diferido"].ToString().Equals("True")){
                        rbDiferido.Checked = true;
                    }
                    else
                    {
                        rbTotal.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void checkPagada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPagada.Checked)
            {
                datePago.Enabled = true;
                datePago.EditValue = DateTime.Now;
            }
            else
            {
                datePago.EditValue = null;
                datePago.Enabled = false;
            }
        }

        private void checkFGasto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFGasto.Checked == false)
            {
                dateOtroGasto.Enabled = true;
                dateOtroGasto.EditValue = DateTime.Today;
            }else
            {
                dateOtroGasto.Enabled = false;
                dateOtroGasto.EditValue = null;
            }
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                checkAll.Text = "Desmarcar todo";
                checkAceite.Checked = true;
                checkAnticongelante.Checked = true;
                checkCaja.Checked = true;
                checkLicencia.Checked = true;
                checkLimpieza.Checked = true;
                checkLiquidoDireccion.Checked = true;
                checkLuces.Checked = true;
                checkPresionLlantas.Checked = true;
                checkTCirculacion.Checked = true;
                checkTCombustible.Checked = true;

            }
            else
            {
                checkAll.Text = "Marcar todo";
                checkAceite.Checked = false;
                checkAnticongelante.Checked = false;
                checkCaja.Checked = false;
                checkLicencia.Checked = false;
                checkLimpieza.Checked = false;
                checkLiquidoDireccion.Checked = false;
                checkLuces.Checked = false;
                checkPresionLlantas.Checked = false;
                checkTCirculacion.Checked = false;
                checkTCombustible.Checked = false;
            }
        }

        

        private void gridCruce_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult = XtraMessageBox.Show("¿Esta seguro de que desea eliminar el Cruce seleccionado?", "Elimnar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    foreach (int i in this.gridView1.GetSelectedRows())
                    {
                        DataRow row = this.gridView1.GetDataRow(i);
                        EliminarSalidasCruces(row["Id_Salida"].ToString().Trim(), Convert.ToInt32(row["Id_Archivo"]));
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void textGastos_EditValueChanged(object sender, EventArgs e)
        {
            if (textGastos.Text.Contains("Otros Gastos") && textGastos.Text.Trim().Length>0)
            {
                textOtrosGastos.Enabled = true;
            }else
            {
                textOtrosGastos.Enabled = false;
                textOtrosGastos.Text = "";
            }
        }

        private void btnUPXMLG_Click(object sender, EventArgs e)
        {
            OpenDialog.Filter = "eXtensible Markup Language (*.XML)|*.XML";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); ;
            OpenDialog.Title = "Cargar Documento XML";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                var result2 = "";
                do
                {
                    args.Caption = "Ingrese el nombre del Archivo";
                    args.Prompt = "Descripción";
                    args.DefaultButtonIndex = 0;
                    //args.Showing += Args_Showing;
                    // initialize a DateEdit editor with custom settings 
                    TextEdit editor = new TextEdit();
                    args.Editor = editor;
                    // a default DateEdit value 
                    args.DefaultResponse = "Archivo XML";
                    // display an Input Box with the custom editor
                    args.Editor = textEdit;
                    result2 = XtraInputBox.Show(args).ToString();
                } while (result2.Length == 0);
                if (result2 != null)
                {
                    NombreXMLG = result2;
                    RutaXMLG = OpenDialog.FileName;
                    textNombreArchivoXML.Text = result2;
                    //string ar = OpenDialog.FileName;
                    //FileStream fs = new FileStream(ar, FileMode.Open);
                    ////Creamos un array de bytes para almacenar los datos leídos por fs.
                    //Byte[] Archivo = new byte[fs.Length];
                    ////Y guardamos los datos en el array data
                    //fs.Read(Archivo, 0, Convert.ToInt32(fs.Length));
                    //CLS_Activos udp = new CLS_Activos();
                    //udp.Id_Activo = vId_Activo;
                    //udp.Opcion = 1;
                    //udp.NombreArchivoXML = txtNombreArchivoXML.Text;
                    //udp.ArchivoXML = Archivo;
                    //udp.MtdUpdateActivoArchivoXML();
                    //if (udp.Exito)
                    //{
                    //    XtraMessageBox.Show("Se a agregado el PDF con Exito");
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show(udp.Mensaje);
                    //}
                }
                else
                {

                }
            }
        }

        private void btnViewXMLG_Click(object sender, EventArgs e)
        {
            Frm_ViewXMLSalidas frm = new Frm_ViewXMLSalidas();
            frm.Id_Salida = textFolio.Text.Trim();
            frm.Ticket = textTicketG.Text.Trim();
            frm.Ventana = "OtrosGastos";
            frm.ShowDialog();
            frm.Dispose();
            System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewXML.xml");
        }

        private void limpiarSalidasFacturas()
        {
            textImporteF.Text = "0";
            labelIdArchivo.Text = "0";
            txtNombreArchivoPDF.Text = "";
            txtNombreArchivoXML.Text = "";
            RutaPDF = "";
            RutaXML = "";
            NombrePDF = "";
            NombreXML = "";
            ArchivoPDFGlobal = null;
            ArchivoXMLGlobal = null;
            checkPagada.Checked = false;
            dateFactura.EditValue = DateTime.Now;
            dateCobro.EditValue = null;
            rbTotalF.Checked = true;
            txtImporteViaje.Text = "0";

        }

       private void limpiarSalidasCruce()
        {
            txtNombreArchivoPDFC.Text = "";
            txtNombreArchivoXMLC.Text = "";
            labelId_Archivo.Text = "0";
            textImporteC.Text = "0";
            RutaPDFC = "";
            RutaXMLC = "";
            NombrePDFC = "";
            NombreXMLC = "";
            ArchivoPDFGlobalC = null;
            ArchivoXMLGlobalC = null;

           
        }

        private void EliminarSalidasFacturas(string Salida, string Id_Archivo)
        {
            CLS_Salidas_Facturas Clase = new CLS_Salidas_Facturas();
            Clase.Id_Salida = Salida;
            Clase.Id_Archivo = Convert.ToDecimal(Id_Archivo);
            Clase.MtdDeleteSalidasArchivoPDFXML();
            if (Clase.Exito)
            {
                CargarSalidasFacturas();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        

       
    
    }
}