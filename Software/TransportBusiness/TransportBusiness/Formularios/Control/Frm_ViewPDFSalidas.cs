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
    public partial class Frm_ViewPDFSalidas : DevExpress.XtraEditors.XtraForm
    {

        public string Id_Salida { get; set; }
        public decimal Id_Archivo { get; set; }
        public string Ventana { get; set; }
        public string Ticket { get; set; }
       

        public Frm_ViewPDFSalidas()
        {
            InitializeComponent();
        }

        private void Frm_ViewPDFSalidas_Load(object sender, EventArgs e)
        {
            
            if (Ventana.Equals("OtrosGastos"))
            {
                CLS_Salidas_OtrosGastos sel = new CLS_Salidas_OtrosGastos();
                sel.Id_Salida = Id_Salida;
                sel.Ticket = Ticket;
                sel.MtdSeleccionarSalidasArchivoPDFXMLView();
                if (sel.Exito)
                {
                    if (sel.Datos.Rows.Count > 0 && sel.Datos.Rows[0]["FacturaPDF"] != null)
                    {
                        byte[] bytes = (byte[])sel.Datos.Rows[0]["FacturaPDF"];

                        System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf", bytes);
                        this.pdfViewer1.LoadDocument(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf");
                    }
                }
            }
            if (Ventana.Equals("Facturas"))
            {
                CLS_Salidas_Facturas sel = new CLS_Salidas_Facturas();
                sel.Id_Salida = Id_Salida;
                sel.Id_Archivo = Id_Archivo;
                sel.MtdSeleccionarSalidasArchivoPDFXMLView();
                if (sel.Exito)
                {
                    if (sel.Datos.Rows.Count > 0 && sel.Datos.Rows[0]["FacturaPDF"] != null)
                    {
                        byte[] bytes = (byte[])sel.Datos.Rows[0]["FacturaPDF"];

                        System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf", bytes);
                        this.pdfViewer1.LoadDocument(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf");
                    }
                }
            }
            if (Ventana.Equals("Cruces"))
            {
                CLS_Salidas_Cruces sel = new CLS_Salidas_Cruces();
                sel.Id_Salida = Id_Salida;
                sel.Id_Archivo = Id_Archivo;
                sel.MtdSeleccionarSalidasArchivoPDFXMLView();
                if (sel.Exito)
                {
                    if (sel.Datos.Rows.Count > 0 && sel.Datos.Rows[0]["FacturaPDF"] != null)
                    {
                        byte[] bytes = (byte[])sel.Datos.Rows[0]["FacturaPDF"];

                        System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf", bytes);
                        this.pdfViewer1.LoadDocument(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ViewPDF.pdf");
                    }
                }
            }
            
            
        }
    }
}