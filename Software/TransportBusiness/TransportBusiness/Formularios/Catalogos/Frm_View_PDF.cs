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
using System.IO;
using CapaDeDatos;

namespace TransportBusiness
{
    public partial class Frm_View_PDF : DevExpress.XtraEditors.XtraForm
    {
        public string Id_Activo { get; set; }
        public Frm_View_PDF()
        {
            InitializeComponent();
        }

        private void Frm_View_PDF_Shown(object sender, EventArgs e)
        {
            CLS_Activos sel = new CLS_Activos();
            sel.Id_Activo = Id_Activo;
            sel.MtdSeleccionarActivoArchivoPDFXML();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0 && sel.Datos.Rows[0]["ArchivoPDF"] != null)
                {
                    byte[] bytes = (byte[])sel.Datos.Rows[0]["ArchivoPDF"];

                    System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf", bytes);
                    this.pdfViewer1.LoadDocument(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf");


                }
            }
        }

        private void Frm_View_PDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}