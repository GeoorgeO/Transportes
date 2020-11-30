using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Cuentas_contables : ConexionBase
    {
       public string Id_cuenta { get; set; }
        public string Id_cuenta_padre { get; set; }
        public string Nombre_cuenta { get; set; }
        public string Id_tipocuenta { get; set; }
        public string Naturaleza { get; set; }
        public string Nivel { get; set; }
        public int Activa { get; set; }
        public int Considera { get; set; }

        public void MtdSeleccionarCtas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Cuentas_Contables_Select";
                _dato.Entero = Activa;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Activa");
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

        public void MtdSeleccionarPadre()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Cuentas_Padre_Select";
                _dato.CadenaTexto = Id_cuenta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_cuenta");
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

        public void MtdInsertarCtas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Cuentas_Contables_Insert";
                _dato.CadenaTexto = Id_cuenta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_cuenta");
                _dato.CadenaTexto = Id_cuenta_padre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_cuenta_padre");
                _dato.CadenaTexto = Nombre_cuenta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_cuenta");
                _dato.CadenaTexto = Id_tipocuenta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_tipocuenta");
                _dato.CadenaTexto = Naturaleza;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Naturaleza");
                _dato.Entero = Activa;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Activa");
                _dato.Entero = Considera;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Considera");
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

        public void MtdEliminarCtas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Cuentas_Contables_Delete";
                _dato.CadenaTexto = Id_cuenta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_cuenta");
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

        public void MtdUpdateCtasNivel()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Ctas_Nivel_Update";
                
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
