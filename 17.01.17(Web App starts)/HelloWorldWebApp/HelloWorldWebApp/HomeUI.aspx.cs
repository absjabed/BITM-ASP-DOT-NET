using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWebApp
{
    public partial class HomeUI : System.Web.UI.Page
    {

        string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

         string name = nameTextBox.Text;
            //this.name = name;
            //Session["FN"] = name;
            //Application["Name"] = name;
            ViewState["Name"] = name;
            nameTextBox.Text = null;
            
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            //string nameSassion = Session["FN"].ToString();
            //string nameApplication = Application["Name"].ToString();
            string nameViewState = ViewState["Name"].ToString();
            showNameLabel.Text = "Hello, "+nameViewState;
        }
    }
}