using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Entradas : ConexionBase
    {

        public string Id_Entrada { get; set; }
        public string Id_Salida { get; set; }
        public string Fecha_Entrada { get; set; }
        public string Fecha_Cruce { get; set; }
        public string Id_Activo_P { get; set; }
        public string Id_Activo_1 { get; set; }
        public string Id_Activo_2 { get; set; }

        public void MtdSeleccionarEntradas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Entradas_Select";
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



        public void MtdInsertarEntradas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Entradas_Insert";
                _dato.CadenaTexto = Id_Entrada;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Entrada");
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.CadenaTexto = Fecha_Entrada;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Entrada");
                _dato.CadenaTexto = Fecha_Cruce;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Cruce");
                _dato.CadenaTexto = Id_Activo_P;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo_P");
                _dato.CadenaTexto = Id_Activo_1;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo_1");
                _dato.CadenaTexto = Id_Activo_2;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo_2");
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

        public void MtdEliminarEntradas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Entradas_Delete";
                _dato.CadenaTexto = Id_Entrada;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Entrada");
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
