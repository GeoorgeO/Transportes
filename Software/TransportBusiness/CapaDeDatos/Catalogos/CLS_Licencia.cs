using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Licencia : ConexionBase
    {

        public string Id_Licencia { get; set; }
        public string Id_Tipo_Licencia { get; set; }
        public string Vigencia { get; set; }
        public string No_Licencia { get; set; }

        public void MtdSeleccionarLicencia()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Licencia_Select";

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



        public void MtdInsertarLicencia()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Licencia_Insert";
                _dato.CadenaTexto = Id_Licencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Licencia");
                _dato.CadenaTexto = Id_Tipo_Licencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tipo_Licencia");
                _dato.CadenaTexto = Vigencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Vigencia");
                _dato.CadenaTexto = No_Licencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "No_Licencia");
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

        public void MtdEliminarLicencia()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Licencia_Delete";
                _dato.CadenaTexto = Id_Licencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Licencia");
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
