using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        public double num1, num2;

        public FrmCalculator()
        {
            InitializeComponent();
            listoOperator();
            cal = new CalculatorClass();
        }

        public void listoOperator()
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtBoxInput1.Text) || String.IsNullOrEmpty(txtBoxInput2.Text))
            {
                MessageBox.Show("Please fill in the blank");
            }
            else if (cbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Please select operator");
            }
            else
            {
                num1 = Convert.ToDouble(txtBoxInput1.Text);
                num2 = Convert.ToDouble(txtBoxInput2.Text);

                if(cbOperator.SelectedItem.ToString() == "+")
                {
                    cal.CalculateEvent += new Formula(cal.GetSum); 
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString(); 
                    cal.CalculateEvent -= new Formula(cal.GetSum);
                }
                else if(cbOperator.SelectedItem.ToString() == "-")
                {
                    cal.CalculateEvent += new Formula(cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula(cal.GetDifference);
                }
                else if (cbOperator.SelectedItem.ToString() == "*")
                {
                    cal.CalculateEvent += new Formula(cal.GetProduct);
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula(cal.GetProduct);
                }
                else if (cbOperator.SelectedItem.ToString() == "/")
                {
                    cal.CalculateEvent += new Formula(cal.GetQuotient);
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula(cal.GetQuotient);
                }
            }
        }
    }
}
