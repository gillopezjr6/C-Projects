using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CreateLogin
{
    public partial class loginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitEventMethod(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=login;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from user_table where username = '" + usernameTextBox.Text + "', and password = '" + passwordTextBox + "'", conn);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            int count = 0;
            while (dataReader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                Console.WriteLine("Ok");
            }
            conn.Close();

        }

    }
}