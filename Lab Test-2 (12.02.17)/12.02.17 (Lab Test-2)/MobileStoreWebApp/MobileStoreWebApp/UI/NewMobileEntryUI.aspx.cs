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
    public partial class NewMobileEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        MobileManager mobileManager = new MobileManager();
        protected void saveButton_Click(object sender, EventArgs e)
        {
            MobilePhone aMobilePhone;
            string model = modelNameTextBox.Text;
            string IMEI = IMEInumberTextBox.Text;
            decimal price = Convert.ToDecimal(priceTextBox.Text);

            if (modelNameTextBox.Text == string.Empty || IMEInumberTextBox.Text == string.Empty ||
                priceTextBox.Text == string.Empty)
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "Any textbox can not be kept empty!";
            }
            else
            {
                if (IMEI.Length != 15)
                {
                    messageLabel.ForeColor = System.Drawing.Color.Red;
                    messageLabel.Text = "The IMEI number must be 15 charecters!";
                    IMEInumberTextBox.Focus();
                }
                else
                {
                    bool isExists = mobileManager.IsExists(IMEI);

                    if (!isExists)
                    {
                        aMobilePhone = new MobilePhone(model, IMEI, price);
                        int row = mobileManager.SaveMobile(aMobilePhone);

                        if (row>0)
                        {
                            messageLabel.ForeColor = System.Drawing.Color.Green;
                            messageLabel.Text = "Successfully Saved!";
                            modelNameTextBox.Text = string.Empty;
                            IMEInumberTextBox.Text = string.Empty;
                            priceTextBox.Text = string.Empty;
                        }
                        else
                        {
                            messageLabel.ForeColor = System.Drawing.Color.Red;
                            messageLabel.Text = "Failed saving new Mobile!";
                            modelNameTextBox.Text = string.Empty;
                            IMEInumberTextBox.Text = string.Empty;
                            priceTextBox.Text = string.Empty;
                        }

                    }
                    else
                    {
                        messageLabel.ForeColor = System.Drawing.Color.Red;
                        messageLabel.Text = "This IMEI number already exists!";
                        modelNameTextBox.Text = string.Empty;
                        IMEInumberTextBox.Text = string.Empty;
                        priceTextBox.Text = string.Empty;
                    }
                }
            }
            
           

        }
    }
}