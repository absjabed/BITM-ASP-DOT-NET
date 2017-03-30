using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{

    //public struct personalInformation
    //{
    //    private string firstName, lastName, fathersName, mothersName, address;

    //    public personalInformation(string receivedFirstName, string receivedLastName, string receivedFathersName, string receivedMothersName,
    //        string receivedAddress)
    //    {
    //        firstName = receivedFirstName;
    //        lastName = receivedLastName;
    //        fathersName = receivedFathersName;
    //        mothersName = receivedMothersName;
    //        address = receivedAddress;

    //    }
    //}


    public partial class MainUI : Form
    {

        string firstName, lastName, fathersName, mothersName, address;
        //private personalInformation personalInformationNode;
       
        public MainUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //string firstName, lastName, fathersName, mothersName, address;


            this.firstName = firstNameTextBox.Text;
            this.lastName = lastNameTextBox.Text;
            this.fathersName = fathersNameTextBox.Text;
            this.mothersName = mothersNameTextBox.Text;
            this.address  = addressTextBox.Text;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }

        }

        private void showInformationButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = this.firstName;
            lastNameTextBox.Text = this.lastName;
            fathersNameTextBox.Text = this.fathersName;
            mothersNameTextBox.Text = this.mothersName;
            addressTextBox.Text = this.address;

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
            firstNameTextBox.Text = this.firstName;
            lastNameTextBox.Text = this.lastName;

        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
            fathersNameTextBox.Text = this.fathersName;
            mothersNameTextBox.Text = this.mothersName;
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
            addressTextBox.Text = this.address;
        }
    }
}
