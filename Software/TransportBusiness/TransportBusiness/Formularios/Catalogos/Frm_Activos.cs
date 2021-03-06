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
    public partial class Frm_Activos : DevExpress.XtraEditors.XtraForm
    {

        public string IdActivo { get; set; }
        public string Activo { get; set; }
        public Boolean PaSel { get; set; }

        string OperadorAnterior = "", ActivoAnterior = "";

        private static Frm_Activos m_FormDefInstance;
        public static Frm_Activos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Activos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Frm_Activos()
        {
            InitializeComponent();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            Frm_Marcas frm = new Frm_Marcas();
            frm.PaSel = true;
            frm.ShowDialog();

            txtMarca.Text = frm.vNombre_Marca;
            txtMarca.Tag = frm.vid_Marca;
        }

        private void btnTipoTransporte_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Transporte frm = new Frm_Tipo_Transporte();
            frm.PaSel = true;
            frm.ShowDialog();

            txtTipoTransporte.Text = frm.vNombre_Tipo_Transporte;
            txtTipoTransporte.Tag = frm.vId_Tipo_Transporte;
        }

        private void btnTipoActivo_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Activo frm = new Frm_Tipo_Activo();
            frm.PaSel = true;
            frm.ShowDialog();

            txtTipoActivo.Text = frm.vNombre_Tipo_Activo;
            txtTipoActivo.Tag = frm.vId_Tipo_Activo;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Frm_Empresas frm = new Frm_Empresas();
            frm.PaSel = true;
            frm.ShowDialog();
            
            txtEmpresa.Text = frm.vNombre_Empresa;
            txtEmpresa.Tag = frm.vId_Empresa;
        }

        private void btnTipoPlaca_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Placa frm = new Frm_Tipo_Placa();
            frm.PaSel = true;
            frm.ShowDialog();

            txtTipoPlaca.Text = frm.vNombre_Tipo_Placa;
            txtTipoPlaca.Tag = frm.vId_Tipo_Placa;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Frm_Empleados frm = new Frm_Empleados();
            frm.PaSel = true;
            frm.ShowDialog();

            txtOperador.Text = frm.vNombre_Empleado;
            txtOperador.Tag = frm.vId_Empleado;
        }

        private void CargarActivos()
        {
            dtgActivos.DataSource = null;
            CLS_Activos Activos = new CLS_Activos();

            if (checkActivo.Checked)
            {
                Activos.Status = "INACTIVO";
            }
            else
            {
                Activos.Status = "ACTIVO  ";
            }


            Activos.MtdSeleccionarActivos();
            if (Activos.Exito)
            {
                dtgActivos.DataSource = Activos.Datos;
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

        private void iniciarTags()
        {
            txtMarca.Tag = "";
            txtTipoTransporte.Tag = "";
            txtTipoActivo.Tag = "";
            txtEmpresa.Tag = "";
            txtTipoPlaca.Tag = "";
            txtOperador.Tag = "";
            txtEmpresaAsegu.Tag = "";
        }

        private void InsertarActivos()
        {
            CLS_Activos Activos = new CLS_Activos();

            DateTime Fecha, Fecha2;
           
            if (dtFechaAlta.Text.Trim() == String.Empty)
            {
                Activos.Fecha_Alta = "";
            }
            else
            {
                Fecha = Convert.ToDateTime(dtFechaAlta.Text.Trim());
                Activos.Fecha_Alta = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            }
               
            if (txtFechaBaja.Text.Trim() == String.Empty)
            {
                Activos.Fecha_Baja = "";
            }
            else
            {
                Fecha2 = Convert.ToDateTime(txtFechaBaja.Text.Trim());
                Activos.Fecha_Baja = Fecha2.Year.ToString() + DosCero(Fecha2.Month.ToString()) + DosCero(Fecha2.Day.ToString());

               
            }
          
            Activos.Id_Activo = txtIdActivo.Text.Trim();
            Activos.Nombre_Interno = txtNombreActivo.Text.Trim();
            Activos.Descripcion = txtDescripcion.Text.Trim();

            if (txtMarca.Tag.ToString() == String.Empty)
            {
                Activos.Id_Marca = "";
            }
            else
            {
                Activos.Id_Marca = txtMarca.Tag.ToString().Trim();
            }
           
            Activos.Color = txtColor.Text.Trim();
            Activos.Costo_Unidad = Convert.ToDouble(txtCosto.Text.Trim());
            Activos.Modelo = txtModelo.Text.Trim();
            Activos.Serie = txtNoSerie.Text.Trim();
            Activos.Status = txtEstatus.Text.Trim();

            if (txtTipoTransporte.Tag.ToString() == String.Empty)
            {
                Activos.Id_Tipo_Transporte = "";
            }
            else
            {
                Activos.Id_Tipo_Transporte = txtTipoTransporte.Tag.ToString().Trim();
            }
           
            if (txtTipoActivo.Tag.ToString() == String.Empty)
            {
                Activos.Id_Tipo_Activo = "";
            }
            else
            {
                Activos.Id_Tipo_Activo = txtTipoActivo.Tag.ToString().Trim();
            }
            
            if (txtEmpresa.Tag.ToString() == String.Empty)
            {
                Activos.Id_Empresa = "";
            } else
            {
                Activos.Id_Empresa = txtEmpresa.Tag.ToString().Trim();
            }
                
            Activos.Tarjeta_Circulacion = txtTarjetaCirculacion.Text.Trim();
            Activos.Placas = txtPlaca.Text.Trim();

            if (txtTipoPlaca.Tag.ToString() == String.Empty)
            {
                Activos.Id_Tipo_Placa = "";
            }
            else
            {
                Activos.Id_Tipo_Placa = txtTipoPlaca.Tag.ToString().Trim();
            }
            
            if (txtOperador.Tag.ToString() == String.Empty)
            {
                Activos.Id_Empleado = "";
            }
            else
            {
                Activos.Id_Empleado = txtOperador.Tag.ToString().Trim();
            }
           
            Activos.Id_Empresa_Aseguradora = txtEmpresaAsegu.Tag.ToString().Trim();
            Activos.Poliza_Seguro = txtPolizaSeguro.Text.Trim();
            
            if (cboAsignado.Text.Trim().Equals("Si"))
            {
                Activos.Asignado = "1";
            }
            else
            {
                Activos.Asignado = "0";
            }

            Activos.Id_Factura = textFactura.Text.Trim();
            
            Activos.Folio_Tarjeta_Circulacion = textFolioCircula.Text.Trim();

            Activos.Activo_Primario = Convert.ToInt16(radioPrimario.EditValue);
            Activos.MtdInsertarActivos();
            if (Activos.Exito)
            {
                if (OperadorAnterior.Equals(txtOperador.Tag.ToString()))
                {
                    
                }
                else
                {
                    InsertarHistorialOperadores();
                }
                ActualizaActivoPoliza();
                CargarActivos();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Activos.Mensaje);
            }
        }

        private void InsertarHistorialOperadores()
        {
            CLS_HistorialOperadores Clase = new CLS_HistorialOperadores();

            Clase.Id_Operador = txtOperador.Tag.ToString();
            Clase.Id_Activo = txtIdActivo.Text;
            Clase.Tipo = "A";

            Clase.MtdInsertarHistorialOperadores();

            if (Clase.Exito)
            {
                
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarActivos()
        {
            CLS_Activos Activos = new CLS_Activos();
            Activos.Id_Activo = txtIdActivo.Text.Trim();
            Activos.MtdEliminarActivos();
            if (Activos.Exito)
            {
                CargarActivos();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Activos.Mensaje);
            }
        }

        private void ActualizaActivoPoliza()
        {
            CLS_Polizas Polizas = new CLS_Polizas();
            Polizas.Id_Activo = txtIdActivo.Text.Trim();
            Polizas.Poliza_Seguro = txtPolizaSeguro.Text.Trim();
            Polizas.MtdUpdateActivoPoliza();
            if (Polizas.Exito)
            {
              
                //XtraMessageBox.Show("Se ha Eliminado el registro con exito");
               
            }
            else
            {
                XtraMessageBox.Show(Polizas.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            txtIdActivo.Text = "";
            txtNombreActivo.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtCosto.Text = "0";
            txtModelo.Text = "";
            txtNoSerie.Text = "";
            txtEstatus.Text = "ACTIVO";
            txtTipoTransporte.Text = "";
            txtTipoActivo.Text = "";
            txtEmpresa.Text = "";
            txtTarjetaCirculacion.Text = "";
            txtPlaca.Text = "";
            txtTipoPlaca.Text = "";
            txtOperador.Text = "";
            txtEmpresaAsegu.Text = "";
            txtPolizaSeguro.Text = "";
            dtFechaAlta.Text = DateTime.Today.ToShortDateString();
            txtFechaBaja.Text = "";
            textFactura.Text = "";
           
            textFolioCircula.Text = "";
            
            ActivarCampos(true);
            OperadorAnterior = "";
        }
        private void ActivarCampos(Boolean Valor)
        {
            txtIdActivo.Enabled = Valor;
            txtNombreActivo.Enabled = Valor;
            txtDescripcion.Enabled = Valor;
            txtColor.Enabled = Valor;
            txtCosto.Enabled = Valor;
            txtModelo.Enabled = Valor;
            txtNoSerie.Enabled = Valor;
            txtTarjetaCirculacion.Enabled = Valor;
            txtPlaca.Enabled = Valor;
            txtPolizaSeguro.Enabled = Valor;
            dtFechaAlta.Enabled = Valor;
            txtFechaBaja.Enabled = Valor;
            textFactura.Enabled = Valor;
           
            textFolioCircula.Enabled = Valor;
            
            cboAsignado.Enabled = Valor;
            btnTipoTransporte.Enabled = Valor;
            btnTipoActivo.Enabled = Valor;
            btnEmpresa.Enabled = Valor;
            btnTipoPlaca.Enabled = Valor;
            btnOperador.Enabled = Valor; 
            btnMarca.Enabled = Valor;
            btnGuardar.Enabled = Valor;
            btnSeleccionar.Enabled = Valor;
        }
        private void dtgActivos_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.cardView1.GetSelectedRows())
                {
                    DataRow row = this.cardView1.GetDataRow(i);
                   

                    txtIdActivo.Text = row["Id_Activo"].ToString();
                    txtNombreActivo.Text = row["Nombre_Interno"].ToString();
                    txtDescripcion.Text = row["Descripcion"].ToString();
                    txtMarca.Tag = row["Id_Marca"].ToString();
                    txtMarca.Text = row["Nombre_Marca"].ToString();
                    txtColor.Text = row["Color"].ToString();
                    txtCosto.Text = row["Costo_Unidad"].ToString();
                    txtModelo.Text = row["Modelo"].ToString();
                    txtNoSerie.Text = row["Serie"].ToString();
                    txtTipoTransporte.Tag = row["Id_Tipo_Transporte"].ToString();
                    txtTipoTransporte.Text = row["Nombre_Tipo_Transporte"].ToString();
                    txtTipoActivo.Tag = row["Id_Tipo_Activo"].ToString();
                    txtTipoActivo.Text = row["Nombre_Tipo_Activo"].ToString();
                    txtEmpresa.Tag = row["Id_Empresa"].ToString();
                    txtEmpresa.Text = row["Nombre_Empresa"].ToString();
                    txtTarjetaCirculacion.Text = row["Tarjeta_Circulacion"].ToString();
                    txtPlaca.Text = row["Placas"].ToString();
                    txtTipoPlaca.Tag = row["Id_Tipo_Placa"].ToString();
                    txtTipoPlaca.Text = row["Nombre_Tipo_Placa"].ToString();
                    txtOperador.Tag = row["Id_Empleado"].ToString();
                    OperadorAnterior= row["Id_Empleado"].ToString();
                    txtOperador.Text = row["Nombre_Empleado"].ToString();
                    txtEmpresaAsegu.Tag = row["Id_Empresa_Aseguradora"].ToString();
                    txtEmpresaAsegu.Text = row["Nombre_Empresa_Aseguradora"].ToString();
                    txtPolizaSeguro.Text = row["Poliza_Seguro"].ToString();
                    dtFechaAlta.Text = row["Fecha_Alta"].ToString();
                    txtFechaBaja.Text = row["Fecha_Baja"].ToString();
                    if (row["Asignado"].ToString().Equals("1")) {
                        cboAsignado.Text = "Si";
                            }
                    else
                    {
                        cboAsignado.Text = "No";
                    }
                    txtEstatus.Text = row["Status"].ToString();

                    if (row["Status"].ToString().Trim().Equals("ACTIVO"))
                    {
                        btnEliminar.Caption = "Dar de Baja";
                        ActivarCampos(true);
                    }else
                    {
                        btnEliminar.Caption = "Dar de Alta";
                        ActivarCampos(false);
                    }
                    textFactura.Text = row["Id_Factura"].ToString();
                    
                    textFolioCircula.Text = row["Folio_Tarjeta_Circulacion"].ToString();

                    radioPrimario.EditValue = Convert.ToInt16(row["Activo_Primario"]);

                }

               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNombreActivo.Text.ToString().Trim().Length > 0)
            {

                    InsertarActivos();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al Activo.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtIdActivo.Text.Trim().Length > 0)
            {
                EliminarActivos();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Activo.");
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

        private void Frm_Activos_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarActivos();
            iniciarTags();
            dtFechaAlta.Text = DateTime.Today.ToShortDateString();
        }

        private void btnEmpresaAsegu_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFechaBaja_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFechaBaja.Text == String.Empty)
            {

            }else
            {
                DateTime Fecha2;
                Fecha2 = Convert.ToDateTime(txtFechaBaja.Text.Trim());

                if (Fecha2 <= DateTime.Today)
                {
                    txtEstatus.Text = "INACTIVO";
                }else
                {
                    txtEstatus.Text = "ACTIVO";
                }
            }
           
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            if (txtIdActivo.Text != string.Empty)
            {
                Frm_PDFXML_Activos frm = new Frm_PDFXML_Activos();
                frm.vId_Activo = txtIdActivo.Text;
                frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un Activo");
            }
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            if (txtIdActivo.Text != string.Empty)
            {
                Frm_Galeria_Activos frm = new Frm_Galeria_Activos();
                frm.vId_Activo = txtIdActivo.Text;
                frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un Activo");
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtIdActivo.Text != string.Empty )
            {
                IdActivo = txtIdActivo.Text;
                Activo = txtNombreActivo.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado un activo");
            }
        }

        private void checkActivo_CheckedChanged(object sender, EventArgs e)
        {
            CargarActivos();
        }

        private void btnTIAVE_Click(object sender, EventArgs e)
        {
            if (txtIdActivo.Text.Trim().Length > 0)
            {
                Frm_Asigna_Tarjeta_IAVE Clase = new Frm_Asigna_Tarjeta_IAVE();
                Clase.IdActivo = txtIdActivo.Text.Trim();
                Clase.Activo = txtNombreActivo.Text.Trim();
                Clase.ShowDialog();
            }else
            {
                XtraMessageBox.Show("No se ha seleccionado un activo");
            }
        }

        private void btnTCombustible_Click(object sender, EventArgs e)
        {
            if (txtIdActivo.Text.Trim().Length > 0)
            {
                Frm_Asigna_Tarjeta_Combustible Clase = new Frm_Asigna_Tarjeta_Combustible();
                Clase.IdActivo = txtIdActivo.Text.Trim();
                Clase.Activo = txtNombreActivo.Text.Trim();
                Clase.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado un activo");
            }
        }

        private void dtgActivos_DoubleClick(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                if (txtIdActivo.Text != string.Empty)
                {
                    IdActivo = txtIdActivo.Text;
                    Activo = txtNombreActivo.Text;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("No se ha seleccionado un activo");
                }
            }
        }

        private void btnBusqPoliza_Click(object sender, EventArgs e)
        {
            Frm_Polizas frm = new Frm_Polizas();
            frm.PaSel = true;
            frm.ShowDialog();
            
            txtPolizaSeguro.Text = frm.IdPoliza;
            txtEmpresaAsegu.Tag = frm.IdAseguradora;
            txtEmpresaAsegu.Text = frm.Aseguradora;
        }
    }
}