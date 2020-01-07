using System;
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
    public partial class Frm_Entradas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Entradas()
        {
            InitializeComponent();
        }

        



        private void InsertarEntradas()
        {
            CLS_Entradas Clase = new CLS_Entradas();
            Clase.Id_Entrada = textEntrada.Text.Trim();
            Clase.Id_Salida = textSalida.Text.Trim();
            Clase.Fecha_Entrada = dtFechaEntrada.Text.Trim();
            Clase.Fecha_Cruce = dtFechaCruce.Text.Trim();
            Clase.Id_Activo_P = textActivoPrincipal.Text.Trim();
            Clase.Id_Activo_1 = textActivoSec.Text.Trim();
            Clase.Id_Activo_2 = textActivoAdicional.Text.Trim();
            Clase.MtdInsertarEntradas();
            if (Clase.Exito)
            {

                
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

       

        private void LimpiarCampos()
        {
            textEntrada.Text = "";
            textSalida.Text = "";
            textActivoPrincipal.Text = "";
            textActivoPrincipal.Tag = "";
            textActivoSec.Text = "";
            textActivoSec.Tag = "";
            textActivoAdicional.Text = "";
            textActivoAdicional.Tag = "";
            dtFechaEntrada.EditValue = DateTime.Now;
            dtFechaCruce.EditValue = DateTime.Now;
        }

        private void btnBusqSalida_Click(object sender, EventArgs e)
        {
            Frm_BusqEntradas frm = new Frm_BusqEntradas();
            frm.ShowDialog();
            textEntrada.Text = frm.vId_Entrada;
            textSalida.Text = frm.vId_Salida;
            textActivoPrincipal.Tag = frm.vId_Activo_P;
            textActivoPrincipal.Text = frm.vNombre_Activo_P;
            textActivoSec.Tag = frm.vId_Activo_1;
            textActivoSec.Text = frm.vNombre_Activo_1;
            textActivoAdicional.Tag = frm.vId_Activo_2;
            textActivoAdicional.Text = frm.vNombre_Activo_2;
            if (frm.vFecha_Entrada.Equals("")) {

            }else
            {
                dtFechaEntrada.EditValue = Convert.ToDateTime(frm.vFecha_Entrada);
            }
            if (frm.vFecha_Cruce.Length > 0)
            {
                dtFechaCruce.EditValue = Convert.ToDateTime(frm.vFecha_Cruce);
            }
            
        }
    }
}