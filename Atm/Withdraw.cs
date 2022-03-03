using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atm.DBOperations;

namespace Atm
{
    public partial class Withdraw : Form
    { 
        //checking empty fields
        private bool CheckEnterText()
        {
            if (txtAmountWithdraw.Text == "")
            {
                return false;
            }
            return true;
        }
        public Withdraw()
        {
            InitializeComponent();
        }
        GlobalClass globalClass = new GlobalClass();
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if(CheckEnterText())
                {
                    string strsql = "insert into Transac values(" + GlobalClass.accountNum + ",'" + DateTime.Now.ToShortDateString() + "',0," + txtAmountWithdraw.Text + ",0)";
                    globalClass.RunNonQuery(strsql);
                    MessageBox.Show("Amount Withdrawed");
                    txtAmountWithdraw.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Enter Amount To Withdraw");
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainClass mainClass = new MainClass();
            mainClass.Show();
            this.Hide();
        }
    }
}
