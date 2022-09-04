using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Net.Mime.MediaTypeNames;

namespace Login_Form
{
    public partial class SignInForm : Form
    {
        
        
        string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Documents\\crud.mdf\";Integrated Security=True;Connect Timeout=30";
        public SignInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:  
                    textBoxPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    textBoxPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Documents\\crud.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            if(textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from UserTable where name=@name and password=@pass", conn);
                cmd.Parameters.AddWithValue("@name", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    MessageBox.Show("login success", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dr.Close();

                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Wrong Email or Password", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please fill both field", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            /*;
            
            ;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text))
            {
                textBoxUsername.Focus();
                errorProvider1.SetError(this.textBoxUsername, "Please fill the username");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Focus();
                errorProvider2.SetError(this.textBoxPassword, "Please fill the username");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
