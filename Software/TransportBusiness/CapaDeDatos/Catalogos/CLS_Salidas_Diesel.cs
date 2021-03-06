﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Salidas_Diesel : ConexionBase
    {
        public string Ticket { get; set; }
        public string Id_Salida { get; set; }
        public decimal Importe { get; set; }
        public decimal Litros { get; set; }
        public string Fecha_Diesel { get; set; }
        public string Moneda { get; set; }
        public string Usuario { get; set; }

        public void MtdSeleccionarSalidas_Diesel()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Diesel_Select";
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



        public void MtdInsertarSalidas_Diesel()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Diesel_Insert";
                _dato.CadenaTexto = Ticket;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Ticket");
                _dato.CadenaTexto = Id_Salida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Salida");
                _dato.DecimalValor = Importe;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Importe");
                _dato.DecimalValor = Litros;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Litros");
                _dato.CadenaTexto = Fecha_Diesel;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Diesel");
                _dato.CadenaTexto = Moneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
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

        public void MtdEliminarSalidas_Diesel()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Salidas_Diesel_Delete";
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
