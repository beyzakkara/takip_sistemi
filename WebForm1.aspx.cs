using ClassLibrary17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace haftalıkKuaförTakipSistemi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GirisModel m3 = new GirisModel();
            m3.tcno = TextBox1.Text;
            m3.sifre = TextBox2.Text;

            if (CheckBox1.Checked == true)
                Response.Redirect("https://localhost:44328/WebForm2");
            else
                Response.Redirect("https://localhost:44328/WebForm2");


            /*yetki m = new yetki();
            m.tcno = TextBox1.Text;
            m.sifre = TextBox2.Text;
            if (m.tcno == "12345678910" && m.sifre == "1234")
            {
                
            }


            else
            {
                Label1.Text = "TC NO VEYA SİFRE HATALI";
                }*/
            
          

           
           
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            callcenter c = new callcenter();
          
        }
    }
}