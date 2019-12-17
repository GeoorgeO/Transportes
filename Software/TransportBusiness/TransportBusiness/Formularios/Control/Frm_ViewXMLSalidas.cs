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
    public partial class Frm_ViewXMLSalidas : DevExpress.XtraEditors.XtraForm
    {

        public string Id_Salida { get; set; }
        public decimal Id_Archivo { get; set; }

        public Frm_ViewXMLSalidas()
        {
            InitializeComponent();
        }

        private void Frm_ViewXMLSalidas_Load(object sender, EventArgs e)
        {
            CLS_Salidas_Facturas sel = new CLS_Salidas_Facturas();
            sel.Id_Salida = Id_Salida;
            sel.Id_Archivo = Id_Archivo;
            sel.MtdSeleccionarSalidasArchivoPDFXMLView();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0 && sel.Datos.Rows[0]["FacturaXML"] != null)
                {
                    byte[] bytes = (byte[])sel.Datos.Rows[0]["FacturaXML"];

                    System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewXML.xml", bytes);
                    webBrowser1.Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewXML.xml");


                }
            }
        }
    }
}