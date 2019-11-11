using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Proveedores : ConexionBase
    {

        public string Id_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string RFC_Proveedor { get; set; }
        public string Telefono { get; set; }
        public int Dias_Credito { get; set; }

        public void MtdSeleccionarProveedores()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Proveedores_Select";

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



        public void MtdInsertarProveedores()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Proveedores_Insert";
                _dato.CadenaTexto = Id_Proveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Proveedor");
                _dato.CadenaTexto = Nombre_Proveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Proveedor");
                _dato.CadenaTexto = RFC_Proveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "RFC_Proveedor");
                _dato.CadenaTexto = Telefono;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono");
                _dato.Entero = Dias_Credito;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Dias_Credito");
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

        public void MtdEliminarProveedores()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Proveedores_Delete";
                _dato.CadenaTexto = Id_Proveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Proveedor");
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
