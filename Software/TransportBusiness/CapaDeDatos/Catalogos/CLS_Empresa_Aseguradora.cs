using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Empresa_Aseguradora : ConexionBase
    {
        public string Id_Empresa_Aseguradora { get; set; }
        public string Nombre_Empresa_Aseguradora { get; set; }
        public string Telefono { get; set; }
        public string Telefono_Siniestros { get; set; }

        public void MtdSeleccionarEmpresaAseguradora()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Empresa_Aseguradora_Select";

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



        public void MtdInsertarEmpresaAseguradora()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Empresa_Aseguradora_Insert";
                _dato.CadenaTexto = Id_Empresa_Aseguradora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa_Aseguradora");
                _dato.CadenaTexto = Nombre_Empresa_Aseguradora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Empresa_Aseguradora");
                _dato.CadenaTexto = Telefono;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono");
                _dato.CadenaTexto = Telefono_Siniestros;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono_Siniestros");
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

        public void MtdEliminarEmpresaAseguradora()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Empresa_Aseguradora_Delete";
                _dato.CadenaTexto = Id_Empresa_Aseguradora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa_Aseguradora");
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
