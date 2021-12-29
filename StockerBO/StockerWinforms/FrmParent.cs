using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockerWinforms
{
    public partial class FrmParent : Form
    {
        private STButton currentButton;
        private Random random;
        private int tempIndex;
        private Form ActiveForm;

        public FrmParent()
        {
            InitializeComponent();
            random = new Random();
            //BtnClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnFacture.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object BtnSender)
        {
            if (BtnSender != null)
            {
                if (btnThem == ((STButton)BtnSender))
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    btnThem = ((STButton)BtnSender);
                    btnThem.BackColor = color;
                    btnThem.ForeColor = Color.White;
                    //currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitre.BackColor = color;
                    pnlMenu.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panel1.BackColor = color;
                    panel2.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //BtnClose.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control PreviousBtn in pnlMenu.Controls)
            {
                if (PreviousBtn.GetType() == typeof(Button))
                {
                    PreviousBtn.BackColor = Color.Blue;
                    PreviousBtn.ForeColor = Color.Gainsboro;
                    PreviousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void OpenChildForm(Form ChildForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            //ActivateButton(btnSender);
            ActiveForm = ChildForm;
            //ChildForm.Dock = DockStyle.Fill;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.pnlParent.Controls.Add(ChildForm);
            this.pnlParent.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            labelTitre.Text = ChildForm.Text;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmStock(), sender);
        }

        private void btnQuitte_Click(object sender, EventArgs e)
        {

        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFourniseur(), sender);
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFacture(), sender);
            btnFacture.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmClient(), sender);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCommande(), sender);
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCategorie(), sender);
        }

        private void btnFournisseur_MouseEnter_1(object sender, EventArgs e)
        {
            this.btnFournisseur.BackColor = pnlMenu.BackColor;
            this.btnFournisseur.ForeColor = Color.Gray;
        }

        private void btnFournisseur_MouseLeave(object sender, EventArgs e)
        {
            this.btnFournisseur.BackColor = Color.White;
            this.btnFournisseur.ForeColor = Color.Black;
        }

        private void btnFacture_MouseEnter_1(object sender, EventArgs e)
        {
            this.POS.BackColor = pnlMenu.BackColor;
            this.POS.ForeColor = Color.Gray;
        }

        private void btnFacture_MouseLeave(object sender, EventArgs e)
        {
            this.POS.BackColor = Color.White;
            this.POS.ForeColor = Color.Black;
        }

        private void btnStock_MouseEnter(object sender, EventArgs e)
        {
            this.btnStock.BackColor = pnlMenu.BackColor;
            this.btnStock.ForeColor = Color.Gray;
        }

        private void btnStock_MouseLeave(object sender, EventArgs e)
        {
            this.btnStock.BackColor = Color.White;
            this.btnStock.ForeColor = Color.Black;
        }

        private void btnCategorie_MouseEnter(object sender, EventArgs e)
        {
            this.btnCategorie.BackColor = pnlMenu.BackColor;
            this.btnCategorie.ForeColor = Color.Gray;
        }

        private void btnCategorie_MouseLeave(object sender, EventArgs e)
        {
            this.btnCategorie.BackColor = Color.White;
            this.btnCategorie.ForeColor = Color.Black;
        }

        private void btnClient_MouseEnter(object sender, EventArgs e)
        {
            this.btnClient.BackColor = pnlMenu.BackColor;
            this.btnClient.ForeColor = Color.Gray;
        }

        private void btnCommande_MouseEnter(object sender, EventArgs e)
        {
            this.btnCommande.BackColor = pnlMenu.BackColor;
            this.btnCommande.ForeColor = Color.Gray;
        }

        private void btnCommande_MouseLeave(object sender, EventArgs e)
        {
            this.btnCommande.BackColor = Color.White;
            this.btnCommande.ForeColor = Color.Black;
        }

        private void btnClient_MouseLeave(object sender, EventArgs e)
        {
            this.btnClient.BackColor = Color.White;
            this.btnClient.ForeColor = Color.Black;
        }

        private void btnQuitte_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new FrmLogin();
            frm.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            this.btnThem.BackColor = pnlMenu.BackColor;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            this.btnThem.BackColor = Color.White;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitre.Text = "Accueil";
            //panelTitre.BackColor = Color.Blue;
            //panelLogo.BackColor = Color.Navy;
            //currentButton = null;
            //BtnClose.Visible = false;
        }
        

        private void FrmParent_Load(object sender, EventArgs e)
        {
            labelUserName.Text = Program.CurrentUser.FullnameU;
            User.Text = Program.CurrentUser.FullnameU;
            Stat.Text = Program.CurrentUser.Status;
        }
    }
}
