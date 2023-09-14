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
        public FrmCalculator()
        {
            InitializeComponent();
            listoOperator();
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

            }

        }
    }
}
