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
        public double num1;
        public double num2;

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
                double result = 0.0;

                num1 = Convert.ToDouble(txtBoxInput1.Text);
                num2 = Convert.ToDouble(txtBoxInput2.Text);

                if(cbOperator.SelectedItem.ToString() == "+")
                {
                    cal.CalculateEvent += (num1, num2) => cal.GetSum(num1, num2);
                    //cal.CalculateEvent += cal.GetSum();
                    lblDisplayTotal.Text = result.ToString();

                }

                // cal.CalculateEvent -= cal.GetSum;

                //cal.CalculateEvent += new Formula<double>(cal.GetSum);

                //lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                // cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }

        }
    }
}
