using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Tipo_Empleado : ConexionBase
    {

        public string Id_Tipo_Placa { get; set; }
        public string Nombre_Tipo_Placa { get; set; }

        public void MtdSeleccionarTiposEmpleados()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tipos_Placas_Select";

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

        public void MtdSeleccionarTipoEmpleado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tipo_Empleado_Select";
                _dato.CadenaTexto = Id_Tipo_Placa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empleado_Placa");

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

        public void MtdInsertarTipoEmpleado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tipo_Empleado_Insert";
                _dato.CadenaTexto = Id_Tipo_Placa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tipo_Empleado");
                _dato.CadenaTexto = Nombre_Tipo_Placa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Tipo_Empleado");
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

        public void MtdEliminarTipoEmpleado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tipo_Empleado_Delete";
                _dato.CadenaTexto = Id_Tipo_Placa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tipo_Empleado");
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
