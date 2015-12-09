using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebAppDemo
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitEventMethod(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;Initial Catalog=\"C:\\USERS\\HP\\DOCUMENTS\\VISUAL STUDIO 2013\\PROJECTS\\WEBAPPDEMO\\WEBAPPDEMO\\APP_DATA\\USERS.MDF\";User ID=sa;Password=Titan#12");

        }

       
  

        //conn = SqlConnection
        //cmd = SqlCommand 
    }
}