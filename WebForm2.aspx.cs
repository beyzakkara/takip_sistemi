using ClassLibrary17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace haftalıkKuaförTakipSistemi
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Randevu m = new Randevu();
        CheckBox cbSacKesimi, cbSacBoyama, cbKasIslemi, cbBirinciIslem, cbIkinciIslem, cbUcuncuIslem;
        int toplam = 0;
        List<string> sehirler = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            cbSacKesimi = CheckBox4;
            cbSacKesimi.Attributes.Add("fiyat", "1000");

            cbSacBoyama = CheckBox5;
            cbSacBoyama.Attributes.Add("fiyat", "400");

            cbKasIslemi = CheckBox6;
            cbKasIslemi.Attributes.Add("fiyat", "500");

            cbBirinciIslem = CheckBox7;
            cbBirinciIslem.Attributes.Add("indirim", "10");

            cbIkinciIslem = CheckBox8;
            cbIkinciIslem.Attributes.Add("indirim", "15");

            cbUcuncuIslem = CheckBox9;
            cbUcuncuIslem.Attributes.Add("indirim", "20");
            //if(!Page.IsPostBack)
            //{
            //    sehirler.AddRange(new[] { "Muğla", "İstanbul", "Ankara" });
            //}
           
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            Randevu m = new Randevu();
            m.islemfiyati = 100;
            toplam += m.islemfiyati;



        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {



        }
        /*static public List<ClassLibrary17.randevu>list_randevu = new List<ClassLibrary17.randevu>(); */
        List<Randevu> randevuListesi = new List<Randevu>();
        protected void Button1_Click(object sender, EventArgs e)
        {

            Randevu m = new Randevu();
            m.ad = TextBox3.Text;
            m.soyad = TextBox4.Text;
            m.gün = TextBox5.Text;
            m.saat = int.Parse(TextBox7.Text);
            m.islemsayisi = 1;
            string islemTuru = CheckBox4.Checked ? CheckBox4.Text : "";
            islemTuru += (CheckBox5.Checked ? CheckBox5.Text : "") + " - ";
            islemTuru += (CheckBox6.Checked ? CheckBox6.Text : "") + " - ";
            m.islemtürü = islemTuru;
            m.RandevuOlustur(m);


            //list_randevu.Add(m); 
            Label10.Text = m.islemfiyati.ToString();
            randevuListesi.Add(m);
            Session["randevuListesi"] = randevuListesi;
            Response.Redirect("https://localhost:44328/WebForm3?xBilgi=deneme");

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {

            m.islemsayisi = 2;
        }

        protected void btnSehirekle_Click(object sender, EventArgs e)
        {
            //sehirler.Add(txtSehirAdi.Text);
            // a = "";
        }

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            // randevu m = new randevu();
            m.islemsayisi = 1;

        }

        protected void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            //randevu m = new randevu();
            m.islemsayisi = 3;
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            // randevu m = new randevu();
            m.islemfiyati = 200;
            toplam += m.islemfiyati;
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            // randevu m = new randevu();
            m.islemfiyati = 700;
            toplam += m.islemfiyati;
        }

        protected void btnHesapla_Click(object sender, EventArgs e)
        {
            int sacBoyamaFiyat = int.Parse(cbSacBoyama.Attributes["fiyat"]);
            int kasIslemleriFiyat = int.Parse(cbKasIslemi.Attributes["fiyat"]);
            int sacKesimiFiyat = int.Parse(cbSacKesimi.Attributes["fiyat"]);

            int birinciIslemIndirim = int.Parse(cbBirinciIslem.Attributes["indirim"]);
            int ikinciIslemIndirim = int.Parse(cbIkinciIslem.Attributes["indirim"]);
            int ucuncuIslemIndirim = int.Parse(cbUcuncuIslem.Attributes["indirim"]);

            int toplamFiyat = 0;
            if (cbSacBoyama.Checked)
                toplamFiyat += sacBoyamaFiyat;
            if (cbKasIslemi.Checked)
                toplamFiyat += kasIslemleriFiyat;
            if (cbSacKesimi.Checked)
                toplamFiyat += sacKesimiFiyat;

            Session["toplamTutar"] = toplamFiyat;

            if (cbBirinciIslem.Checked)
            {
                toplamFiyat = (toplamFiyat - ((toplamFiyat * birinciIslemIndirim) / 100));
                Session["indirimOrani"] = birinciIslemIndirim.ToString();
            }
            if (cbIkinciIslem.Checked)
            {
                toplamFiyat = (toplamFiyat - ((toplamFiyat * ikinciIslemIndirim) / 100));
                Session["indirimOrani"] = ikinciIslemIndirim.ToString();
            }
            if (cbUcuncuIslem.Checked)
            {
                toplamFiyat = (toplamFiyat - ((toplamFiyat * ucuncuIslemIndirim) / 100));
                Session["indirimOrani"] = ucuncuIslemIndirim.ToString();
            }


            //int sayi = 1 > 5 ? 3 : 2;
            //
            //if(1>5)
            //{
            //
            //}
            //else{
            //
            //}

            Session["genelToplam"] = toplamFiyat;
            lblToplamFiyat.Text = toplamFiyat.ToString() + "₺";
        }
    }
}