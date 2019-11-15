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

namespace TransportBusiness.Formularios.Catalogos
{
    public partial class Frm_View_PDF : DevExpress.XtraEditors.XtraForm
    {
        public Frm_View_PDF()
        {
            InitializeComponent();
        }

        private void Frm_View_PDF_Shown(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("..\\..\\Demo.pdf", FileMode.Open);
            pdfViewer1.LoadDocument(stream);
        }
    }
}