using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
            textBoxYear.Focus();
        }

        private void textBoxYear_Enter(object sender, EventArgs e)
        {
            textBoxYear.SelectAll();
        }

        private void textBoxMonth_Enter(object sender, EventArgs e)
        {
            textBoxMonth.SelectAll();
        }

        private void textBoxDay_Enter(object sender, EventArgs e)
        {
            textBoxDay.SelectAll();
        }

        private void checkDateButton_Click(object sender, EventArgs e)
        {
            bool isValid = DateValidator.Validate(textBoxYear.Text, textBoxMonth.Text, textBoxDay.Text);

            if (isValid)
            {
                labelResult.ForeColor = Color.Green;
                labelResult.Text = "Valid";
                toolTipResult.SetToolTip(labelResult, "Entered Date is Valid");
            }
            else
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Invalid";
                toolTipResult.SetToolTip(labelResult, "Entered Date is NOT Valid");
            }
        }
    }
}
