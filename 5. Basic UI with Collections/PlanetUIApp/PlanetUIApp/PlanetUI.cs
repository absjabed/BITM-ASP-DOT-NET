using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetUIApp
{
    public partial class PlanetUI : Form
    {
        public PlanetUI()
        {
            InitializeComponent();
        }

        private void showPlanetButton_Click(object sender, EventArgs e)
        {
            string planetName = planetComboBox.Text;
            if (planetName == "Planet")
            {
                MessageBox.Show("It is in 3rd position");
            }
            else if (planetName == "Saturn")
            {
                MessageBox.Show("It is in 6th position");
            }
            else if (planetName == "Mars")
            {
                MessageBox.Show("It is in 4th position");
            }
            else
            {
                MessageBox.Show("I don’t know");
            }
        }
    }
}