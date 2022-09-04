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

namespace CRUD_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Documents\\crud.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTable values (@ID, @Name, @Age, @Email, @Password)", conn);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textId.Text));
            cmd.Parameters.AddWithValue("@Name", textName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textAge.Text));
            cmd.Parameters.AddWithValue("@Email", textEmail.Text);
            cmd.Parameters.AddWithValue("@Password", textPassword.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Saved");

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Documents\\crud.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update UserTable set Name = @Name, Age = @Age where ID = @ID", conn);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textId.Text));
            cmd.Parameters.AddWithValue("@Name", textName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textAge.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Saved");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Documents\\crud.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete UserTable where ID = @ID", conn);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textId.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted Sucessfull");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Documents\\crud.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTable where Id=@IDs", conn);
            cmd.Parameters.AddWithValue("@IDs", int.Parse(textId.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}