using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Salidas_Viaticos : ConexionBase
    {

        public string Id_Viatico { get; set; }
        public string Id_Salida { get; set; }
        public decimal Importe { get; set; }
        public string PagadoPor { get; set; }
        public string FechaPago { get; set; }

        public void MtdSeleccionarSalidas_Viaticos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Viaticos_Select";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
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



        public void MtdInsertarSalidas_Viaticos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Viaticos_Insert";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.DecimalValor = Importe;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Importe");
                _dato.CadenaTexto = PagadoPor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "PagadoPor");
                _dato.CadenaTexto = FechaPago;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaPago");
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

        public void MtdEliminarSalidas_Viaticos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Viaticos_Delete";
                _dato.CadenaTexto = Id_Viatico;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Viatico");
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
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
