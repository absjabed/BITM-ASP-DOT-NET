using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileStoreWebApp.BLL;
using MobileStoreWebApp.Model;

namespace MobileStoreWebApp.UI
{
    public partial class SearchMobileIMEI_UI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowMobilesList();
            }

        }
        MobileManager mobileManager = new MobileManager();
        protected void searchButton_Click(object sender, EventArgs e)
        {
           

            if (startingPriceTextBox.Text == string.Empty || endingPriceTextBox.Text ==string.Empty) 
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "Any textbox can not be kept empty!";
            }
            else
            {

                decimal startingPrice = Convert.ToDecimal(startingPriceTextBox.Text);
                decimal endingPrice = Convert.ToDecimal(endingPriceTextBox.Text);
                List<MobilePhone> mobilePhones = mobileManager.SearchMobilePrice(startingPrice, endingPrice);

                if (mobilePhones == null)
                {
                    messageLabel.ForeColor = System.Drawing.Color.Red;
                    messageLabel.Text = "No Mobile Phone Found in this range!";
                }else
                {
                    messageLabel.ForeColor = System.Drawing.Color.Green;
                    messageLabel.Text = "Found!";
                    mobileGridView.DataSource = mobilePhones;
                    mobileGridView.DataBind();
                }
                
                
            }
        }

        private void ShowMobilesList()
        {
            List<MobilePhone> phones = new List<MobilePhone>();
            phones =mobileManager.GetMobiles();
            mobileGridView.DataSource = phones;
            mobileGridView.DataBind();
        }
    }
}