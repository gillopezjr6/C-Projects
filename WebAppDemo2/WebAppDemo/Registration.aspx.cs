using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebAppDemo
{
    public partial class Registration : System.Web.UI.Page
    {
        /*SqlConnection conn; 
        SqlCommand cmd;
        String queryString; */
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerEventMethod(object sender, EventArgs e)
        {
                     //RegisterUser();
        }

        /* private void RegisterUser()
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

            conn = new SqlConnection(connString);
            conn.Open();
            queryString = "";

            queryString = "INSERT INTO UsersConnected.User_Registration (first_name, last_name, email, phone_number, user_name, password)" +
                "Values('" + firstnameTextBox.Text + "', '" + lastnameTextBox.Text + "', '" + emailTextBox.Text + "', '" + phonenumberTextBox.Text + "', '" + usernameTextBox.Text + "', '" + passwordTextBox.Text + "')";
            cmd = new SqlCommand(queryString, conn);
            cmd.ExecuteReader();
            conn.Close();
        } */

        
    }
}