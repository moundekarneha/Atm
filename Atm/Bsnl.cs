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
    public partial class Bsnl : Form
    {
        public Bsnl()
        {
            InitializeComponent();
        }

        GlobalClass globalClass = new GlobalClass();

        //checking empty fields
        private bool CheckEnterText()
        {
            if (txtBillNum.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {    if(CheckEnterText())
                {
                    //account number should be valid
                    globalClass.CheckAccountNumber("501");
                    //checking balance before transfer
                    int balance = globalClass.GetBalance(GlobalClass.accountNum);
                    if (balance >= int.Parse(txtAmount.Text))
                    {
                        globalClass.RunNonQuery("insert into Transac values(" + GlobalClass.accountNum + ",'" + DateTime.Now.ToShortDateString() + "',0," + txtAmount.Text + ",0)");
                        globalClass.RunNonQuery("insert into Transac values(" + 502 + ",'" + DateTime.Now.ToShortDateString() + "'," + txtAmount.Text + ",0,0)");
                        MessageBox.Show("Amount Paid");
                        txtAmount.Text = "";
                        txtBillNum.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Bill Number");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insufficient Funds");
                txtBillNum.Text = "";
                txtAmount.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainClass mainClass = new MainClass();
            mainClass.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (CheckEnterText())
            {
                if (globalClass.CheckBill(txtBillNum.Text, "Bsnl"))
                {
                    int billAmount = globalClass.GetBillAmnt("Bsnl");
                    txtAmount.Text = billAmount.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Bill Number");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Bill Number");
            }
        }
    }
}
