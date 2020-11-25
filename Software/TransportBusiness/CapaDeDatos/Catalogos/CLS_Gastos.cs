using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Gastos : ConexionBase
    {
        public string Fecha_Gasto { get; set; }
        public string Id_GastoIndirecto { get; set; }
        public decimal Importe { get; set; }
        public decimal Tipo_Cambio { get; set; }
        public string Factura { get; set; }
        public string Concepto { get; set; }
        public string Id_Cuenta { get; set; }
        public string Referencia { get; set; }
        public int Poliza { get; set; }
        public string Moneda { get; set; }
        public string TipoPoliza { get; set; }


        public void MtdSeleccionarGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Select";
                _dato.CadenaTexto = Fecha_Gasto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Gasto");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdSeleccionarTCxFecha()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_TipoCambio_x_Fecha_Select";
                _dato.CadenaTexto = Fecha_Gasto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdSeleccionarIdGasto()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Id_Gasto_Select";
                _dato.CadenaTexto = Fecha_Gasto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Gasto");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdInsertarGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Insert";
                _dato.CadenaTexto = Fecha_Gasto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Gasto");
                _dato.CadenaTexto = Id_GastoIndirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_GastoIndirecto");
                _dato.DecimalValor = Importe;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Importe");
                _dato.DecimalValor = Tipo_Cambio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Tipo_Cambio");
                _dato.CadenaTexto = Factura;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Factura");
                _dato.CadenaTexto = Concepto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Concepto");
                _dato.CadenaTexto = Id_Cuenta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Cuenta");
                _dato.CadenaTexto = Referencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Referencia");
                _dato.EnteroLargo = Poliza;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Poliza");
                _dato.CadenaTexto = Moneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
                _dato.CadenaTexto = TipoPoliza;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "TipoPoliza");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdEliminarGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Delete";
                _dato.EnteroLargo = Poliza;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Poliza");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

    }
}
