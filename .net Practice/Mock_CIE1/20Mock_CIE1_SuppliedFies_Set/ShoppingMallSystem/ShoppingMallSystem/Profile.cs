using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShoppingMallSystem
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name, comment, organization;
            name = textBoxName.Text;
            comment = textBoxComment.Text;
            organization = textBoxOrganization.Text;
            LabelMessageShow.Text = String.Format("Message of {0} from {1} with {2}", name, comment, organization);
        }
    }
}
