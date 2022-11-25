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

namespace OrderEntery
{
    public partial class orderEntery : Form
    {
        String ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sanjay Sah\Documents\orderEnteryDb.mdf"";Integrated Security=True;Connect Timeout=30";
        public orderEntery()
        {
            InitializeComponent();
        }

        

        private void orderEntery_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);
            con.Open();
            string query = "insert into Product values(@ID, @Name, @Category, @Price, @Quantity,@Date)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Category", textBox3.Text);
            cmd.Parameters.AddWithValue("@Price", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Date", DeliveryDatePicker.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Enter ");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);
            con.Open();
            String query = "Select * from Product where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                textBox2.Text = dr.GetValue(1).ToString(); // textBox2.Text = dr["Name"].ToString();
                textBox3.Text = dr["Category"].ToString();
                textBox4.Text = dr["Price"].ToString();
                textBox5.Text = dr["Quantity"].ToString();
                DeliveryDatePicker.Text = dr["DeliveryDate"].ToString();

            }
            con.Close();
            
        }
    }
}
