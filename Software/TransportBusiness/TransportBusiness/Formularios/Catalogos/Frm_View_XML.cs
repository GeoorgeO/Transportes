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
    public partial class Frm_View_XML : DevExpress.XtraEditors.XtraForm
    {
        public string Id_Activo { get; set; }
        public Frm_View_XML()
        {
            InitializeComponent();
        }

        private void Frm_View_XML_Shown(object sender, EventArgs e)
        {
            CLS_Activos sel = new CLS_Activos();
            sel.Id_Activo = Id_Activo;
            sel.MtdSeleccionarActivoArchivoPDFXML();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0 && sel.Datos.Rows[0]["ArchivoXML"]!=null)
                {
                    byte[] bytes = (byte[])sel.Datos.Rows[0]["ArchivoXML"];

                    System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewXML.xml", bytes);
                    webBrowser1.Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewXML.xml");


                }
            }
        }
    }
}