using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockerWinforms
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbNom_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbNom.Text))
                label1.Show();
            else
                label1.Hide();
        }

        private void txtbEmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbEmail.Text))
                label2.Show();
            else
                label2.Hide();
        }

        private void txtbLocation_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbLocation.Text))
                label3.Show();
            else
                label3.Hide();
        }

        private void txtbPhone_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbPhone.Text))
                label4.Show();
            else
                label4.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtbEmail.Text = "";
            txtbNom.Text = "";
            txtbPhone.Text = "";
            txtbLocation.Text = "";
        }
    }
}
