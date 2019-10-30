using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Clientes: ConexionBase
    {

        public string Id_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string RFC_Cliente { get; set; }
        public string Telefono { get; set; }

        public void MtdSeleccionarClientes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Clientes_Select";

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



        public void MtdInsertarClientes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Clientes_Insert";
                _dato.CadenaTexto = Id_Cliente;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Cliente");
                _dato.CadenaTexto = Nombre_Cliente;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Cliente");
                _dato.CadenaTexto = RFC_Cliente;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "RFC_Cliente");
                _dato.CadenaTexto = Telefono;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono");
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

        public void MtdEliminarClientes()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Clientes_Delete";
                _dato.CadenaTexto = Id_Cliente;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Cliente");
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
