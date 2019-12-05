using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_ServiciosDetalle : ConexionBase
    {

        public string Folio { get; set; }
        public string Nombre_ServicioDetalle { get; set; }
        public int Secuencia { get; set; }
        public double Costo { get; set; }
        public double Piezas { get; set; }
        public double Total { get; set; }

        public void MtdSeleccionarServiciosDetalle()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ServiciosDetalle_Select";
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



        public void MtdInsertarServiciosDetalle()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ServiciosDetalle_Insert";
                _dato.CadenaTexto = Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio");
                _dato.CadenaTexto = Nombre_ServicioDetalle;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_ServicioDetalle");
                _dato.Entero = Secuencia;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Secuencia");
                _dato.DecimalValor = Convert.ToDecimal(Costo);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Costo");
                _dato.DecimalValor = Convert.ToDecimal(Piezas);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Piezas");
                _dato.DecimalValor = Convert.ToDecimal(Total);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
                
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

        public void MtdEliminarServiciosDetalle()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ServiciosDetalle_Delete";
                _dato.CadenaTexto = Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio");
                _dato.Entero = Secuencia;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Secuencia");
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

        public void MtdEliminarServiciosDetalleALL()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ServiciosDetalleALL_Delete";
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
