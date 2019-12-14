﻿using System;
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
    public partial class Frm_Salidas : DevExpress.XtraEditors.XtraForm
    {
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

            Clase.MtdInsertarSalidas();

            if (Clase.Exito)
            {
                //CargarCiudad();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                textFolio.Text = Clase.Datos.Rows[0][0].ToString();
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
        }

        private void btnBusqSalida_Click(object sender, EventArgs e)
        {
            Frm_BusqSalidas frm = new Frm_BusqSalidas();

            frm.ShowDialog();
            textFolio.Text= frm.vId_Salida;
            dtFechaSalida.EditValue=Convert.ToDateTime(frm.vFecha_Salida);
            textActivoPrincipal.Tag=frm.vId_Activo_Principal;
            textActivoPrincipal.Text=frm.vNombre_Activo_Principal;
            textOperador.Tag=frm.vId_Operador;
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
            textTicket.Focus();
        }

        private void btnSalidaDiesel_Click(object sender, EventArgs e)
        {
            if (textTicket.Text.ToString().Trim().Length > 0)
            {
                if (Convert.ToDecimal(textImporte.Text)>0)
                {
                    InsertarSalidasDiesel();
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
            Clase.Id_GastoDirecto = textGastos.Tag.ToString();
            if (checkPagadoOperador.Checked)
            {
                Clase.PagoOperador = "1";
            }
            else
            {
                Clase.PagoOperador = "0";
            }
            
            Clase.MtdInsertarSalidas_OtrosGastos();

            if (Clase.Exito)
            {
                CargarSalidasOtrosGastos();
                InsertarSalidasHonorarioPagoOperador();
                limpiarSalidasOtrosGastos();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");

            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
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
                    InsertarSalidasOtrosGastos();
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
    }
}