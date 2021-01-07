using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Gastos_Contpaq : ConexionBase
    {
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Cuentas { get; set; }

        public void MtdSeleccionarGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexionC);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Contpaq_Select";
                _dato.CadenaTexto = FechaInicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaInicio");
                _dato.CadenaTexto = FechaFin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaFin");
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

        public void MtdSeleccionarCtasNoConsidera()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_CtasNoConsideradas_Select";
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
