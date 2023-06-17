using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstASPNETApllicaiton
{
    public partial class MyPage : System.Web.UI.Page
    {

        // ADO.NET
        //ActiveX Data Object

        // ORM
        // Which ORm you are using ??
        // 

       

       //string abc = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        SqlConnection SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //Data Source = LAPTOP - LQDQBGOC; Initial Catalog = MyDBJMAA; User ID = sa; Password = ***********
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Select : Do not need to use Open or close

            SqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[AuditLog]", SqlConnection);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                string AuditLogId = sdr.GetValue(0).ToString();
                string text = sdr.GetValue(1).ToString();

            }

            SqlConnection.Close();
            //SqlConnection.Open();

            //SqlConnection.Close();

            string FN = txtFirstName.Text;
            string DES = txtDescription.InnerText;



        }
    }
}