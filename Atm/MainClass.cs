using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm
{
    public partial class MainClass : Form
    {
        public MainClass()
        {
            InitializeComponent();
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            Deposite deposite = new Deposite();
            deposite.Show();
            this.Hide();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void btnMseb_Click(object sender, EventArgs e)
        {
            Mseb mseb = new Mseb();
            mseb.Show();
            this.Hide();
        }

        private void btnBsnl_Click(object sender, EventArgs e)
        {
            Bsnl bsnl = new Bsnl();
            bsnl.Show();
            this.Hide();
        }

        private void btnLic_Click(object sender, EventArgs e)
        {
            Lic lic = new Lic();
            lic.Show();
            this.Hide();
        }

        private void btnMinistatement_Click(object sender, EventArgs e)
        {
            Ministatement ministatement = new Ministatement();
            ministatement.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
