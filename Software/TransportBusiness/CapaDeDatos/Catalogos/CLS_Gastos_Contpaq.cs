﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Gastos_Contpaq : ConexionBase
    {

        public string Id_Gasto { get; set; }
        public string Fecha_Gasto { get; set; }
        public string Id_GastoIndirecto { get; set; }
        public decimal Importe { get; set; }
        public decimal Tipo_Cambio { get; set; }
        public string Factura { get; set; }
        public string Concepto { get; set; }
        public string Id_Cuenta { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }


        public void MtdSeleccionarGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexionC);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Contpaq_Select";
                _dato.CadenaTexto = FechaInicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaInicio");
                _dato.CadenaTexto = FechaFin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaFin");
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
        public void MtdInsertarGastos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Gastos_Insert";
                _dato.CadenaTexto = Id_Gasto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Gasto");
                _dato.CadenaTexto = Fecha_Gasto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Gasto");
                _dato.CadenaTexto = Id_GastoIndirecto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_GastoIndirecto");
                _dato.DecimalValor = Importe;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Importe");
                _dato.DecimalValor = Tipo_Cambio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Tipo_Cambio");
                _dato.CadenaTexto = Factura;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Factura");
                _dato.CadenaTexto = Concepto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Concepto");
                _dato.CadenaTexto = Id_Cuenta;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Cuenta");
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
