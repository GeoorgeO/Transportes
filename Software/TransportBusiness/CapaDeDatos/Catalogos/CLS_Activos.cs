using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Activos : ConexionBase
    {

        public string Id_Activo { get; set; }
        public string Nombre_Interno { get; set; }
        public double Costo_Unidad { get; set; }
        public string Fecha_Alta { get; set; }
        public string Fecha_Baja { get; set; }
        public string Serie { get; set; }
        public string Tarjeta_Circulacion { get; set; }
        public string Placas { get; set; }
        public string Id_Tipo_Placa { get; set; }
        public string Id_Tipo_Activo { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public string Id_Marca { get; set; }
        public string Descripcion { get; set; }
        public string Id_Tipo_Transporte { get; set; }
        public string Poliza_Seguro { get; set; }
        public string Id_Empresa_Aseguradora { get; set; }
        public string Status { get; set; }
        public string Asignado { get; set; }
        public string Id_Empleado { get; set; }
        public string Id_Empresa { get; set; }

        public void MtdSeleccionarActivos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Activos_Select";

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



        public void MtdInsertarActivos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Activos_Insert";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
                _dato.CadenaTexto = Nombre_Interno;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_Interno");
                _dato.DecimalValor =  Convert.ToDecimal(Costo_Unidad);
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Costo_Unidad");
                _dato.CadenaTexto = Fecha_Alta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Alta");
                _dato.CadenaTexto = Fecha_Baja;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Baja");
                _dato.CadenaTexto = Serie;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Serie");
                _dato.CadenaTexto = Tarjeta_Circulacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Tarjeta_Circulacion");
                _dato.CadenaTexto = Placas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Placas");
                _dato.CadenaTexto = Id_Tipo_Placa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tipo_Placa ");
                _dato.CadenaTexto = Id_Tipo_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tipo_Activo");
                _dato.CadenaTexto = Color;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Color");
                _dato.CadenaTexto = Modelo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Modelo");
                _dato.CadenaTexto = Id_Marca;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Marca");
                _dato.CadenaTexto = Descripcion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Descripcion");
                _dato.CadenaTexto = Id_Tipo_Transporte;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tipo_Transporte");
                _dato.CadenaTexto = Poliza_Seguro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Poliza_Seguro");
                _dato.CadenaTexto = Id_Empresa_Aseguradora;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa_Aseguradora");
                _dato.CadenaTexto = Status;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Status");
                _dato.CadenaTexto = Asignado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Asignado");
                _dato.CadenaTexto = Id_Empleado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empleado");
                _dato.CadenaTexto = Id_Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa");
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

        public void MtdEliminarActivos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Activos_Delete";
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
