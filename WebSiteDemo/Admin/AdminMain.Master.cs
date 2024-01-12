using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteDemo.Admin
{
    public partial class AdminMain1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string girisDurumu = Session["LoginSucces"].ToString();
                if (girisDurumu == "true")
                {
                    lbl_AdSoyad.Text = Session["NameSurname"].ToString();
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