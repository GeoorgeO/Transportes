using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Rpt_SalidasG : ConexionBase
    {
        public string Anio { get; set; }
	    public string Id_Empresa { get; set; }
        public string Moneda { get; set; }
        public string Cuentas { get; set; }


        public void MtdNSalidasxMes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rpt_NumeroSalidasxMes_Select";
                _dato.CadenaTexto = Anio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Anio");
                _dato.CadenaTexto = Id_Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa");
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

        public void MtdGastosDirectosxMes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rpt_GastosDirectosxMes_Select";
                _dato.CadenaTexto = Anio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Anio");
                _dato.CadenaTexto = Id_Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa");
                _dato.CadenaTexto = Moneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
                _dato.CadenaTexto = Cuentas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Cuentas");
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

        public void MtdSeleccionarGastosCuentasxMes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Cuentas_xMes_Select";

                _dato.CadenaTexto = Anio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Anio");
                _dato.CadenaTexto = Id_Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa");
                _dato.CadenaTexto = Cuentas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Cuentas");
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

        public void MtdGastosIndirectosxMes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rpt_GastosIndirectosxMes_Select";

                _dato.CadenaTexto = Anio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Anio");
                _dato.CadenaTexto = Id_Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa");
                _dato.CadenaTexto = Cuentas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Cuentas");
                _dato.CadenaTexto = Moneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
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

        public void MtdFacturasxMes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rpt_FacturasxMes_Select";

                _dato.CadenaTexto = Anio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Anio");
                _dato.CadenaTexto = Id_Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa");
                _dato.CadenaTexto = Cuentas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Cuentas");
                _dato.CadenaTexto = Moneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
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

        public void MtdUtilidadxMes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rpt_UtilidadxMes_Select";

                _dato.CadenaTexto = Anio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Anio");
                _dato.CadenaTexto = Id_Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa");
                _dato.CadenaTexto = Cuentas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Cuentas");
                _dato.CadenaTexto = Moneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
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
