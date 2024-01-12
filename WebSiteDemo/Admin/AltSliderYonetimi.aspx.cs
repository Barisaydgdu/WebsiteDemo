using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteDemo.Admin
{
    public partial class AltSliderYonetimi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmıt_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Value;
            string summaryText = txtSummaryText.Value;
            string fullText = txtFullText.Value;
            string img = "";
            int queue = Convert.ToInt16(txtQueueNo5.Text);

            if (FlIcon.FileName != "")
            {
                string guidKey = Guid.NewGuid().ToString("N").Substring(0, 10);
                FlIcon.SaveAs(Server.MapPath("../Resimler/"  + guidKey + FlIcon.FileName));
                img = guidKey + FlIcon.FileName;
            }

            DAL.AltSlider slider1 = new DAL.AltSlider();
            slider1.aktiflikDurumu = true;
            slider1.OzetMetin = summaryText;
            slider1.TamMetin = fullText;
            slider1.ImgUrl = img;
            slider1.Baslik = title;
            slider1.SiraNo = queue;
            slider1.EklenmeTarihi = DateTime.Now;
            
            new BLL.BLLAltSlider().Ekle(slider1);
            

        }
    }
}