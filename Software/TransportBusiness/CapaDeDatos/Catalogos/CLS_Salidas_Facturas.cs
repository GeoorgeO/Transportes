using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Salidas_Facturas : ConexionBase
    {
        public string Id_Salida { get; set; }
        public byte[] FacturaPDF { get; set; }
        public string FacturaPDFNombre { get; set; }
        public byte[] FacturaXML { get; set; }
        public string FacturaXMLNombre { get; set; }
        public decimal Importe { get; set; }
        public decimal Id_Archivo { get; set; }
        public string Moneda { get; set; }
        public string Diferido { get; set; }
        public string Fecha_Factura { get; set; }
        public string Fecha_Pago { get; set; }
        public string Fecha_Cobro { get; set; }
        public decimal Importe_Viaje { get; set; }

        public void MtdSeleccionarSalidasArchivoPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Faturas_PDFXML_Select";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexionR.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }

        public void MtdSeleccionarSalidasArchivoPDFXMLView()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Faturas_PDFXML_View_Select";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.DecimalValor = Id_Archivo;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Id_Archivo");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexionR.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }

        public void MtdInsertarSalidasArchivoPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Faturas_PDFXML_Insert";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.ArchivoValor = FacturaPDF;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "FacturaPDF");
                _dato.CadenaTexto = FacturaPDFNombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FacturaPDFNombre");
                _dato.ArchivoValor = FacturaXML;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "FacturaXML");
                _dato.CadenaTexto = FacturaXMLNombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FacturaXMLNombre");
                _dato.DecimalValor = Importe;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Importe");
                _dato.DecimalValor = Id_Archivo;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Id_Archivo");
                _dato.CadenaTexto = Moneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
                _dato.CadenaTexto = Diferido;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Diferido");
                _dato.CadenaTexto = Fecha_Factura;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Factura");
                _dato.CadenaTexto = Fecha_Cobro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Cobro");
                _dato.CadenaTexto = Fecha_Pago;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Pago");
                _dato.DecimalValor = Importe_Viaje;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Importe_Viaje");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexionR.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }
        
        public void MtdDeleteSalidasArchivoPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Facturas_PDFXML_Delete";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.DecimalValor = Id_Archivo;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Id_Archivo");
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
