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
    public partial class Deposite : Form
    {
        public Deposite()
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
            if (txtDepositeAmount.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnDeposite_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEnterText())
                {
                    string strsql = "insert into Transac values(" + GlobalClass.accountNum + ",'" + DateTime.Now.ToShortDateString() + "'," + txtDepositeAmount.Text + ",0,0)";
                    globalClass.RunNonQuery(strsql);
                    MessageBox.Show("Amount Deposited");
                    txtDepositeAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Enter Amount For Deposite");
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void txtDepositeAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
