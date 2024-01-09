using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class BllUserLog
    {
        public bool AddLog(DAL.UserLog logkayitlari)
        {
            DAL.webSiteDemoEntities1 vt = new DAL.webSiteDemoEntities1();
            vt.UserLog.Add(logkayitlari);
            vt.SaveChanges();
            return true;
        }
    }
}