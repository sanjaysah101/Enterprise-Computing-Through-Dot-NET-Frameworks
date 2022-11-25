using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountApp
{
    public partial class Account : Form
    {
        String connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Downloads\\.net Practice\\CIE 2\\CIE2_SuppliedFies_Set-3\\AccountApp\\AccountApp\\CIE2.mdf\";Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;


        public Account()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
            conn.Open();
            bindData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int acctId, custId, balance, dailyLimit;
            
            custId = Convert.ToInt32(comboBoxCustId.Text);
            balance = Convert.ToInt32(textBoxBalance.Text);
            dailyLimit = Convert.ToInt32(textBoxDailyLimit.Text);
            string query = "insert into Accounts(CustId, Balance, DailyWithLimit) values (@custId, @balance, @dailyLimit)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@custId", custId);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@dailyLimit", dailyLimit);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Inserted Successful");

        }
        private void bindData()
        {
           
            string query = "select CustId from Customer";
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxCustId.Items.Add(reader[0].ToString());
            }
            reader.Close();            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            string query = "delete from Accounts where AcctId = @id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxAccId.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "select * from Accounts where AcctId = @id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxAccId.Text));
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                textBoxBalance.Text = reader["Balance"].ToString();
                textBoxDailyLimit.Text = reader["DailyWithLimit"].ToString();
                if (reader["CustId"] == null)
                {
                    comboBoxCustId.Text = "";
                }
                else
                {
                    comboBoxCustId.Text = reader["CustId"].ToString();
                }
            }
            reader.Close();

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            string query = "select Customer.CustId, Customer.CustName, Accounts.AcctId, Accounts.Balance, " +
                "Accounts.DailyWithLimit from Accounts Inner Join Customer on Accounts.CustId = Customer.CustId";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
