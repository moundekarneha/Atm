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
    public partial class Ministatement : Form
    {
        public Ministatement()
        {
            InitializeComponent();
        }
        GlobalClass globalClass = new GlobalClass();
        private void btnMiniStmt_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet = globalClass.GetMiniStmt(GlobalClass.accountNum);
            dataGridMinistmt.DataSource = dataSet.Tables["dt"];

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainClass mainClass = new MainClass();
            mainClass.Show();
            this.Hide();
        }

        private void Ministatement_Load(object sender, EventArgs e)
        {

        }
    }
}
