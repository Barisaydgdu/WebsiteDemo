using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteDemo.Admin
{
    public partial class userLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUserGiris(object sender, EventArgs e)
        {
            string email = txtUserLoginEmail.Value;
            string password = txtUserLoginPassword.Value;

            var sonuc = new BLL.BLLUser().UserControl(email, password);
            if (sonuc.Count() >0)
            {
                string ipAddres = ipNedir();
                DAL.UserLog entitty = new DAL.UserLog();
                entitty.PCIP = ipAddres;
                entitty.RegisterDate = DateTime.Now;
                entitty.LogCaption = "Kullanıcı Giriş Başarılı.";
                entitty.LogTypeID = 1;
                entitty.LogUserID = sonuc[0].UserID;
                new BLL.BllUserLog().AddLog(entitty);





                Session["UserID"] = sonuc[0].UserID;
                Session["NameSurname"] = sonuc[0].Name + " " + sonuc[0].Surname;
                Session["Loginsucces"] = "true";
                Response.Redirect("index.aspx");
                lblUserMessage.Text = "Giriş Başarılı.";
            }
            else
            {
                string ipAddres = ipNedir();
                DAL.UserLog entitty = new DAL.UserLog();
                entitty.PCIP = ipAddres;
                entitty.RegisterDate = DateTime.Now;
                entitty.LogCaption = "Kullanıcı Adı veya Şifre Hatalı.(KullanıcıAdı:" + txtUserLoginEmail.Value + " Sifre: " + txtUserLoginPassword.Value; ;
                entitty.LogTypeID = 2;
                entitty.LogUserID = 9999;
                new BLL.BllUserLog().AddLog(entitty);

                lblUserMessage.Text = "Kullanıcı Adı veya Şifre Hatalı.";
            }
        }
        protected string ipNedir()
        {
            string ipAddress;
            ipAddress = Context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (ipAddress == null || ipAddress == "")
                ipAddress = Context.Request.ServerVariables["REMOTE_ADDR"];
            return ipAddress;
            
        }
    }
}