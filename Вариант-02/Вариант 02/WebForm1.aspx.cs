using Option02.Core;
using Option02.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Вариант_02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ApplicantAddressRepository Repo = new ApplicantAddressRepository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            ApplicantAddress Address = new ApplicantAddress
            {
                
            Край_Область = TextBox1.Text,
                город = TextBox2.Text,
                район = TextBox3.Text,
                Address1 = TextBox4.Text,
                Address2 = TextBox5.Text,
                Address3 = TextBox6.Text,
                Address4 = TextBox7.Text
                
                
                     

            };
            Repo.Add(Address);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Adress1"] = TextBox4.Text;
            Session["Adress2"] = TextBox5.Text;
            Session["Adress3"] = TextBox6.Text;
            Session["Adress4"] = TextBox7.Text;
            Session["City"] = TextBox2.Text;
            Response.Redirect("~/WebForm2.aspx");




        }
    }
}