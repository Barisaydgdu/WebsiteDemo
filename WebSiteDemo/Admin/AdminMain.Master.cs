using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteDemo.Admin
{
    public partial class AdminMain : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string girisDurumu = Session["LoginSucces"].ToString();
                if (girisDurumu == "true")
                {
                    lblNameSurname.Text = Session["NameSurname"].ToString();
                }
                else
                {
                    Response.Redirect("userLogin.aspx");

                }
            }
            catch (Exception)
            {
                Response.Redirect("userLogin.aspx");
                throw;
            }
        }

        protected void lnklogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("userLogin.aspx");
        }
    }
}