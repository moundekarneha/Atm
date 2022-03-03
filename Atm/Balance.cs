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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        GlobalClass globalClass = new GlobalClass();
        
        // check balance amount
        private void btnBalance_Click(object sender, EventArgs e)
        {
            try
            {
                int balance=globalClass.GetBalance(GlobalClass.accountNum);
                txtBalance.Text = balance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
