using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_AuthorizationDemo
{
    public partial class EditItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["id"]!=null)
            {
                MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
                int id =  Convert.ToInt32(Request.QueryString["id"].ToString());
                MenuItem obj = (from x in menuItemDaoCollection.menuItemList

                                where x.Id == id
                                select x).FirstOrDefault();
                if (obj != null)
                {
                    menuItemDaoCollection.menuItemList.Where(w => w.Id == id).ToList().ForEach(i => i.Name = "Name is changed");
                }
                foreach(var x in menuItemDaoCollection.menuItemList)
                {
                    Response.Write(x.Id +  " " + x.Name);
                }
            }
        }
    }
}