using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Response.Write("Hello, World!");
            Response.Write("<br>"+"Hello everyone!");

            for (int i = 1; i < 11; i++)
            {
                Response.Write("<br>" + i);
            }

            showButton.Text = "Done!";

        }
    }
}