using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Rutas : ConexionBase
    {

        public string Id_Rutas { get; set; }
        public string Nombre_Rutas { get; set; }
        public double Kilometros { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }


        public void MtdSeleccionarRutas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rutas_Select";

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



        public void MtdInsertarRutas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rutas_Insert";
                _dato.CadenaTexto = Id_Rutas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Rutas");
                _dato.CadenaTexto = Nombre_Rutas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Ruta");
                _dato.DecimalValor = Convert.ToDecimal( Kilometros);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Kilometros");
                _dato.CadenaTexto = Origen;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Origen");
                _dato.CadenaTexto = Destino;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Destino");
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

        public void MtdEliminarRutas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Rutas_Delete";
                _dato.CadenaTexto = Id_Rutas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Rutas");
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
