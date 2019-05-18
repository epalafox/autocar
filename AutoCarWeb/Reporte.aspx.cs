using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DataLayer;
using Microsoft.Reporting.WebForms;

namespace AutoCarWeb
{
    public partial class Reporte1 : System.Web.UI.Page
    {
        /*
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = newSqlConnection("Data Source=sql Server name ;Initial Catalog=ResultDB;Integrated Security=True");  
            if (!IsPostBack)  
            {  
                string strQuery = "SELECT * FROM tblStudent";  
                SqlDataAdapter da = newSqlDataAdapter(strQuery, con);  
                DataTable dt = newDataTable();  
                da.Fill(dt);  
                RDLC ds = newRDLC();  
                ds.Tables["tblStudent"].Merge(dt);  
                ReportViewer1.ProcessingMode = ProcessingMode.Local;  
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("Student.rdlc");  
                ReportDataSource datasource = newReportDataSource("RDLC", ds.Tables[0]);  
                ReportViewer1.LocalReport.DataSources.Clear();  
                ReportViewer1.LocalReport.DataSources.Add(datasource);  
            }  
        }
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=sql Server name ;Initial Catalog=ResultDB;Integrated Security=True");

            IDatabase _database = LiteDBDatabase.GetInstance();
            if (!IsPostBack)
            {
                AutoDataSet ds = new AutoDataSet();
                DataTable dt = ds.Tables["AutoDT"];
               
                foreach (var a in _database.GetAutos())
                {
                    var r = dt.NewRow();
                    r["Id"] = a.Id;
                    r["Year"] = a.Year;
                    r["Brand"] = a.Brand;
                    r["Model"] = a.Model;
                    r["Price"] = a.Price;
                    r["Km"] = a.Km;
                    r["ExtColor"] = a.ExtColor;
                    r["IntColor"] = a.IntColor;
                    r["Liters"] = a.Liters;
                    r["Doors"] = a.Doors;
                    dt.Rows.Add(r);
                }
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("AutoReporte.rdlc");
                ReportDataSource datasource = new ReportDataSource("AutoDataSet", dt);
                //ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);
            }
        }
    }
}