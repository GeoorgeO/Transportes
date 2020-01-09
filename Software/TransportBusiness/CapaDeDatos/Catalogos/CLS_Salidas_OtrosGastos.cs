using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Salidas_OtrosGastos : ConexionBase
    {
        public string Ticket { get; set; }
        public string Id_Salida { get; set; }
        public decimal Importe { get; set; }
        public string Id_GastoDirecto { get; set; }
        public string PagoOperador { get; set; }
        public string Otros_Gastos { get; set; }
        public byte[] FacturaPDF { get; set; }
        public string FacturaPDFNombre { get; set; }
        public byte[] FacturaXML { get; set; }
        public string FacturaXMLNombre { get; set; }
        public string Moneda { get; set; }

        public void MtdSeleccionarSalidas_OtrosGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_OtrosGastos_Select";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
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



        public void MtdInsertarSalidas_OtrosGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_OtrosGastos_Insert";
                _dato.CadenaTexto = Ticket;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Ticket");
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.DecimalValor = Importe;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Importe");
                _dato.CadenaTexto = Id_GastoDirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_GastoDirecto");
                _dato.CadenaTexto = PagoOperador;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "PagoOperador");
                _dato.ArchivoValor = FacturaPDF;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "FacturaPDF");
                _dato.CadenaTexto = FacturaPDFNombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FacturaPDFNombre");
                _dato.ArchivoValor = FacturaXML;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "FacturaXML");
                _dato.CadenaTexto = FacturaXMLNombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FacturaXMLNombre");
                _dato.CadenaTexto = Moneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
                _dato.CadenaTexto = Otros_Gastos;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Otros_Gastos");
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

        public void MtdEliminarSalidas_OtrosGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_OtrosGastos_Delete";
                _dato.CadenaTexto = Ticket;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Ticket");
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
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
