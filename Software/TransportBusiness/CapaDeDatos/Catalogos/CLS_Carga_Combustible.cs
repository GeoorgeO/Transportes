using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Carga_Combustible : ConexionBase
    {

        public string Folio { get; set; }
        public string FechaCarga { get; set; }
        public double Kilometraje { get; set; }
        public double Litros { get; set; }
        public double PrecioLitro { get; set; }
        public double PrecioTotal { get; set; }
        public string Id_Activo { get; set; }
        public string Id_Proveedor { get; set; }
        public string Id_Factura { get; set; }
        public string Comprador { get; set; }
        public string Observaciones { get; set; }
        public string Id_Salida { get; set; }
        public string Ticket { get; set; }

        public void MtdSeleccionarCarga_Combustible()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Carga_Combustible_Select";

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

        public void MtdSeleccionarCombustibleSalida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Combustible_Salida_Select";
                _dato.CadenaTexto = FechaCarga;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
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

        public void MtdInsertarCarga_Combustible()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Carga_Combustible_Insert";
                _dato.CadenaTexto = Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio");
                _dato.CadenaTexto = FechaCarga;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaCarga");
                _dato.DecimalValor = Convert.ToDecimal(Kilometraje);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Kilometraje");
                _dato.DecimalValor = Convert.ToDecimal(Litros);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Litros");
                _dato.DecimalValor = Convert.ToDecimal(PrecioLitro);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioLitro");
                _dato.DecimalValor = Convert.ToDecimal(PrecioTotal);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioTotal");
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
                _dato.CadenaTexto = Id_Proveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Proveedor");
                _dato.CadenaTexto = Id_Factura;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Factura");
                _dato.CadenaTexto = Comprador;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Comprador");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.CadenaTexto = Ticket;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Ticket");
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

        public void MtdEliminarCarga_Combustible()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Carga_Combustible_Delete";
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

        public void MtdEliminarCarga_Combustible_New()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Carga_Combustible_Delete_New";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.CadenaTexto = Ticket;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Ticket");
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
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
