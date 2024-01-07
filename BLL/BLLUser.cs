using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace BLL
{
    public class BLLUser
    {
        public bool KullaniciAdiKulaniliyorMu(string email)
        {
            DAL.webSiteDemoEntities1 vt = new DAL.webSiteDemoEntities1();
            var kullanici = vt.User.Where(p => p.Email == email).ToList();
            if (kullanici.Count> 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool KullaniciEkle(DAL.User User)
        {
            DAL.webSiteDemoEntities1 vt = new DAL.webSiteDemoEntities1();
            vt.User.Add(User);
            vt.SaveChanges();
            return true;
        }
    }
}