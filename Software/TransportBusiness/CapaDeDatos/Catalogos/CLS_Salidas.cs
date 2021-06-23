using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Salidas : ConexionBase
    {

        public string Id_Salida { get; set; }
        public string Fecha_Salida { get; set; }
        public string Id_Activo_Principal { get; set; }
        public string Id_Operador { get; set; }
        public string Id_Ayudante { get; set; }
        public string Id_Activo_Secundario { get; set; }
        public string Id_Activo_Adicional { get; set; }
        public string Id_Ruta { get; set; }
        public string Id_MotivoSalida { get; set; }
        public string Id_Cliente { get; set; }
        public decimal km_Inicio { get; set; }
        public decimal km_Fin { get; set; }
        public decimal Dias_Viaje { get; set; }
        public decimal Lts_Km { get; set; }
        public string Id_Huerta { get; set; }
        public string Observaciones { get; set; }
        public string EnRuta { get; set; }
        public int filtro { get; set; }
        public string Usuario { get; set; }

        public void MtdSeleccionarSalida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Select";
                _dato.Entero = filtro;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "filtro");
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



        public void MtdInsertarSalidas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Insert";
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.CadenaTexto = Fecha_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Salida");
                _dato.CadenaTexto = Id_Activo_Principal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo_Principal");
                _dato.CadenaTexto = Id_Operador;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Operador");
                _dato.CadenaTexto = Id_Ayudante;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Ayudante");
                _dato.CadenaTexto = Id_Activo_Secundario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo_Secundario");
                _dato.CadenaTexto = Id_Activo_Adicional;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo_Adicional");
                _dato.CadenaTexto = Id_Ruta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Ruta");
                _dato.CadenaTexto = Id_MotivoSalida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_MotivoSalida");
                _dato.CadenaTexto = Id_Cliente;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Cliente");
                _dato.DecimalValor = km_Inicio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "km_Inicio");
                _dato.DecimalValor = km_Fin;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "km_Fin");
                _dato.DecimalValor = Dias_Viaje;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Dias_Viaje");
                _dato.DecimalValor = Lts_Km;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Lts_Km");
                _dato.CadenaTexto = Id_Huerta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Huerta");
                _dato.CadenaTexto = Observaciones;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Observaciones");
                _dato.CadenaTexto = EnRuta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "EnRuta");
                _dato.CadenaTexto = Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Usuario");
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
