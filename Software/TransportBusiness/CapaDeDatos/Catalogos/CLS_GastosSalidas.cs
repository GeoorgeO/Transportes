using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_GastosSalidas : ConexionBase
    {

        public string Parametro { get; set; }
        public string F_Del { get; set; }
        public string F_Al { get; set; }
        public string Id_Activo { get; set; }

        public void MtdSeleccionarGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Salidas_G_Select";
                _dato.CadenaTexto = Parametro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Parametro");
                _dato.CadenaTexto = F_Del;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Del");
                _dato.CadenaTexto = F_Al;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Al");
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
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

        public void MtdSeleccionarGastosDet()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Salidas_Select";
                _dato.CadenaTexto = Parametro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Parametro");
                _dato.CadenaTexto = F_Del;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Del");
                _dato.CadenaTexto = F_Al;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "F_Al");
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
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
