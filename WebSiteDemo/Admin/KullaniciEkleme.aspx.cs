using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteDemo.Admin
{
    public partial class KullaniciEkleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmıt_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Value;
            string password = txtPassword.Value;
            string name = txtName.Value;
            string surname = txtSurname.Value;

            var sonuc = new BLL.BLLUser().KullaniciAdiKulaniliyorMu(email);
            if (sonuc)
            {
                string ipAddres = ipNedir();
                DAL.UserLog entitty = new DAL.UserLog();
                entitty.PCIP = ipAddres;
                entitty.RegisterDate = DateTime.Now;
                entitty.LogCaption =email +" Kullanıcı Ekleme İşlemi Yapıldı .";
                entitty.LogTypeID = 1;
                entitty.LogUserID = Convert.ToInt32(Session["UserID"]);
                new BLL.BllUserLog().AddLog(entitty);



                DAL.User entity = new DAL.User();
                entity.UserActivity = true;
                entity.Email = email;
                entity.Password = password;
                entity.Name = name;
                entity.Surname = surname;
                entity.RegisterDate = DateTime.Now;
                entity.AuthorizationTypeID = 2;

                new BLL.BLLUser().KullaniciEkle(entity);
                lblMessage.Text = "Kullanıcı Kaydı Başarılı";


                
            }
            else
            {
                lblMessage.Text = "Eposta Adresi Kullanılıyor";
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