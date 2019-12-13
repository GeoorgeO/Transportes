﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_MotivoSalidas : ConexionBase
    {

        public string Id_MotivoSalida { get; set; }
        public string Nombre_MotivoSalida { get; set; }

        public void MtdSeleccionarMotivoSalida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_MotivoSalida_Select";

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



        public void MtdInsertarMotivoSalida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_MotivoSalida_Insert";
                _dato.CadenaTexto = Id_MotivoSalida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_MotivoSalida");
                _dato.CadenaTexto = Nombre_MotivoSalida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre_MotivoSalida");
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

        public void MtdEliminarMotivoSalida()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_MotivoSalida_Delete";
                _dato.CadenaTexto = Id_MotivoSalida;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_MotivoSalida");
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
