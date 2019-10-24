using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    class CLS_Agente_Empresa_Aseguradora : ConexionBase
    {

        public string Id_Agente_Empresa_Aseguradora { get; set; }
        public string Nombre_Agente_Empresa_Aseguradora { get; set; }
        public string Telefono { get; set; }
        public string Id_Empresa_Aseguradora { get; set; }

        public void MtdSeleccionarAgenteEmpresaAseguradora()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Agente_Empresa_Aseguradora_Select";

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



        public void MtdInsertarAgenteEmpresaAseguradora()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Agente_Empresa_Aseguradora_Insert";
                _dato.CadenaTexto = Id_Agente_Empresa_Aseguradora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Agente_Empresa_Aseguradora");
                _dato.CadenaTexto = Nombre_Agente_Empresa_Aseguradora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Agente_Empresa_Aseguradora");
                _dato.CadenaTexto = Telefono;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono");
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

        public void MtdEliminarAgenteEmpresaAseguradora()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Agente_Empresa_Aseguradora_Delete";
                _dato.CadenaTexto = Id_Agente_Empresa_Aseguradora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Agente_Empresa_Aseguradora");
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
