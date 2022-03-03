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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainClass mainClass = new MainClass();
            mainClass.Show();
            this.Hide();
        }
        GlobalClass globalClass = new GlobalClass();
        //checking empty fields
        private bool CheckEnterText()
        {
            if (txtAmountTransfer.Text == "" || txtTransferToAccount.Text=="")
            {
                return false;
            }
            return true;
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEnterText())
                {
                    //account number should be valid
                    globalClass.CheckAccountNumber(txtTransferToAccount.Text);
                    //checking balance before transfer
                    int balance = globalClass.GetBalance(GlobalClass.accountNum);
                    if (balance >= int.Parse(txtAmountTransfer.Text))
                    {
                        globalClass.RunNonQuery("insert into Transac values(" + GlobalClass.accountNum + ",'" + DateTime.Now.ToShortDateString() + "',0,0," + txtAmountTransfer.Text + ")");
                        globalClass.RunNonQuery("insert into Transac values(" + txtTransferToAccount.Text + ",'" + DateTime.Now.ToShortDateString() + "'," + txtAmountTransfer.Text + ",0,0)");
                        MessageBox.Show("Amount Transfered");
                        txtAmountTransfer.Text = "";
                        txtTransferToAccount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Funds");
                        txtAmountTransfer.Text = "";
                        txtTransferToAccount.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill Information");
                }
                
            }
            catch (Exception)
            {
            }
        }
    }
}
