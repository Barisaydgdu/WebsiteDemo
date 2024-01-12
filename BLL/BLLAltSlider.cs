using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class BLLAltSlider
    {
        public List<DAL.AltSlider> List()
        {
            DAL.webSiteDemoEntities1 vt = new DAL.webSiteDemoEntities1();
            return vt.AltSlider.Where(p=>p.aktiflikDurumu == true).ToList();

        }
        public bool Ekle(DAL.AltSlider degerler)
        {
            DAL.webSiteDemoEntities1 vt = new DAL.webSiteDemoEntities1 ();
            vt.AltSlider.Add(degerler);
            vt.SaveChanges();
            return true;
        }
        public bool Sil(DAL.AltSlider degerler)
        {
            DAL.webSiteDemoEntities1 vt = new DAL.webSiteDemoEntities1();
            var deger = vt.AltSlider.Where(p => p.AltSliderID ==  degerler.AltSliderID).SingleOrDefault();
            deger.aktiflikDurumu = false;
            vt.SaveChanges();
            return true;
        }
    }
}