using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Registration
{
    public partial class Update_dv : System.Web.UI.Page
    {
        private SqlCommand GetCommand(string commandText)
        {
            string connectionString = string.Empty;

            connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(commandText, connection);
            return command;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Data Updated Successfully....!");


            string query = ConfigurationManager.AppSettings["Fetch"];
            SqlCommand command = GetCommand(query);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "StudentReg");
            gvStudentReg.DataSource = ds.Tables["StudentReg"];
            gvStudentReg.DataBind();
        }
    }
}