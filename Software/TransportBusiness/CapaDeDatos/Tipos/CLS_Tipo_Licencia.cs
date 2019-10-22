using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Tipo_Licencia : ConexionBase
    {

        public string Id_Tipo_Licencia { get; set; }
        public string Nombre_Tipo_Licencia { get; set; }

        public void MtdSeleccionarTipoLicencia()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tipo_Licencia_Select";

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



        public void MtdInsertarTipoLicencia()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tipo_Licencia_Insert";
                _dato.CadenaTexto = Id_Tipo_Licencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tipo_Licencia");
                _dato.CadenaTexto = Nombre_Tipo_Licencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Tipo_Licencia");
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

        public void MtdEliminarTipoLicencia()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tipo_Licencia_Delete";
                _dato.CadenaTexto = Id_Tipo_Licencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tipo_Licencia");
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
