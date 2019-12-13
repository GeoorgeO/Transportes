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
    public partial class Frm_Salidas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Salidas()
        {
            InitializeComponent();
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
            Clase.Id_MotivoSalida = "011";// cboMotivoSalida.EditValue.ToString();
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
            cboMotivoSalida.EditValue = "011";
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
                    //if (cboMotivoSalida.EditValue!=null)
                    //{
                        if (textCliente.Tag.ToString().Trim().Length >0)
                        {
                           InsertarSalidas();
                        }
                        else
                        {
                            XtraMessageBox.Show("Es necesario seleccionar un cliente");
                        }
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show("Es necesario seleccionar un motivo de salida");
                    //}
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
        }
    }
}