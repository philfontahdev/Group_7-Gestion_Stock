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
    public partial class FrmLogin : Form
    {
        private bool ExitApp = true;
        public FrmLogin()
        {
            InitializeComponent();
            txtbEmail.Text = "ainapetula@gmail.com";
            txtbMDP.Text = "20005";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //txtbEmail.BorderStyle = ButtonBorderStyle.Dotted;
        }
        private bool IsAuthenticate()
        {
            return txtbEmail.Text.Equals("ainapetula@gmail.com", StringComparison.OrdinalIgnoreCase) && txtbMDP.Text.Equals("20005");
        }

        private void txtbMDP_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbMDP.Text))
            {
                label2.Show();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }                
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                label2.Hide();
            }
        }

        private void txtbEmail_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbEmail.Text))
                label1.Show();
            else
                label1.Hide();

            if (txtbEmail.Text.Contains("") && txtbEmail.Text.Contains(""))
            {
                txtbEmail.BackColor = Color.White;
            }
            else
            {
                txtbEmail.BackColor = Color.Red;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsAuthenticate())
            {
                var form = new FrmParent();
                form.Show();
                ExitApp = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show
                    (
                       "Email or password is incorrect",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                    );
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                txtbMDP.UseSystemPasswordChar = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
            else
            {
                txtbMDP.UseSystemPasswordChar = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
