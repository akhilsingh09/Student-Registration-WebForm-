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
    public partial class std_reg : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

            load_func();
        }

        private void load_func()
        {
            string query = ConfigurationManager.AppSettings["Fetch"];
            SqlCommand command = GetCommand(query);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "akhil_StudentReg");
            dgvStudentReg.DataSource = ds.Tables["akhil_StudentReg"];
            dgvStudentReg.DataBind();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=SampleDB;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=sksdemoazuresql.database.windows.net,1433;Initial Catalog=knowledgesession;Persist Security Info=False;User ID=ssaminathan;Password=asdf1234$");
        string gender = string.Empty;
        protected void btnSave_Click(object sender, EventArgs e)
        {


            //cookie_method();
            //session_method();
            //Response.Redirect("Page_2.aspx");
            //Server.Transfer("Page_2.aspx");

            if (radioMale.Checked)
            {
                gender = "Male";
            }
            if(radioFemale.Checked)
            {
                gender = "Female";
            }

            SqlCommand cmd = new SqlCommand("Insert into akhil_StudentReg(StudentName, FatherName,Age,Program,Country,Address,ContactNumber,Email,Gender,StudentID) values (@SName,@FatherName, @Age, @Program,@Country,@Address,@Mobile,@Email,@Gender,@SId)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SName", txtSName.Text);
            cmd.Parameters.AddWithValue("@FatherName", txtFName.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@Program", txtProgram.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Mobile", txtContactNumber.Text );
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Gender", gender );
            cmd.Parameters.AddWithValue("@SId", txtID.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            load_func();
            reset_form();
            //Response.Redirect("Insert_dataview.aspx");
        }

        private void reset_form()
        {
            txtID.Text = string.Empty;
            txtSName.Text = string.Empty;
            txtFName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtProgram.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            radioFemale.Checked = false;
            radioMale.Checked = false;

            txtID.Focus();
        }

        private void session_method()
        {
            this.Session["Name"] = txtSName.Text;
            this.Session["Email"] = txtEmail.Text;
        }

        private void cookie_method()
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = txtSName.Text;
            cookie["Email"] = txtEmail.Text;
            ///cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from akhil_StudentReg WHERE StudentID=@ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", txtID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            load_func();
            reset_form();

            //Response.Redirect("Delete_dv.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            if (radioFemale.Checked)
            {
                gender = "Female";
            }
            SqlCommand cmd = new SqlCommand("Update akhil_StudentReg SET StudentName=@SName, FatherName=@FatherName,Age=@Age,Program=@Program,Country=@Country,Address=@Address,ContactNumber=@Mobile,Email=@Email,Gender=@Gender WHERE StudentID=@SId", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SName", txtSName.Text);
            cmd.Parameters.AddWithValue("@FatherName", txtFName.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@Program", txtProgram.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Mobile", txtContactNumber.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@SId", txtID.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            load_func();
            reset_form();

            //Response.Redirect("Update_dv.aspx");
        }

        protected void btnSession_Click(object sender, EventArgs e)
        {
            cookie_method();
            //session_method();

            //Response.Redirect("Page_2.aspx");
            Server.Transfer("Page_2.aspx");
        }
        private SqlCommand GetCommand(string commandText)
        {
            string connectionString = string.Empty;

            connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(commandText, connection);
            return command;
        }

        protected void linkSelect_Click(object sender, EventArgs e)
        {
            int stud_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            //int rowind = ((GridView)(sender as Control).NamingContainer).SelectedRow;

            SqlCommand cmd = new SqlCommand("SELECT * from akhil_StudentReg WHERE StudentID=@ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", stud_id);

            con.Open();
            SqlDataReader da = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();

            while (da.Read())
            {
                string gen = string.Empty;
                txtSName.Text = da.GetValue(0).ToString();
                txtID.Text = da.GetValue(9).ToString();
                txtFName.Text = da.GetValue(1).ToString();
                txtAge.Text = da.GetValue(2).ToString();
                txtProgram.Text = da.GetValue(3).ToString();
                txtCountry.Text = da.GetValue(4).ToString();
                txtAddress.Text = da.GetValue(5).ToString();
                txtContactNumber.Text = da.GetValue(6).ToString();
                txtEmail.Text = da.GetValue(7).ToString();
                gen = da.GetValue(8).ToString();
                

                if (gen.Trim() == "Male")
                {
                    radioMale.Checked = true;
                }
                if(gen.Trim() == "Female")
                {
                    radioFemale.Checked = true;
                }

            }
            con.Close();




        }

        protected void reset_click(object sender, EventArgs e)
        {
            reset_form();
        }
    }
}