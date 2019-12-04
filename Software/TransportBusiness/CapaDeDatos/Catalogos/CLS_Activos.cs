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
        public string Id_Factura { get; set; }
        public string IAVE { get; set; }
        public string Folio_Tarjeta_Circulacion { get; set; }
        public int SerieImagen { get; set; }
        public byte[] Imagen { get; set; }
        public int? Opcion { get; set; }
        public string NombreArchivoPDF { get; set; }
        public byte[] ArchivoPDF { get; set; }
        public string NombreArchivoXML { get; set; }
        public byte[] ArchivoXML { get; set; }
        public string TargCombustibles { get; set; }

        public void MtdSeleccionarActivos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Activos_Select";
                _dato.CadenaTexto = Status;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Status");
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
                _dato.CadenaTexto = Id_Factura;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Factura");
                _dato.CadenaTexto = IAVE;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "IAVE");
                _dato.CadenaTexto = Folio_Tarjeta_Circulacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio_Tarjeta_Circulacion");
                _dato.CadenaTexto = TargCombustibles;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Tarjeta_Combustible");
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

        public void MtdSeleccionarActivoImagen()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoImagen_Select";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
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
        public void MtdInsertarActivoImagen()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoImagen_Insert";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
                _dato.Entero = SerieImagen;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Serie");
                _dato.CadenaTexto = Descripcion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Descripcion");
                _dato.ImagenValor = Imagen;
                _conexion.agregarParametro(EnumTipoDato.imagen, _dato, "Imagen");
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
        public void MtdEliminarActivoImagen()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoImagen_Delete";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
                _dato.Entero = SerieImagen;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Serie");
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

        public void MtdSeleccionarActivoArchivoPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoArchivosFicales_Select";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
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
        public void MtdInsertarActivoArchivoPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoArchivosFicales_Insert";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
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
        public void MtdUpdateActivoArchivoPDF()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoArchivosFicalesPDF_Update";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
                _dato.Entero = Opcion;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Opcion");
                _dato.CadenaTexto = NombreArchivoPDF;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NombreArchivoPDF");
                _dato.ArchivoValor = ArchivoPDF;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "ArchivoPDF");
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
        public void MtdUpdateActivoArchivoXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoArchivosFicalesXML_Update";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
                _dato.Entero = Opcion;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Opcion");
                _dato.CadenaTexto = NombreArchivoXML;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NombreArchivoXML");
                _dato.ArchivoValor = ArchivoXML;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "ArchivoXML");
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
        public void MtdDeleteActivoArchivoPDF()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoArchivosFicalesPDF_Delete";
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
        public void MtdDeleteActivoArchivoXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ActivoArchivosFicalesXML_Delete";
                _dato.CadenaTexto = Id_Activo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Activo");
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

    }
}
