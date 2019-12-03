using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Rutas_Detalle : ConexionBase
    {

        public string Id_Rutas { get; set; }
        public string Nombre_Rutas_Detalle { get; set; }
        public string Secuencia { get; set; }


        public void MtdSeleccionarRutasDetalle()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rutas_Detalle_Select";
                _dato.CadenaTexto = Id_Rutas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Rutas");
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



        public void MtdInsertarRutasDetalle()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rutas_Detalle_Insert";
                _dato.CadenaTexto = Id_Rutas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Rutas");
                _dato.CadenaTexto = Nombre_Rutas_Detalle;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Rutas_Detalle");
                _dato.CadenaTexto = Secuencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Secuencia");
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

        public void MtdEliminarRutasDetalle()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rutas_Detalle_Delete";
                _dato.CadenaTexto = Id_Rutas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Rutas");
                _dato.CadenaTexto = Secuencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Secuencia");
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

        public void MtdEliminarRutasDetalleALL()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rutas_DetalleAll_Delete";
                _dato.CadenaTexto = Id_Rutas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Rutas");
              
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
