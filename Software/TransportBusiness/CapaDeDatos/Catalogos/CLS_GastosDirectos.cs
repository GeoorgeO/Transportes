using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_GastosDirectos : ConexionBase
    {

        public string Id_GastoDirecto { get; set; }
        public string Nombre_GastoDirecto { get; set; }

        public void MtdSeleccionarGastosDirectos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_GastosDirectos_Select";

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

        public void MtdInsertarGastosDirectos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_GastosDirectos_Insert";
                _dato.CadenaTexto = Id_GastoDirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_GastoDirecto");
                _dato.CadenaTexto = Nombre_GastoDirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_GastoDirecto");
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

        public void MtdEliminarGastosDirectos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_GastosDirectos_Delete";
                _dato.CadenaTexto = Id_GastoDirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_GastoDirecto");
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
