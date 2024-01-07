using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteDemo.Admin
{
    public partial class Regıster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister(object sender, EventArgs e)
        {
            string email = txtEmail.Value;
            string password = txtPassword1.Value;

            var sonuc = new BLL.BLLUser().KullaniciAdiKulaniliyorMu(email);

            if (sonuc)
            {
                DAL.User entity = new DAL.User();
                entity.Email = email;
                entity.Password = password;
                entity.RegisterDate = DateTime.Now;
                entity.UserActivity = true;
                entity.AuthorizationTypeID = 2;
                new BLL.BLLUser().KullaniciEkle(entity);
                lblMesaj.Text = "Kullanıcı Kaydı Başarılı.";







            }
            else
            {
                lblMesaj.Text = "E-posta Adresi Kullaniliyor.";
            }
        }
    }
}