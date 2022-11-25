using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class Form1 : Form
    {
        ArrayList items = new ArrayList() {"zebra","Education","Food For All","Freedom of Speech","Good Books","Good Movies" };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void buttonShort_Click(object sender, EventArgs e)
        {
            items.Sort();
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            labelTotalItem.Text = listBox1.Items.Count.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            String selectedItem =  listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(selectedItem);
        }
    }
}
