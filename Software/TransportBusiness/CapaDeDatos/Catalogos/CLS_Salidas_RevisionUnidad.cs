using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Salidas_RevisionUnidad : ConexionBase
    {
        public string AceiteMotor { get; set; }
        public string Id_Salida { get; set; }
        public string LiqDireccionHidraulica { get; set; }
        public string Anticongelante { get; set; }
        public string TCirculacion { get; set; }
        public string TCombustible { get; set; }
        public string TLicencia { get; set; }
        public string LimpiezaInterior { get; set; }
        public string PresionLlantas { get; set; }
        public string Luces { get; set; }
        public string CajaCampo { get; set; }
        public decimal Combustible { get; set; }

        public void MtdSeleccionarSalidas_RevisionUnidad()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_RevisionUnidad_Select";
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



        public void MtdInsertarSalidas_RevisionUnidad()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_RevisionUnidad_Insert";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.CadenaTexto = AceiteMotor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "AceiteMotor");
                _dato.CadenaTexto = LiqDireccionHidraulica;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "LiqDireccionHidraulica");
                _dato.CadenaTexto = Anticongelante;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Anticongelante");
                _dato.CadenaTexto = TCirculacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "TCirculacion");
                _dato.CadenaTexto = TCombustible;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "TCombustible");
                _dato.CadenaTexto = TLicencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "TLicencia");
                _dato.CadenaTexto = LimpiezaInterior;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "LimpiezaInterior");
                _dato.CadenaTexto = PresionLlantas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "PresionLlantas");
                _dato.CadenaTexto = Luces;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Luces");
                _dato.CadenaTexto = CajaCampo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "CajaCampo");
                _dato.DecimalValor = Combustible;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Combustible");
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
