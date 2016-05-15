using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class Form1 : Form // start class
    {
        Account account = new Account(); // new account object
        double withdrawlAmount = 0;// variable declerations
        double depositAmount = 0;
        double clacIntRate = 0;
        double earnedInterest = 0;
        double newBal = 0;
        // array creation
        string[] accountArray = new string[5] { "A2W31234", "H123Ed12", "ZWE12345", "S12987GH", "A154R56" };

        public Form1()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)// withdrawl event
        {
             if(withdrawlAmount < account.Balance) // checks to make sure there is enough money for the withdrawl
            {
                withdrawlAmount = double.Parse(textBox1.Text.ToString()); // takes the value from textbox for the withdrawl amount
                newBal = withdrawlAmount - account.Balance; // changes the value of balance
                account.Balance = newBal;
                textBox2.Text = newBal.ToString("C");
                account.NumOfTransactions += 1;
            }
            else
             {
                 MessageBox.Show("You dont Have enough money in your account"); // message if not enough money
             }
        }

        private void button2_Click(object sender, EventArgs e) // deposit event
        {
            depositAmount = double.Parse(textBox1.Text.ToString());
            newBal = depositAmount + account.Balance;
            account.Balance = newBal;
            textBox2.Text = account.Balance.ToString("C");
            account.NumOfTransactions += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = account.Balance.ToString("C");
            account.NumOfTransactions += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            account.NumOfTransactions += 1;
            textBox2.Text = account.NumOfTransactions.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            earnedInterest = account.Balance / account.InterestRate;
            textBox2.Text = earnedInterest.ToString();
            account.NumOfTransactions += 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clacIntRate = account.Balance * account.InterestRate;
            textBox2.Text = clacIntRate.ToString("C");
            account.Balance = clacIntRate;
            account.NumOfTransactions += 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            account.Balance = double.Parse(textBox3.Text.ToString());
            account.NumOfTransactions += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < accountArray.Length; i++)
            {
                foreach(string st in accountArray)
                 listBox1.Items.Add(accountArray[i]);
            }
        }
    }
}
