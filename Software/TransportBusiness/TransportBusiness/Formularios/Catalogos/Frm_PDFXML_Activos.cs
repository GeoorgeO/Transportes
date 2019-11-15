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
using System.Xml;
using System.IO;
using CapaDeDatos;

namespace TransportBusiness
{
    public partial class Frm_PDFXML_Activos : DevExpress.XtraEditors.XtraForm
    {
        public string vId_Activo { get; set; }
        public Frm_PDFXML_Activos()
        {
            InitializeComponent();
        }

        private void Frm_PDFXML_Activos_Load(object sender, EventArgs e)
        {
            vId_Activo = "00000001";
            Verificar_Registro();
            //var responseXml = "<ResponseXML> your xml string </ResponseXML>";
            //var path = Path.Combine(Path.GetTempPath(), "Response.xml");
            //var responseXmlDocument = new XmlDocument();
            //responseXmlDocument.LoadXml(responseXml);
            //responseXmlDocument.Save(path);
            //webBrowser1.Navigate(path);
        }

        private void Verificar_Registro()
        {
            CLS_Activos sel = new CLS_Activos();
            sel.Id_Activo = vId_Activo;
            sel.MtdSeleccionarActivoArchivoPDFXML();
            if(sel.Exito)
            {
                if(sel.Datos.Rows.Count==0)
                {
                    CLS_Activos ins = new CLS_Activos();
                    ins.Id_Activo = vId_Activo;
                    ins.MtdInsertarActivoArchivoPDFXML();
                    if(!ins.Exito)
                    {
                        XtraMessageBox.Show(ins.Mensaje);
                    }
                }
                else
                {
                    txtNombreArchivoPDF.Text = sel.Datos.Rows[0]["NombreArchivoPDF"].ToString();
                    txtNombreArchivoXML.Text = sel.Datos.Rows[0]["NombreArchivoXML"].ToString();
                }
            }
            else
            {
                XtraMessageBox.Show(sel.Mensaje);
            }
        }

        private void btnUpPDF_Click(object sender, EventArgs e)
        {
            OpenDialog.Filter = "Portable Document Format (*.PDF)|*.PDF";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); ;
            OpenDialog.Title = "Cargar Documento PDF";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                args.Caption = "Ingrese el nombre del Archivo";
                args.Prompt = "Descripción";
                args.DefaultButtonIndex = 0;
                //args.Showing += Args_Showing;
                // initialize a DateEdit editor with custom settings 
                TextEdit editor = new TextEdit();
                args.Editor = editor;
                // a default DateEdit value 
                args.DefaultResponse = "Archivo PDF";
                // display an Input Box with the custom editor
                args.Editor = textEdit;
                var result2 = XtraInputBox.Show(args).ToString();
                if (result2 != null)
                {
                    txtNombreArchivoPDF.Text = result2;
                    string ar=OpenDialog.FileName;
                    FileStream fs = new FileStream(ar, FileMode.Open);
                    //Creamos un array de bytes para almacenar los datos leídos por fs.
                    Byte[] Archivo = new byte[fs.Length];
                    //Y guardamos los datos en el array data
                    fs.Read(Archivo, 0, Convert.ToInt32(fs.Length));
                    CLS_Activos udp = new CLS_Activos();
                    udp.Id_Activo = vId_Activo;
                    udp.Opcion = 1;
                    udp.NombreArchivoPDF = txtNombreArchivoPDF.Text;
                    udp.ArchivoPDF = Archivo;
                    udp.MtdUpdateActivoArchivoPDF();
                    if(udp.Exito)
                    {
                        XtraMessageBox.Show("Se a agregado el PDF con Exito");
                    }
                    else
                    {
                        XtraMessageBox.Show(udp.Mensaje);
                    }
                }
            }
        }

        private void btnUPXML_Click(object sender, EventArgs e)
        {
            OpenDialog.Filter = "eXtensible Markup Language (*.XML)|*.XML";
            OpenDialog.FilterIndex = 1;
            OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); ;
            OpenDialog.Title = "Cargar Documento XML";
            OpenDialog.CheckFileExists = false;
            OpenDialog.Multiselect = false;
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
                textEdit.Properties.MaxLength = 100;
                //textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                args.Caption = "Ingrese el nombre del Archivo";
                args.Prompt = "Descripción";
                args.DefaultButtonIndex = 0;
                //args.Showing += Args_Showing;
                // initialize a DateEdit editor with custom settings 
                TextEdit editor = new TextEdit();
                args.Editor = editor;
                // a default DateEdit value 
                args.DefaultResponse = "Archivo XML";
                // display an Input Box with the custom editor
                args.Editor = textEdit;
                var result2 = XtraInputBox.Show(args).ToString();
                if (result2 != null)
                {
                    txtNombreArchivoXML.Text = result2;
                    string ar = OpenDialog.FileName;
                    FileStream fs = new FileStream(ar, FileMode.Open);
                    //Creamos un array de bytes para almacenar los datos leídos por fs.
                    Byte[] Archivo = new byte[fs.Length];
                    //Y guardamos los datos en el array data
                    fs.Read(Archivo, 0, Convert.ToInt32(fs.Length));
                    CLS_Activos udp = new CLS_Activos();
                    udp.Id_Activo = vId_Activo;
                    udp.Opcion = 1;
                    udp.NombreArchivoXML = txtNombreArchivoXML.Text;
                    udp.ArchivoXML = Archivo;
                    udp.MtdUpdateActivoArchivoXML();
                    if (udp.Exito)
                    {
                        XtraMessageBox.Show("Se a agregado el PDF con Exito");
                    }
                    else
                    {
                        XtraMessageBox.Show(udp.Mensaje);
                    }
                }
            }
        }

        private void btnDeletePDF_Click(object sender, EventArgs e)
        {
            CLS_Activos udp = new CLS_Activos();
            udp.Id_Activo = vId_Activo;
            udp.Opcion = 0;
            udp.NombreArchivoPDF =string.Empty;
            udp.ArchivoPDF = null;
            udp.MtdDeleteActivoArchivoPDF();
            if (udp.Exito)
            {
                txtNombreArchivoPDF.Text = string.Empty;
                XtraMessageBox.Show("Se a quitado el PDF con Exito");
            }
            else
            {
                XtraMessageBox.Show(udp.Mensaje);
            }
        }

        private void btnDeleteXML_Click(object sender, EventArgs e)
        {
            CLS_Activos udp = new CLS_Activos();
            udp.Id_Activo = vId_Activo;
            udp.Opcion = 0;
            udp.NombreArchivoXML = string.Empty;
            udp.ArchivoXML = null;
            udp.MtdDeleteActivoArchivoXML();
            if (udp.Exito)
            {
                txtNombreArchivoPDF.Text = string.Empty;
                XtraMessageBox.Show("Se a quitado el XML con Exito");
            }
            else
            {
                XtraMessageBox.Show(udp.Mensaje);
            }
        }
    }
}