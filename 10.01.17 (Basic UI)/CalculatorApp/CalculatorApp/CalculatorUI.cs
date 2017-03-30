using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result;

            result = Add(firstNumber, secondNumber);
            resultNumberTextBox.Text = result.ToString();
        }

        private double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result;

            result = Subtract(firstNumber, secondNumber);
            resultNumberTextBox.Text = result.ToString();

        }

        private double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result;

            result = Multiply(firstNumber, secondNumber);
            resultNumberTextBox.Text = result.ToString();

        }

        private double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result;

            if (Convert.ToInt32(secondNumberTextBox.Text) == 0)
            {
                resultNumberTextBox.Text = "Cannot divide by zero!";
            }
            else
            {
                result = Divide(firstNumber, secondNumber);
                resultNumberTextBox.Text = result.ToString();              
            }
  

        }

        private double Divide(double firstNumber, double secondNumber)
        {
            
            return firstNumber / secondNumber;
        }
    }
}
