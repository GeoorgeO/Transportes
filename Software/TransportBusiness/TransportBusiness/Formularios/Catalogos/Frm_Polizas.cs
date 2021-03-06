﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaDeDatos;

namespace TransportBusiness
{
    public partial class Frm_Polizas : DevExpress.XtraEditors.XtraForm
    {
        public string IdPoliza { get; set; }
        public string FInicio { get; set; }
        public string Ffin {get; set;}
        public string IdAseguradora { get; set; }
        public string Aseguradora { get; set; }
        public Boolean PaSel { get; set; }

        public Frm_Polizas()
        {
            InitializeComponent();
        }

        private void abilitar( Boolean sino)
        {
            groupControl1.Enabled=sino;
            btnGuardar.Enabled = sino;
            btnSeleccionar.Enabled = sino;
        }

        private void CargarPolizas()
        {
            gridControl1.DataSource = null;
            CLS_Polizas Polizas = new CLS_Polizas();
            if (checkActivo.Checked)
            {
                Polizas.Estatus = "0";
            }
            else
            {
                Polizas.Estatus = "1";
            }
            
            Polizas.MtdSeleccionarPolizas();
            if (Polizas.Exito)
            {
                gridControl1.DataSource = Polizas.Datos;
            }
        }

        private string DosCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }

