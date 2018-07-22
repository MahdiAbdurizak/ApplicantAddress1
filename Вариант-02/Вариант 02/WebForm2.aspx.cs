using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Вариант_02
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAddress1.Text = Session["Adress1"].ToString();
            lblAddress2.Text = Session["Adress2"].ToString();
            lblAddress3.Text = Session["Adress3"].ToString();
            lblAddress4.Text = Session["Adress4"].ToString();
            lblГород.Text = Session["City"].ToString();





        }
    }
}