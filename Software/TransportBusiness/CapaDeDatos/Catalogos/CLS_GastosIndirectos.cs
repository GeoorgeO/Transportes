using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_GastosIndirectos : ConexionBase
    {

        public string Id_GastoIndirecto { get; set; }
        public string Nombre_GastoIndirecto { get; set; }

        public void MtdSeleccionarGastosIndirectos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_GastosIndirectos_Select";

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

        public void MtdInsertarGastosIndirectos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_GastosIndirectos_Insert";
                _dato.CadenaTexto = Id_GastoIndirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_GastoIndirecto");
                _dato.CadenaTexto = Nombre_GastoIndirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_GastoIndirecto");
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

        public void MtdEliminarGastosIndirectos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_GastosIndirectos_Delete";
                _dato.CadenaTexto = Id_GastoIndirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_GastoIndirecto");
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
