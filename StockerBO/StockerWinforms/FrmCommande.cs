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
    public partial class FrmCommande : Form
    {
        public FrmCommande()
        {
            InitializeComponent();
        }

        private void txtbChercher_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbChercher.Text))
                label3.Show();
            else
                label3.Hide();
        }
    }
}