        private void InsertarPolizas()
        {
            CLS_Polizas Polizas = new CLS_Polizas();
            Polizas.Poliza_Seguro = textId.Text.Trim();
            DateTime Fecha = Convert.ToDateTime(dateInicio.Text.Trim());
            
            Polizas.Fecha_Inicio = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Fecha = Convert.ToDateTime(dateFin.Text.Trim());
            Polizas.Fecha_Fin= Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
          
           
                Polizas.Estatus = "1";
           
            Polizas.Id_Activo = labelActivo.Tag.ToString();
            Polizas.Id_Empresa_Aseguradora = txtEmpresaAsegu.Tag.ToString();
            Polizas.MtdInsertarPolizas();
            if (Polizas.Exito)
            {

                CargarPolizas();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Polizas.Mensaje);
            }
        }

        private void EliminarPolizas()
        {
            CLS_Polizas Polizas = new CLS_Polizas();
            Polizas.Poliza_Seguro = textId.Text.Trim();
            Polizas.MtdEliminarPolizas();
            if (Polizas.Exito)
            {
                CargarPolizas();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Polizas.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            labelActivo.Text = "";
            labelActivo.Tag = "";
            labelStatus.Text = "";
            textId.Enabled = true;
            txtEmpresaAsegu.Text = "";
            txtEmpresaAsegu.Tag = "";
        }


        private void vigentes()
        {
            for (int x=0; x<gridView1.RowCount; x++)
            {
                int xRow = gridView1.GetVisibleRowHandle(x);
                if (Convert.ToInt32(DateTime.Now.Year.ToString() + DosCero(DateTime.Now.Month.ToString()) + DosCero(DateTime.Now.Day.ToString())) >= Convert.ToInt32(Convert.ToDateTime(gridView1.GetRowCellValue(xRow, gridView1.Columns["Fecha_Inicio"])).Year.ToString() + DosCero(Convert.ToDateTime(gridView1.GetRowCellValue(xRow, gridView1.Columns["Fecha_Inicio"])).Month.ToString()) + DosCero(Convert.ToDateTime(gridView1.GetRowCellValue(xRow, gridView1.Columns["Fecha_Inicio"])).Day.ToString())) && Convert.ToInt32(DateTime.Now.Year.ToString() + DosCero(DateTime.Now.Month.ToString()) + DosCero(DateTime.Now.Day.ToString())) <= Convert.ToInt32(Convert.ToDateTime(gridView1.GetRowCellValue(xRow, gridView1.Columns["Fecha_Fin"])).Year.ToString() + DosCero(Convert.ToDateTime(gridView1.GetRowCellValue(xRow, gridView1.Columns["Fecha_Fin"])).Month.ToString()) + DosCero(Convert.ToDateTime(gridView1.GetRowCellValue(xRow, gridView1.Columns["Fecha_Fin"])).Day.ToString())))
                {

                }else
                {
                    gridView1.DeleteRow(xRow);
                }
                    
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Poliza_Seguro"].ToString();
                    dateInicio.Text = row["Fecha_Inicio"].ToString();
                    dateFin.Text = row["Fecha_Fin"].ToString();
                    labelActivo.Tag = row["Id_Activo"].ToString();
                    labelActivo.Text = row["Nombre_Interno"].ToString();
                    labelStatus.Text = row["Estatus"].ToString();
                    txtEmpresaAsegu.Tag = row["Id_Empresa_Aseguradora"].ToString();
                    txtEmpresaAsegu.Text = row["Nombre_Empresa_Aseguradora"].ToString();

                    if (row["Estatus"].ToString().Equals("False"))
                    {
                        abilitar(false);
                        btnEliminar.Caption = "Habilitar";
                    }
                    else
                    {
                        abilitar(true);
                        btnEliminar.Caption = "Inhabilitar";
                    }

                    if (row["Poliza_Seguro"].ToString().Trim().Length > 0)
                    {
                        textId.Enabled = false;
                    }
                    else
                    {
                        textId.Enabled = true;
                    }

                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Polizas_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarPolizas();
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dateInicio.EditValue!=null && dateFin.EditValue!=null)
            {

                InsertarPolizas();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar Fecha de inicio y de fin.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 )
            {
                EliminarPolizas();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un pais.");
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
            abilitar(true);
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Convert.ToInt32(DateTime.Now.Year.ToString() + DosCero(DateTime.Now.Month.ToString()) + DosCero(DateTime.Now.Day.ToString())) >= Convert.ToInt32(Convert.ToDateTime(dateInicio.EditValue).Year.ToString() + DosCero(Convert.ToDateTime(dateInicio.EditValue).Month.ToString()) + DosCero(Convert.ToDateTime(dateInicio.EditValue).Day.ToString())) && Convert.ToInt32(DateTime.Now.Year.ToString() + DosCero(DateTime.Now.Month.ToString()) + DosCero(DateTime.Now.Day.ToString())) <= Convert.ToInt32(Convert.ToDateTime(dateFin.EditValue).Year.ToString() + DosCero(Convert.ToDateTime(dateFin.EditValue).Month.ToString()) + DosCero(Convert.ToDateTime(dateFin.EditValue).Day.ToString())))
            {
                IdPoliza = textId.Text.Trim();
                FInicio = Convert.ToDateTime(dateFin.Text.Trim()).Year.ToString() + DosCero(Convert.ToDateTime(dateFin.Text.Trim()).Month.ToString()) + DosCero(Convert.ToDateTime(dateFin.Text.Trim()).Day.ToString());
                Ffin = Convert.ToDateTime(dateInicio.Text.Trim()).Year.ToString() + DosCero(Convert.ToDateTime(dateInicio.Text.Trim()).Month.ToString()) + DosCero(Convert.ToDateTime(dateInicio.Text.Trim()).Day.ToString());
                IdAseguradora = txtEmpresaAsegu.Tag.ToString();
                Aseguradora = txtEmpresaAsegu.Text.Trim();
                this.Close();
            }else
            {
                XtraMessageBox.Show("No esta vigente la poliza de seguro seleccionada.");
            }
           
        }

        private void checkActivo_CheckedChanged(object sender, EventArgs e)
        {
            CargarPolizas();   
        }

        private void btnEmpresaAsegu_Click(object sender, EventArgs e)
        {
            Frm_Aseguradoras frm = new Frm_Aseguradoras();
            frm.PaSel = true;
            frm.ShowDialog();

            txtEmpresaAsegu.Tag = frm.idAseguradora;
            txtEmpresaAsegu.Text = frm.Aseguradora;
        }

        private void checkvigentes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkvigentes.Checked)
            {
                vigentes();
            }
            else
            {
                CargarPolizas();
            }
           
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                if (Convert.ToInt32(DateTime.Now.Year.ToString() + DosCero(DateTime.Now.Month.ToString()) + DosCero(DateTime.Now.Day.ToString())) >= Convert.ToInt32(Convert.ToDateTime(dateInicio.EditValue).Year.ToString() + DosCero(Convert.ToDateTime(dateInicio.EditValue).Month.ToString()) + DosCero(Convert.ToDateTime(dateInicio.EditValue).Day.ToString())) && Convert.ToInt32(DateTime.Now.Year.ToString() + DosCero(DateTime.Now.Month.ToString()) + DosCero(DateTime.Now.Day.ToString())) <= Convert.ToInt32(Convert.ToDateTime(dateFin.EditValue).Year.ToString() + DosCero(Convert.ToDateTime(dateFin.EditValue).Month.ToString()) + DosCero(Convert.ToDateTime(dateFin.EditValue).Day.ToString())))
                {
                    IdPoliza = textId.Text.Trim();
                    FInicio = Convert.ToDateTime(dateFin.Text.Trim()).Year.ToString() + DosCero(Convert.ToDateTime(dateFin.Text.Trim()).Month.ToString()) + DosCero(Convert.ToDateTime(dateFin.Text.Trim()).Day.ToString());
                    Ffin = Convert.ToDateTime(dateInicio.Text.Trim()).Year.ToString() + DosCero(Convert.ToDateTime(dateInicio.Text.Trim()).Month.ToString()) + DosCero(Convert.ToDateTime(dateInicio.Text.Trim()).Day.ToString());
                    IdAseguradora = txtEmpresaAsegu.Tag.ToString();
                    Aseguradora = txtEmpresaAsegu.Text.Trim();
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("No esta vigente la poliza de seguro seleccionada.");
                }
            }
        }
    }
}