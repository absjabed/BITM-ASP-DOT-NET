using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefinedClassTypeWebApp
{
    
    public partial class MainUI : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            List<Person> personList = (List<Person>)ViewState["Jamil"];
            foreach (Person person in personList)
            {
                personListBox.Items.Add(person.GetFullName());
            }

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<Person> persons;
            Person aPerson = new Person();

            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;


            if (ViewState["Jamil"] == null)
            {
                persons = new List<Person>();
            }
            else
            {
                persons = (List<Person>)ViewState["Jamil"];
            }


            firstNameTextBox.Text = null;
            middleNameTextBox.Text = null;
            lastNameTextBox.Text = null;


            persons.Add(aPerson);

            ViewState["Jamil"] = persons;
        }
    }
}