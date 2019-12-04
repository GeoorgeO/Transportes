using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeDatos
{
    public class CLS_Servicios: ConexionBase
    {

        public string Folio { get; set; }
        public string Id_Activo { get; set; }
        public string Id_TipoServicio { get; set; }
        public string PrecioTotal { get; set; }
        public string Kilometraje { get; set; }
        public string FechaServicio { get; set; }
        public string Id_Proveedor { get; set; }
        public string Id_Factura { get; set; }
        public string Comprador { get; set; }
        public string Observaciones { get; set; }

        public void MtdSeleccionarServicios()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Servicios_Select";

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



        public void MtdInsertarServicios()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Servicios_Insert";
                _dato.CadenaTexto = Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio");
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
                _dato.CadenaTexto = Id_TipoServicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_TipoServicio");
                _dato.CadenaTexto = PrecioTotal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "PrecioTotal");
                _dato.CadenaTexto = Kilometraje;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Kilometraje");
                _dato.CadenaTexto = FechaServicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaServicio");
                _dato.CadenaTexto = Id_Proveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Proveedor");
                _dato.CadenaTexto = Id_Factura;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Factura");
                _dato.CadenaTexto = Comprador;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Comprador");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
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

        public void MtdEliminarServicios()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Pais_Delete";
                _dato.CadenaTexto = Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio");
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
