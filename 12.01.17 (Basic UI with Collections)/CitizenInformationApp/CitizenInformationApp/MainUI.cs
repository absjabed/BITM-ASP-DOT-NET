using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenInformationApp
{
    public partial class MainUI : Form
    {
        Dictionary<string, string> citizenDictionary = new Dictionary<string, string>();
        public MainUI()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string citizenID = idTextBox.Text;
            string citizenDetails = detailsTextBox.Text;

            citizenDictionary.Add(citizenID,citizenDetails);

            idTextBox.Text = null;
            detailsTextBox.Text = null;
        }
        private void findButton_Click(object sender, EventArgs e)
        {
            string findCitizenID = findIDTextBox.Text;
            if (citizenDictionary.ContainsKey(findCitizenID))
            {
                string value, citizenDetails;
                bool hasValue = citizenDictionary.TryGetValue(findCitizenID, out value);
                if (hasValue)
                {
                    citizenDetails = value;
                    MessageBox.Show("Citizen found!" + "\n" +
                    "ID: "+findCitizenID+"\n"+
                    "Name: "+citizenDetails, "Find Citizen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Citizen info not found!", "Find Citizen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
                }   
            }
            else
            {
                MessageBox.Show("Citizen info not found!", "Find Citizen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            findIDTextBox.Text = null;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> keyValuePair in citizenDictionary)
            {
                citizenInfoListBox.Items.Add(String.Format("{0} - {1}", keyValuePair.Key.ToString(), keyValuePair.Value.ToString()));
            }
        }
    }
}
