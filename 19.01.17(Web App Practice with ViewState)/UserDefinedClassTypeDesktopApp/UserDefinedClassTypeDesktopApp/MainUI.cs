using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserDefinedClassTypeDesktopApp
{
    public partial class MainUI : Form
    {
        List<Person> persons = new List<Person>();

        public MainUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();

            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;

            persons.Add(aPerson);

            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {

            personListBox.Items.Clear();

            foreach (Person person in persons)
            {
                personListBox.Items.Add(person.GetFullName());
            }

        }
    }
}
