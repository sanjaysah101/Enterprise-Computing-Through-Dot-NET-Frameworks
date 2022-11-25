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

namespace AccountApp
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String name, city, conString, query;
            name = textBoxName.Text;
            city = textBoxCity.Text;
            conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Documents\\CIE2.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            query = "Insert into Customer (CustName, CustCity) Values(@name, @city)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added Successfully");

        }
    }
}
