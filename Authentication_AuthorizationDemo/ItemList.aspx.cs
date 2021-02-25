using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_AuthorizationDemo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            GridView1.DataSource = menuItemDaoCollection.menuItemList;
            GridView1.DataBind();

        }
    }
}