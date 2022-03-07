using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Atm.DBOperations
{
    public class GlobalClass
    {
        public static string accountNum;
        public static string dueDateDisp;
        //runnonquey function-insert update delete
        public void RunNonQuery(string strsql)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnstr"];
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(strsql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //checking account num for transfering amt
        public bool CheckAccountNumber(string accountNum)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnstr"];
            sqlConnection.Open();
            string strsql = "select * from LoginTable where AccountNum=" + accountNum + "";
            SqlCommand sqlCommand = new SqlCommand(strsql,sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bool loginStatus = false;
            if(sqlDataReader.Read())
            {
                loginStatus = true;
            }
            sqlConnection.Close();
            return loginStatus;

        }


        //login to atm account
        public bool CheckLogion(string accountNum, string pinNum)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnstr"];
            sqlConnection.Open();
            string strsql = "select * from  LoginTable where AccountNum=" + accountNum + " and PinNum=" + pinNum + "";
            SqlCommand sqlCommand = new SqlCommand(strsql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bool loginStatus = false;
            if(sqlDataReader.Read())
            {
                loginStatus = true;
            }
            sqlConnection.Close();
            return loginStatus;
        }
        //get the balance amount of logged in user
        public int GetBalance(string accountNum)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnstr"];
            sqlConnection.Open();
            string strsql = "select sum(Deposite)-sum(Withdraw)-sum(Transf) from Transac where AccountNum="+accountNum+"";
            SqlCommand sqlCommand = new SqlCommand(strsql,sqlConnection);
            int balance = int.Parse(sqlCommand.ExecuteScalar().ToString());
            sqlConnection.Close();
            return balance;
        }

        //get ministatement
        public DataSet GetMiniStmt(string accountNum)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnstr"];
            sqlConnection.Open();
            string strsql = "select * from Transac where AccountNum=" + accountNum + "";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strsql, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet,"dt");
            sqlConnection.Close();
            return dataSet;
            
        }

        //show button Mseb
        public bool CheckBill(string billNum, string accountHolder)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnstr"];
            sqlConnection.Open();
            string strsql = "select b.BillNum from Bill b inner join LoginTable l on b.LoginId=l.LoginId where AcccountHolder='"+ accountHolder+ "'";
            SqlCommand sqlCommand = new SqlCommand(strsql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bool billStatus = false;
            while(sqlDataReader.Read())
            {
                if(billNum== sqlDataReader[0].ToString())
                billStatus = true;
            }
            sqlConnection.Close();
            return billStatus;
        }

        //show button return bill amount
        public int GetBillAmnt(string accountHolder)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnstr"];
            sqlConnection.Open();
            string strsql = "select b.BillAmount,b.DueDate from Bill b inner join LoginTable l on b.LoginId=l.LoginId where AcccountHolder='"+ accountHolder+ "'";
            SqlCommand sqlCommand = new SqlCommand(strsql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            int billAmount = 0;
            DateTime dueDate;
            DateTime todaysDate= Convert.ToDateTime(DateTime.Now.ToShortDateString());
            while(sqlDataReader.Read())
            {
                dueDate =Convert.ToDateTime(sqlDataReader[1].ToString());
                dueDateDisp = dueDate.ToShortDateString();
                int res = DateTime.Compare(dueDate,todaysDate);
                if(res<0)
                    billAmount = int.Parse(sqlDataReader[0].ToString())+10;
                if(res>0)
                    billAmount = int.Parse(sqlDataReader[0].ToString()) + 10;
                if (res == 0)
                    billAmount = int.Parse(sqlDataReader[0].ToString());
            }
            sqlConnection.Close();
            return billAmount;
        }

    }
}
