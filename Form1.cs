using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //total amount of debt the US has to pay off, taken from the box input
            decimal total_debt = decimal.Parse(textBox1.Text);
            //total time in years to pay off the debt
            decimal time_pay_off;
            //there are on average 332 million people in the US
            double population = 332915073;
            //we know each person has to pay $1,000 each year
            int yearly_pay_individual = 1000;

            //to calculate the time to pay off the debt, we take total debt and divide
            //by the total amount of money the US population would pay each year
            time_pay_off = total_debt / (decimal)population * yearly_pay_individual;
            //now let's chenge the text value of the Time To Pay Off textbox
            textBox2.Text = time_pay_off.ToString();
        }
    }
}
