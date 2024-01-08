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
            if (sonuc.Count>0)
            {
                lblUserMessage.Text = "Giriş Başarılı.";
            }
            else
            {
                lblUserMessage.Text = "Kullanıcı Adı veya Şifre Hatalı.";
            }
        }
    }
}