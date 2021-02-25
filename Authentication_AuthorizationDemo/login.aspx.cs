using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_AuthorizationDemo
{
    public partial class login : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "user1" && TextBox2.Text == "user2")
            {
                Session["userName"] = TextBox1.Text;
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
            }

        }
    }
}