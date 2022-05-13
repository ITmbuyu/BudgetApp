using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            double Purchurseprice =0;
            double Totaldeposit = 0;
            double IntrestRate = 0;
            int numberofmonths = 0;
            double rentalamount = 0;
            string Accomendation = " ";

            double GMI = Convert.ToDouble(textBox1.Text);
            double EMT = Convert.ToDouble(textBox2.Text);


            double Egroceries = Convert.ToDouble(textBox3.Text);
            double Ewaterandlights = Convert.ToDouble(textBox4.Text);
            double Etravelcosts = Convert.ToDouble(textBox5.Text);
            double Ecellphone = Convert.ToDouble(textBox6.Text);
            double Eotherexpenses = Convert.ToDouble(textBox7.Text);
            
            

            

            if (comboBox1.SelectedIndex == 0)
            {
                Accomendation = "Renting Accommodation";
                rentalamount = Convert.ToDouble(textBox8.Text);
                ExpensesClass expensesClass = new ExpensesClass(GMI,EMT,Egroceries,Ewaterandlights,Etravelcosts,Ecellphone,Eotherexpenses,Accomendation,rentalamount);
                richTextBox1.Text = expensesClass.ToDisplay();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Accomendation = "Buying A Property";
                Purchurseprice = Convert.ToDouble(textBox9.Text);
                Totaldeposit = Convert.ToDouble(textBox10.Text);
                IntrestRate = Convert.ToDouble(numericUpDown1.Value / 100);
                numberofmonths = Convert.ToInt32(numericUpDown2.Value);
                HomeLoanClass homeLoanClass = new HomeLoanClass(Purchurseprice, Totaldeposit, IntrestRate, numberofmonths, GMI, EMT, Egroceries, Ewaterandlights, Etravelcosts, Ecellphone, Eotherexpenses, Accomendation, rentalamount);
                richTextBox1.Text= homeLoanClass.ToDisplay();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                panel5.Enabled = false;
                panel4.Enabled = true;
               
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                panel4.Enabled = false;
                panel5.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            richTextBox1.Clear();
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
        }
    }
}

