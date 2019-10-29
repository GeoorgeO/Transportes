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

namespace TransportBusiness
{
    public partial class Frm_Clientes : DevExpress.XtraEditors.XtraForm
    {

        private static Frm_Clientes m_FormDefInstance;
        public static Frm_Clientes DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Clientes();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Frm_Clientes()
        {
            InitializeComponent();
        }
    }
}