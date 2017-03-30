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
    public partial class SearchMobilePriceUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        MobileManager mobileManager = new MobileManager();

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string imei = imeiTextBox.Text;

            if (imei.Length != 15 || imeiTextBox.Text == string.Empty)
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "IMEI number must be 15 charecters </br> The textbox is empty </br> No match found!";
            }
            else
            {
                MobilePhone mobile = mobileManager.getByImei(imei);
                if (mobile == null)
                {
                    messageLabel.ForeColor = System.Drawing.Color.Red;
                    messageLabel.Text = "No mobile Found with this IMEI number!";
                }else
                {
                    modelNameLabel.Text = mobile.ModelName;
                    imeiLabel.Text = mobile.IMEI;
                    priceLabel.Text = mobile.Price.ToString();
                    messageLabel.ForeColor = System.Drawing.Color.Green;
                    messageLabel.Text = "Found a Mobile!";
                }
            }
        }

    }
}