using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TransportBusiness
{
    public partial class rpt_Reporte_Salidas : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_Reporte_Salidas(string F_Del,string F_Al,string Id_Empresa,string Moneda)
        {
            InitializeComponent();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            queryParameter1.Name = "@F_Del";
            queryParameter1.Type = typeof(string);
            queryParameter2.Name = "@F_Al";
            queryParameter2.Type = typeof(string);
            queryParameter3.Name = "@Id_Empresa";
            queryParameter3.Type = typeof(string);
            queryParameter4.Name = "@Moneda";
            queryParameter4.Type = typeof(string);
            queryParameter1.ValueInfo = Convert.ToString(F_Del);
            queryParameter2.ValueInfo = Convert.ToString(F_Al);
            queryParameter3.ValueInfo = Convert.ToString(Id_Empresa);
            queryParameter4.ValueInfo = Convert.ToString(Moneda);
            sqlDataSource1.Queries[0].Parameters.Clear();
            sqlDataSource1.Queries[1].Parameters.Clear();
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter1);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter2);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter3);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter4);
            sqlDataSource1.Queries[1].Parameters.Add(queryParameter1);
            sqlDataSource1.Queries[1].Parameters.Add(queryParameter2);
            sqlDataSource1.Queries[1].Parameters.Add(queryParameter3);
            sqlDataSource1.Queries[1].Parameters.Add(queryParameter4);

        }

    }
}
