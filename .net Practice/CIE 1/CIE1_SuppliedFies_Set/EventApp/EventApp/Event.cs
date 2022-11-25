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

namespace EventApp
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isGoing, firstName, lastName, email, phoneNumber, SmsNumber, numberOfGuest;
            if (radioButtonYes.Checked)
                isGoing = "Yes";
            else
                isGoing = "No";
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;
            email = textBoxEmail.Text;
            phoneNumber = textBoxPhoneNumber.Text;
            SmsNumber = textBoxSmsNumber.Text;
            numberOfGuest = comboBoxGuest.SelectedItem.ToString();

            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sanjay Sah\\Documents\\EventsCIE1.mdf\";Integrated Security=True;Connect Timeout=30";
            string query = "insert into Participants(first_name, last_name, email, phone_number, sms_number, no_of_guest, is_attending) Values(@firstName, @lastName, @email, @phoneNumber, @smsNumber, @noOfGuests, @isAttending)";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@smsNumber", SmsNumber);
            cmd.Parameters.AddWithValue("@noOfGuests", numberOfGuest);
            cmd.Parameters.AddWithValue("@isAttending", isGoing);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert Successfull");

            
        }
    }
}
