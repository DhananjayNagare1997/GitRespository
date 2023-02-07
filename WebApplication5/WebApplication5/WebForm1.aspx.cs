using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // Step1
namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //-----Step2
        SqlConnection con;  //To connect with DB
        SqlCommand cmd;   //To Execute sql Command.


        public void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            string EmpID = TextBox1.Text;
            string EmpName = TextBox2.Text;
            string MailID = TextBox3.Text;
            string Mobile = TextBox4.Text;
            string Password = TextBox5.Text;
            con = new SqlConnection("data source=G09INXNP31261X1;initial catalog=TestDB;Integrated security=true");
            con.Open();
            string query = "insert into Employeeinfo values(" + EmpID + ",'" + EmpName + "','" + MailID + "','" + Mobile + "','" + Password + "')";

            cmd = new SqlCommand(query, con);

           // cmd.ExecuteNonQuery();

            Label6.Text = "Data has been Saved";
            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

         protected void TextBox5_TextChanged(object sender, EventArgs e)
          {

          }
        
    }
}