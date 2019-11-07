using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Contacto_Emergencia : ConexionBase
    {

        public string Id_Contacto { get; set; }
        public string Nombre_Contacto { get; set; }
        public string Telefono { get; set; }
        public string Id_Empleado { get; set; }
        public string Calle { get; set; }
        public string NoInterior { get; set; }
        public string NoExterior { get; set; }
        public string Colonia { get; set; }
        public string Codigo_Postal { get; set; }
        public string Id_Estado { get; set; }
        public string Id_TipoDomicilio { get; set; }

    public void MtdSeleccionarContacto()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Contacto_Emergencia_Select";
                _dato.CadenaTexto = Id_Empleado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empleado");
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



        public void MtdInsertarContacto()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Contacto_Emergencia_Insert";
                _dato.CadenaTexto = Id_Contacto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Contacto");
                _dato.CadenaTexto = Nombre_Contacto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Contacto");
                _dato.CadenaTexto = Telefono;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono");
                _dato.CadenaTexto = Id_Empleado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empleado");
                _dato.CadenaTexto = Calle;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Calle");
                _dato.CadenaTexto = NoInterior;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NoInterior");
                _dato.CadenaTexto = NoExterior;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NoExterior");
                _dato.CadenaTexto = Colonia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Colonia");
                _dato.CadenaTexto = Codigo_Postal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Codigo_Postal");
                _dato.CadenaTexto = Id_Estado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Estado");
                _dato.CadenaTexto = Id_TipoDomicilio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_TipoDomicilio");
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

        public void MtdEliminarContacto()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Contacto_Emergencia_Delete";
                _dato.CadenaTexto = Id_Contacto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Contacto");
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

        public void MtdEliminarContactoPersona()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Contacto_Emergencia_Delete";
                _dato.CadenaTexto = Id_Empleado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empleado");
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
