using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_HistorialOperadores : ConexionBase
    {

        public string Id_Operador { get; set; }
        public string Id_Activo { get; set; }
        public string Tipo { get; set; }

        public void MtdInsertarHistorialOperadores()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_HistorialOperadores_Insert";
                _dato.CadenaTexto = Id_Operador;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Operador");
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
                _dato.CadenaTexto = Tipo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Tipo");
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
