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
    public partial class Mseb : Form
    {
        public Mseb()
        {
            InitializeComponent();
        }

        GlobalClass globalClass = new GlobalClass();

        // check empty fields
        private bool CheckEnterText()
        {
            if(txtBillNum.Text=="")
            {
                return false;
            }
            return true;
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {   if(CheckEnterText())
                {
                    //account number should be valid
                    globalClass.CheckAccountNumber("501");
                    //checking balance before transfer
                    int balance = globalClass.GetBalance(GlobalClass.accountNum);
                    if (balance >= int.Parse(txtAmount.Text))
                    {
                        globalClass.RunNonQuery("insert into Transac values(" + GlobalClass.accountNum + ",'" + DateTime.Now.ToShortDateString() + "',0," + txtAmount.Text + ",0)");
                        globalClass.RunNonQuery("insert into Transac values(" + 501 + ",'" + DateTime.Now.ToShortDateString() + "'," + txtAmount.Text + ",0,0)");
                        MessageBox.Show("Amount Paid");
                        txtAmount.Text = "";
                        txtBillNum.Text = "";
                        txtDueDate.Text = "";
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
                txtDueDate.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainClass mainClass = new MainClass();
            mainClass.Show();
            this.Hide();
        }

        //will return bill amount after validating bill number
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (CheckEnterText())
            {
                if (globalClass.CheckBill(txtBillNum.Text, "Mseb"))
                {
                    int billAmount = globalClass.GetBillAmnt("Mseb");
                    txtAmount.Text = billAmount.ToString();
                    txtDueDate.Text = GlobalClass.dueDateDisp;
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
