using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_TiposServicio : ConexionBase
    {

        public string Id_TipoServicio { get; set; }
        public string Nombre_TipoServicio { get; set; }
        public string Abreviatura { get; set; }

        public void MtdSeleccionarTiposServicio()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_TiposServicio_Select";

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

      

        public void MtdInsertarTiposServicio()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_TiposServicio_Insert";
                _dato.CadenaTexto = Id_TipoServicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_TipoServicio");
                _dato.CadenaTexto = Nombre_TipoServicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_TipoServicio");
                _dato.CadenaTexto = Abreviatura;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Abreviatura");
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

        public void MtdEliminarTiposServicio()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_TiposServicio_Delete";
                _dato.CadenaTexto = Id_TipoServicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_TipoServicio");
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
