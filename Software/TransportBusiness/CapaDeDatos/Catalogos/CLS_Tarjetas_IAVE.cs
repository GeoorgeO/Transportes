﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Tarjetas_IAVE : ConexionBase
    {

        public string IAVE { get; set; }
        public string Vigencia { get; set; }
        public string Id_Empresa { get; set; }
        public decimal Monto_Min { get; set; }
        public decimal Monto_Max { get; set; }

        public void MtdSeleccionarTarjetas_IAVE()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tarjetas_IAVE_Select";

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



        public void MtdInsertarTarjetas_IAVE()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tarjetas_IAVE_Insert";
                _dato.CadenaTexto = IAVE;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "IAVE");
                _dato.CadenaTexto = Vigencia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Vigencia");
                _dato.CadenaTexto = Id_Empresa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Empresa");
                _dato.DecimalValor = Monto_Min;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Monto_Min");
                _dato.DecimalValor = Monto_Max;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Monto_Max");
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

        public void MtdEliminarTarjetas_IAVE()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tarjetas_IAVE_Delete";
                _dato.CadenaTexto = IAVE;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "IAVE");
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