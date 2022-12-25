using ClassLibrary17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace haftalıkKuaförTakipSistemi
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // URL+"?yBilgi=test"
            string yBilgi = Request.QueryString["yBilgi"];
          
            if (Session["randevuListesi"] != null)
            {
                List<Randevu> liste = Session["randevuListesi"] as List<Randevu>;
                if (liste.Count() > 0)
                {
                    lblIslemTur.Text = liste.FirstOrDefault().islemtürü;
                    lblRndGun.Text = liste.FirstOrDefault().gün;
                    lblrndSaat.Text = liste.FirstOrDefault().saat.ToString();
                    lblToplamFiyat.Text = Session["toplamTutar"].ToString() + "₺";
                    lblIndirimOrani.Text = "% "+Session["indirimOrani"].ToString();
                    lblGenelToplam.Text = Session["genelToplam"].ToString() + "₺";
                }
            }
        }
    }
}