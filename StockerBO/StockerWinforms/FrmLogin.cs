using System;
using System.Drawing;
using System.Windows.Forms;
using StockerBLL;

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
       /* private bool IsAuthenticate()
        {
            return txtbEmail.Text.Equals("ainapetula@gmail.com", StringComparison.OrdinalIgnoreCase) && txtbMDP.Text.Equals("20005");
        }*/

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
            try
            {
                UserManager userManager = new UserManager();
                var user = userManager.Authenticate(txtbEmail.Text, txtbMDP.Text);
                if (user == null)
                    throw new Exception("Email or password is incorrect !");

                Program.CurrentUser = user;

                MessageBox.Show($"Welcome {user.FullnameU} !", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form = new FrmParent();
                form.Show();
                ExitApp = false;
                this.Hide();

            }
            catch(Exception me)
            {
                MessageBox.Show(me.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /* MessageBox.Show
                     (
                        "Email or password is incorrect",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                     );*/
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
